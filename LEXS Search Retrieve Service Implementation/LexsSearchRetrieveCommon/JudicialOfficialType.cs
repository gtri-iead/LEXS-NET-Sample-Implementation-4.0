namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/domains/jxdm/4.1")]
    public partial class JudicialOfficialType : ComplexObjectType
    {
        
        private ReferenceType2 roleOfPersonReferenceField;
        
        private IdentificationType judicialOfficialPanelIdentificationField;
        
        private IdentificationType judicialOfficialRegistrationIdentificationField;
        
        private TextType judicialOfficialCategoryTextField;
        
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
        public IdentificationType JudicialOfficialPanelIdentification
        {
            get
            {
                return this.judicialOfficialPanelIdentificationField;
            }
            set
            {
                this.judicialOfficialPanelIdentificationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public IdentificationType JudicialOfficialRegistrationIdentification
        {
            get
            {
                return this.judicialOfficialRegistrationIdentificationField;
            }
            set
            {
                this.judicialOfficialRegistrationIdentificationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public TextType JudicialOfficialCategoryText
        {
            get
            {
                return this.judicialOfficialCategoryTextField;
            }
            set
            {
                this.judicialOfficialCategoryTextField = value;
            }
        }
    }
}
