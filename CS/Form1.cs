using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestGridLookUpEditCSV {
    public partial class Form1 : DevExpress.XtraEditors.XtraForm {
        public Form1() {
            InitializeComponent();
            InitGrid();
            RepositoryItemPopupContainerEdit ri = new RepositoryItemPopupContainerEdit();
            ri.QueryResultValue += ri_QueryResultValue;
            ri.EditValueChanged += ri_EditValueChanged;
            ri.Popup += ri_Popup;
            ri.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            PopupContainerControl popupControl = new PopupContainerControl();
            popupControl.Controls.Add(popupGridControl1);
            popupControl.Size = new System.Drawing.Size(500, 300);
            ri.PopupControl = popupControl;
            gridView1.Columns["Name"].ColumnEdit = ri;

            popupContainerEdit1.Properties.PopupControl = popupContainerControl1;
            popupContainerEdit1.Properties.QueryResultValue += Properties_QueryResultValue;
            popupContainerEdit1.Properties.EditValueChanged += Properties_EditValueChanged;
            popupContainerEdit1.Properties.Popup += Properties_Popup;

        }

        void Properties_Popup(object sender, EventArgs e) {
            PopupContainerEdit edit = sender as PopupContainerEdit;
            if(!edit.IsPopupOpen)
                edit.ShowPopup();
            UpdateSelection(edit, popupGridView2);
        }

        void Properties_EditValueChanged(object sender, EventArgs e) {
            PopupContainerEdit edit = sender as PopupContainerEdit;
            UpdateSelection(edit, popupGridView2);
        }

        void Properties_QueryResultValue(object sender, DevExpress.XtraEditors.Controls.QueryResultValueEventArgs e) {
            int[] selectedRows = popupGridView2.GetSelectedRows();
            List<string> values = new List<string>();
            foreach(int rowHandle in selectedRows) {
                values.Add(popupGridView2.GetRowCellValue(rowHandle, "Name").ToString());
            }
            string csv = String.Join(", ", values);
            e.Value = csv;
        }

        void ri_Popup(object sender, EventArgs e) {
            PopupContainerEdit edit = sender as PopupContainerEdit;
            UpdateSelection(edit, popupGridView1);
        }

        void ri_EditValueChanged(object sender, EventArgs e) {
            PopupContainerEdit edit = sender as PopupContainerEdit;
            if(!edit.IsPopupOpen)
                edit.ShowPopup();
            UpdateSelection(edit, popupGridView1);
        }

        void ri_QueryResultValue(object sender, DevExpress.XtraEditors.Controls.QueryResultValueEventArgs e) {
            int[] selectedRows = popupGridView1.GetSelectedRows();
            List<string> values = new List<string>();
            foreach(int rowHandle in selectedRows) {
                values.Add(popupGridView1.GetRowCellValue(rowHandle, "Name").ToString());
            }
            string csv = String.Join(", ", values);
            e.Value = csv;
        }

        private void UpdateSelection(PopupContainerEdit edit, GridView view) {
            view.BeginSelection();
            view.ClearSelection();
            if(edit != null)
                if(edit.EditValue != null) {
                    edit.Focus();
                    List<int> selection = GetSelection(edit.EditValue.ToString().Split(new string[] { ", " }, StringSplitOptions.None), "Name", view);
                    foreach(int rowHandle in selection) {
                        view.SelectRow(rowHandle);
                    }
                }
            view.EndSelection();
        }

        private List<int> GetSelection(string[] values, string fieldName, GridView view) {
            List<int> selection = new List<int>();
            foreach(string val in values) {
                for(int i = 0; i < view.RowCount; i++) {
                    if(view.GetRowCellValue(i, fieldName).ToString() == val)
                        selection.Add(i);
                }
            }
            return selection;
        }



        private void InitGrid() {
            popupGridControl1.DataSource = CreateList(5);
            gridControl2.DataSource = CreateList(5);
            popupGridControl2.DataSource = CreateList(5);
        }

        BindingList<Customer> CreateList(int count) {
            BindingList<Customer> list = new BindingList<Customer>();
            for(int i = 0; i < count; i++) {
                list.Add(new Customer(i, "Name" + i, "Info" + i));
            }
            return list;
        }

    }
}
