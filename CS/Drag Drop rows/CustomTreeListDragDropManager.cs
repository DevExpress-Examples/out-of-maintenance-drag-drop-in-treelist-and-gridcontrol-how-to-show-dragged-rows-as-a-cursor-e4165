// Developer Express Code Central Example:
// How to show dragged rows as a cursor when performing Drag & Drop in TreeList and Grid controls
// 
// This example shows how to customize drag&drop in Grid and TreeList controls, so
// that a dragged row is shown as a cursor. To do so, you need to override the
// corresponding DragDropManager class to pass RowData to DragElement instead of
// the row content and change its template to draw rows in the same way as they are
// drawn in Grid.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E4165

// Developer Express Code Central Example:
// How to show dragged rows as a cursor when performing Drag & Drop in TreeList and Grid controls
// 
// This example shows how to customize drag&drop in Grid and TreeList controls, so
// that a dragged row is shown as a cursor. To do so, you need to override the
// corresponding DragDropManager class to pass RowData to DragElement instead of
// the row content and change its template to draw rows in the same way as they are
// drawn in Grid.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E4165

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using DevExpress.Xpf.Grid;

namespace Drag_Drop_rows
{
    public class CustomTreeListDragDropManager : TreeListDragDropManager, IDragRowVisibilitySupport
    {

        public List<object> DraggingRowsData { get; set; }

        protected override DevExpress.Xpf.Core.IDragElement CreateDragElement(Point offset, FrameworkElement owner)
        {
            return new CustomDataControlDragElement(this, offset, owner);
        }

        public void SetDraggingRowsData()
        {
            List<object> list = new List<object>();
            TreeListView view = View as TreeListView;
            foreach (int rowHandle in view.GetSelectedRowHandles())
            {
                list.Add((view.GetRowElementByRowHandle(rowHandle) as GridRow).RowDataContent.DataContext);
            }
            DraggingRowsData = list;
        }

        protected override System.Collections.IList CalcDraggingRows(DevExpress.Xpf.Core.IndependentMouseEventArgs e)
        {
            SetDraggingRowsData();
            return base.CalcDraggingRows(e);
        }
    }
}