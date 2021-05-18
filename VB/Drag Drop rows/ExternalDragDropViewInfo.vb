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
Imports DevExpress.Xpf.Grid
Imports System.Collections
Imports DevExpress.Xpf.Utils

Namespace Drag_Drop_rows
	Public Class ExternalDragDropViewInfo
		Inherits DragDropViewInfo

		Public Shadows Shared ReadOnly DraggingRowsProperty As DependencyProperty
		Public Shadows Shared ReadOnly DropTargetRowProperty As DependencyProperty
		Public Shadows Shared ReadOnly DropTargetTypeProperty As DependencyProperty
		Public Shadows Shared ReadOnly FirstDraggingObjectProperty As DependencyProperty
		Public Shadows Shared ReadOnly GroupInfoProperty As DependencyProperty

		Shared Sub New()
			Dim ownerType As Type = GetType(ExternalDragDropViewInfo)
			DraggingRowsProperty = DependencyPropertyManager.Register("DraggingRows", GetType(IList), ownerType, New UIPropertyMetadata(Nothing))
			DropTargetTypeProperty = DependencyPropertyManager.Register("DropTargetType", GetType(DropTargetType), ownerType, New UIPropertyMetadata(DropTargetType.None))
			DropTargetRowProperty = DependencyPropertyManager.Register("DropTargetRow", GetType(Object), ownerType, New UIPropertyMetadata(Nothing))
			GroupInfoProperty = DependencyPropertyManager.Register("GroupInfo", GetType(IList(Of GroupInfo)), ownerType, New UIPropertyMetadata(Nothing))
			FirstDraggingObjectProperty = DependencyPropertyManager.Register("FirstDraggingObject", GetType(Object), ownerType, New UIPropertyMetadata(Nothing))
		End Sub

		Public Shadows Property DraggingRows() As IList
			Get
				Return DirectCast(MyBase.GetValue(DraggingRowsProperty), IList)
			End Get
			Set(ByVal value As IList)
				MyBase.SetValue(DraggingRowsProperty, value)
			End Set
		End Property

		Public Shadows Property DropTargetRow() As Object
			Get
				Return MyBase.GetValue(DropTargetRowProperty)
			End Get
			Set(ByVal value As Object)
				MyBase.SetValue(DropTargetRowProperty, value)
			End Set
		End Property

		Public Shadows Property DropTargetType() As DropTargetType
			Get
				Return CType(MyBase.GetValue(DropTargetTypeProperty), DropTargetType)
			End Get
			Set(ByVal value As DropTargetType)
				MyBase.SetValue(DropTargetTypeProperty, value)
			End Set
		End Property

		Public Shadows Property FirstDraggingObject() As Object
			Get
				Return MyBase.GetValue(FirstDraggingObjectProperty)
			End Get
			Set(ByVal value As Object)
				MyBase.SetValue(FirstDraggingObjectProperty, value)
			End Set
		End Property

		Public Shadows Property GroupInfo() As IList(Of GroupInfo)
			Get
				Return DirectCast(MyBase.GetValue(GroupInfoProperty), IList(Of GroupInfo))
			End Get
			Set(ByVal value As IList(Of GroupInfo))
				MyBase.SetValue(GroupInfoProperty, value)
			End Set
		End Property
	End Class
End Namespace
