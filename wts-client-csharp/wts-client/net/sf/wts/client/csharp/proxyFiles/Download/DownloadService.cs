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
namespace net.sf.wts.client.proxyFiles.Download {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="DownloadSoapBinding", Namespace="urn:Download")]
    public partial class DownloadService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback execOperationCompleted;
        
        /// <remarks/>
        public DownloadService() {
            this.Url = "http://localhost:8080/axis/services/Download";
        }
        
        /// <remarks/>
        public event execCompletedEventHandler execCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace="urn:Download", ResponseNamespace="urn:Download")]
        [return: System.Xml.Serialization.SoapElementAttribute("execReturn", DataType="base64Binary")]
        public byte[] exec(string in0, string in1, string in2) {
            object[] results = this.Invoke("exec", new object[] {
                        in0,
                        in1,
                        in2});
            return ((byte[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult Beginexec(string in0, string in1, string in2, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("exec", new object[] {
                        in0,
                        in1,
                        in2}, callback, asyncState);
        }
        
        /// <remarks/>
        public byte[] Endexec(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((byte[])(results[0]));
        }
        
        /// <remarks/>
        public void execAsync(string in0, string in1, string in2) {
            this.execAsync(in0, in1, in2, null);
        }
        
        /// <remarks/>
        public void execAsync(string in0, string in1, string in2, object userState) {
            if ((this.execOperationCompleted == null)) {
                this.execOperationCompleted = new System.Threading.SendOrPostCallback(this.OnexecOperationCompleted);
            }
            this.InvokeAsync("exec", new object[] {
                        in0,
                        in1,
                        in2}, this.execOperationCompleted, userState);
        }
        
        private void OnexecOperationCompleted(object arg) {
            if ((this.execCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.execCompleted(this, new execCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    public delegate void execCompletedEventHandler(object sender, execCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class execCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal execCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public byte[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((byte[])(this.results[0]));
            }
        }
    }
}
