namespace TestGridLookUpEditCSV
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.popupGridControl1 = new DevExpress.XtraGrid.GridControl();
            this.popupGridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.popupContainerEdit1 = new DevExpress.XtraEditors.PopupContainerEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.popupContainerControl1 = new DevExpress.XtraEditors.PopupContainerControl();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.popupGridControl2 = new DevExpress.XtraGrid.GridControl();
            this.popupGridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupContainerEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupContainerControl1)).BeginInit();
            this.popupContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupGridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl2
            // 
            this.gridControl2.Location = new System.Drawing.Point(12, 36);
            this.gridControl2.MainView = this.gridView1;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(907, 516);
            this.gridControl2.TabIndex = 4;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl2;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            // 
            // popupGridControl1
            // 
            this.popupGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.popupGridControl1.Location = new System.Drawing.Point(0, 0);
            this.popupGridControl1.MainView = this.popupGridView1;
            this.popupGridControl1.Name = "popupGridControl1";
            this.popupGridControl1.Size = new System.Drawing.Size(931, 261);
            this.popupGridControl1.TabIndex = 0;
            this.popupGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.popupGridView1,
            this.gridView2});
            // 
            // popupGridView1
            // 
            this.popupGridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.popupGridView1.GridControl = this.popupGridControl1;
            this.popupGridView1.Name = "popupGridView1";
            this.popupGridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.popupGridView1.OptionsSelection.EnableAppearanceHideSelection = false;
            this.popupGridView1.OptionsSelection.MultiSelect = true;
            this.popupGridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.popupGridControl1;
            this.gridView2.Name = "gridView2";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.popupContainerControl1);
            this.layoutControl1.Controls.Add(this.popupContainerEdit1);
            this.layoutControl1.Controls.Add(this.gridControl2);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(931, 564);
            this.layoutControl1.TabIndex = 5;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.emptySpaceItem1,
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(931, 564);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl2;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(911, 520);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // popupContainerEdit1
            // 
            this.popupContainerEdit1.Location = new System.Drawing.Point(12, 12);
            this.popupContainerEdit1.Name = "popupContainerEdit1";
            this.popupContainerEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.popupContainerEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.popupContainerEdit1.Size = new System.Drawing.Size(297, 20);
            this.popupContainerEdit1.StyleController = this.layoutControl1;
            this.popupContainerEdit1.TabIndex = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.popupContainerEdit1;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(301, 24);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // popupContainerControl1
            // 
            this.popupContainerControl1.Controls.Add(this.popupGridControl2);
            this.popupContainerControl1.Location = new System.Drawing.Point(279, 238);
            this.popupContainerControl1.Name = "popupContainerControl1";
            this.popupContainerControl1.Size = new System.Drawing.Size(399, 229);
            this.popupContainerControl1.TabIndex = 6;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(301, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(610, 24);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // popupGridControl2
            // 
            this.popupGridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.popupGridControl2.Location = new System.Drawing.Point(0, 0);
            this.popupGridControl2.MainView = this.popupGridView2;
            this.popupGridControl2.Name = "popupGridControl2";
            this.popupGridControl2.Size = new System.Drawing.Size(399, 229);
            this.popupGridControl2.TabIndex = 0;
            this.popupGridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.popupGridView2});
            // 
            // popupGridView2
            // 
            this.popupGridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.popupGridView2.GridControl = this.popupGridControl2;
            this.popupGridView2.Name = "popupGridView2";
            this.popupGridView2.OptionsBehavior.Editable = false;
            this.popupGridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.popupGridView2.OptionsSelection.EnableAppearanceHideSelection = false;
            this.popupGridView2.OptionsSelection.MultiSelect = true;
            this.popupGridView2.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.popupGridView2.OptionsView.ShowGroupPanel = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 564);
            this.Controls.Add(this.layoutControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupContainerEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupContainerControl1)).EndInit();
            this.popupContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupGridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl popupGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView popupGridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.PopupContainerControl popupContainerControl1;
        private DevExpress.XtraGrid.GridControl popupGridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView popupGridView2;
        private DevExpress.XtraEditors.PopupContainerEdit popupContainerEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;



    }
}

