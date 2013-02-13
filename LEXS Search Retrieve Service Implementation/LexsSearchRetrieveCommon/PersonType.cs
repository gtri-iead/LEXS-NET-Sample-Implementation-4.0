namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PersonType1))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/niem-core/2.0")]
    public partial class PersonType : ComplexObjectType
    {
        
        private TimeMeasureType[] personAgeMeasureField;
        
        private PersonNameType[] personAlternateNameField;
        
        private DateType[] personBirthDateField;
        
        private CountryCodeType[] itemsField;
        
        private DateType personDeathDateField;
        
        private TextType personDescriptionTextField;
        
        private object itemField;
        
        private object item1Field;
        
        private LengthMeasureType[] personHeightMeasureField;
        
        private boolean personLivingIndicatorField;
        
        private PersonNameType personNameField;
        
        private IdentificationType[] personOtherIdentificationField;
        
        private IdentificationType[] personPassportIdentificationField;
        
        private PersonLanguageType personPrimaryLanguageField;
        
        private object item2Field;
        
        private SEXCodeType item3Field;
        
        private IdentificationType[] personSSNIdentificationField;
        
        private WeightMeasureType[] personWeightMeasureField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonAgeMeasure", IsNullable=true, Order=0)]
        public TimeMeasureType[] PersonAgeMeasure
        {
            get
            {
                return this.personAgeMeasureField;
            }
            set
            {
                this.personAgeMeasureField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonAlternateName", IsNullable=true, Order=1)]
        public PersonNameType[] PersonAlternateName
        {
            get
            {
                return this.personAlternateNameField;
            }
            set
            {
                this.personAlternateNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonBirthDate", IsNullable=true, Order=2)]
        public DateType[] PersonBirthDate
        {
            get
            {
                return this.personBirthDateField;
            }
            set
            {
                this.personBirthDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonCitizenshipFIPS10-4Code", IsNullable=true, Order=3)]
        public CountryCodeType[] Items
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=4)]
        public DateType PersonDeathDate
        {
            get
            {
                return this.personDeathDateField;
            }
            set
            {
                this.personDeathDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=5)]
        public TextType PersonDescriptionText
        {
            get
            {
                return this.personDescriptionTextField;
            }
            set
            {
                this.personDescriptionTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonEyeColorCode", typeof(EYECodeType), IsNullable=true, Order=6)]
        [System.Xml.Serialization.XmlElementAttribute("PersonEyeColorText", typeof(TextType), IsNullable=true, Order=6)]
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
        [System.Xml.Serialization.XmlElementAttribute("PersonHairColorCode", typeof(HAICodeType), IsNullable=true, Order=7)]
        [System.Xml.Serialization.XmlElementAttribute("PersonHairColorText", typeof(TextType), IsNullable=true, Order=7)]
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
        [System.Xml.Serialization.XmlElementAttribute("PersonHeightMeasure", IsNullable=true, Order=8)]
        public LengthMeasureType[] PersonHeightMeasure
        {
            get
            {
                return this.personHeightMeasureField;
            }
            set
            {
                this.personHeightMeasureField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=9)]
        public boolean PersonLivingIndicator
        {
            get
            {
                return this.personLivingIndicatorField;
            }
            set
            {
                this.personLivingIndicatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=10)]
        public PersonNameType PersonName
        {
            get
            {
                return this.personNameField;
            }
            set
            {
                this.personNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonOtherIdentification", IsNullable=true, Order=11)]
        public IdentificationType[] PersonOtherIdentification
        {
            get
            {
                return this.personOtherIdentificationField;
            }
            set
            {
                this.personOtherIdentificationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonPassportIdentification", IsNullable=true, Order=12)]
        public IdentificationType[] PersonPassportIdentification
        {
            get
            {
                return this.personPassportIdentificationField;
            }
            set
            {
                this.personPassportIdentificationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=13)]
        public PersonLanguageType PersonPrimaryLanguage
        {
            get
            {
                return this.personPrimaryLanguageField;
            }
            set
            {
                this.personPrimaryLanguageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonRaceCode", typeof(RACCodeType), IsNullable=true, Order=14)]
        [System.Xml.Serialization.XmlElementAttribute("PersonRaceText", typeof(TextType), IsNullable=true, Order=14)]
        public object Item2
        {
            get
            {
                return this.item2Field;
            }
            set
            {
                this.item2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonSexCode", IsNullable=true, Order=15)]
        public SEXCodeType Item3
        {
            get
            {
                return this.item3Field;
            }
            set
            {
                this.item3Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonSSNIdentification", IsNullable=true, Order=16)]
        public IdentificationType[] PersonSSNIdentification
        {
            get
            {
                return this.personSSNIdentificationField;
            }
            set
            {
                this.personSSNIdentificationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonWeightMeasure", IsNullable=true, Order=17)]
        public WeightMeasureType[] PersonWeightMeasure
        {
            get
            {
                return this.personWeightMeasureField;
            }
            set
            {
                this.personWeightMeasureField = value;
            }
        }
    }
}
