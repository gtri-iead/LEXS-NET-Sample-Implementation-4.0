namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ActivityInvolvedPersonAssociationType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/niem-core/2.0")]
    public partial class ActivityPersonAssociationType : AssociationType
    {
        
        private ReferenceType2[] activityReferenceField;
        
        private ReferenceType2[] personReferenceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ActivityReference", Order=0)]
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
        [System.Xml.Serialization.XmlElementAttribute("PersonReference", Order=1)]
        public ReferenceType2[] PersonReference
        {
            get
            {
                return this.personReferenceField;
            }
            set
            {
                this.personReferenceField = value;
            }
        }
    }
}
