namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ulex.gov/ulex/2.0")]
    public partial class AttachmentResponseMessageType : ResponseMessageType
    {
        
        private AttachmentType[] attachmentField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Attachment", Order=0)]
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
