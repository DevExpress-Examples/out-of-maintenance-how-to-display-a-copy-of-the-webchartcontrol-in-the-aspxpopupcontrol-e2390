Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.XtraCharts
Imports System.Data

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		BindSimpleChartToData()

		If (Not IsPostBack) Then
			ChartpopupControl1.CopyFromChart(WebChartControl1, 600, 400)
		End If
	End Sub

	Private Sub BindSimpleChartToData()
		' Cpecify ScaleTypes
		WebChartControl1.SeriesTemplate.ArgumentScaleType = ScaleType.DateTime
		WebChartControl1.SeriesTemplate.ValueScaleType = ScaleType.Numerical

		' Bound series template to data
		WebChartControl1.DataSource = GetSimpleChartDataCache().Tables(0)
		WebChartControl1.SeriesDataMember = "MyRow"
		WebChartControl1.SeriesTemplate.ArgumentDataMember = "MyDateTime"
		WebChartControl1.SeriesTemplate.ValueDataMembers.AddRange(New String() { "MyData" })

		' Adjust AxisX
		CType(WebChartControl1.Diagram, XYDiagram).AxisX.DateTimeOptions.Format = DateTimeFormat.ShortDate
		CType(WebChartControl1.Diagram, XYDiagram).AxisX.DateTimeMeasureUnit = DateTimeMeasurementUnit.Day

		WebChartControl1.DataBind()
	End Sub

	Private Function GetSimpleChartDataCache() As DataSet
		If Session("chartData") Is Nothing Then
			Session("chartData") = ManualDataSet.CreateData()
		End If

		Return CType(Session("chartData"), DataSet)
	End Function
End Class
