namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ulex.gov/ulex/2.0")]
    public partial class AttachmentType
    {
        
        private string attachmentURIField;
        
        private object attachmentContentAbstractField;
        
        private DataOwnerMetadataType dataOwnerMetadataField;
        
        private DomainAttributeType[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI", Order=0)]
        public string AttachmentURI
        {
            get
            {
                return this.attachmentURIField;
            }
            set
            {
                this.attachmentURIField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        [System.Xml.Serialization.XmlElementAttribute("AttachmentContentBinary", typeof(BinaryType), Namespace="http://lexs.gov/lexs/4.0", IsNullable=false, Order=1)]
        public object AttachmentContentAbstract
        {
            get
            {
                return this.attachmentContentAbstractField;
            }
            set
            {
                this.attachmentContentAbstractField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public DataOwnerMetadataType DataOwnerMetadata
        {
            get
            {
                return this.dataOwnerMetadataField;
            }
            set
            {
                this.dataOwnerMetadataField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AttachmentDomainAttribute", Order=3)]
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
