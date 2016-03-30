using NFe.Repositories.Context;
using NFe.Repositories.Entities;
using System.Diagnostics;
using System.ServiceModel;
using System.Xml;
namespace NFe.Repositories.Request
{
    [MessageContractAttribute(IsWrapped = false)]
    public class NFeStatusServicoNF2Request 
    {
        [MessageHeaderAttribute(Namespace = NFeStatusServicoContext.Namespace)]
        public NFeCabecMsg nfeCabecMsg;

        [MessageBodyMemberAttribute(Namespace = NFeStatusServicoContext.Namespace, Order = 0)]
        public XmlNode nfeDadosMsg;

        public NFeStatusServicoNF2Request()
        {
        }

        public NFeStatusServicoNF2Request(NFeCabecMsg nfeCabecMsg, XmlNode nfeDadosMsg)
        {
            this.nfeCabecMsg = nfeCabecMsg;
            this.nfeDadosMsg = nfeDadosMsg;
        }
        public NFeStatusServicoNF2Request(NFeCabecMsg nfeCabecMsg, XmlDocument nfeDadosMsg)
        {
            this.nfeCabecMsg = nfeCabecMsg;
            this.nfeDadosMsg = nfeDadosMsg;
        }
    }
}
