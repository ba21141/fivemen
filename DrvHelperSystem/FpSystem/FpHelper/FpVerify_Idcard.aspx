﻿<%@ Page Title="" Language="C#" MasterPageFile="~/FpSystem/FpHelper/FpHelper.master" AutoEventWireup="true" CodeFile="FpVerify_Idcard.aspx.cs" Inherits="FpSystem_FpHelper_FpVerify_Idcard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script type="text/javascript">
  
    document.
</script>
  <asp:Label Text="身份证明号码" runat="server" ID="lbInfo"></asp:Label>

        
     <object id="ETTSelfIDCardActiveX1" 	classid="CLSID:447C4906-6678-461B-9E20-100BDE913828">
		<param name="_Version" value="65536" />
		<param name="_ExtentX" value="2646" />
		<param name="_ExtentY" value="1323" />
		<param name="_StockProps" value="0" />
	</object>
  
	
        <input name="FunName" type="hidden"  />
        <input id="txtIdcard" runat="server" style=" width:200px"   />
        
<asp:Button ID="btnVerify" runat="server" onclick="btnVerify_Click"  Text="验证"/>

<script type="text/javascript">
function txtIdcard_onkeydown(){
    if (event.keyCode == 13) {
       var val = document.getElementById("ctl00_ContentPlaceHolder1_txtIdcard").value;
       
      window.document.location.search="?idcard="+val;
       // event.cancelBubble = true;
       // event.returnValue = false;
       // document.all.FunName.value = "doVerify";
      // document.form[0].submit();
      
    }

}

document.body.onkeydown = function() {
    if (event.keyCode == 13) {
        //var val = document.getElementById("ctl00_ContentPlaceHolder1_txtIdcard").value;
        document.all.FunName.value = "doVerify";
        //window.location.search = "?idcard=" + val;
        document.getElementById("ctl00_ContentPlaceHolder1_btnVerify").click();
    }
}

    var isReading = false;
    var reader = document.getElementById("ETTSelfIDCardActiveX1");
    var idcard; 
    function readCard() {
        try {
            //if (isReading) {
             //   return;
            //}
            isReading = true;
            reader.ReadIDCard();
            var tempIdcard = reader.IDCard;
            if (tempIdcard != "" && idcard != tempIdcard) {
                idcard = tempIdcard;
                ///document.getElementById("ctl00_ContentPlaceHolder1_txtIdCard").value=idcard;
                window.location.search = "?idcard=" + idcard;
            }
        } catch (ex) {alert(ex);}
    }


    document.body.onload = function() {
        
     //  window.setInterval("readCard()", 2000);
        //document.all.txtIdCard.value = reader.IDCard;
        //var int = self.setInterval("readCard()", 1000);
    }
	
	
</script>
	 
</asp:Content>

