Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows
Imports DevExpress.Xpf.Grid

Namespace Drag_Drop_rows
	Partial Public Class MainWindow
		Inherits Window

		Private Const listSize As Integer = 5
		Private _ID As Integer = listSize

		Public ReadOnly Property ID() As Integer
			Get
				_ID += 1
'INSTANT VB WARNING: An assignment within expression was extracted from the following statement:
'ORIGINAL LINE: return ++_ID;
				Return _ID
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
			TreeListView.DisableOptimizedModeVerification = True

			treeList.ItemsSource = CreateData(listSize)
			gridControl.ItemsSource = CreateData(listSize)
		End Sub

		Private Shared Function CreateData(ByVal listCnt As Integer) As List(Of Task)
			Dim rand As New Random()
			Dim list As New List(Of Task)()
			For i As Integer = 0 To listCnt - 1
				list.Add(New Task With {
					.ID = i + 1,
					.ParentID = If(i Mod 2 = 0, 0, i),
					.Name = "Task" & (i + 1),
					.IsComplete = Math.Round(rand.NextDouble()) = 0
				})
			Next i
			Return list
		End Function

		Public Class Task
			Public Property ID() As Integer
			Public Property ParentID() As Integer
			Public Property Name() As String
			Public Property IsComplete() As Boolean
		End Class

		Private Sub CustomTreeListDragDropManager_Drop(ByVal sender As Object, ByVal e As DevExpress.Xpf.Grid.DragDrop.TreeListDropEventArgs)
			If TypeOf e.DraggedRows(0) Is TreeListNode Then
				Return
			End If
			For i As Integer = 0 To e.DraggedRows.Count - 1
				Dim task As Task = TryCast(e.DraggedRows(i), Task)
				e.DraggedRows(i) = New Task With {
					.ID = ID,
					.ParentID = task.ParentID,
					.Name = task.Name,
					.IsComplete = task.IsComplete
				}
			Next i
		End Sub

		Private Sub CustomGridDragDropManager_Drop(ByVal sender As Object, ByVal e As DevExpress.Xpf.Grid.DragDrop.GridDropEventArgs)
			If TypeOf e.DraggedRows(0) Is TreeListNode Then
				For i As Integer = 0 To e.DraggedRows.Count - 1
					Dim task As Task = TryCast((TryCast(e.DraggedRows(i), TreeListNode)).Content, Task)
					e.DraggedRows(i) = New Task With {
						.ID = ID,
						.ParentID = task.ParentID,
						.Name = task.Name,
						.IsComplete = task.IsComplete
					}
				Next i
			End If
		End Sub
	End Class
End Namespace