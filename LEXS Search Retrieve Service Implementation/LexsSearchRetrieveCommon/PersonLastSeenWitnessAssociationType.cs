namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://lexs.gov/digest/4.0")]
    public partial class PersonLastSeenWitnessAssociationType : AssociationType
    {
        
        private ReferenceType2 missingPersonReferenceField;
        
        private ReferenceType2 witnessReferenceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://niem.gov/niem/domains/jxdm/4.1", Order=1)]
        public ReferenceType2 WitnessReference
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
