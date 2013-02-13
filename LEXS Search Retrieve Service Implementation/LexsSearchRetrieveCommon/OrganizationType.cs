namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrganizationType1))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/niem-core/2.0")]
    public partial class OrganizationType : ComplexObjectType
    {
        
        private TextType organizationAbbreviationTextField;
        
        private object itemField;
        
        private TextType organizationDescriptionTextField;
        
        private DateType organizationEstablishedDateField;
        
        private TextType[] organizationNameField;
        
        private IdentificationType organizationTaxIdentificationField;
        
        private DateType organizationTerminationDateField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public TextType OrganizationAbbreviationText
        {
            get
            {
                return this.organizationAbbreviationTextField;
            }
            set
            {
                this.organizationAbbreviationTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OrganizationCategoryText", IsNullable=true, Order=1)]
        [System.Xml.Serialization.XmlElementAttribute("OrganizationCategoryCode", typeof(OrganizationCategoryCodeType), Namespace="http://lexs.gov/digest/4.0", IsNullable=true, Order=1)]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public TextType OrganizationDescriptionText
        {
            get
            {
                return this.organizationDescriptionTextField;
            }
            set
            {
                this.organizationDescriptionTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public DateType OrganizationEstablishedDate
        {
            get
            {
                return this.organizationEstablishedDateField;
            }
            set
            {
                this.organizationEstablishedDateField = value;
            }
        }

        // Note: This is a manual modification to prevent NULL elements from being serialized
        public bool ShouldSerializeOrganizationName()
        {
            return organizationNameField != null;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OrganizationName", IsNullable=true, Order=4)]
        public TextType[] OrganizationName
        {
            get
            {
                return this.organizationNameField;
            }
            set
            {
                this.organizationNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=5)]
        public IdentificationType OrganizationTaxIdentification
        {
            get
            {
                return this.organizationTaxIdentificationField;
            }
            set
            {
                this.organizationTaxIdentificationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=6)]
        public DateType OrganizationTerminationDate
        {
            get
            {
                return this.organizationTerminationDateField;
            }
            set
            {
                this.organizationTerminationDateField = value;
            }
        }
    }
}
