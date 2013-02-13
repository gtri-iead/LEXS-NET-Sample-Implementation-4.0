namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SRMessageMetadataType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PDMessageMetadataType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DEMessageMetadataType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SNMessageMetadataType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ulex.gov/ulex/2.0")]
    public abstract partial class MessageMetadataAbstractType
    {
        
        private string uLEXFrameworkVersionTextField;
        
        private ULEXImplementationType uLEXImplementationField;
        
        private System.DateTime messageDateTimeField;
        
        private AttributedURIType messageIDField;
        
        private AttributedURIType toField;
        
        private EndpointReferenceType fromField;
        
        private EndpointReferenceType replyToField;
        
        private EndpointReferenceType faultToField;
        
        private AttributedURIType actionField;
        
        private RelatesToType[] relatesToField;
        
        private object dataSensitivityAbstractField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string ULEXFrameworkVersionText
        {
            get
            {
                return this.uLEXFrameworkVersionTextField;
            }
            set
            {
                this.uLEXFrameworkVersionTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public ULEXImplementationType ULEXImplementation
        {
            get
            {
                return this.uLEXImplementationField;
            }
            set
            {
                this.uLEXImplementationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public System.DateTime MessageDateTime
        {
            get
            {
                return this.messageDateTimeField;
            }
            set
            {
                this.messageDateTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.w3.org/2005/08/addressing", Order=3)]
        public AttributedURIType MessageID
        {
            get
            {
                return this.messageIDField;
            }
            set
            {
                this.messageIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.w3.org/2005/08/addressing", Order=4)]
        public AttributedURIType To
        {
            get
            {
                return this.toField;
            }
            set
            {
                this.toField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.w3.org/2005/08/addressing", Order=5)]
        public EndpointReferenceType From
        {
            get
            {
                return this.fromField;
            }
            set
            {
                this.fromField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.w3.org/2005/08/addressing", Order=6)]
        public EndpointReferenceType ReplyTo
        {
            get
            {
                return this.replyToField;
            }
            set
            {
                this.replyToField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.w3.org/2005/08/addressing", Order=7)]
        public EndpointReferenceType FaultTo
        {
            get
            {
                return this.faultToField;
            }
            set
            {
                this.faultToField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.w3.org/2005/08/addressing", Order=8)]
        public AttributedURIType Action
        {
            get
            {
                return this.actionField;
            }
            set
            {
                this.actionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RelatesTo", Namespace="http://www.w3.org/2005/08/addressing", Order=9)]
        public RelatesToType[] RelatesTo
        {
            get
            {
                return this.relatesToField;
            }
            set
            {
                this.relatesToField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        [System.Xml.Serialization.XmlElementAttribute("DataSensitivityText", typeof(@string), Namespace="http://lexs.gov/lexs/4.0", IsNullable=false, Order=10)]
        public object DataSensitivityAbstract
        {
            get
            {
                return this.dataSensitivityAbstractField;
            }
            set
            {
                this.dataSensitivityAbstractField = value;
            }
        }
    }
}
