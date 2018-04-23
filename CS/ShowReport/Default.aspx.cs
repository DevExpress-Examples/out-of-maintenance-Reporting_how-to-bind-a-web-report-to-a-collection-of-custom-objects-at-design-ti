using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections.Generic;
using Reports;
using System.IO;
using DevExpress.XtraReports.UI;

namespace ShowReport {
    public partial class _Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            ASPxDocumentViewer1.Report = GetReport();
        }

        XtraReport1 GetReport() {
            XtraReport1 report = new XtraReport1();
            report.DataSourceDemanded += report_DataSourceDemanded;
            return report;
        }

        void report_DataSourceDemanded(object sender, EventArgs e) {
            XtraReport report = sender as XtraReport;
            report.DataSource = GetData();
        }
        List<Data> GetData() {
            List<Data> data = new List<Data>();
            Data item = new Data(1, "Alex");
            data.Add(item);
            item = new Data(2, "John");
            data.Add(item);
            item = new Data(3, "Mary");
            data.Add(item);
            return data;
        }

        protected void ASPxDocumentViewer1_CacheReportDocument(object sender, DevExpress.XtraReports.Web.CacheReportDocumentEventArgs e) {
            Page.Session["report"] = e.SaveDocumentToMemoryStream();
        }

        protected void ASPxDocumentViewer1_RestoreReportDocumentFromCache(object sender, DevExpress.XtraReports.Web.RestoreReportDocumentFromCacheEventArgs e) {
            Stream stream = Page.Session["report"] as Stream;
            if (stream != null)
                e.RestoreDocumentFromStream(stream);
        }
    }
}
