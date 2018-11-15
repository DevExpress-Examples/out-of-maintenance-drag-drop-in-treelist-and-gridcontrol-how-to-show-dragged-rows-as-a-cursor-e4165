<!-- default file list -->
*Files to look at*:

* [CustomDataControlDragElement.cs](./CS/Drag Drop rows/CustomDataControlDragElement.cs) (VB: [CustomDataControlDragElement.vb](./VB/Drag Drop rows/CustomDataControlDragElement.vb))
* [CustomGridDragDropManager.cs](./CS/Drag Drop rows/CustomGridDragDropManager.cs) (VB: [CustomGridDragDropManager.vb](./VB/Drag Drop rows/CustomGridDragDropManager.vb))
* [CustomTreeListDragDropManager.cs](./CS/Drag Drop rows/CustomTreeListDragDropManager.cs) (VB: [CustomTreeListDragDropManager.vb](./VB/Drag Drop rows/CustomTreeListDragDropManager.vb))
* [ExternalDragDropViewInfo.cs](./CS/Drag Drop rows/ExternalDragDropViewInfo.cs) (VB: [ExternalDragDropViewInfo.vb](./VB/Drag Drop rows/ExternalDragDropViewInfo.vb))
* [IDragRowVisibilitySupport.cs](./CS/Drag Drop rows/IDragRowVisibilitySupport.cs) (VB: [IDragRowVisibilitySupport.vb](./VB/Drag Drop rows/IDragRowVisibilitySupport.vb))
* [MainWindow.xaml](./CS/Drag Drop rows/MainWindow.xaml) (VB: [MainWindow.xaml.vb](./VB/Drag Drop rows/MainWindow.xaml.vb))
* [MainWindow.xaml.cs](./CS/Drag Drop rows/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/Drag Drop rows/MainWindow.xaml.vb))
<!-- default file list end -->
# Drag & Drop in TreeList and GridControl - How to show dragged rows as a cursor


<p>This example shows how to customize drag&drop in Grid and TreeList controls, so that a dragged row is shown as a cursor. To do so, you need to override the corresponding DragDropManager class to pass RowData to DragElement instead of the row content and change its template to draw rows in the same way as they are drawn in Grid.</p>

<br/>


