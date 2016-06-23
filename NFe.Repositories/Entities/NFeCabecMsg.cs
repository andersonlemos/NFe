using NFe.Repositories.Context;
using System;
using System.ComponentModel;
using System.Xml;
using System.Xml.Serialization;
using NFe.Domain.Entities.Base;

namespace NFe.Repositories.Entities
{
   
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace = NFeStatusServicoContext.Namespace)]
    public class NFeCabecMsg : object, INotifyPropertyChanged
    {
        private XmlAttribute[] _anyAttrField;

        [XmlElementAttribute("cUF",Order = 0)]
        public CodUfIBGE CUf { get; set; }

        [XmlElementAttribute("versaoDados",Order = 1)]
        public VersaoNFe VersaoDados { get; set; }
    
        [XmlAnyAttributeAttribute()]
        public XmlAttribute[] AnyAttr
        {
            get
            {
                return _anyAttrField;
            }
            set
            {
                _anyAttrField = value;
                RaisePropertyChanged("AnyAttr");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            var propertyChanged = PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
