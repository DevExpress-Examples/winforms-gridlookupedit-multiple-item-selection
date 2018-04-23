Namespace TestGridLookUpEditCSV
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.gridControl2 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.popupGridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.popupGridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.popupContainerEdit1 = New DevExpress.XtraEditors.PopupContainerEdit()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.popupContainerControl1 = New DevExpress.XtraEditors.PopupContainerControl()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.popupGridControl2 = New DevExpress.XtraGrid.GridControl()
            Me.popupGridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
            DirectCast(Me.gridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.popupGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.popupGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.popupContainerEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.popupContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.popupContainerControl1.SuspendLayout()
            DirectCast(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.popupGridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.popupGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' gridControl2
            ' 
            Me.gridControl2.Location = New System.Drawing.Point(12, 36)
            Me.gridControl2.MainView = Me.gridView1
            Me.gridControl2.Name = "gridControl2"
            Me.gridControl2.Size = New System.Drawing.Size(907, 516)
            Me.gridControl2.TabIndex = 4
            Me.gridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
            ' 
            ' gridView1
            ' 
            Me.gridView1.GridControl = Me.gridControl2
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True
            Me.gridView1.OptionsDetail.EnableMasterViewMode = False
            ' 
            ' popupGridControl1
            ' 
            Me.popupGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.popupGridControl1.Location = New System.Drawing.Point(0, 0)
            Me.popupGridControl1.MainView = Me.popupGridView1
            Me.popupGridControl1.Name = "popupGridControl1"
            Me.popupGridControl1.Size = New System.Drawing.Size(931, 261)
            Me.popupGridControl1.TabIndex = 0
            Me.popupGridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.popupGridView1, Me.gridView2})
            ' 
            ' popupGridView1
            ' 
            Me.popupGridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
            Me.popupGridView1.GridControl = Me.popupGridControl1
            Me.popupGridView1.Name = "popupGridView1"
            Me.popupGridView1.OptionsSelection.EnableAppearanceFocusedCell = False
            Me.popupGridView1.OptionsSelection.EnableAppearanceHideSelection = False
            Me.popupGridView1.OptionsSelection.MultiSelect = True
            Me.popupGridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
            ' 
            ' gridView2
            ' 
            Me.gridView2.GridControl = Me.popupGridControl1
            Me.gridView2.Name = "gridView2"
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.popupContainerControl1)
            Me.layoutControl1.Controls.Add(Me.popupContainerEdit1)
            Me.layoutControl1.Controls.Add(Me.gridControl2)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(931, 564)
            Me.layoutControl1.TabIndex = 5
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem2, Me.emptySpaceItem1, Me.layoutControlItem1})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(931, 564)
            Me.layoutControlGroup1.Text = "layoutControlGroup1"
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.gridControl2
            Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(911, 520)
            Me.layoutControlItem1.Text = "layoutControlItem1"
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextToControlDistance = 0
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' popupContainerEdit1
            ' 
            Me.popupContainerEdit1.Location = New System.Drawing.Point(12, 12)
            Me.popupContainerEdit1.Name = "popupContainerEdit1"
            Me.popupContainerEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.popupContainerEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
            Me.popupContainerEdit1.Size = New System.Drawing.Size(297, 20)
            Me.popupContainerEdit1.StyleController = Me.layoutControl1
            Me.popupContainerEdit1.TabIndex = 5
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.popupContainerEdit1
            Me.layoutControlItem2.CustomizationFormText = "layoutControlItem2"
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(301, 24)
            Me.layoutControlItem2.Text = "layoutControlItem2"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextToControlDistance = 0
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' popupContainerControl1
            ' 
            Me.popupContainerControl1.Controls.Add(Me.popupGridControl2)
            Me.popupContainerControl1.Location = New System.Drawing.Point(279, 238)
            Me.popupContainerControl1.Name = "popupContainerControl1"
            Me.popupContainerControl1.Size = New System.Drawing.Size(399, 229)
            Me.popupContainerControl1.TabIndex = 6
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1"
            Me.emptySpaceItem1.Location = New System.Drawing.Point(301, 0)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(610, 24)
            Me.emptySpaceItem1.Text = "emptySpaceItem1"
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' popupGridControl2
            ' 
            Me.popupGridControl2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.popupGridControl2.Location = New System.Drawing.Point(0, 0)
            Me.popupGridControl2.MainView = Me.popupGridView2
            Me.popupGridControl2.Name = "popupGridControl2"
            Me.popupGridControl2.Size = New System.Drawing.Size(399, 229)
            Me.popupGridControl2.TabIndex = 0
            Me.popupGridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.popupGridView2})
            ' 
            ' popupGridView2
            ' 
            Me.popupGridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
            Me.popupGridView2.GridControl = Me.popupGridControl2
            Me.popupGridView2.Name = "popupGridView2"
            Me.popupGridView2.OptionsBehavior.Editable = False
            Me.popupGridView2.OptionsSelection.EnableAppearanceFocusedCell = False
            Me.popupGridView2.OptionsSelection.EnableAppearanceHideSelection = False
            Me.popupGridView2.OptionsSelection.MultiSelect = True
            Me.popupGridView2.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
            Me.popupGridView2.OptionsView.ShowGroupPanel = False
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(931, 564)
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.gridControl2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.popupGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.popupGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.popupContainerEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.popupContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.popupContainerControl1.ResumeLayout(False)
            DirectCast(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.popupGridControl2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.popupGridView2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private gridControl2 As DevExpress.XtraGrid.GridControl
        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private popupGridControl1 As DevExpress.XtraGrid.GridControl
        Private popupGridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Private popupContainerControl1 As DevExpress.XtraEditors.PopupContainerControl
        Private popupGridControl2 As DevExpress.XtraGrid.GridControl
        Private popupGridView2 As DevExpress.XtraGrid.Views.Grid.GridView
        Private popupContainerEdit1 As DevExpress.XtraEditors.PopupContainerEdit
        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem



    End Class
End Namespace

