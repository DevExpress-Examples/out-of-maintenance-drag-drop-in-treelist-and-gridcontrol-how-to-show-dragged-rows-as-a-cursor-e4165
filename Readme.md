# Drag & Drop in TreeList and GridControl - How to show dragged rows as a cursor


<p>This example shows how to customize drag&drop in Grid and TreeList controls, so that a dragged row is shown as a cursor. To do so, you need to override the corresponding DragDropManager class to pass RowData to DragElement instead of the row content and change its template to draw rows in the same way as they are drawn in Grid.</p>

<br/>


