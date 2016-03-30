using NFe.Repositories.Entities;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml;
using NFe.Repositories.Context;
namespace NFe.Repositories.Response
{
    [DebuggerStepThroughAttribute()]
    [MessageContractAttribute(IsWrapped = false)]
    public class NFeStatusServicoNF2Response
    {
      
        [MessageHeaderAttribute(Namespace =  NFeStatusServicoContext.Namespace)]
        public NFeCabecMsg nfeCabecMsg;

        [MessageBodyMemberAttribute(Namespace = NFeStatusServicoContext.Namespace, Order = 0)]
        public XmlNode nfeStatusServicoNF2Result;

        public NFeStatusServicoNF2Response()
        {
        }

        public NFeStatusServicoNF2Response(NFeCabecMsg nfeCabecMsg, XmlNode nfeStatusServicoNF2Result)
        {
            this.nfeCabecMsg = nfeCabecMsg;
            this.nfeStatusServicoNF2Result = nfeStatusServicoNF2Result;
        }
    }
}
