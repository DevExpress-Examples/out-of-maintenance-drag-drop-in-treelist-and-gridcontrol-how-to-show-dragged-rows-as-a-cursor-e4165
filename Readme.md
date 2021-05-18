<!-- default file list -->
*Files to look at*:

* [CustomDataControlDragElement.cs](./CS/Drag%20Drop%20rows/CustomDataControlDragElement.cs) (VB: [CustomDataControlDragElement.vb](./VB/Drag%20Drop%20rows/CustomDataControlDragElement.vb))
* [CustomGridDragDropManager.cs](./CS/Drag%20Drop%20rows/CustomGridDragDropManager.cs) (VB: [CustomGridDragDropManager.vb](./VB/Drag%20Drop%20rows/CustomGridDragDropManager.vb))
* [CustomTreeListDragDropManager.cs](./CS/Drag%20Drop%20rows/CustomTreeListDragDropManager.cs) (VB: [CustomTreeListDragDropManager.vb](./VB/Drag%20Drop%20rows/CustomTreeListDragDropManager.vb))
* [ExternalDragDropViewInfo.cs](./CS/Drag%20Drop%20rows/ExternalDragDropViewInfo.cs) (VB: [ExternalDragDropViewInfo.vb](./VB/Drag%20Drop%20rows/ExternalDragDropViewInfo.vb))
* [IDragRowVisibilitySupport.cs](./CS/Drag%20Drop%20rows/IDragRowVisibilitySupport.cs) (VB: [IDragRowVisibilitySupport.vb](./VB/Drag%20Drop%20rows/IDragRowVisibilitySupport.vb))
* [MainWindow.xaml](./CS/Drag%20Drop%20rows/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/Drag%20Drop%20rows/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/Drag%20Drop%20rows/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/Drag%20Drop%20rows/MainWindow.xaml.vb))
<!-- default file list end -->
# Drag & Drop in TreeList and GridControl - How to show dragged rows as a cursor


<p>This example shows how to customize drag&drop in Grid and TreeList controls, so that a dragged row is shown as a cursor. To do so, you need to override the corresponding DragDropManager class to pass RowData to DragElement instead of the row content and change its template to draw rows in the same way as they are drawn in Grid.</p>

<br/>


