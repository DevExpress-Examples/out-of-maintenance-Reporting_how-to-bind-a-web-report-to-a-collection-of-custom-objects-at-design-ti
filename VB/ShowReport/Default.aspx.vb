Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports System.Collections.Generic
Imports Reports

Namespace ShowReport
	Partial Public Class _Default
		Inherits System.Web.UI.Page
		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			If Session("report") Is Nothing Then
				Session("report") = GetReport()
			End If
			ReportViewer1.Report = TryCast(Session("report"), XtraReport1)
		End Sub

		Private Function GetReport() As XtraReport1
			Dim report As New XtraReport1()
			report.DataSource = GetData()
			Return report
		End Function
		Private Function GetData() As List(Of Data)
			Dim data As New List(Of Data)()
			Dim item As New Data(1, "Alex")
			data.Add(item)
			item = New Data(2, "John")
			data.Add(item)
			item = New Data(3, "Mary")
			data.Add(item)
			Return data
		End Function
		Protected Sub ReportViewer1_Unload(ByVal sender As Object, ByVal e As EventArgs)
			ReportViewer1.Report = Nothing
		End Sub
	End Class
End Namespace
