<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PCs.ascx.cs" Inherits="MyAttendance.PCs" %>

<style>
    #draggable, #draggable2 {
        width: 100px;
        height: 100px;
        padding: 0.5em;
        float: left;
        margin: 0 10px 10px 0;
    }
</style>
<script src="Script/jquery-1.12.4.js"></script>
<script src="Script/jquery-ui.js"></script>
<%--<script src="https://code.jquery.com/jquery-1.12.4.js"></script>
<script src="https://code.jquery.com/ui/1.12.0/jquery-ui.js"></script>--%>
<script>
    $(function () {
        $("#draggable").draggable({ revert: true });
        $("#draggable2").draggable({ revert: true, helper: "clone" });
    });
</script>


<div>
    <div id="draggable" class="ui-widget-content">
        <p>Revert the original</p>
    </div>

    <div id="draggable2" class="ui-widget-content">
        <p>Revert the helper</p>
    </div>

</div>
