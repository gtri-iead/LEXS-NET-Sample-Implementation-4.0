namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ulex.gov/ulex/2.0")]
    public partial class StructuredPayloadQueryStatementType
    {
        
        private StructuredPayloadMetadataType structuredPayloadMetadataField;
        
        private System.Xml.XmlElement structuredPayloadQueryFieldField;
        
        private QueryMatchCodeSimpleType queryMatchCodeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public StructuredPayloadMetadataType StructuredPayloadMetadata
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public System.Xml.XmlElement StructuredPayloadQueryField
        {
            get
            {
                return this.structuredPayloadQueryFieldField;
            }
            set
            {
                this.structuredPayloadQueryFieldField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public QueryMatchCodeSimpleType QueryMatchCode
        {
            get
            {
                return this.queryMatchCodeField;
            }
            set
            {
                this.queryMatchCodeField = value;
            }
        }
    }
}
