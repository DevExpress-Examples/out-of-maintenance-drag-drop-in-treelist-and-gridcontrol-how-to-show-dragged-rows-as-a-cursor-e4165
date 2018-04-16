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