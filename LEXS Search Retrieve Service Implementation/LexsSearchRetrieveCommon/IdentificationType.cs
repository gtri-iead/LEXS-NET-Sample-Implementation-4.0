namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PersonBOPRegisterNumberType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/niem-core/2.0")]
    public partial class IdentificationType : ComplexObjectType
    {
        
        private @string identificationIDField;
        
        private object itemField;
        
        private DateType identificationEffectiveDateField;
        
        private DateType identificationExpirationDateField;
        
        private object item1Field;
        
        private TextType identificationSourceTextField;
        
        private StatusType identificationStatusField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public @string IdentificationID
        {
            get
            {
                return this.identificationIDField;
            }
            set
            {
                this.identificationIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IdentificationCategoryText", IsNullable=true, Order=1)]
        [System.Xml.Serialization.XmlElementAttribute("PersonIDCategoryCode", typeof(MNUCodeType), Namespace="http://niem.gov/niem/domains/jxdm/4.1", IsNullable=true, Order=1)]
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

        // Note: This is a manual modification to prevent NULL elements from being serialized
        public bool ShouldSerializeIdentificationEffectiveDate()
        {
            return IdentificationEffectiveDate != null;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public DateType IdentificationEffectiveDate
        {
            get
            {
                return this.identificationEffectiveDateField;
            }
            set
            {
                this.identificationEffectiveDateField = value;
            }
        }
        
        
        // Note: This is a manual modification to prevent NULL elements from being serialized
        public bool ShouldSerializeIdentificationExpirationDate()
        {
            return IdentificationExpirationDate != null;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public DateType IdentificationExpirationDate
        {
            get
            {
                return this.identificationExpirationDateField;
            }
            set
            {
                this.identificationExpirationDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IdentificationJurisdictionFIPS10-4Code", typeof(CountryCodeType), IsNullable=true, Order=4)]
        [System.Xml.Serialization.XmlElementAttribute("IdentificationJurisdictionText", typeof(TextType), IsNullable=true, Order=4)]
        [System.Xml.Serialization.XmlElementAttribute("IdentificationJurisdictionNCICLISCode", typeof(LISCodeType), Namespace="http://niem.gov/niem/domains/jxdm/4.1", IsNullable=true, Order=4)]
        [System.Xml.Serialization.XmlElementAttribute("IdentificationJurisdictionNCICRESCode", typeof(RESCodeType), Namespace="http://niem.gov/niem/domains/jxdm/4.1", IsNullable=true, Order=4)]
        public object Item1
        {
            get
            {
                return this.item1Field;
            }
            set
            {
                this.item1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=5)]
        public TextType IdentificationSourceText
        {
            get
            {
                return this.identificationSourceTextField;
            }
            set
            {
                this.identificationSourceTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=6)]
        public StatusType IdentificationStatus
        {
            get
            {
                return this.identificationStatusField;
            }
            set
            {
                this.identificationStatusField = value;
            }
        }
    }
}
