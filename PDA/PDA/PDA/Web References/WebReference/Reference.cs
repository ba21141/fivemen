﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:2.0.50727.3615
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

// 
// 此源代码是由 Microsoft.CompactFramework.Design.Data 2.0.50727.3615 版自动生成。
// 
namespace PDA.WebReference {
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;
    using System.Data;
    
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="Service1Soap", Namespace="http://tempuri.org/")]
    public partial class Service1 : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        /// <remarks/>
        public Service1() {
            this.Url = "http://192.168.1.123:100/Service1.asmx";
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetDataSet", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetDataSet(string sql, string useName, string passWord) {
            object[] results = this.Invoke("GetDataSet", new object[] {
                        sql,
                        useName,
                        passWord});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetDataSet(string sql, string useName, string passWord, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetDataSet", new object[] {
                        sql,
                        useName,
                        passWord}, callback, asyncState);
        }
        
        /// <remarks/>
        public System.Data.DataSet EndGetDataSet(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ExecSql", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int ExecSql(string sql, string useName, string passWord) {
            object[] results = this.Invoke("ExecSql", new object[] {
                        sql,
                        useName,
                        passWord});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginExecSql(string sql, string useName, string passWord, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("ExecSql", new object[] {
                        sql,
                        useName,
                        passWord}, callback, asyncState);
        }
        
        /// <remarks/>
        public int EndExecSql(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ExecSqls", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int ExecSqls(string[] sqls, string useName, string passWord) {
            object[] results = this.Invoke("ExecSqls", new object[] {
                        sqls,
                        useName,
                        passWord});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginExecSqls(string[] sqls, string useName, string passWord, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("ExecSqls", new object[] {
                        sqls,
                        useName,
                        passWord}, callback, asyncState);
        }
        
        /// <remarks/>
        public int EndExecSqls(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getAsnDetail", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet getAsnDetail(string asn) {
            object[] results = this.Invoke("getAsnDetail", new object[] {
                        asn});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BegingetAsnDetail(string asn, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("getAsnDetail", new object[] {
                        asn}, callback, asyncState);
        }
        
        /// <remarks/>
        public System.Data.DataSet EndgetAsnDetail(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SaveAsn", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool SaveAsn(System.Data.DataTable dt, string userid) {
            object[] results = this.Invoke("SaveAsn", new object[] {
                        dt,
                        userid});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginSaveAsn(System.Data.DataTable dt, string userid, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("SaveAsn", new object[] {
                        dt,
                        userid}, callback, asyncState);
        }
        
        /// <remarks/>
        public bool EndSaveAsn(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SavePutAway", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool SavePutAway(System.Data.DataTable dtDisk, System.Data.DataTable dtLoc, string al, string userid, System.Data.DataTable dtSku) {
            object[] results = this.Invoke("SavePutAway", new object[] {
                        dtDisk,
                        dtLoc,
                        al,
                        userid,
                        dtSku});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginSavePutAway(System.Data.DataTable dtDisk, System.Data.DataTable dtLoc, string al, string userid, System.Data.DataTable dtSku, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("SavePutAway", new object[] {
                        dtDisk,
                        dtLoc,
                        al,
                        userid,
                        dtSku}, callback, asyncState);
        }
        
        /// <remarks/>
        public bool EndSavePutAway(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetPutAway", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetPutAway(string putAwayBillNo) {
            object[] results = this.Invoke("GetPutAway", new object[] {
                        putAwayBillNo});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetPutAway(string putAwayBillNo, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetPutAway", new object[] {
                        putAwayBillNo}, callback, asyncState);
        }
        
        /// <remarks/>
        public System.Data.DataSet EndGetPutAway(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetUserRight", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetUserRight(string user, string pwd) {
            object[] results = this.Invoke("GetUserRight", new object[] {
                        user,
                        pwd});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetUserRight(string user, string pwd, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetUserRight", new object[] {
                        user,
                        pwd}, callback, asyncState);
        }
        
        /// <remarks/>
        public System.Data.DataSet EndGetUserRight(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetPickData", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetPickData(string PickKey, string loc) {
            object[] results = this.Invoke("GetPickData", new object[] {
                        PickKey,
                        loc});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetPickData(string PickKey, string loc, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetPickData", new object[] {
                        PickKey,
                        loc}, callback, asyncState);
        }
        
        /// <remarks/>
        public System.Data.DataSet EndGetPickData(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SavePickData", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool SavePickData(System.Data.DataTable dtPick, System.Data.DataTable dtDisk, string userid) {
            object[] results = this.Invoke("SavePickData", new object[] {
                        dtPick,
                        dtDisk,
                        userid});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginSavePickData(System.Data.DataTable dtPick, System.Data.DataTable dtDisk, string userid, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("SavePickData", new object[] {
                        dtPick,
                        dtDisk,
                        userid}, callback, asyncState);
        }
        
        /// <remarks/>
        public bool EndSavePickData(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetPartDisk", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetPartDisk() {
            object[] results = this.Invoke("GetPartDisk", new object[0]);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetPartDisk(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetPartDisk", new object[0], callback, asyncState);
        }
        
        /// <remarks/>
        public System.Data.DataSet EndGetPartDisk(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SavePartDisk", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool SavePartDisk(System.Data.DataTable dt, string userid) {
            object[] results = this.Invoke("SavePartDisk", new object[] {
                        dt,
                        userid});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginSavePartDisk(System.Data.DataTable dt, string userid, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("SavePartDisk", new object[] {
                        dt,
                        userid}, callback, asyncState);
        }
        
        /// <remarks/>
        public bool EndSavePartDisk(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetFeedBackData", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetFeedBackData(string id) {
            object[] results = this.Invoke("GetFeedBackData", new object[] {
                        id});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetFeedBackData(string id, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetFeedBackData", new object[] {
                        id}, callback, asyncState);
        }
        
        /// <remarks/>
        public System.Data.DataSet EndGetFeedBackData(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SaveFeedBackData", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool SaveFeedBackData(System.Data.DataTable dt) {
            object[] results = this.Invoke("SaveFeedBackData", new object[] {
                        dt});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginSaveFeedBackData(System.Data.DataTable dt, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("SaveFeedBackData", new object[] {
                        dt}, callback, asyncState);
        }
        
        /// <remarks/>
        public bool EndSaveFeedBackData(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetAndUpdateDiskForOpen", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetAndUpdateDiskForOpen(string id, string userid) {
            object[] results = this.Invoke("GetAndUpdateDiskForOpen", new object[] {
                        id,
                        userid});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetAndUpdateDiskForOpen(string id, string userid, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetAndUpdateDiskForOpen", new object[] {
                        id,
                        userid}, callback, asyncState);
        }
        
        /// <remarks/>
        public string EndGetAndUpdateDiskForOpen(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetAndSaveDiskForBegin", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetAndSaveDiskForBegin(string id, string userid, string scantype) {
            object[] results = this.Invoke("GetAndSaveDiskForBegin", new object[] {
                        id,
                        userid,
                        scantype});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetAndSaveDiskForBegin(string id, string userid, string scantype, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetAndSaveDiskForBegin", new object[] {
                        id,
                        userid,
                        scantype}, callback, asyncState);
        }
        
        /// <remarks/>
        public string EndGetAndSaveDiskForBegin(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetAndSaveDiskForEnd", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetAndSaveDiskForEnd(string id, string userid, string scantype) {
            object[] results = this.Invoke("GetAndSaveDiskForEnd", new object[] {
                        id,
                        userid,
                        scantype});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetAndSaveDiskForEnd(string id, string userid, string scantype, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetAndSaveDiskForEnd", new object[] {
                        id,
                        userid,
                        scantype}, callback, asyncState);
        }
        
        /// <remarks/>
        public string EndGetAndSaveDiskForEnd(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetCompany", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetCompany() {
            object[] results = this.Invoke("GetCompany", new object[0]);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetCompany(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetCompany", new object[0], callback, asyncState);
        }
        
        /// <remarks/>
        public System.Data.DataSet EndGetCompany(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetDiskList", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetDiskList(string diskid, string sku, System.DateTime dt, string asn) {
            object[] results = this.Invoke("GetDiskList", new object[] {
                        diskid,
                        sku,
                        dt,
                        asn});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetDiskList(string diskid, string sku, System.DateTime dt, string asn, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetDiskList", new object[] {
                        diskid,
                        sku,
                        dt,
                        asn}, callback, asyncState);
        }
        
        /// <remarks/>
        public System.Data.DataSet EndGetDiskList(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IsInDataBase", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string IsInDataBase(string id) {
            object[] results = this.Invoke("IsInDataBase", new object[] {
                        id});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginIsInDataBase(string id, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("IsInDataBase", new object[] {
                        id}, callback, asyncState);
        }
        
        /// <remarks/>
        public string EndIsInDataBase(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetPickDisk", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataTable GetPickDisk(string pickid, string loc) {
            object[] results = this.Invoke("GetPickDisk", new object[] {
                        pickid,
                        loc});
            return ((System.Data.DataTable)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetPickDisk(string pickid, string loc, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetPickDisk", new object[] {
                        pickid,
                        loc}, callback, asyncState);
        }
        
        /// <remarks/>
        public System.Data.DataTable EndGetPickDisk(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Data.DataTable)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetMoveLocData", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetMoveLocData(string loc) {
            object[] results = this.Invoke("GetMoveLocData", new object[] {
                        loc});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetMoveLocData(string loc, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetMoveLocData", new object[] {
                        loc}, callback, asyncState);
        }
        
        /// <remarks/>
        public System.Data.DataSet EndGetMoveLocData(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SaveMoveLoc", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool SaveMoveLoc(System.Data.DataTable dt, string userid) {
            object[] results = this.Invoke("SaveMoveLoc", new object[] {
                        dt,
                        userid});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginSaveMoveLoc(System.Data.DataTable dt, string userid, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("SaveMoveLoc", new object[] {
                        dt,
                        userid}, callback, asyncState);
        }
        
        /// <remarks/>
        public bool EndSaveMoveLoc(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetMoveLotData", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetMoveLotData(string billid, string lot) {
            object[] results = this.Invoke("GetMoveLotData", new object[] {
                        billid,
                        lot});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetMoveLotData(string billid, string lot, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetMoveLotData", new object[] {
                        billid,
                        lot}, callback, asyncState);
        }
        
        /// <remarks/>
        public System.Data.DataSet EndGetMoveLotData(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SaveMoveLotData", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool SaveMoveLotData(System.Data.DataTable dt, string userid) {
            object[] results = this.Invoke("SaveMoveLotData", new object[] {
                        dt,
                        userid});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginSaveMoveLotData(System.Data.DataTable dt, string userid, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("SaveMoveLotData", new object[] {
                        dt,
                        userid}, callback, asyncState);
        }
        
        /// <remarks/>
        public bool EndSaveMoveLotData(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((bool)(results[0]));
        }
    }
}
