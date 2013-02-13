namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ulex.gov/ulex/2.0")]
    public partial class AttachmentSearchRequestMessageType : SearchRequestMessageType
    {
        
        private AttachmentType attachmentField;
        
        private System.Xml.XmlQualifiedName[] attachmentSummaryConnectionQNameField;
        
        private object[] attachmentHashValueAbstractField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public AttachmentType Attachment
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AttachmentSummaryConnectionQName", Order=1)]
        public System.Xml.XmlQualifiedName[] AttachmentSummaryConnectionQName
        {
            get
            {
                return this.attachmentSummaryConnectionQNameField;
            }
            set
            {
                this.attachmentSummaryConnectionQNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AttachmentHashValueAbstract", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute("AttachmentHashValue", typeof(HashValueType), Namespace="http://lexs.gov/lexs/4.0", IsNullable=true, Order=2)]
        public object[] AttachmentHashValueAbstract
        {
            get
            {
                return this.attachmentHashValueAbstractField;
            }
            set
            {
                this.attachmentHashValueAbstractField = value;
            }
        }
    }
}
