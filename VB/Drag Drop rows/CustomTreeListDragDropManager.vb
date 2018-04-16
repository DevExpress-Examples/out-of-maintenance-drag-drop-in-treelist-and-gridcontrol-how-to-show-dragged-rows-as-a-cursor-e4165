Imports Microsoft.VisualBasic
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
		Public Class CustomTreeListDragSource
			Inherits TreeListDragSource
			Public Sub New(ByVal dragDropManager As DragDropManagerBase)
				MyBase.New(dragDropManager)
			End Sub

			Protected Overrides Function GetDraggingRows(ByVal e As MouseButtonEventArgs) As System.Collections.IList
				CustomTreeListDragDropManager.SetDraggingRowsData()
				Return MyBase.GetDraggingRows(e)
			End Function

			Private ReadOnly Property CustomTreeListDragDropManager() As CustomTreeListDragDropManager
				Get
					Return CType(MyBase.dragDropManager, CustomTreeListDragDropManager)
				End Get
			End Property
		End Class

		Private privateDraggingRowsData As List(Of Object)
		Public Property DraggingRowsData() As List(Of Object) Implements IDragRowVisibilitySupport.DraggingRowsData
			Get
				Return privateDraggingRowsData
			End Get
			Set(ByVal value As List(Of Object))
				privateDraggingRowsData = value
			End Set
		End Property

		Protected Overrides Function CreateDragSource(ByVal dataViewDragDropManager As DataViewDragDropManager) As DevExpress.Xpf.Core.ISupportDragDrop
			Return New CustomTreeListDragSource(dataViewDragDropManager)
		End Function

		Protected Overrides Function CreateDragElement(ByVal offset As Point, ByVal owner As FrameworkElement) As DevExpress.Xpf.Core.IDragElement
			Return New CustomDataControlDragElement(Me, offset, owner)
		End Function

		Public Sub SetDraggingRowsData()
			Dim list As New List(Of Object)()
            Dim view As TreeListView = TryCast(MyBase.View, TreeListView)
			For Each rowHandle As Integer In view.GetSelectedRowHandles()
				list.Add((TryCast(view.GetRowElementByRowHandle(rowHandle), GridRow)).RowDataContent.DataContext)
			Next rowHandle
			DraggingRowsData = list
		End Sub
	End Class
End Namespace