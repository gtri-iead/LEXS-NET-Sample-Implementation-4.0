namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://lexs.gov/digest/4.0")]
    public partial class ActivityTelephoneNumberAssociationType : AssociationType
    {
        
        private ReferenceType2[] activityReferenceField;
        
        private ReferenceType2[] telephoneNumberReferenceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ActivityReference", Namespace="http://niem.gov/niem/niem-core/2.0", Order=0)]
        public ReferenceType2[] ActivityReference
        {
            get
            {
                return this.activityReferenceField;
            }
            set
            {
                this.activityReferenceField = value;
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
