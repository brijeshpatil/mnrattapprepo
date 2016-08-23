<%@ Page Title="" Language="C#" MasterPageFile="~/Attendance.Master" AutoEventWireup="true" CodeBehind="MakeAttendance.aspx.cs" Inherits="MyAttendance.ListAttendance" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        /*.Control {
            width: 100%;
            height: 30px;
            border-radius:0; padding:8px 8px;
        }

        .ControlDrp {
            width: 102%;
            height: 30px;
        }

        .btn {
            background-color: #db3d03;
            font-weight:bold;
            box-shadow:0px 0px 2px #db3d03;
        }*/

        .lblName {
            color: #4797bf;
            text-transform: capitalize;
        }

        .lblTech {
            color: #fe5214;
        }

        .MyPnl {
            background-color: white;
            padding: 5%;
            border: 10px solid #de3e05;
            border-radius: 10px;
        }


        .popupBack {
            background-color: black;
            opacity: 0.5;
        }

        .popupBackRed {
            background-color: red;
            opacity: 0.5;
        }

        .TimeNotification {
            background-color: #fe5214;
        }
    </style>

    <%--    <script type="text/javascript">
        alert("");
    </script>--%>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderLeft" runat="server">
    <h4 style="color: #fe5214;">Fill your Attendance<br />
    </h4>
    <div>
        <table style="width: 80%; margin: 10px;" align="center">
            <tr>
                <td>
                    <asp:TextBox ID="txtDate" runat="server" CssClass="Control" ReadOnly="true"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:DropDownList ID="drpBranch" runat="server" CssClass="ControlDrp"></asp:DropDownList>
                    <asp:RequiredFieldValidator ValidationGroup="ATT" ID="RequiredFieldValidator6" runat="server" SetFocusOnError="true" ControlToValidate="drpBranch" InitialValue="0" ErrorMessage=""></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="txtfname" runat="server" CssClass="Control"></asp:TextBox>
                    <asp:RequiredFieldValidator ValidationGroup="ATT" ID="RequiredFieldValidator1" runat="server" SetFocusOnError="true" ControlToValidate="txtfname" ErrorMessage=""></asp:RequiredFieldValidator>
                    <cc1:TextBoxWatermarkExtender ID="txtfname_TextBoxWatermarkExtender" runat="server" WatermarkText="Enter Your First Name" Enabled="True" TargetControlID="txtfname">
                    </cc1:TextBoxWatermarkExtender>

                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="txtlname" runat="server" CssClass="Control"></asp:TextBox>
                    <asp:RequiredFieldValidator ValidationGroup="ATT" ID="RequiredFieldValidator2" runat="server" SetFocusOnError="true" ControlToValidate="txtlname" ErrorMessage=""></asp:RequiredFieldValidator>
                    <cc1:TextBoxWatermarkExtender ID="txtlname_TextBoxWatermarkExtender" runat="server" WatermarkText="Enter Your Last Name" Enabled="True" TargetControlID="txtlname">
                    </cc1:TextBoxWatermarkExtender>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:DropDownList ID="drpTechnology" runat="server" CssClass="ControlDrp"></asp:DropDownList>
                    <asp:RequiredFieldValidator ValidationGroup="ATT" ID="RequiredFieldValidator3" runat="server" SetFocusOnError="true" ControlToValidate="drpTechnology" InitialValue="0" ErrorMessage=""></asp:RequiredFieldValidator>
                    <%--<asp:RadioButtonList ID="rdoTechnology" CssClass="Control" runat="server" RepeatDirection="Horizontal" RepeatColumns="3"></asp:RadioButtonList>--%>
                </td>
            </tr>

            <tr>
                <td>

                    <asp:DropDownList ID="drpProgram" runat="server" CssClass="ControlDrp"></asp:DropDownList>

                    <asp:RequiredFieldValidator ValidationGroup="ATT" ID="RequiredFieldValidator4" runat="server" SetFocusOnError="true" ControlToValidate="drpProgram" InitialValue="0" ErrorMessage=""></asp:RequiredFieldValidator>
                    <%--<asp:RadioButtonList ID="rdoProgram" CssClass="Control" runat="server" RepeatDirection="Horizontal" RepeatColumns="3"></asp:RadioButtonList>--%>
                </td>
            </tr>
            <tr>
                <td></td>
            </tr>
            <tr>
                <td>
                    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                        <Triggers>
                            <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" />
                        </Triggers>
                        <ContentTemplate>
                            <asp:TextBox ID="txtInTime" runat="server" CssClass="Control" ReadOnly="true"></asp:TextBox>
                            <asp:Timer ID="Timer1" runat="server" Interval="59000" OnTick="Timer1_Tick"></asp:Timer>
                        </ContentTemplate>
                    </asp:UpdatePanel>

                </td>
            </tr>
            <tr>
                <td align="right">
                    <asp:Button ID="Button1" runat="server" Text="Submit" CssClass="btn" Font-Bold="true" OnClick="Button1_Click" ValidationGroup="ATT" />
                    <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                        <Triggers>
                            <asp:AsyncPostBackTrigger ControlID="Button1" EventName="Click" />
                        </Triggers>
                        <ContentTemplate>

                            <asp:Label ID="Label5" runat="server" Text=""></asp:Label>
                            <cc1:ModalPopupExtender ID="ModalPopupDuration" runat="server" TargetControlID="Label5" PopupControlID="pnlDuration" BackgroundCssClass="popupBack"></cc1:ModalPopupExtender>
                            <asp:Panel ID="pnlDuration" runat="server" CssClass="MyPnl">
                                <asp:Label ID="lblDuration" runat="server" Text="RACORD SUBMITTED"></asp:Label>
                                <asp:Button ID="Button3" runat="server" Text="OK" CssClass="btn btn-danger" OnClick="Button3_Click" />
                            </asp:Panel>
                        </ContentTemplate>
                    </asp:UpdatePanel>

                </td>
            </tr>
        </table>
    </div>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h3>Filled Attendance For Today - <%Response.Write(DateTime.Now.ToShortDateString()); %></h3>
    <div>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <table>
                    <tr>
                        <td valign="top">
                            <asp:TextBox ID="txtSearch" runat="server" PlaceHolder="Search Name for Logout" AutoCompleteType="Disabled"></asp:TextBox></td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ControlToValidate="txtSearch" SetFocusOnError="true" runat="server" ErrorMessage="" ValidationGroup="Search"></asp:RequiredFieldValidator>
                        <td valign="top">
                            <asp:Button ID="btnSearch" runat="server" CssClass="btn" Text="Search" OnClick="btnSearch_Click" ValidationGroup="Search" />
                        </td>
                    </tr>
                </table>
                <br />
                <br />


                <asp:DataList ID="DataList1" CssClass="media-list" runat="server" Width="100%" OnItemCommand="DataList1_ItemCommand">
                    <ItemTemplate>

                        <li class="media well well-small">

                            <div class="media-body" style="width: 100%;">
                                <table style="width: 100%;">
                                    <tr>
                                        <td rowspan="5" style="width: 100px;">
                                            <a class="pull-left" href="#">
                                                <img class="media-object" src="TechImages/User-blue.png" alt="bootstrap business template" />
                                            </a>
                                        </td>
                                        <td></td>
                                        <td></td>
                                        <td rowspan="5" valign="top">
                                            <h4>
                                                <asp:LinkButton ID="LinkButton1" runat="server" CssClass="pull-right" OnClientClick="return confirm('Are you sure to Logout?');" CommandName="Logout" CommandArgument='<%#Eval("ATID") %>'>Logout</asp:LinkButton></h4>

                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 20%;">
                                            <h4>Student Name</h4>
                                        </td>
                                        <td>
                                            <h4>
                                                <asp:Label ID="Label1" runat="server" CssClass="lblName" Text='<%# Eval("fname")+" "+Eval("lname") %>'></asp:Label>&nbsp;
                                                (
                                            <asp:Label ID="Label6" runat="server" CssClass="lblTech" Text='<%#Bind("TechName") %>'></asp:Label>
                                                )

                                            </h4>
                                        </td>

                                    </tr>
                                    <tr>
                                        <td style="width: 20%;"><b>Technology</b></td>
                                        <td>
                                            <asp:Label ID="Label3" runat="server" Text='<%#Bind("TechName") %>'></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 20%;"><b>Enrollment Program</b></td>
                                        <td>
                                            <asp:Label ID="Label2" runat="server" Text='<%#Bind("PName") %>'></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 20%;"><b>In Time</b></td>
                                        <td>
                                            <asp:Label ID="Label4" runat="server" Text='<%#Bind("InTime") %>'></asp:Label>
                                        </td>
                                    </tr>
                                </table>
                                <%--          Cras sit amet nibh libero metus
					  Cras sit amet nibh ...<small> November 15 2012</small><a class="pull-right" href="#"><strong>Kim</strong></a>--%>
                            </div>
                        </li>
                    </ItemTemplate>

                </asp:DataList>
                <%--<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MyAttendanceDBConnectionString %>" SelectCommand="GetAllAttendance" SelectCommandType="StoredProcedure" FilterExpression="fname like '%{0}%'">
                    <FilterParameters>
                        <asp:ControlParameter Name="fname" ControlID="txtSearch" PropertyName="Text" />
                    </FilterParameters>
                </asp:SqlDataSource>--%>
            </ContentTemplate>
        </asp:UpdatePanel>
        <div class="alert alert-warning">
            <strong>Need Attention!</strong> Your Attendance Reports are shared with Placement Management.
        </div>
      <%--  <div class="TimeNotification">
            <marquee behavior="scroll" direction="up" onmouseover="this.setAttribute('scrollamount', 0, 0);this.stop();" onmouseout="this.setAttribute('scrollamount', 3, 0);this.start();" scrollamount="3">
                    <h5 class="font-red-flamingo"><i class="fa fa-birthday-cake"></i> Birthday</h5> 
                        <h5><span class="font-blue"> [SH055] Chirag Ayar (20-Jul)                                </span></h5>
                        <h5><span class="font-blue"> [MN017] Jalpa Shah (25-Jul)                                </span></h5>
                        <h5><span class="font-blue"> [SH045] Pranav Parikh (26-Jul)                                </span></h5>
                         <h5><span class="font-blue"> 
                                [CG171] Khushbu Chauhan (26-Jul)                                </span></h5>
                                                            <h5><span class="font-blue"> 
                                [SH221] Asha Nair (26-Jul)                                </span></h5>
                                                            <h5><span class="font-blue"> 
                                [SH033] Sunny Jani (27-Jul)                                </span></h5>
                                                            <h5><span class="font-blue"> 
                                [SH188] Jay Lad (28-Jul)                                </span></h5>
                                                                                            </marquee>
        </div>--%>
    </div>
</asp:Content>
<%-- <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ATID,PID,TechID" DataSourceID="SqlDataSource1">
                    <Columns>
                        <asp:BoundField DataField="ATID" HeaderText="ATID" InsertVisible="False" ReadOnly="True" SortExpression="ATID" Visible="false" />
                        <asp:BoundField DataField="fname" HeaderText="First Name" SortExpression="fname" />
                        <asp:BoundField DataField="lname" HeaderText="Last Name" SortExpression="lname" />
                        <asp:BoundField DataField="TechName" HeaderText="Technology" SortExpression="TechName" />
                        <asp:BoundField DataField="InTime" HeaderText="InTime" SortExpression="InTime" />
                        <asp:BoundField DataField="OutTime" HeaderText="OutTime" SortExpression="OutTime" />
                        <asp:BoundField DataField="PName" HeaderText="Enrollment Program" SortExpression="PName" />
                        <asp:BoundField DataField="FkTechID" HeaderText="FkTechID" SortExpression="FkTechID" Visible="false" />
                        <asp:BoundField DataField="FkPID" HeaderText="FkPID" SortExpression="FkPID" Visible="false" />


                        <asp:BoundField DataField="AtDate" HeaderText="AtDate" SortExpression="AtDate" Visible="false" />
                        <asp:BoundField DataField="PID" HeaderText="PID" InsertVisible="False" ReadOnly="True" SortExpression="PID" Visible="false" />

                        <asp:BoundField DataField="Duration" HeaderText="Duration" SortExpression="Duration" Visible="false" />
                        <asp:BoundField DataField="TechID" HeaderText="TechID" InsertVisible="False" ReadOnly="True" SortExpression="TechID" Visible="false" />

                    </Columns>
                </asp:GridView>--%>