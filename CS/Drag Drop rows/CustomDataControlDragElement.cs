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
using System.Windows.Controls;
using DevExpress.Xpf.Grid;

namespace Drag_Drop_rows
{
    public class CustomDataControlDragElement : DataControlDragElement
    {
        public CustomDataControlDragElement(DragDropManagerBase dragDropManager, Point offset, FrameworkElement owner)
            : base(dragDropManager, offset, owner)
        {
            ContentPresenter content = container.Content as ContentPresenter;
            DragDropViewInfo oldInfo = content.Content as DragDropViewInfo;
            ExternalDragDropViewInfo info = new ExternalDragDropViewInfo { DraggingRows = (dragDropManager as IDragRowVisibilitySupport).DraggingRowsData,
                                                                           DropTargetRow = oldInfo.DropTargetRow,
                                                                           DropTargetType = oldInfo.DropTargetType,
                                                                           FirstDraggingObject = oldInfo.FirstDraggingObject,
                                                                           GroupInfo = oldInfo.GroupInfo};
            content.Content = info;
        }
    }
}