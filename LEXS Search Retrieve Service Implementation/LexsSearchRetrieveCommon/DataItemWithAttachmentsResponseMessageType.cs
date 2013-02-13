namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ulex.gov/ulex/2.0")]
    public partial class DataItemWithAttachmentsResponseMessageType : ResponseMessageType
    {
        
        private SystemMetadataType dataSubmitterMetadataField;
        
        private DataItemPackageType dataItemPackageField;
        
        private AttachmentType[] attachmentField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public DataItemPackageType DataItemPackage
        {
            get
            {
                return this.dataItemPackageField;
            }
            set
            {
                this.dataItemPackageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Attachment", Order=2)]
        public AttachmentType[] Attachment
        {
            get
            {
                return this.attachmentField;
            }
            set
            {
                this.attachmentField = value;
            }
        }
    }
}
