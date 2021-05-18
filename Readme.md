<!-- default file list -->
*Files to look at*:

* [CustomDataControlDragElement.cs](./CS/DragDropRows/CustomDataControlDragElement.cs) (VB: [CustomDataControlDragElement.vb](./VB/DragDropRows/CustomDataControlDragElement.vb))
* [CustomGridDragDropManager.cs](./CS/DragDropRows/CustomGridDragDropManager.cs) (VB: [CustomGridDragDropManager.vb](./VB/DragDropRows/CustomGridDragDropManager.vb))
* [CustomTreeListDragDropManager.cs](./CS/DragDropRows/CustomTreeListDragDropManager.cs) (VB: [CustomTreeListDragDropManager.vb](./VB/DragDropRows/CustomTreeListDragDropManager.vb))
* [ExternalDragDropViewInfo.cs](./CS/DragDropRows/ExternalDragDropViewInfo.cs) (VB: [ExternalDragDropViewInfo.vb](./VB/DragDropRows/ExternalDragDropViewInfo.vb))
* [IDragRowVisibilitySupport.cs](./CS/DragDropRows/IDragRowVisibilitySupport.cs) (VB: [IDragRowVisibilitySupport.vb](./VB/DragDropRows/IDragRowVisibilitySupport.vb))
* [MainWindow.xaml](./CS/DragDropRows/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/DragDropRows/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/DragDropRows/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/DragDropRows/MainWindow.xaml.vb))
<!-- default file list end -->
# Drag & Drop in TreeList and GridControl - How to show dragged rows as a cursor


<p>This example shows how to customize drag&drop in Grid and TreeList controls, so that a dragged row is shown as a cursor. To do so, you need to override the corresponding DragDropManager class to pass RowData to DragElement instead of the row content and change its template to draw rows in the same way as they are drawn in Grid.</p>

<br/>


