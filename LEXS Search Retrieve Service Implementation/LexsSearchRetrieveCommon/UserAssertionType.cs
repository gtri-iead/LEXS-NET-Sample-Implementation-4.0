namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://lexs.gov/lexs/4.0")]
    public partial class UserAssertionType : ComplexObjectType
    {
        
        private @string userIDField;
        
        private PersonNameTextType personGivenNameField;
        
        private PersonNameTextType personSurNameField;
        
        private object[] itemsField;
        
        private TextType organizationNameField;
        
        private @string originatingAgencyIDField;
        
        private DomainAttributeType1[] userAssertionDomainAttributeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public @string UserID
        {
            get
            {
                return this.userIDField;
            }
            set
            {
                this.userIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://niem.gov/niem/niem-core/2.0", IsNullable=true, Order=1)]
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
        [System.Xml.Serialization.XmlElementAttribute("ContactEmailID", typeof(@string), Namespace="http://niem.gov/niem/niem-core/2.0", IsNullable=true, Order=3)]
        [System.Xml.Serialization.XmlElementAttribute("ContactInstantMessenger", typeof(InstantMessengerType), Namespace="http://niem.gov/niem/niem-core/2.0", IsNullable=true, Order=3)]
        [System.Xml.Serialization.XmlElementAttribute("ContactTelephoneNumber", typeof(TelephoneNumberType), Namespace="http://niem.gov/niem/niem-core/2.0", IsNullable=true, Order=3)]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://niem.gov/niem/niem-core/2.0", IsNullable=true, Order=4)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public @string OriginatingAgencyID
        {
            get
            {
                return this.originatingAgencyIDField;
            }
            set
            {
                this.originatingAgencyIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UserAssertionDomainAttribute", Order=6)]
        public DomainAttributeType1[] UserAssertionDomainAttribute
        {
            get
            {
                return this.userAssertionDomainAttributeField;
            }
            set
            {
                this.userAssertionDomainAttributeField = value;
            }
        }
    }
}
