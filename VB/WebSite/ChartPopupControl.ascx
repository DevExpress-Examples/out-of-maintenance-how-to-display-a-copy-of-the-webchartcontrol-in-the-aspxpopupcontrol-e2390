<%@ Control Language="vb" AutoEventWireup="true" CodeFile="ChartPopupControl.ascx.vb"
	Inherits="ChartPopupControl" %>
<%@ Register Assembly="DevExpress.Web.v10.1, Version=10.1.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.Web.ASPxPopupControl" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.XtraCharts.v10.1.Web, Version=10.1.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.XtraCharts.Web" TagPrefix="dxchartsui" %>
<%@ Register Assembly="DevExpress.XtraCharts.v10.1, Version=10.1.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.XtraCharts" TagPrefix="cc1" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v10.1, Version=10.1.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>

<dx:ASPxPopupControl ID="ASPxPopupControl1" runat="server" DragElement="Header"
	HeaderText="ChartPopup" AllowDragging="True" CloseAction="CloseButton" 
	Modal="True" PopupHorizontalAlign="WindowCenter" 
	PopupVerticalAlign="WindowCenter">
	<ContentCollection>
		<dx:PopupControlContentControl runat="server">
			<dxchartsui:WebChartControl ID="WebChartControl1" runat="server" Height="200px" Width="300px" >
				<fillstyle>
			<optionsserializable>
				<cc1:SolidFillOptions />
			</optionsserializable>
		</fillstyle>
				<seriestemplate>
			<viewserializable>
				<cc1:SideBySideBarSeriesView>
				</cc1:SideBySideBarSeriesView>
			</viewserializable>
			<labelserializable>
				<cc1:SideBySideBarSeriesLabel LineVisible="True">
					<fillstyle>
						<optionsserializable>
							<cc1:SolidFillOptions />
						</optionsserializable>
					</fillstyle>
				</cc1:SideBySideBarSeriesLabel>
			</labelserializable>
			<pointoptionsserializable>
				<cc1:PointOptions>
				</cc1:PointOptions>
			</pointoptionsserializable>
			<legendpointoptionsserializable>
				<cc1:PointOptions>
				</cc1:PointOptions>
			</legendpointoptionsserializable>
		</seriestemplate>
			</dxchartsui:WebChartControl>
			<table width="100%">
				<tr>
					<td width="50%" align="center">
						<dx:ASPxButton ID="ASPxButton1" runat="server" Text="Print" AutoPostBack="False">
						</dx:ASPxButton>
					</td>
					<td width="50%" align="center">
						<dx:ASPxButton ID="ASPxButton2" runat="server" Text="Export" AutoPostBack="False">
						</dx:ASPxButton>
					</td>
				</tr>
			</table>
		</dx:PopupControlContentControl>
	</ContentCollection>
</dx:ASPxPopupControl>