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
Imports System.IO
Imports DevExpress.XtraReports.UI

Namespace ShowReport
    Partial Public Class _Default
        Inherits System.Web.UI.Page

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
            ASPxDocumentViewer1.Report = GetReport()
        End Sub

        Private Function GetReport() As XtraReport1
            Dim report As New XtraReport1()
            AddHandler report.DataSourceDemanded, AddressOf report_DataSourceDemanded
            Return report
        End Function

        Private Sub report_DataSourceDemanded(ByVal sender As Object, ByVal e As EventArgs)
            Dim report As XtraReport = TryCast(sender, XtraReport)
            report.DataSource = GetData()
        End Sub
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

        Protected Sub ASPxDocumentViewer1_CacheReportDocument(ByVal sender As Object, ByVal e As DevExpress.XtraReports.Web.CacheReportDocumentEventArgs)
            Page.Session("report") = e.SaveDocumentToMemoryStream()
        End Sub

        Protected Sub ASPxDocumentViewer1_RestoreReportDocumentFromCache(ByVal sender As Object, ByVal e As DevExpress.XtraReports.Web.RestoreReportDocumentFromCacheEventArgs)
            Dim stream As Stream = TryCast(Page.Session("report"), Stream)
            If stream IsNot Nothing Then
                e.RestoreDocumentFromStream(stream)
            End If
        End Sub
    End Class
End Namespace
