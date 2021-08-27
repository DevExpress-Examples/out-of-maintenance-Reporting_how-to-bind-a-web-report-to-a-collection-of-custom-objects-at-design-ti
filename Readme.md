<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1936)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Data.cs](./CS/Reports/Data.cs) (VB: [Data.vb](./VB/Reports/Data.vb))
* [XtraReport1.cs](./CS/Reports/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/Reports/XtraReport1.vb))
* [Default.aspx](./CS/ShowReport/Default.aspx) (VB: [Default.aspx](./VB/ShowReport/Default.aspx))
* [Default.aspx.cs](./CS/ShowReport/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/ShowReport/Default.aspx.vb))
<!-- default file list end -->
# How to bind a web report to a collection of custom objects at design time


<p>This example illustrates how to bind a report to lists for web projects at design time. To do this you need to extract your reports together with the corresponding classes representing your business objects into a separate assembly. Then, you can easily perform all necessary design-time binding using the BindingSource component (by specifying the required object type as its DataSource).</p><p>This approach differs from how this is done under the Windows Forms platforms in that you cannot assign your object to the <strong>BindingSource.DataSource</strong> property at design time. Instead, you should perform the binding right within the <strong>InitializeComponent</strong> method.</p>

<br/>


