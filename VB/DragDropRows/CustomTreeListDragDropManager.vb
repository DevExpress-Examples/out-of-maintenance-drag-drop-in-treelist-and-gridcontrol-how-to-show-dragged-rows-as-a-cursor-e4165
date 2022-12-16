Imports System
Imports System.Collections.Generic
Imports System.Windows
Imports DevExpress.Xpf.Grid

Namespace Drag_Drop_rows

    Public Class CustomTreeListDragDropManager
        Inherits TreeListDragDropManager
        Implements IDragRowVisibilitySupport

        Public Property DraggingRowsData As List(Of Object) Implements IDragRowVisibilitySupport.DraggingRowsData

        Protected Overrides Function CreateDragElement(ByVal offset As Point, ByVal owner As FrameworkElement) As DevExpress.Xpf.Core.IDragElement
            Return New CustomDataControlDragElement(Me, offset, owner)
        End Function

        Public Sub SetDraggingRowsData()
            DraggingRowsData = GetRowImages(TreeListView)
        End Sub

        Protected Overrides Function CalcDraggingRows(ByVal e As DevExpress.Xpf.Core.IndependentMouseEventArgs) As Collections.IList
            SetDraggingRowsData()
            Return MyBase.CalcDraggingRows(e)
        End Function
    End Class
End Namespace
