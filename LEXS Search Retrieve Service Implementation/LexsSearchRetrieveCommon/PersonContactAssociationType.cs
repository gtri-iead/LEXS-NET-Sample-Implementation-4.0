namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://lexs.gov/digest/4.0")]
    public partial class PersonContactAssociationType : AssociationType
    {
        
        private ReferenceType2 personReferenceField;
        
        private ReferenceType2 contactPersonReferenceField;
        
        private PersonLanguageType contactPersonLanguageField;
        
        private ReferenceType2[] contactPersonLocationReferenceField;
        
        private ReferenceType2[] contactPersonEmailAddressReferenceField;
        
        private ReferenceType2[] contactPersonTelephoneNumberReferenceField;
        
        private TextType contactPersonRelationshipTextField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://niem.gov/niem/niem-core/2.0", Order=0)]
        public ReferenceType2 PersonReference
        {
            get
            {
                return this.personReferenceField;
            }
            set
            {
                this.personReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public ReferenceType2 ContactPersonReference
        {
            get
            {
                return this.contactPersonReferenceField;
            }
            set
            {
                this.contactPersonReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public PersonLanguageType ContactPersonLanguage
        {
            get
            {
                return this.contactPersonLanguageField;
            }
            set
            {
                this.contactPersonLanguageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ContactPersonLocationReference", Order=3)]
        public ReferenceType2[] ContactPersonLocationReference
        {
            get
            {
                return this.contactPersonLocationReferenceField;
            }
            set
            {
                this.contactPersonLocationReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ContactPersonEmailAddressReference", Order=4)]
        public ReferenceType2[] ContactPersonEmailAddressReference
        {
            get
            {
                return this.contactPersonEmailAddressReferenceField;
            }
            set
            {
                this.contactPersonEmailAddressReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ContactPersonTelephoneNumberReference", Order=5)]
        public ReferenceType2[] ContactPersonTelephoneNumberReference
        {
            get
            {
                return this.contactPersonTelephoneNumberReferenceField;
            }
            set
            {
                this.contactPersonTelephoneNumberReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=6)]
        public TextType ContactPersonRelationshipText
        {
            get
            {
                return this.contactPersonRelationshipTextField;
            }
            set
            {
                this.contactPersonRelationshipTextField = value;
            }
        }
    }
}
