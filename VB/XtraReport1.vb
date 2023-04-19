Imports System.Drawing
Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI

' ...
Namespace Controls_XRTable

    Public Partial Class XtraReport1
        Inherits XtraReport

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub XtraReport1_BeforePrint(ByVal sender As Object, ByVal e As PrintEventArgs)
            Detail.Controls.Add(CreateXRTable())
        End Sub

        Public Function CreateXRTable() As XRTable
            ' Create an empty table and set its size.
            Dim table As XRTable = New XRTable()
            table.Size = New Size(300, 100)
            ' Start table initialization.
            table.BeginInit()
            ' Enable table borders to see its boundaries.
            table.BorderWidth = 2
            table.Borders = DevExpress.XtraPrinting.BorderSide.All
            ' Create a table row.
            Dim row As XRTableRow = New XRTableRow()
            ' Create two table cells.
            Dim cell0 As XRTableCell = New XRTableCell()
            Dim cell1 As XRTableCell = New XRTableCell()
            ' Construct the table.
            row.Cells.Add(cell0)
            row.Cells.Add(cell1)
            table.Rows.Add(row)
            ' Finish table initialization.
            table.EndInit()
            Return table
        End Function
    End Class
End Namespace
