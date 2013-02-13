namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://lexs.gov/digest/4.0")]
    public partial class EmailAddressOtherAssociationType : AssociationType
    {
        
        private ReferenceType2[] emailAddressReferenceField;
        
        private ReferenceType2[] otherReferenceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EmailAddressReference", Order=0)]
        public ReferenceType2[] EmailAddressReference
        {
            get
            {
                return this.emailAddressReferenceField;
            }
            set
            {
                this.emailAddressReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OtherReference", Order=1)]
        public ReferenceType2[] OtherReference
        {
            get
            {
                return this.otherReferenceField;
            }
            set
            {
                this.otherReferenceField = value;
            }
        }
    }
}
