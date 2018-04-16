Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq

Namespace Drag_Drop_rows
	Public Interface IDragRowVisibilitySupport
		Property DraggingRowsData() As List(Of Object)
	End Interface
End Namespace
