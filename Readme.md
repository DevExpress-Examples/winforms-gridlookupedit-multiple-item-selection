# How to provide the MultiSelect functionality for GridLookUpEdit


A general idea is to use <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraEditorsPopupContainerEdittopic">PopupContainerEdit</a> with a <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraGridGridControltopic">GridControl</a> inside. In this example, an editor's value is represented by CSV. So, you can type in textbox comma-separated values from the popup, and they will be automatically selected. And vice versa, when you select values in the popup and close it, the selected values will appear as a comma-separated string.<br /><br />See also: <a href="https://www.devexpress.com/Support/Center/p/T188764">Provide a control similar to SearchLookUpEdit that will support selecting multiple values with a CheckBox column</a>

<br/>


