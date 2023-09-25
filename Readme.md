<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128631055/13.2.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T191038)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WinForms Grid Lookup - How to select multiple items

The WinForms `GridLookUpEdit` control does not support multiple item selection ot of the box. This example demonstrates how to implement a "custom" Grid Lookup editor that allows users to select multiple values (rows) in its dropdown window.

The Grid Lookup editor is implemented based on a [PopupContainerEdit](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.PopupContainerEdit) control that displays a [GridControl](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.GridControl) in the dropdown window. 

The Grid Lookup editor's value is a string in CSV format. You can type comma-separated values (for example, "Name0, Name2, Name4") in the edit box to select corresponding rows in the dropdown. Users can also select rows in the dropdown. When the dropdown is closed, the Grid Lookup editor displays selected row values in the edit box.

## WinForms LookUpEdit <b>v.23.1+<b/> Supports Multiple Item Selection

Read the following help topic for more information and examples: [LookUpEdit - Enable Multiple Item Selection](https://docs.devexpress.com/WindowsForms/116008/controls-and-libraries/editors-and-simple-controls/lookup-editors#enable-multiple-item-selection).

## Files to Review

* [Customer.cs](./CS/Customer.cs) (VB: [Customer.vb](./VB/Customer.vb))
* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb))

## Documentation

* [PopupContainerEdit](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.PopupContainerEdit)
* [GridControl](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.GridControl)
* [DevExpress Lookup Editors for WinForms](https://docs.devexpress.com/WindowsForms/116008/controls-and-libraries/editors-and-simple-controls/lookup-editors)

## See Also

* [DevExpress WinForms Troubleshooting - LookUp Editors](https://go.devexpress.com/CheatSheets_WinForms_Examples_T929986.aspx)
