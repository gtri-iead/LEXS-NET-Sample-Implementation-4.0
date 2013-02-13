namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ulex.gov/library/2.0")]
    public partial class SameAsConnectionType
    {
        
        private ValidatingObjectReferenceType digestObjectReferenceField;
        
        private NonValidatingObjectReferenceType[] structuredPayloadObjectReferenceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ValidatingObjectReferenceType DigestObjectReference
        {
            get
            {
                return this.digestObjectReferenceField;
            }
            set
            {
                this.digestObjectReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("StructuredPayloadObjectReference", Order=1)]
        public NonValidatingObjectReferenceType[] StructuredPayloadObjectReference
        {
            get
            {
                return this.structuredPayloadObjectReferenceField;
            }
            set
            {
                this.structuredPayloadObjectReferenceField = value;
            }
        }
    }
}
