﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace PDiscountCard.vfiliasesb0 {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1099.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WriteVisitDiscountObj", Namespace="urn:coffeemania:discount-services")]
    public partial class WriteVisitDiscountService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback DefiniteSafeCardOperationCompleted;
        
        private System.Threading.SendOrPostCallback FixedVizitOperationCompleted;
        
        private System.Threading.SendOrPostCallback WriteVizitOperationCompleted;
        
        private System.Threading.SendOrPostCallback WriteVizitNewOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public WriteVisitDiscountService() {
            this.Url = global::PDiscountCard.Properties.Settings.Default.PDiscountCard_vfiliasesb0_WriteVisitDiscountService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event DefiniteSafeCardCompletedEventHandler DefiniteSafeCardCompleted;
        
        /// <remarks/>
        public event FixedVizitCompletedEventHandler FixedVizitCompleted;
        
        /// <remarks/>
        public event WriteVizitCompletedEventHandler WriteVizitCompleted;
        
        /// <remarks/>
        public event WriteVizitNewCompletedEventHandler WriteVizitNewCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="urn:coffeemania:discount-services:WriteVisitDiscount", ResponseNamespace="urn:coffeemania:discount-services:WriteVisitDiscount", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("result", IsNullable=true)]
        public string DefiniteSafeCard([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string KardPrefix, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string KardKode, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] out System.Nullable<bool> TrustedCustomer) {
            object[] results = this.Invoke("DefiniteSafeCard", new object[] {
                        KardPrefix,
                        KardKode});
            TrustedCustomer = ((System.Nullable<bool>)(results[1]));
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void DefiniteSafeCardAsync(string KardPrefix, string KardKode) {
            this.DefiniteSafeCardAsync(KardPrefix, KardKode, null);
        }
        
        /// <remarks/>
        public void DefiniteSafeCardAsync(string KardPrefix, string KardKode, object userState) {
            if ((this.DefiniteSafeCardOperationCompleted == null)) {
                this.DefiniteSafeCardOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDefiniteSafeCardOperationCompleted);
            }
            this.InvokeAsync("DefiniteSafeCard", new object[] {
                        KardPrefix,
                        KardKode}, this.DefiniteSafeCardOperationCompleted, userState);
        }
        
        private void OnDefiniteSafeCardOperationCompleted(object arg) {
            if ((this.DefiniteSafeCardCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DefiniteSafeCardCompleted(this, new DefiniteSafeCardCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="urn:coffeemania:discount-services:WriteVisitDiscount", ResponseNamespace="urn:coffeemania:discount-services:WriteVisitDiscount", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("result", IsNullable=true)]
        public string FixedVizit([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string pPrefix, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string CardN, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] System.Nullable<int> CodSh, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string CheckN, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] System.Nullable<int> TermN, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] System.Nullable<System.DateTime> DaTime, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] System.Nullable<int> iWrite, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] out System.Nullable<int> CountV, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] out System.Nullable<int> CountD, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] out System.Nullable<int> iGold) {
            object[] results = this.Invoke("FixedVizit", new object[] {
                        pPrefix,
                        CardN,
                        CodSh,
                        CheckN,
                        TermN,
                        DaTime,
                        iWrite});
            CountV = ((System.Nullable<int>)(results[1]));
            CountD = ((System.Nullable<int>)(results[2]));
            iGold = ((System.Nullable<int>)(results[3]));
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void FixedVizitAsync(string pPrefix, string CardN, System.Nullable<int> CodSh, string CheckN, System.Nullable<int> TermN, System.Nullable<System.DateTime> DaTime, System.Nullable<int> iWrite) {
            this.FixedVizitAsync(pPrefix, CardN, CodSh, CheckN, TermN, DaTime, iWrite, null);
        }
        
        /// <remarks/>
        public void FixedVizitAsync(string pPrefix, string CardN, System.Nullable<int> CodSh, string CheckN, System.Nullable<int> TermN, System.Nullable<System.DateTime> DaTime, System.Nullable<int> iWrite, object userState) {
            if ((this.FixedVizitOperationCompleted == null)) {
                this.FixedVizitOperationCompleted = new System.Threading.SendOrPostCallback(this.OnFixedVizitOperationCompleted);
            }
            this.InvokeAsync("FixedVizit", new object[] {
                        pPrefix,
                        CardN,
                        CodSh,
                        CheckN,
                        TermN,
                        DaTime,
                        iWrite}, this.FixedVizitOperationCompleted, userState);
        }
        
        private void OnFixedVizitOperationCompleted(object arg) {
            if ((this.FixedVizitCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.FixedVizitCompleted(this, new FixedVizitCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="urn:coffeemania:discount-services:WriteVisitDiscount", ResponseNamespace="urn:coffeemania:discount-services:WriteVisitDiscount", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("result", IsNullable=true)]
        public string WriteVizit([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string pPrefix, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string CardN, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] System.Nullable<int> CodSh, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string CheckN, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] System.Nullable<int> TermN, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] System.Nullable<System.DateTime> DaTime, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] out System.Nullable<int> CountV, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] out System.Nullable<int> CountD) {
            object[] results = this.Invoke("WriteVizit", new object[] {
                        pPrefix,
                        CardN,
                        CodSh,
                        CheckN,
                        TermN,
                        DaTime});
            CountV = ((System.Nullable<int>)(results[1]));
            CountD = ((System.Nullable<int>)(results[2]));
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void WriteVizitAsync(string pPrefix, string CardN, System.Nullable<int> CodSh, string CheckN, System.Nullable<int> TermN, System.Nullable<System.DateTime> DaTime) {
            this.WriteVizitAsync(pPrefix, CardN, CodSh, CheckN, TermN, DaTime, null);
        }
        
        /// <remarks/>
        public void WriteVizitAsync(string pPrefix, string CardN, System.Nullable<int> CodSh, string CheckN, System.Nullable<int> TermN, System.Nullable<System.DateTime> DaTime, object userState) {
            if ((this.WriteVizitOperationCompleted == null)) {
                this.WriteVizitOperationCompleted = new System.Threading.SendOrPostCallback(this.OnWriteVizitOperationCompleted);
            }
            this.InvokeAsync("WriteVizit", new object[] {
                        pPrefix,
                        CardN,
                        CodSh,
                        CheckN,
                        TermN,
                        DaTime}, this.WriteVizitOperationCompleted, userState);
        }
        
        private void OnWriteVizitOperationCompleted(object arg) {
            if ((this.WriteVizitCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.WriteVizitCompleted(this, new WriteVizitCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="urn:coffeemania:discount-services:WriteVisitDiscount", ResponseNamespace="urn:coffeemania:discount-services:WriteVisitDiscount", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("result", IsNullable=true)]
        public string WriteVizitNew([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string pPrefix, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string CardN, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] System.Nullable<int> CodSh, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string CheckN, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] System.Nullable<int> TermN, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] System.Nullable<System.DateTime> DaTime, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] System.Nullable<decimal> Summ, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] System.Nullable<int> kol, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] out System.Nullable<int> CountV, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] out System.Nullable<int> CountD) {
            object[] results = this.Invoke("WriteVizitNew", new object[] {
                        pPrefix,
                        CardN,
                        CodSh,
                        CheckN,
                        TermN,
                        DaTime,
                        Summ,
                        kol});
            CountV = ((System.Nullable<int>)(results[1]));
            CountD = ((System.Nullable<int>)(results[2]));
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void WriteVizitNewAsync(string pPrefix, string CardN, System.Nullable<int> CodSh, string CheckN, System.Nullable<int> TermN, System.Nullable<System.DateTime> DaTime, System.Nullable<decimal> Summ, System.Nullable<int> kol) {
            this.WriteVizitNewAsync(pPrefix, CardN, CodSh, CheckN, TermN, DaTime, Summ, kol, null);
        }
        
        /// <remarks/>
        public void WriteVizitNewAsync(string pPrefix, string CardN, System.Nullable<int> CodSh, string CheckN, System.Nullable<int> TermN, System.Nullable<System.DateTime> DaTime, System.Nullable<decimal> Summ, System.Nullable<int> kol, object userState) {
            if ((this.WriteVizitNewOperationCompleted == null)) {
                this.WriteVizitNewOperationCompleted = new System.Threading.SendOrPostCallback(this.OnWriteVizitNewOperationCompleted);
            }
            this.InvokeAsync("WriteVizitNew", new object[] {
                        pPrefix,
                        CardN,
                        CodSh,
                        CheckN,
                        TermN,
                        DaTime,
                        Summ,
                        kol}, this.WriteVizitNewOperationCompleted, userState);
        }
        
        private void OnWriteVizitNewOperationCompleted(object arg) {
            if ((this.WriteVizitNewCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.WriteVizitNewCompleted(this, new WriteVizitNewCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1099.0")]
    public delegate void DefiniteSafeCardCompletedEventHandler(object sender, DefiniteSafeCardCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1099.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DefiniteSafeCardCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DefiniteSafeCardCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
        
        /// <remarks/>
        public System.Nullable<bool> TrustedCustomer {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Nullable<bool>)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1099.0")]
    public delegate void FixedVizitCompletedEventHandler(object sender, FixedVizitCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1099.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FixedVizitCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal FixedVizitCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
        
        /// <remarks/>
        public System.Nullable<int> CountV {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Nullable<int>)(this.results[1]));
            }
        }
        
        /// <remarks/>
        public System.Nullable<int> CountD {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Nullable<int>)(this.results[2]));
            }
        }
        
        /// <remarks/>
        public System.Nullable<int> iGold {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Nullable<int>)(this.results[3]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1099.0")]
    public delegate void WriteVizitCompletedEventHandler(object sender, WriteVizitCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1099.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WriteVizitCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal WriteVizitCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
        
        /// <remarks/>
        public System.Nullable<int> CountV {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Nullable<int>)(this.results[1]));
            }
        }
        
        /// <remarks/>
        public System.Nullable<int> CountD {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Nullable<int>)(this.results[2]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1099.0")]
    public delegate void WriteVizitNewCompletedEventHandler(object sender, WriteVizitNewCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1099.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WriteVizitNewCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal WriteVizitNewCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
        
        /// <remarks/>
        public System.Nullable<int> CountV {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Nullable<int>)(this.results[1]));
            }
        }
        
        /// <remarks/>
        public System.Nullable<int> CountD {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Nullable<int>)(this.results[2]));
            }
        }
    }
}

#pragma warning restore 1591