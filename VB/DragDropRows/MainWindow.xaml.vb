Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows
Imports DevExpress.Xpf.Grid

Namespace Drag_Drop_rows

    Public Partial Class MainWindow
        Inherits System.Windows.Window

        Const listSize As Integer = 5

        Private _ID As Integer = Drag_Drop_rows.MainWindow.listSize

        Public ReadOnly Property ID As Integer
            Get
                Return System.Threading.Interlocked.Increment(Me._ID)
            End Get
        End Property

        Public Sub New()
            Me.InitializeComponent()
            DevExpress.Xpf.Grid.TreeListView.DisableOptimizedModeVerification = True
            Me.treeList.ItemsSource = Drag_Drop_rows.MainWindow.CreateData(Drag_Drop_rows.MainWindow.listSize)
            Me.gridControl.ItemsSource = Drag_Drop_rows.MainWindow.CreateData(Drag_Drop_rows.MainWindow.listSize)
        End Sub

        Private Shared Function CreateData(ByVal listCnt As Integer) As List(Of Drag_Drop_rows.MainWindow.Task)
            Dim rand As System.Random = New System.Random()
            Dim list As System.Collections.Generic.List(Of Drag_Drop_rows.MainWindow.Task) = New System.Collections.Generic.List(Of Drag_Drop_rows.MainWindow.Task)()
            For i As Integer = 0 To listCnt - 1
                list.Add(New Drag_Drop_rows.MainWindow.Task With {.ID = i + 1, .ParentID = If(i Mod 2 = 0, 0, i), .Name = "Task" & (i + 1), .IsComplete = System.Math.Round(rand.NextDouble()) = 0})
            Next

            Return list
        End Function

        Public Class Task

            Public Property ID As Integer

            Public Property ParentID As Integer

            Public Property Name As String

            Public Property IsComplete As Boolean
        End Class

        Private Sub CustomTreeListDragDropManager_Drop(ByVal sender As Object, ByVal e As DevExpress.Xpf.Grid.DragDrop.TreeListDropEventArgs)
            If TypeOf e.DraggedRows(0) Is DevExpress.Xpf.Grid.TreeListNode Then Return
            For i As Integer = 0 To e.DraggedRows.Count - 1
                Dim task As Drag_Drop_rows.MainWindow.Task = TryCast(e.DraggedRows(i), Drag_Drop_rows.MainWindow.Task)
                e.DraggedRows(i) = New Drag_Drop_rows.MainWindow.Task With {.ID = Me.ID, .ParentID = task.ParentID, .Name = task.Name, .IsComplete = task.IsComplete}
            Next
        End Sub

        Private Sub CustomGridDragDropManager_Drop(ByVal sender As Object, ByVal e As DevExpress.Xpf.Grid.DragDrop.GridDropEventArgs)
            If TypeOf e.DraggedRows(0) Is DevExpress.Xpf.Grid.TreeListNode Then
                For i As Integer = 0 To e.DraggedRows.Count - 1
                    Dim task As Drag_Drop_rows.MainWindow.Task = TryCast(TryCast(e.DraggedRows(CInt((i))), DevExpress.Xpf.Grid.TreeListNode).Content, Drag_Drop_rows.MainWindow.Task)
                    e.DraggedRows(i) = New Drag_Drop_rows.MainWindow.Task With {.ID = Me.ID, .ParentID = task.ParentID, .Name = task.Name, .IsComplete = task.IsComplete}
                Next
            End If
        End Sub
    End Class
End Namespace
