namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TextSearchRequestMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StructuredSearchRequestMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DataItemMetadataSearchRequestMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AttachmentSearchRequestMessageType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ulex.gov/ulex/2.0")]
    public abstract partial class SearchRequestMessageType : RequestMessageType
    {
        
        private SearchRequestMetadataType searchRequestMetadataField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public SearchRequestMetadataType SearchRequestMetadata
        {
            get
            {
                return this.searchRequestMetadataField;
            }
            set
            {
                this.searchRequestMetadataField = value;
            }
        }
    }
}
