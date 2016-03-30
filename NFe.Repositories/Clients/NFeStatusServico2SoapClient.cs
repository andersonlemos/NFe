using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.ServiceModel;
using NFe.Repositories.Response;
using NFe.Repositories.Request;
using System.Threading.Tasks;
using System.Xml;
using NFe.Repositories.Entities;
using NFe.Repositories.Interfaces;

namespace NFe.Repositories.Clients
{
    [DebuggerStepThroughAttribute()]
    //[GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public class NFeStatusServico2SoapClient :ClientBase<INFeStatusServico2Soap>, INFeStatusServico2Soap
    {

        public NFeStatusServico2SoapClient()
        {
        }

        public NFeStatusServico2SoapClient(string endpointConfigurationName) :
            base(endpointConfigurationName)
        {
        }

        public NFeStatusServico2SoapClient(string endpointConfigurationName, string remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public NFeStatusServico2SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public NFeStatusServico2SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
            base(binding, remoteAddress)
        {
        }

        public NFeStatusServicoNF2Response NFeStatusServicoNF2(NFeStatusServicoNF2Request request)
        {
            return base.Channel.NFeStatusServicoNF2(request);
        }

        public Task<NFeStatusServicoNF2Response> NFeStatusServicoNF2Async(NFeStatusServicoNF2Request request)
        {
            return base.Channel.NFeStatusServicoNF2Async(request);
        }

        public XmlNode NFeStatusServicoNF2(NFeCabecMsg nfeCabecMsg, XmlDocument nfeDadosMsg)
        {
            NFeStatusServicoNF2Request inValue = new NFeStatusServicoNF2Request();

            inValue.nfeCabecMsg = nfeCabecMsg;
            inValue.nfeDadosMsg = nfeDadosMsg;

            NFeStatusServicoNF2Response retVal = ((INFeStatusServico2Soap)(this)).NFeStatusServicoNF2(inValue);

            nfeCabecMsg = retVal.nfeCabecMsg;

            return retVal.nfeStatusServicoNF2Result;

        }
    }
}
