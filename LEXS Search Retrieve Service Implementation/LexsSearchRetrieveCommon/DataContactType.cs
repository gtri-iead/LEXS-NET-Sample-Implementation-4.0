namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://lexs.gov/lexs/4.0")]
    public partial class DataContactType : ComplexObjectType
    {
        
        private PersonNameTextType personGivenNameField;
        
        private PersonNameTextType personMiddleNameField;
        
        private PersonNameTextType personSurNameField;
        
        private PersonNameTextType personFullNameField;
        
        private object[] itemsField;
        
        private TextType organizationNameField;
        
        private DomainAttributeType1[] dataContactDomainAttributeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://niem.gov/niem/niem-core/2.0", IsNullable=true, Order=0)]
        public PersonNameTextType PersonGivenName
        {
            get
            {
                return this.personGivenNameField;
            }
            set
            {
                this.personGivenNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://niem.gov/niem/niem-core/2.0", IsNullable=true, Order=1)]
        public PersonNameTextType PersonMiddleName
        {
            get
            {
                return this.personMiddleNameField;
            }
            set
            {
                this.personMiddleNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://niem.gov/niem/niem-core/2.0", IsNullable=true, Order=2)]
        public PersonNameTextType PersonSurName
        {
            get
            {
                return this.personSurNameField;
            }
            set
            {
                this.personSurNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://niem.gov/niem/niem-core/2.0", IsNullable=true, Order=3)]
        public PersonNameTextType PersonFullName
        {
            get
            {
                return this.personFullNameField;
            }
            set
            {
                this.personFullNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ContactEmailID", typeof(@string), Namespace="http://niem.gov/niem/niem-core/2.0", IsNullable=true, Order=4)]
        [System.Xml.Serialization.XmlElementAttribute("ContactInstantMessenger", typeof(InstantMessengerType), Namespace="http://niem.gov/niem/niem-core/2.0", IsNullable=true, Order=4)]
        [System.Xml.Serialization.XmlElementAttribute("ContactTelephoneNumber", typeof(TelephoneNumberType), Namespace="http://niem.gov/niem/niem-core/2.0", IsNullable=true, Order=4)]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        // Note: This is a manual modification to prevent NULL elements from being serialized
        public bool ShouldSerializeOrganizationName()
        {
            return organizationNameField != null;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://niem.gov/niem/niem-core/2.0", IsNullable=true, Order=5)]
        public TextType OrganizationName
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
        [System.Xml.Serialization.XmlElementAttribute("DataContactDomainAttribute", Order=6)]
        public DomainAttributeType1[] DataContactDomainAttribute
        {
            get
            {
                return this.dataContactDomainAttributeField;
            }
            set
            {
                this.dataContactDomainAttributeField = value;
            }
        }
    }
}
