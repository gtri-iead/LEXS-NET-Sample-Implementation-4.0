namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ulex.gov/ulex/2.0")]
    public partial class AttachmentRequestMessageType : RequestMessageType
    {
        
        private string[] attachmentURIField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AttachmentURI", DataType="anyURI", Order=0)]
        public string[] AttachmentURI
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
    }
}
