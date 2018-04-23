using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using DevExpress.Xpf.Grid;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Drag_Drop_rows {
    public class CustomTreeListDragDropManager : TreeListDragDropManager, IDragRowVisibilitySupport {
        public List<object> DraggingRowsData { get; set; }
        protected override DevExpress.Xpf.Core.IDragElement CreateDragElement(Point offset, FrameworkElement owner) {
            return new CustomDataControlDragElement(this, offset, owner);
        }
        public void SetDraggingRowsData() {
            DraggingRowsData = GetRowImagesHelper.GetRowImages(TreeListView);
        }
        protected override System.Collections.IList CalcDraggingRows(DevExpress.Xpf.Core.IndependentMouseEventArgs e) {
            SetDraggingRowsData();
            return base.CalcDraggingRows(e);
        }
    }
}