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
Imports System.Windows.Input
Imports DevExpress.Xpf.Grid

Namespace Drag_Drop_rows
	Public Class CustomTreeListDragDropManager
		Inherits TreeListDragDropManager
		Implements IDragRowVisibilitySupport

		Public Property DraggingRowsData() As List(Of Object) Implements IDragRowVisibilitySupport.DraggingRowsData

		Protected Overrides Function CreateDragElement(ByVal offset As Point, ByVal owner As FrameworkElement) As DevExpress.Xpf.Core.IDragElement
			Return New CustomDataControlDragElement(Me, offset, owner)
		End Function

		Public Sub SetDraggingRowsData()
			Dim list As New List(Of Object)()
			Dim view As TreeListView = TryCast(View, TreeListView)
			For Each rowHandle As Integer In view.DataControl.GetSelectedRowHandles()
				list.Add((TryCast(view.GetRowElementByRowHandle(rowHandle), GridRow)).RowDataContent.DataContext)
			Next rowHandle
			DraggingRowsData = list
		End Sub

		Protected Overrides Function CalcDraggingRows(ByVal e As DevExpress.Xpf.Core.IndependentMouseEventArgs) As System.Collections.IList
			SetDraggingRowsData()
			Return MyBase.CalcDraggingRows(e)
		End Function
	End Class
End Namespace