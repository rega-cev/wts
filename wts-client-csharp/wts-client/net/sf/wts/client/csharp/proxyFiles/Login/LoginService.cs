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
namespace net.sf.wts.client.proxyFiles.Login {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="LoginSoapBinding", Namespace="urn:Login")]
    public partial class LoginService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback execOperationCompleted;
        
        /// <remarks/>
        public LoginService() {
            this.Url = "http://localhost:8080/axis/services/Login";
        }
        
        /// <remarks/>
        public event execCompletedEventHandler execCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace="urn:Login", ResponseNamespace="urn:Login")]
        [return: System.Xml.Serialization.SoapElementAttribute("execReturn")]
        public string exec(string in0, string in1, string in2, string in3) {
            object[] results = this.Invoke("exec", new object[] {
                        in0,
                        in1,
                        in2,
                        in3});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult Beginexec(string in0, string in1, string in2, string in3, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("exec", new object[] {
                        in0,
                        in1,
                        in2,
                        in3}, callback, asyncState);
        }
        
        /// <remarks/>
        public string Endexec(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void execAsync(string in0, string in1, string in2, string in3) {
            this.execAsync(in0, in1, in2, in3, null);
        }
        
        /// <remarks/>
        public void execAsync(string in0, string in1, string in2, string in3, object userState) {
            if ((this.execOperationCompleted == null)) {
                this.execOperationCompleted = new System.Threading.SendOrPostCallback(this.OnexecOperationCompleted);
            }
            this.InvokeAsync("exec", new object[] {
                        in0,
                        in1,
                        in2,
                        in3}, this.execOperationCompleted, userState);
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
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}
