using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using DevExpress.Xpf.Grid;

namespace Drag_Drop_rows
{
    public class CustomGridDragDropManager : GridDragDropManager, IDragRowVisibilitySupport
    {
        public class CustomGridDragSource : GridDragSource
        {
            public CustomGridDragSource(DragDropManagerBase dragDropManager)
                : base(dragDropManager)
            {  
            }

            protected override System.Collections.IList GetDraggingRows(MouseButtonEventArgs e)
            {
                CustomGridDragDropManager.SetDraggingRowsData();
                return base.GetDraggingRows(e);
            }

            private CustomGridDragDropManager CustomGridDragDropManager
            {
                get
                {
                    return (CustomGridDragDropManager)base.dragDropManager;
                }
            }
        }

        public List<object> DraggingRowsData { get; set; }

        protected override DevExpress.Xpf.Core.ISupportDragDrop CreateDragSource(DataViewDragDropManager dataViewDragDropManager)
        {
            return new CustomGridDragSource(dataViewDragDropManager);
        }

        protected override DevExpress.Xpf.Core.IDragElement CreateDragElement(Point offset, FrameworkElement owner)
        {
            return new CustomDataControlDragElement(this, offset, owner);
        }

        public void SetDraggingRowsData()
        {
            List<object> list = new List<object>();
            TableView view = View as TableView;
            foreach (int rowHandle in view.GetSelectedRowHandles())
            {
                list.Add((view.GetRowElementByRowHandle(rowHandle) as GridRow).RowDataContent.DataContext);
            }
            DraggingRowsData = list;
        }
    }
}
