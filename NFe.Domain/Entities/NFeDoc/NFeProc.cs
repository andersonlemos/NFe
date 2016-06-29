using System.Xml.Serialization;
using NFe.Domain.Entities.Base;

namespace NFe.Domain.Entities.NFeDoc
{
    [XmlRoot("nfeProc", Namespace = NamespaceBase.Domain)]
    public class NFeProc:ModelBase
    {
        [XmlElement("NFe")]
        public NFe Nfe { get; set; }

        public NFeProc()
        {
            
        }

        public NFeProc(NFe nfe)
        {
            Nfe = nfe;
        }

    }
}
