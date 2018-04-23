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

namespace ShowReport {
    public partial class _Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if (Session["report"] == null)
                Session["report"] = GetReport();
            ReportViewer1.Report = Session["report"] as XtraReport1;
        }

        XtraReport1 GetReport() {
            XtraReport1 report = new XtraReport1();
            report.DataSource = GetData();
            return report;
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
        protected void ReportViewer1_Unload(object sender, EventArgs e) {
            ReportViewer1.Report = null;
        }
    }
}
