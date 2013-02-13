namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ulex.gov/searchretrieve/2.0")]
    public partial class doStructuredSearchRequestType
    {
        
        private StructuredSearchRequestMessageType structuredSearchRequestMessageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://ulex.gov/ulex/2.0", Order=0)]
        public StructuredSearchRequestMessageType StructuredSearchRequestMessage
        {
            get
            {
                return this.structuredSearchRequestMessageField;
            }
            set
            {
                this.structuredSearchRequestMessageField = value;
            }
        }
    }
}
