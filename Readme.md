<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128631055/13.2.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T191038)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->


# How to select multiple items in GridLookUpEdit

[GridLookUpEdit](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.GridLookUpEdit) does not support multiple row selection by default. However, you can implement a custom [PopupContainerEdit](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.PopupContainerEdit) that recreates the functionality of GridLookUpEdit. It also allows you to select multiple values in its drop-down window.

This editor's value is stored as a string of comma-separated values. You can set selected rows using the editor's text area, and vice versa.



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


