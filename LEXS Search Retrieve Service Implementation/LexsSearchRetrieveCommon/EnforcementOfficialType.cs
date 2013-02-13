namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/domains/jxdm/4.1")]
    public partial class EnforcementOfficialType : ComplexObjectType
    {
        
        private ReferenceType2 roleOfPersonReferenceField;
        
        private IdentificationType enforcementOfficialBadgeIdentificationField;
        
        private TextType enforcementOfficialCategoryTextField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://niem.gov/niem/niem-core/2.0", Order=0)]
        public ReferenceType2 RoleOfPersonReference
        {
            get
            {
                return this.roleOfPersonReferenceField;
            }
            set
            {
                this.roleOfPersonReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public IdentificationType EnforcementOfficialBadgeIdentification
        {
            get
            {
                return this.enforcementOfficialBadgeIdentificationField;
            }
            set
            {
                this.enforcementOfficialBadgeIdentificationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public TextType EnforcementOfficialCategoryText
        {
            get
            {
                return this.enforcementOfficialCategoryTextField;
            }
            set
            {
                this.enforcementOfficialCategoryTextField = value;
            }
        }
    }
}
