namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ulex.gov/ulex/2.0")]
    public partial class SRMessageMetadataType : MessageMetadataAbstractType
    {
        
        private SystemMetadataType messageOriginMetadataField;
        
        private object[] messageDestinationIdentifierAbstractField;
        
        private DomainAttributeType[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public SystemMetadataType MessageOriginMetadata
        {
            get
            {
                return this.messageOriginMetadataField;
            }
            set
            {
                this.messageOriginMetadataField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MessageDestinationIdentifierAbstract", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute("MessageDestinationIdentifier", typeof(SystemIdentifierType), Namespace="http://lexs.gov/lexs/4.0", IsNullable=false, Order=1)]
        public object[] MessageDestinationIdentifierAbstract
        {
            get
            {
                return this.messageDestinationIdentifierAbstractField;
            }
            set
            {
                this.messageDestinationIdentifierAbstractField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SRMessageMetadataDomainAttribute", Order=2)]
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
