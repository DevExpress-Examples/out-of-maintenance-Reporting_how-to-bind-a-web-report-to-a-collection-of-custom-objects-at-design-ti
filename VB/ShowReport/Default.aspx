<%@ Page Language="vb" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="ShowReport._Default" %>

<%@ Register Assembly="DevExpress.XtraReports.v13.2.Web, Version=13.2.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.XtraReports.Web" TagPrefix="dxxr" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <dxxr:ASPxDocumentViewer ID="ASPxDocumentViewer1" runat="server" 
            oncachereportdocument="ASPxDocumentViewer1_CacheReportDocument" 
            onrestorereportdocumentfromcache="ASPxDocumentViewer1_RestoreReportDocumentFromCache">
        </dxxr:ASPxDocumentViewer>    
    </div>
    </form>
</body>
</html>