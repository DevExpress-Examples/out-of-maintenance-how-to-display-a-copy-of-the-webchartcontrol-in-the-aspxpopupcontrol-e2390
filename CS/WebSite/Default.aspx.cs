using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.XtraCharts;
using System.Data;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        BindSimpleChartToData();

        if(!IsPostBack)
            ChartpopupControl1.CopyFromChart(WebChartControl1, 600, 400);
    }

    private void BindSimpleChartToData() {
        // Cpecify ScaleTypes
        WebChartControl1.SeriesTemplate.ArgumentScaleType = ScaleType.DateTime;
        WebChartControl1.SeriesTemplate.ValueScaleType = ScaleType.Numerical;

        // Bound series template to data
        WebChartControl1.DataSource = GetSimpleChartDataCache().Tables[0];
        WebChartControl1.SeriesDataMember = "MyRow";
        WebChartControl1.SeriesTemplate.ArgumentDataMember = "MyDateTime";
        WebChartControl1.SeriesTemplate.ValueDataMembers.AddRange(new string[] { "MyData" });

        // Adjust AxisX
        ((XYDiagram)WebChartControl1.Diagram).AxisX.DateTimeOptions.Format = DateTimeFormat.ShortDate;
        ((XYDiagram)WebChartControl1.Diagram).AxisX.DateTimeMeasureUnit = DateTimeMeasurementUnit.Day;

        WebChartControl1.DataBind();
    }

    private DataSet GetSimpleChartDataCache() {
        if(Session["chartData"] == null)
            Session["chartData"] = ManualDataSet.CreateData();

        return (DataSet)Session["chartData"];
    }
}
