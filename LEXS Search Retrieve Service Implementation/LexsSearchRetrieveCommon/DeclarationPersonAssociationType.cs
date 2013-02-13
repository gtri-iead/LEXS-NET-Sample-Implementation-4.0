namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://lexs.gov/digest/4.0")]
    public partial class DeclarationPersonAssociationType : AssociationType
    {
        
        private ReferenceType2 declarationPersonReferenceField;
        
        private ReferenceType2 missingPersonReferenceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ReferenceType2 DeclarationPersonReference
        {
            get
            {
                return this.declarationPersonReferenceField;
            }
            set
            {
                this.declarationPersonReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public ReferenceType2 MissingPersonReference
        {
            get
            {
                return this.missingPersonReferenceField;
            }
            set
            {
                this.missingPersonReferenceField = value;
            }
        }
    }
}
