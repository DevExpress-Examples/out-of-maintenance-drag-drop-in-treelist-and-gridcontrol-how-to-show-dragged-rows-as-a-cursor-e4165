' Developer Express Code Central Example:
' How to show dragged rows as a cursor when performing Drag & Drop in TreeList and Grid controls
' 
' This example shows how to customize drag&drop in Grid and TreeList controls, so
' that a dragged row is shown as a cursor. To do so, you need to override the
' corresponding DragDropManager class to pass RowData to DragElement instead of
' the row content and change its template to draw rows in the same way as they are
' drawn in Grid.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E4165

Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Xpf.Grid

Namespace Drag_Drop_rows
	Public Class CustomDataControlDragElement
		Inherits DataControlDragElement

		Public Sub New(ByVal dragDropManager As DragDropManagerBase, ByVal offset As Point, ByVal owner As FrameworkElement)
			MyBase.New(dragDropManager, offset, owner)
			Dim content As ContentPresenter = TryCast(container.Content, ContentPresenter)
			Dim oldInfo As DragDropViewInfo = TryCast(content.Content, DragDropViewInfo)
			Dim info As New ExternalDragDropViewInfo With {
				.DraggingRows = (TryCast(dragDropManager, IDragRowVisibilitySupport)).DraggingRowsData,
				.DropTargetRow = oldInfo.DropTargetRow,
				.DropTargetType = oldInfo.DropTargetType,
				.FirstDraggingObject = oldInfo.FirstDraggingObject,
				.GroupInfo = oldInfo.GroupInfo
			}
			content.Content = info
		End Sub
	End Class
End Namespace