namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/domains/screening/2.1")]
    public partial class DocumentAssociationType : AssociationType
    {
        
        private ReferenceType2 primaryDocumentReferenceField;
        
        private ReferenceType2[] secondaryDocumentReferenceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ReferenceType2 PrimaryDocumentReference
        {
            get
            {
                return this.primaryDocumentReferenceField;
            }
            set
            {
                this.primaryDocumentReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SecondaryDocumentReference", Order=1)]
        public ReferenceType2[] SecondaryDocumentReference
        {
            get
            {
                return this.secondaryDocumentReferenceField;
            }
            set
            {
                this.secondaryDocumentReferenceField = value;
            }
        }
    }
}
