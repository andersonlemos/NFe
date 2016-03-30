using NFe.Repositories.Context;
using NFe.Repositories.Request;
using NFe.Repositories.Response;
using System.ServiceModel;
using System.Threading.Tasks;
namespace NFe.Repositories.Interfaces
{
  
    [ServiceContractAttribute(Namespace = NFeStatusServicoContext.Namespace, ConfigurationName = NFeStatusServicoContext.ConfigurationName)]
    public interface INFeStatusServico2Soap
    {

        [OperationContractAttribute(Action = NFeStatusServicoContext.Action, ReplyAction = "*")]
        [XmlSerializerFormatAttribute(SupportFaults = true)]
        NFeStatusServicoNF2Response NFeStatusServicoNF2(NFeStatusServicoNF2Request request);

        [OperationContractAttribute(Action = NFeStatusServicoContext.Action, ReplyAction = "*")]
        Task<NFeStatusServicoNF2Response> NFeStatusServicoNF2Async(NFeStatusServicoNF2Request request);
    }
}
