namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ulex.gov/library/2.0")]
    public partial class NonValidatingObjectReferenceType
    {
        
        private string structuredPayloadReferenceField;
        
        private string nonValidatingObjectReferenceField;
        
        private string xpathObjectReferenceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, DataType="IDREF")]
        public string structuredPayloadReference
        {
            get
            {
                return this.structuredPayloadReferenceField;
            }
            set
            {
                this.structuredPayloadReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, DataType="NCName")]
        public string nonValidatingObjectReference
        {
            get
            {
                return this.nonValidatingObjectReferenceField;
            }
            set
            {
                this.nonValidatingObjectReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string xpathObjectReference
        {
            get
            {
                return this.xpathObjectReferenceField;
            }
            set
            {
                this.xpathObjectReferenceField = value;
            }
        }
    }
}
