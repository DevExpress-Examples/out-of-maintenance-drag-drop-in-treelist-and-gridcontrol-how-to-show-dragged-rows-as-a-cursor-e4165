using System;
using System.Collections.Generic;
using System.Linq;

namespace Drag_Drop_rows
{
    public interface IDragRowVisibilitySupport
    {
        List<object> DraggingRowsData { get; set; }
    }
}
