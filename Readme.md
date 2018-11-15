<!-- default file list -->
*Files to look at*:

* [BO.cs](./CS/WebSite/App_Code/BO.cs) (VB: [BO.vb](./VB/WebSite/App_Code/BO.vb))
* [ChartPopupControl.ascx](./CS/WebSite/ChartPopupControl.ascx) (VB: [ChartPopupControl.ascx](./VB/WebSite/ChartPopupControl.ascx))
* [ChartPopupControl.ascx.cs](./CS/WebSite/ChartPopupControl.ascx.cs) (VB: [ChartPopupControl.ascx](./VB/WebSite/ChartPopupControl.ascx))
* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
<!-- default file list end -->
# How to display a copy of the WebChartControl in the ASPxPopupControl


<p>In this example, you can find a ChartPopupControl.ascx user control. To use this control, attach it to the WebChartControl instance via the ChartPopupControl.CopyFromChart() server-side method. Then, simply call the ChartPopupControl.Show() method on the client side (via the JavaScript) to display a popup. Note that in addition, you can print and export a WebChartControl directly from the popup.</p>

<br/>


