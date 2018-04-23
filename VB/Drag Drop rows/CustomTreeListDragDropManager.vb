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

		Public Property DraggingRowsData() As List(Of Object) Implements IDragRowVisibilitySupport.DraggingRowsData

		Protected Overrides Function CreateDragElement(ByVal offset As Point, ByVal owner As FrameworkElement) As DevExpress.Xpf.Core.IDragElement
			Return New CustomDataControlDragElement(Me, offset, owner)
		End Function

		Public Sub SetDraggingRowsData()
            DraggingRowsData = GetRowImagesHelper.GetRowImages(TreeListView)
        End Sub

		Protected Overrides Function CalcDraggingRows(ByVal e As DevExpress.Xpf.Core.IndependentMouseEventArgs) As System.Collections.IList
			SetDraggingRowsData()
			Return MyBase.CalcDraggingRows(e)
		End Function
	End Class
End Namespace