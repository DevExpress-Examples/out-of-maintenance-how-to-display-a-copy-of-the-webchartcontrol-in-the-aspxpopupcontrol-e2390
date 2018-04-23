using System;
using System.IO;
using DevExpress.XtraCharts.Native;
using DevExpress.XtraCharts.Web;

public partial class ChartPopupControl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ASPxPopupControl1.ClientInstanceName = this.ID;
        WebChartControl1.ClientInstanceName = this.ID + "_chart";

        ASPxButton1.ClientSideEvents.Click = string.Format(
            "function(s, e) {{{0}.Print();}}", WebChartControl1.ClientInstanceName);
        ASPxButton2.ClientSideEvents.Click = string.Format(
            "function(s, e) {{{0}.SaveToWindow('pdf');}}", WebChartControl1.ClientInstanceName);
    }

    public void CopyFromChart(WebChartControl chart, int width, int height) { 
        MemoryStream memoryStream = new MemoryStream();

        ((IChartContainer)chart).Chart.DataSnapshot();
        ((IChartContainer)chart).Chart.SaveLayout(memoryStream);
        memoryStream.Seek(0, SeekOrigin.Begin);
        ((IChartContainer)WebChartControl1).Chart.LoadLayout(memoryStream);
        WebChartControl1.Width = width;
        WebChartControl1.Height = height;
    }

}
