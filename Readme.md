<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128647521/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4165)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
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

The GridControl allows you to drag records and drop them in external controls. This example shows how to display dragged row as a cursor. Override the corresponding DragDropManager class and pass RowData to DragElement. Change the drag element's template to draw rows in the same way as they are drawn in Grid.

Refer to the [Drag-and-Drop Between GridControls](https://docs.devexpress.com/WPF/119267/controls-and-libraries/data-grid/drag-and-drop/process-drag-and-drop/drag-and-drop-between-gridcontrols) topic for more information.
