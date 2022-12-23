Imports System
Imports System.Collections.Generic
Imports System.Windows
Imports DevExpress.Xpf.Grid
Imports System.Windows.Media
Imports System.Windows.Media.Imaging

Namespace Drag_Drop_rows

    Public Class CustomGridDragDropManager
        Inherits GridDragDropManager
        Implements IDragRowVisibilitySupport

        Public Property DraggingRowsData As List(Of Object) Implements IDragRowVisibilitySupport.DraggingRowsData

        Public ReadOnly Property TableView As TableView
            Get
                Return TryCast(View, TableView)
            End Get
        End Property

        Protected Overrides Function CreateDragElement(ByVal offset As Point, ByVal owner As FrameworkElement) As DevExpress.Xpf.Core.IDragElement
            Return New CustomDataControlDragElement(Me, offset, owner)
        End Function

        Public Sub SetDraggingRowsData()
            DraggingRowsData = GetRowImages(TableView)
        End Sub

        Protected Overrides Function CalcDraggingRows(ByVal e As DevExpress.Xpf.Core.IndependentMouseEventArgs) As Collections.IList
            SetDraggingRowsData()
            Return MyBase.CalcDraggingRows(e)
        End Function
    End Class

    Public Module GetRowImagesHelper

        Public Function GetRowImages(ByVal view As DataViewBase) As List(Of Object)
            Dim images As List(Of Object) = New List(Of Object)()
            For Each rowHandle As Integer In view.DataControl.GetSelectedRowHandles()
                Dim element As FrameworkElement = view.GetRowElementByRowHandle(rowHandle)
                If element IsNot Nothing Then
                    element = TryCast(VisualTreeHelper.GetChild(element, 0), FrameworkElement)
                    Dim bmp As RenderTargetBitmap = New RenderTargetBitmap(CInt(element.ActualWidth), CInt(element.ActualHeight), 96, 96, PixelFormats.Pbgra32)
                    bmp.Render(element)
                    images.Add(New Image() With {.ImageSource = bmp, .Width = element.ActualWidth, .Height = element.ActualHeight})
                End If
            Next

            Return images
        End Function
    End Module

    Public Class Image

        Public Property ImageSource As ImageSource

        Public Property Width As Double

        Public Property Height As Double
    End Class
End Namespace
