namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ulex.gov/ulex/2.0")]
    public partial class DomainActionMessageType
    {
        
        private DEMessageMetadataType dEMessageMetadataField;
        
        private SystemMetadataType dataSubmitterMetadataField;
        
        private DomainAttributeType[] domainAttributeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public DEMessageMetadataType DEMessageMetadata
        {
            get
            {
                return this.dEMessageMetadataField;
            }
            set
            {
                this.dEMessageMetadataField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public SystemMetadataType DataSubmitterMetadata
        {
            get
            {
                return this.dataSubmitterMetadataField;
            }
            set
            {
                this.dataSubmitterMetadataField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DomainAttribute", Order=2)]
        public DomainAttributeType[] DomainAttribute
        {
            get
            {
                return this.domainAttributeField;
            }
            set
            {
                this.domainAttributeField = value;
            }
        }
    }
}
