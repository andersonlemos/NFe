﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NFe.Repositories.StatusServico {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.portalfiscal.inf.br/nfe/wsdl/NfeStatusServico2", ConfigurationName="StatusServico.NfeStatusServico2Soap")]
    public interface NfeStatusServico2Soap {
        
        // CODEGEN: Generating message contract since the operation nfeStatusServicoNF2 is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.portalfiscal.inf.br/nfe/wsdl/NfeStatusServico2/nfeStatusServicoNF2", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        NFe.Repositories.StatusServico.nfeStatusServicoNF2Response nfeStatusServicoNF2(NFe.Repositories.StatusServico.nfeStatusServicoNF2Request request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.portalfiscal.inf.br/nfe/wsdl/NfeStatusServico2/nfeStatusServicoNF2", ReplyAction="*")]
        System.Threading.Tasks.Task<NFe.Repositories.StatusServico.nfeStatusServicoNF2Response> nfeStatusServicoNF2Async(NFe.Repositories.StatusServico.nfeStatusServicoNF2Request request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34281")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.portalfiscal.inf.br/nfe/wsdl/NfeStatusServico2")]
    public partial class nfeCabecMsg : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string cUFField;
        
        private string versaoDadosField;
        
        private System.Xml.XmlAttribute[] anyAttrField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string cUF {
            get {
                return this.cUFField;
            }
            set {
                this.cUFField = value;
                this.RaisePropertyChanged("cUF");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string versaoDados {
            get {
                return this.versaoDadosField;
            }
            set {
                this.versaoDadosField = value;
                this.RaisePropertyChanged("versaoDados");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
                this.RaisePropertyChanged("AnyAttr");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class nfeStatusServicoNF2Request {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://www.portalfiscal.inf.br/nfe/wsdl/NfeStatusServico2")]
        public NFe.Repositories.StatusServico.nfeCabecMsg nfeCabecMsg;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.portalfiscal.inf.br/nfe/wsdl/NfeStatusServico2", Order=0)]
        public System.Xml.XmlNode nfeDadosMsg;
        
        public nfeStatusServicoNF2Request() {
        }
        
        public nfeStatusServicoNF2Request(NFe.Repositories.StatusServico.nfeCabecMsg nfeCabecMsg, System.Xml.XmlNode nfeDadosMsg) {
            this.nfeCabecMsg = nfeCabecMsg;
            this.nfeDadosMsg = nfeDadosMsg;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class nfeStatusServicoNF2Response {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://www.portalfiscal.inf.br/nfe/wsdl/NfeStatusServico2")]
        public NFe.Repositories.StatusServico.nfeCabecMsg nfeCabecMsg;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.portalfiscal.inf.br/nfe/wsdl/NfeStatusServico2", Order=0)]
        public System.Xml.XmlNode nfeStatusServicoNF2Result;
        
        public nfeStatusServicoNF2Response() {
        }
        
        public nfeStatusServicoNF2Response(NFe.Repositories.StatusServico.nfeCabecMsg nfeCabecMsg, System.Xml.XmlNode nfeStatusServicoNF2Result) {
            this.nfeCabecMsg = nfeCabecMsg;
            this.nfeStatusServicoNF2Result = nfeStatusServicoNF2Result;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface NfeStatusServico2SoapChannel : NFe.Repositories.StatusServico.NfeStatusServico2Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class NfeStatusServico2SoapClient : System.ServiceModel.ClientBase<NFe.Repositories.StatusServico.NfeStatusServico2Soap>, NFe.Repositories.StatusServico.NfeStatusServico2Soap {
        
        public NfeStatusServico2SoapClient() {
        }
        
        public NfeStatusServico2SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public NfeStatusServico2SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NfeStatusServico2SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NfeStatusServico2SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        NFe.Repositories.StatusServico.nfeStatusServicoNF2Response NFe.Repositories.StatusServico.NfeStatusServico2Soap.nfeStatusServicoNF2(NFe.Repositories.StatusServico.nfeStatusServicoNF2Request request) {
            return base.Channel.nfeStatusServicoNF2(request);
        }
        
        public System.Xml.XmlNode nfeStatusServicoNF2(ref NFe.Repositories.StatusServico.nfeCabecMsg nfeCabecMsg, System.Xml.XmlNode nfeDadosMsg) {
            NFe.Repositories.StatusServico.nfeStatusServicoNF2Request inValue = new NFe.Repositories.StatusServico.nfeStatusServicoNF2Request();
            inValue.nfeCabecMsg = nfeCabecMsg;
            inValue.nfeDadosMsg = nfeDadosMsg;
            NFe.Repositories.StatusServico.nfeStatusServicoNF2Response retVal = ((NFe.Repositories.StatusServico.NfeStatusServico2Soap)(this)).nfeStatusServicoNF2(inValue);
            nfeCabecMsg = retVal.nfeCabecMsg;
            return retVal.nfeStatusServicoNF2Result;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<NFe.Repositories.StatusServico.nfeStatusServicoNF2Response> NFe.Repositories.StatusServico.NfeStatusServico2Soap.nfeStatusServicoNF2Async(NFe.Repositories.StatusServico.nfeStatusServicoNF2Request request) {
            return base.Channel.nfeStatusServicoNF2Async(request);
        }
        
        public System.Threading.Tasks.Task<NFe.Repositories.StatusServico.nfeStatusServicoNF2Response> nfeStatusServicoNF2Async(NFe.Repositories.StatusServico.nfeCabecMsg nfeCabecMsg, System.Xml.XmlNode nfeDadosMsg) {
            NFe.Repositories.StatusServico.nfeStatusServicoNF2Request inValue = new NFe.Repositories.StatusServico.nfeStatusServicoNF2Request();
            inValue.nfeCabecMsg = nfeCabecMsg;
            inValue.nfeDadosMsg = nfeDadosMsg;
            return ((NFe.Repositories.StatusServico.NfeStatusServico2Soap)(this)).nfeStatusServicoNF2Async(inValue);
        }


        public System.Xml.XmlNode nfeStatusServicoNF2(nfeCabecMsg nfeCabecMsg, System.Xml.XmlDocument nfeDadosMsg)
        {
            NFe.Repositories.StatusServico.nfeStatusServicoNF2Request inValue = new NFe.Repositories.StatusServico.nfeStatusServicoNF2Request();
           
            inValue.nfeCabecMsg = nfeCabecMsg;
            inValue.nfeDadosMsg = nfeDadosMsg;
            
            NFe.Repositories.StatusServico.nfeStatusServicoNF2Response retVal = ((NFe.Repositories.StatusServico.NfeStatusServico2Soap)(this)).nfeStatusServicoNF2(inValue);
           
            nfeCabecMsg = retVal.nfeCabecMsg;
            return retVal.nfeStatusServicoNF2Result;

        }
    }
}
