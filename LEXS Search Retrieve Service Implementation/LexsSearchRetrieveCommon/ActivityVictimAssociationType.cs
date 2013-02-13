namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/domains/jxdm/4.1")]
    public partial class ActivityVictimAssociationType : AssociationType
    {
        
        private ReferenceType2[] activityReferenceField;
        
        private ReferenceType2[] victimReferenceField;
        
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
        [System.Xml.Serialization.XmlElementAttribute("VictimReference", Order=1)]
        public ReferenceType2[] VictimReference
        {
            get
            {
                return this.victimReferenceField;
            }
            set
            {
                this.victimReferenceField = value;
            }
        }
    }
}
