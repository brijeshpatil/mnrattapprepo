<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="MyAttendance.WebForm1" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Src="~/PCs.ascx" TagPrefix="uc1" TagName="PCs" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <%--<link rel="stylesheet" href="//code.jquery.com/ui/1.12.0/themes/base/jquery-ui.css" />
    <link rel="stylesheet" href="/resources/demos/style.css" />
    <style>
        #draggable, #draggable2 {
            width: 100px;
            height: 100px;
            padding: 0.5em;
            float: left;
            margin: 0 10px 10px 0;
        }
    </style>
    <script src="https://code.jquery.com/jquery-1.12.4.js"></script>
    <script src="https://code.jquery.com/ui/1.12.0/jquery-ui.js"></script>
    <script>
        $(function () {
            $("#draggable").draggable({ revert: true });
            $("#draggable2").draggable({ revert: true, helper: "clone" });
        });
    </script>--%>
</head>
<body>
    <form id="form1" runat="server">

<%--        <div>
            <div id="draggable" class="ui-widget-content">
                <p>Revert the original</p>
            </div>

            <div id="draggable2" class="ui-widget-content">
                <p>Revert the helper</p>
            </div>

        </div>--%>
        <uc1:PCs runat="server" id="PCs" />
    </form>
</body>
</html>
