namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ulex.gov/ulex/2.0")]
    public partial class MatchStructuredPayloadElementReferenceType
    {
        
        private NonValidatingObjectReferenceType structuredPayloadObjectReferenceField;
        
        private string queryMatchTextField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://ulex.gov/library/2.0", Order=0)]
        public NonValidatingObjectReferenceType StructuredPayloadObjectReference
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string QueryMatchText
        {
            get
            {
                return this.queryMatchTextField;
            }
            set
            {
                this.queryMatchTextField = value;
            }
        }
    }
}
