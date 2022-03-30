Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Views.Grid
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing

Namespace TestGridLookUpEditCSV

    Public Partial Class Form1
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
            InitGrid()
            Dim ri As RepositoryItemPopupContainerEdit = New RepositoryItemPopupContainerEdit()
            AddHandler ri.QueryResultValue, AddressOf ri_QueryResultValue
            AddHandler ri.EditValueChanged, AddressOf ri_EditValueChanged
            AddHandler ri.Popup, AddressOf ri_Popup
            ri.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
            Dim popupControl As PopupContainerControl = New PopupContainerControl()
            popupControl.Controls.Add(popupGridControl1)
            popupControl.Size = New System.Drawing.Size(500, 300)
            ri.PopupControl = popupControl
            gridControl2.RepositoryItems.Add(ri)
            gridView1.Columns("Name").ColumnEdit = ri
            popupContainerEdit1.Properties.PopupControl = popupContainerControl1
            AddHandler popupContainerEdit1.Properties.QueryResultValue, AddressOf Properties_QueryResultValue
            AddHandler popupContainerEdit1.Properties.EditValueChanged, AddressOf Properties_EditValueChanged
            AddHandler popupContainerEdit1.Properties.Popup, AddressOf Properties_Popup
        End Sub

        Private Sub Properties_Popup(ByVal sender As Object, ByVal e As EventArgs)
            Dim edit As PopupContainerEdit = TryCast(sender, PopupContainerEdit)
            If Not edit.IsPopupOpen Then edit.ShowPopup()
            UpdateSelection(edit, popupGridView2)
        End Sub

        Private Sub Properties_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim edit As PopupContainerEdit = TryCast(sender, PopupContainerEdit)
            UpdateSelection(edit, popupGridView2)
        End Sub

        Private Sub Properties_QueryResultValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.QueryResultValueEventArgs)
            Dim selectedRows As Integer() = popupGridView2.GetSelectedRows()
            Dim values As List(Of String) = New List(Of String)()
            For Each rowHandle As Integer In selectedRows
                values.Add(popupGridView2.GetRowCellValue(rowHandle, "Name").ToString())
            Next

            Dim csv As String = String.Join(", ", values)
            e.Value = csv
        End Sub

        Private Sub ri_Popup(ByVal sender As Object, ByVal e As EventArgs)
            Dim edit As PopupContainerEdit = TryCast(sender, PopupContainerEdit)
            UpdateSelection(edit, popupGridView1)
        End Sub

        Private Sub ri_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim edit As PopupContainerEdit = TryCast(sender, PopupContainerEdit)
            If Not edit.IsPopupOpen Then edit.ShowPopup()
            UpdateSelection(edit, popupGridView1)
        End Sub

        Private Sub ri_QueryResultValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.QueryResultValueEventArgs)
            Dim selectedRows As Integer() = popupGridView1.GetSelectedRows()
            Dim values As List(Of String) = New List(Of String)()
            For Each rowHandle As Integer In selectedRows
                values.Add(popupGridView1.GetRowCellValue(rowHandle, "Name").ToString())
            Next

            Dim csv As String = String.Join(", ", values)
            e.Value = csv
        End Sub

        Private Sub UpdateSelection(ByVal edit As PopupContainerEdit, ByVal view As GridView)
            view.BeginSelection()
            view.ClearSelection()
            If edit IsNot Nothing Then
                If edit.EditValue IsNot Nothing Then
                    edit.Focus()
                    Dim selection As List(Of Integer) = GetSelection(edit.EditValue.ToString().Split(New String() {", "}, StringSplitOptions.None), "Name", view)
                    For Each rowHandle As Integer In selection
                        view.SelectRow(rowHandle)
                    Next
                End If
            End If

            view.EndSelection()
        End Sub

        Private Function GetSelection(ByVal values As String(), ByVal fieldName As String, ByVal view As GridView) As List(Of Integer)
            Dim selection As List(Of Integer) = New List(Of Integer)()
            For Each val As String In values
                For i As Integer = 0 To view.RowCount - 1
                    If Equals(view.GetRowCellValue(i, fieldName).ToString(), val) Then selection.Add(i)
                Next
            Next

            Return selection
        End Function

        Private Sub InitGrid()
            popupGridControl1.DataSource = CreateList(5)
            gridControl2.DataSource = CreateList(5)
            popupGridControl2.DataSource = CreateList(5)
        End Sub

        Private Function CreateList(ByVal count As Integer) As BindingList(Of Customer)
            Dim list As BindingList(Of Customer) = New BindingList(Of Customer)()
            For i As Integer = 0 To count - 1
                list.Add(New Customer(i, "Name" & i, "Info" & i))
            Next

            Return list
        End Function
    End Class
End Namespace
