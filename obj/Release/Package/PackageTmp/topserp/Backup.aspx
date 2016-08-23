<%@ Page Title="" Language="C#" MasterPageFile="~/topserp/TopsManagement.Master" AutoEventWireup="true" CodeBehind="Backup.aspx.cs" Inherits="MyAttendance.topserp.Backup" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolderMenu" runat="server">
    <ul class="nav pull-right">
        <%--<li class=""><a href="index.html">Home	</a></li>
                            <li class=""><a href="services.html">What we do?</a></li>--%>
        <li class=""><a href="StudentStuff.aspx">Student Stuff</a></li>
        <li class="active"><a href="Backup.aspx">Backup</a></li>
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
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderLeft" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
