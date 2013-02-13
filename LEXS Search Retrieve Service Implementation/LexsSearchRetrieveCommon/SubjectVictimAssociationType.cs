namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://lexs.gov/digest/4.0")]
    public partial class SubjectVictimAssociationType : AssociationType
    {
        
        private ReferenceType2[] subjectReferenceField;
        
        private ReferenceType2[] victimReferenceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SubjectReference", Namespace="http://niem.gov/niem/domains/jxdm/4.1", Order=0)]
        public ReferenceType2[] SubjectReference
        {
            get
            {
                return this.subjectReferenceField;
            }
            set
            {
                this.subjectReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("VictimReference", Namespace="http://niem.gov/niem/domains/jxdm/4.1", Order=1)]
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
