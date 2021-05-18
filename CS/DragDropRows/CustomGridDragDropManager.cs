using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using DevExpress.Xpf.Grid;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Drag_Drop_rows {
    public class CustomGridDragDropManager : GridDragDropManager, IDragRowVisibilitySupport {
        public List<object> DraggingRowsData { get; set; }
        public TableView TableView { get { return View as TableView; } }
        protected override DevExpress.Xpf.Core.IDragElement CreateDragElement(Point offset, FrameworkElement owner) {
            return new CustomDataControlDragElement(this, offset, owner);
        }
        public void SetDraggingRowsData() {
            DraggingRowsData = GetRowImagesHelper.GetRowImages(TableView);
        }
        protected override System.Collections.IList CalcDraggingRows(DevExpress.Xpf.Core.IndependentMouseEventArgs e) {
            SetDraggingRowsData();
            return base.CalcDraggingRows(e);
        }
    }
    public static class GetRowImagesHelper {
        public static List<object> GetRowImages(DataViewBase view) {
            List<object> images = new List<object>();
            foreach (int rowHandle in view.DataControl.GetSelectedRowHandles()) {
                FrameworkElement element = view.GetRowElementByRowHandle(rowHandle);
                if (element != null) {
                    element = VisualTreeHelper.GetChild(element, 0) as FrameworkElement;
                    RenderTargetBitmap bmp = new RenderTargetBitmap((int)element.ActualWidth, (int)element.ActualHeight, 96, 96, PixelFormats.Pbgra32);
                    bmp.Render(element);
                    images.Add(new Image() { ImageSource = bmp, Width = element.ActualWidth, Height = element.ActualHeight });
                }
            }
            return images;
        }
    }
    public class Image {
        public ImageSource ImageSource { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
    }
}