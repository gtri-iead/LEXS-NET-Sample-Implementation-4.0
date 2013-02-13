namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SearchResultPackageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DataItemPackageType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ulex.gov/ulex/2.0")]
    public abstract partial class PackageAbstractType
    {
        
        private PackageMetadataType packageMetadataField;
        
        private object digestAbstractField;
        
        private StructuredPayloadType[] structuredPayloadField;
        
        private AttachmentSummaryType[] attachmentSummaryField;
        
        private LinkagesType linkagesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public PackageMetadataType PackageMetadata
        {
            get
            {
                return this.packageMetadataField;
            }
            set
            {
                this.packageMetadataField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        [System.Xml.Serialization.XmlElementAttribute("Digest", typeof(DigestType), Namespace="http://lexs.gov/lexs/4.0", IsNullable=false, Order=1)]
        public object DigestAbstract
        {
            get
            {
                return this.digestAbstractField;
            }
            set
            {
                this.digestAbstractField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("StructuredPayload", Order=2)]
        public StructuredPayloadType[] StructuredPayload
        {
            get
            {
                return this.structuredPayloadField;
            }
            set
            {
                this.structuredPayloadField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AttachmentSummary", Order=3)]
        public AttachmentSummaryType[] AttachmentSummary
        {
            get
            {
                return this.attachmentSummaryField;
            }
            set
            {
                this.attachmentSummaryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public LinkagesType Linkages
        {
            get
            {
                return this.linkagesField;
            }
            set
            {
                this.linkagesField = value;
            }
        }
    }
}
