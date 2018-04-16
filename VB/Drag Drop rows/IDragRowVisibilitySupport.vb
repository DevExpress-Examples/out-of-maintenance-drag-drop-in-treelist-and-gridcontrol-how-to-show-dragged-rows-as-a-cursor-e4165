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


Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq

Namespace Drag_Drop_rows
	Public Interface IDragRowVisibilitySupport
		Property DraggingRowsData() As List(Of Object)
	End Interface
End Namespace
