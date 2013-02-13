namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ulex.gov/ulex/2.0")]
    public partial class StructuredQueryType
    {
        
        private DigestQueryStatementType[] digestQueryStatementField;
        
        private StructuredPayloadQueryStatementType[] structuredPayloadQueryStatementField;
        
        private object[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DigestQueryStatement", Order=0)]
        public DigestQueryStatementType[] DigestQueryStatement
        {
            get
            {
                return this.digestQueryStatementField;
            }
            set
            {
                this.digestQueryStatementField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("StructuredPayloadQueryStatement", Order=1)]
        public StructuredPayloadQueryStatementType[] StructuredPayloadQueryStatement
        {
            get
            {
                return this.structuredPayloadQueryStatementField;
            }
            set
            {
                this.structuredPayloadQueryStatementField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("StructuredQueryDomainAttribute", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute("StructuredQueryExtension", typeof(StructuredQueryExtensionType), Namespace="http://lexs.gov/lexs/4.0", IsNullable=false, Order=2)]
        public object[] Items
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
