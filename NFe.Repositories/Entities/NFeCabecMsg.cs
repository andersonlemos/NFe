using NFe.Repositories.Context;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace NFe.Repositories.Entities
{
   
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = NFeStatusServicoContext.Namespace)]
    public class NFeCabecMsg : object, INotifyPropertyChanged
    {

        private string cUFField;

        private string versaoDadosField;

        private XmlAttribute[] anyAttrField;

        /// <remarks/>
        [XmlElementAttribute(Order = 0)]
        public string cUF
        {
            get
            {
                return this.cUFField;
            }
            set
            {
                this.cUFField = value;
                this.RaisePropertyChanged("cUF");
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 1)]
        public string versaoDados
        {
            get
            {
                return this.versaoDadosField;
            }
            set
            {
                this.versaoDadosField = value;
                this.RaisePropertyChanged("versaoDados");
            }
        }

        /// <remarks/>
        [XmlAnyAttributeAttribute()]
        public XmlAttribute[] AnyAttr
        {
            get
            {
                return this.anyAttrField;
            }
            set
            {
                this.anyAttrField = value;
                this.RaisePropertyChanged("AnyAttr");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
