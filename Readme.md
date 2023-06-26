<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128631055/13.2.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T191038)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->


# Grid LookUp for Windows Forms - How to select multiple items in a Grid Lookup control

This example implements a Grid Lookup editor that allows you to select multiple values (rows) in its dropdown window. The Grid Lookup editor is implemented based on a [PopupContainerEdit](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.PopupContainerEdit) control that displays a [GridControl](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.GridControl) inside the editor's dropdown window. 

The Grid Lookup editor's value is a string in CSV format. You can type comma-separated values (for instance, "Name0, Name2, Name4") in the editor's text box to select corresponding rows in the popup. And vice versa, when you select rows in the popup and close it, the selected row values are displayed in the edit box as a comma-separated string.

## Please note that LookUpEdit supports the Multiple Item Selection function in <b>v.23.1+<b/>. 
Please refer to the following help topic for more information: [Enable Multiple Item Selection](https://docs.devexpress.com/WindowsForms/116008/controls-and-libraries/editors-and-simple-controls/lookup-editors#enable-multiple-item-selection).

<!-- default file list -->
## Files to Look At
* [Customer.cs](./CS/Customer.cs) (VB: [Customer.vb](./VB/Customer.vb))
* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb))
<!-- default file list end -->

## Documentation
- [PopupContainerEdit](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.PopupContainerEdit)
- [GridControl](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.GridControl)

## See Also
- [DevExpress WinForms Troubleshooting - LookUp Editors](https://go.devexpress.com/CheatSheets_WinForms_Examples_T929986.aspx)

<br/>


