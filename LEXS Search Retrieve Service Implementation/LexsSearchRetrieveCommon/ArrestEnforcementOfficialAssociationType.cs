namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://lexs.gov/digest/4.0")]
    public partial class ArrestEnforcementOfficialAssociationType : AssociationType
    {
        
        private ReferenceType2[] arrestReferenceField;
        
        private ReferenceType2[] enforcementOfficialReferenceField;
        
        private TextType personActivityInvolvementTextField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ArrestReference", Namespace="http://niem.gov/niem/domains/jxdm/4.1", Order=0)]
        public ReferenceType2[] ArrestReference
        {
            get
            {
                return this.arrestReferenceField;
            }
            set
            {
                this.arrestReferenceField = value;
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
