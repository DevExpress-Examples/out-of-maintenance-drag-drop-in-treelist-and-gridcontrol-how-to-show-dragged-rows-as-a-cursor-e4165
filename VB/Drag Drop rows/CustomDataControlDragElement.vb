Imports Microsoft.VisualBasic
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
			Dim info As ExternalDragDropViewInfo = New ExternalDragDropViewInfo With {.DraggingRows = (TryCast(dragDropManager, IDragRowVisibilitySupport)).DraggingRowsData, .DropTargetRow = oldInfo.DropTargetRow, .DropTargetType = oldInfo.DropTargetType, .FirstDraggingObject = oldInfo.FirstDraggingObject, .GroupInfo = oldInfo.GroupInfo}
			content.Content = info
		End Sub
	End Class
End Namespace