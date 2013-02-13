namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ulex.gov/library/2.0")]
    public partial class ValidatingObjectReferenceType
    {
        
        private string validatingObjectReferenceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, DataType="IDREF")]
        public string validatingObjectReference
        {
            get
            {
                return this.validatingObjectReferenceField;
            }
            set
            {
                this.validatingObjectReferenceField = value;
            }
        }
    }
}
