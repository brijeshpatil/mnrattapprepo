<%@ Page Title="" Language="C#" MasterPageFile="~/topserp/TopsManagement.Master" AutoEventWireup="true" CodeBehind="StudentStuff.aspx.cs" Inherits="MyAttendance.topserp.StudentStuff" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .MyPnl {
            height: 20%;
            width: 50%;
            background-color: white;
            padding: 5%;
            border: 10px solid #de3e05;
            border-radius: 10px;
        }

            .MyPnl input[type='text'], .MyPnl input[type='password'] {
                width: 100%;
            }

            .MyPnl table {
                font-weight: bold;
                font-size: large;
                width: 80%;
            }

        .popupBack {
            background-color: black;
            opacity: 0.5;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMenu" runat="server">
    <ul class="nav pull-right">
        <%--<li class=""><a href="index.html">Home	</a></li>
                            <li class=""><a href="services.html">What we do?</a></li>--%>
        <li class="active"><a href="StudentStuff.aspx">Student Stuff</a></li>
        <li class=""><a href="Backup.aspx">Backup</a></li>
        <li class=""><a href="Logout.aspx">Logout</a></li>
        <%-- <li class="dropdown">
                                <a href="#" class="dropdown-toggle" data-toggle="dropdown">Features<b class="caret"></b></a>
                                <ul class="dropdown-menu">
                                    <li><a href="elements.html">Page Elements</a></li>
                                    <li><a href="comingsoon.html">Coming soon page</a></li>
                                </ul>
                            </li>
                            <li class=""><a href="blog.html">Blog</a></li>
                            <li class=""><a href="contact.html">Support</a></li>--%>
    </ul>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderLeft" runat="server">
    <table>
        <tr>
            <td>
                <asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
                <cc1:CalendarExtender ID="TextBox1_CalendarExtender" runat="server" Enabled="True" TargetControlID="txtDate">
                </cc1:CalendarExtender>
            </td>
        </tr>
        <tr>
            <td align="right">
                <asp:Button ID="btnDate" runat="server" Text="Search" CssClass="btn" OnClick="btnDate_Click" />
            </td>
        </tr>
    </table>

</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <cc1:ModalPopupExtender ID="ModalPopupExtender1" runat="server" BackgroundCssClass="popupBack" TargetControlID="Label1" PopupControlID="Panel1"></cc1:ModalPopupExtender>
        <asp:Panel ID="Panel1" runat="server" CssClass="MyPnl">
            <div style="width: 100%;" align="center">
                <table>
                    <tr>
                        <td style="width: 20%;">UserName</td>
                        <td>
                            <asp:TextBox ID="txtUname" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Password</td>
                        <td>
                            <asp:TextBox ID="txtPass" TextMode="Password" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>
                            <asp:Button ID="Button1" runat="server" Text="Login" CssClass="btn" OnClick="Button1_Click" />
                            <asp:Button ID="Button2" runat="server" Text="Cancel" CssClass="btn" PostBackUrl="~/MakeAttendance.aspx" />
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>
                            <asp:Label ID="lblError" runat="server" CssClass="alert-danger" Text=""></asp:Label>
                        </td>
                    </tr>
                </table>
            </div>

        </asp:Panel>
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="true">
        </asp:GridView>
    </div>
</asp:Content>
