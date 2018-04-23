Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports DevExpress.XtraCharts.Native
Imports DevExpress.XtraCharts.Web

Partial Public Class ChartPopupControl
	Inherits System.Web.UI.UserControl
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		ASPxPopupControl1.ClientInstanceName = Me.ID
		WebChartControl1.ClientInstanceName = Me.ID & "_chart"

		ASPxButton1.ClientSideEvents.Click = String.Format("function(s, e) {{{0}.Print();}}", WebChartControl1.ClientInstanceName)
		ASPxButton2.ClientSideEvents.Click = String.Format("function(s, e) {{{0}.SaveToWindow('pdf');}}", WebChartControl1.ClientInstanceName)
	End Sub

	Public Sub CopyFromChart(ByVal chart As WebChartControl, ByVal width As Integer, ByVal height As Integer)
		Dim memoryStream As New MemoryStream()

		CType(chart, IChartContainer).Chart.DataSnapshot()
		CType(chart, IChartContainer).Chart.SaveLayout(memoryStream)
		memoryStream.Seek(0, SeekOrigin.Begin)
		CType(WebChartControl1, IChartContainer).Chart.LoadLayout(memoryStream)
		WebChartControl1.Width = width
		WebChartControl1.Height = height
	End Sub

End Class
