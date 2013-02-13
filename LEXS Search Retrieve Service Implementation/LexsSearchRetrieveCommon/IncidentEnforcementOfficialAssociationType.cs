namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://lexs.gov/digest/4.0")]
    public partial class IncidentEnforcementOfficialAssociationType : AssociationType
    {
        
        private ReferenceType2[] incidentReferenceField;
        
        private ReferenceType2[] enforcementOfficialReferenceField;
        
        private TextType personActivityInvolvementTextField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IncidentReference", Namespace="http://niem.gov/niem/niem-core/2.0", Order=0)]
        public ReferenceType2[] IncidentReference
        {
            get
            {
                return this.incidentReferenceField;
            }
            set
            {
                this.incidentReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EnforcementOfficialReference", Order=1)]
        public ReferenceType2[] EnforcementOfficialReference
        {
            get
            {
                return this.enforcementOfficialReferenceField;
            }
            set
            {
                this.enforcementOfficialReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://niem.gov/niem/niem-core/2.0", IsNullable=true, Order=2)]
        public TextType PersonActivityInvolvementText
        {
            get
            {
                return this.personActivityInvolvementTextField;
            }
            set
            {
                this.personActivityInvolvementTextField = value;
            }
        }
    }
}
