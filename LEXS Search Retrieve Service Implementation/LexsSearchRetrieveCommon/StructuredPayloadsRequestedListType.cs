namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ulex.gov/ulex/2.0")]
    public partial class StructuredPayloadsRequestedListType
    {
        
        private StructuredPayloadMetadataType[] structuredPayloadMetadataField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("StructuredPayloadMetadata", Order=0)]
        public StructuredPayloadMetadataType[] StructuredPayloadMetadata
        {
            get
            {
                return this.structuredPayloadMetadataField;
            }
            set
            {
                this.structuredPayloadMetadataField = value;
            }
        }
    }
}
