namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/niem-core/2.0")]
    public partial class GuardianAssociationType : AssociationType
    {
        
        private ReferenceType2[] personGuardianReferenceField;
        
        private ReferenceType2[] personDependentReferenceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonGuardianReference", Order=0)]
        public ReferenceType2[] PersonGuardianReference
        {
            get
            {
                return this.personGuardianReferenceField;
            }
            set
            {
                this.personGuardianReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonDependentReference", Order=1)]
        public ReferenceType2[] PersonDependentReference
        {
            get
            {
                return this.personDependentReferenceField;
            }
            set
            {
                this.personDependentReferenceField = value;
            }
        }
    }
}
