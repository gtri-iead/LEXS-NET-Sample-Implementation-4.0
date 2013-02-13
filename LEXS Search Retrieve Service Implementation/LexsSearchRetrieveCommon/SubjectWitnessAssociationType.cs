namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://lexs.gov/digest/4.0")]
    public partial class SubjectWitnessAssociationType : AssociationType
    {
        
        private ReferenceType2[] subjectReferenceField;
        
        private ReferenceType2[] witnessReferenceField;
        
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
        [System.Xml.Serialization.XmlElementAttribute("WitnessReference", Namespace="http://niem.gov/niem/domains/jxdm/4.1", Order=1)]
        public ReferenceType2[] WitnessReference
        {
            get
            {
                return this.witnessReferenceField;
            }
            set
            {
                this.witnessReferenceField = value;
            }
        }
    }
}
