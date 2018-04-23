using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using DevExpress.Xpf.Grid;

namespace Drag_Drop_rows {
    public partial class MainWindow : Window {
        const int listSize = 5;
        int _ID = listSize;

        public int ID {
            get {
                return ++_ID;
            }
        }

        public MainWindow() {
            InitializeComponent();
            TreeListView.DisableOptimizedModeVerification = true;
            
            treeList.ItemsSource = CreateData(listSize);
            gridControl.ItemsSource = CreateData(listSize);
        }

        private static List<Task> CreateData(int listCnt) {
            Random rand = new Random();
            List<Task> list = new List<Task>();
            for(int i = 0; i < listCnt; i++) {
                list.Add(new Task { ID = i + 1, ParentID = i % 2 == 0 ? 0 : i, Name = "Task" + (i + 1), IsComplete = Math.Round(rand.NextDouble()) == 0 });
            }
            return list;
        }

        public class Task {
            public int ID { get; set; }
            public int ParentID { get; set; }
            public string Name { get; set; }
            public bool IsComplete { get; set; }
        }

        private void CustomTreeListDragDropManager_Drop(object sender, DevExpress.Xpf.Grid.DragDrop.TreeListDropEventArgs e) {
            if(e.DraggedRows[0] is TreeListNode)
                return;
            for(int i = 0; i < e.DraggedRows.Count; i++) {
                Task task = e.DraggedRows[i] as Task;
                e.DraggedRows[i] = new Task { ID = ID, ParentID = task.ParentID, Name = task.Name, IsComplete = task.IsComplete };
            }
        }

        private void CustomGridDragDropManager_Drop(object sender, DevExpress.Xpf.Grid.DragDrop.GridDropEventArgs e) {
            if(e.DraggedRows[0] is TreeListNode)
                for(int i = 0; i < e.DraggedRows.Count; i++) {
                    Task task = (e.DraggedRows[i] as TreeListNode).Content as Task;
                    e.DraggedRows[i] = new Task { ID = ID, ParentID = task.ParentID, Name = task.Name, IsComplete = task.IsComplete };
                }
        }
    }
}