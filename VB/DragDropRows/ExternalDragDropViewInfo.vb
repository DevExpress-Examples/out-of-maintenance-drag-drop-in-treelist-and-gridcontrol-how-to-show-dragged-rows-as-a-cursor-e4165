Imports System
Imports System.Collections.Generic
Imports System.Windows
Imports DevExpress.Xpf.Grid
Imports System.Collections
Imports DevExpress.Xpf.Utils

Namespace Drag_Drop_rows

    Public Class ExternalDragDropViewInfo
        Inherits DragDropViewInfo

        Public Shared Shadows ReadOnly DraggingRowsProperty As DependencyProperty

        Public Shared Shadows ReadOnly DropTargetRowProperty As DependencyProperty

        Public Shared Shadows ReadOnly DropTargetTypeProperty As DependencyProperty

        Public Shared Shadows ReadOnly FirstDraggingObjectProperty As DependencyProperty

        Public Shared Shadows ReadOnly GroupInfoProperty As DependencyProperty

        Shared Sub New()
            Dim ownerType As Type = GetType(ExternalDragDropViewInfo)
            DraggingRowsProperty = DependencyPropertyManager.Register("DraggingRows", GetType(IList), ownerType, New UIPropertyMetadata(CType(Nothing, PropertyChangedCallback)))
            DropTargetTypeProperty = DependencyPropertyManager.Register("DropTargetType", GetType(DropTargetType), ownerType, New UIPropertyMetadata(DropTargetType.None))
            DropTargetRowProperty = DependencyPropertyManager.Register("DropTargetRow", GetType(Object), ownerType, New UIPropertyMetadata(CType(Nothing, PropertyChangedCallback)))
            GroupInfoProperty = DependencyPropertyManager.Register("GroupInfo", GetType(IList(Of GroupInfo)), ownerType, New UIPropertyMetadata(CType(Nothing, PropertyChangedCallback)))
            FirstDraggingObjectProperty = DependencyPropertyManager.Register("FirstDraggingObject", GetType(Object), ownerType, New UIPropertyMetadata(CType(Nothing, PropertyChangedCallback)))
        End Sub

        Overloads Public Property DraggingRows As IList
            Get
                Return CType(GetValue(DraggingRowsProperty), IList)
            End Get

            Set(ByVal value As IList)
                SetValue(DraggingRowsProperty, value)
            End Set
        End Property

        Overloads Public Property DropTargetRow As Object
            Get
                Return GetValue(DropTargetRowProperty)
            End Get

            Set(ByVal value As Object)
                SetValue(DropTargetRowProperty, value)
            End Set
        End Property

        Overloads Public Property DropTargetType As DropTargetType
            Get
                Return CType(GetValue(DropTargetTypeProperty), DropTargetType)
            End Get

            Set(ByVal value As DropTargetType)
                SetValue(DropTargetTypeProperty, value)
            End Set
        End Property

        Overloads Public Property FirstDraggingObject As Object
            Get
                Return GetValue(FirstDraggingObjectProperty)
            End Get

            Set(ByVal value As Object)
                SetValue(FirstDraggingObjectProperty, value)
            End Set
        End Property

        Overloads Public Property GroupInfo As IList(Of GroupInfo)
            Get
                Return CType(GetValue(GroupInfoProperty), IList(Of GroupInfo))
            End Get

            Set(ByVal value As IList(Of GroupInfo))
                SetValue(GroupInfoProperty, value)
            End Set
        End Property
    End Class
End Namespace
