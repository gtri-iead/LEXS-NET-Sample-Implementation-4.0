namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://lexs.gov/digest/4.0")]
    public partial class TelephoneNumberOtherAssociationType : AssociationType
    {
        
        private ReferenceType2[] otherReferenceField;
        
        private ReferenceType2[] telephoneNumberReferenceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OtherReference", Order=0)]
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TelephoneNumberReference", Namespace="http://niem.gov/niem/niem-core/2.0", Order=1)]
        public ReferenceType2[] TelephoneNumberReference
        {
            get
            {
                return this.telephoneNumberReferenceField;
            }
            set
            {
                this.telephoneNumberReferenceField = value;
            }
        }
    }
}
