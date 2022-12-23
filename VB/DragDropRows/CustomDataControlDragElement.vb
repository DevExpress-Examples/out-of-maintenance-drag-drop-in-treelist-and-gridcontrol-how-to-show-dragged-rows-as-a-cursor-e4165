Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Xpf.Grid

Namespace Drag_Drop_rows

    Public Class CustomDataControlDragElement
        Inherits DevExpress.Xpf.Grid.DataControlDragElement

        Public Sub New(ByVal dragDropManager As DevExpress.Xpf.Grid.DragDropManagerBase, ByVal offset As System.Windows.Point, ByVal owner As System.Windows.FrameworkElement)
            MyBase.New(dragDropManager, offset, owner)
            Dim content As System.Windows.Controls.ContentPresenter = TryCast(Me.container.Content, System.Windows.Controls.ContentPresenter)
            Dim oldInfo As DevExpress.Xpf.Grid.DragDropViewInfo = TryCast(content.Content, DevExpress.Xpf.Grid.DragDropViewInfo)
            Dim info As Drag_Drop_rows.ExternalDragDropViewInfo = New Drag_Drop_rows.ExternalDragDropViewInfo With {.DraggingRows = TryCast(dragDropManager, Drag_Drop_rows.IDragRowVisibilitySupport).DraggingRowsData, .DropTargetRow = oldInfo.DropTargetRow, .DropTargetType = oldInfo.DropTargetType, .FirstDraggingObject = oldInfo.FirstDraggingObject, .GroupInfo = oldInfo.GroupInfo}
            content.Content = info
        End Sub
    End Class
End Namespace
