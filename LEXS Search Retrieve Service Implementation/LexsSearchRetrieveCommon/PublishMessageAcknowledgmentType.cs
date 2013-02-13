namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ulex.gov/ulex/2.0")]
    public partial class PublishMessageAcknowledgmentType
    {
        
        private PDMessageMetadataType pDMessageMetadataField;
        
        private EndpointReferenceType publishMessageAcknowledgmentReferenceField;
        
        private DomainAttributeType[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public PDMessageMetadataType PDMessageMetadata
        {
            get
            {
                return this.pDMessageMetadataField;
            }
            set
            {
                this.pDMessageMetadataField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public EndpointReferenceType PublishMessageAcknowledgmentReference
        {
            get
            {
                return this.publishMessageAcknowledgmentReferenceField;
            }
            set
            {
                this.publishMessageAcknowledgmentReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PublishMessageAcknowledgmentDomainAttribute", Order=2)]
        public DomainAttributeType[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }
}
