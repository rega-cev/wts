﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.42
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by wsdl, Version=2.0.50727.42.
// 
namespace net.sf.wts.client.proxyFiles.Stop {
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="StopSoapBinding", Namespace="urn:Stop")]
    public partial class StopService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback execOperationCompleted;
        
        /// <remarks/>
        public StopService() {
            this.Url = "http://localhost:8080/axis/services/Stop";
        }
        
        /// <remarks/>
        public event execCompletedEventHandler execCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace="urn:Stop", ResponseNamespace="urn:Stop")]
        public void exec(string in0, string in1) {
            this.Invoke("exec", new object[] {
                        in0,
                        in1});
        }
        
        /// <remarks/>
        public System.IAsyncResult Beginexec(string in0, string in1, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("exec", new object[] {
                        in0,
                        in1}, callback, asyncState);
        }
        
        /// <remarks/>
        public void Endexec(System.IAsyncResult asyncResult) {
            this.EndInvoke(asyncResult);
        }
        
        /// <remarks/>
        public void execAsync(string in0, string in1) {
            this.execAsync(in0, in1, null);
        }
        
        /// <remarks/>
        public void execAsync(string in0, string in1, object userState) {
            if ((this.execOperationCompleted == null)) {
                this.execOperationCompleted = new System.Threading.SendOrPostCallback(this.OnexecOperationCompleted);
            }
            this.InvokeAsync("exec", new object[] {
                        in0,
                        in1}, this.execOperationCompleted, userState);
        }
        
        private void OnexecOperationCompleted(object arg) {
            if ((this.execCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.execCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    public delegate void execCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
}