namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="PersonAugmentationType", Namespace="http://lexs.gov/digest/4.0")]
    public partial class PersonAugmentationType1 : AugmentationType
    {
        
        private IdentificationType[] alienNumberField;
        
        private PersonBOPRegisterNumberType[] personBOPRegisterNumberField;
        
        private IdentificationType[] personUSMSFugitiveIdentificationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AlienNumber", Namespace="http://niem.gov/niem/domains/immigration/2.1", IsNullable=true, Order=0)]
        public IdentificationType[] AlienNumber
        {
            get
            {
                return this.alienNumberField;
            }
            set
            {
                this.alienNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonBOPRegisterNumber", IsNullable=true, Order=1)]
        public PersonBOPRegisterNumberType[] PersonBOPRegisterNumber
        {
            get
            {
                return this.personBOPRegisterNumberField;
            }
            set
            {
                this.personBOPRegisterNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonUSMSFugitiveIdentification", IsNullable=true, Order=2)]
        public IdentificationType[] PersonUSMSFugitiveIdentification
        {
            get
            {
                return this.personUSMSFugitiveIdentificationField;
            }
            set
            {
                this.personUSMSFugitiveIdentificationField = value;
            }
        }
    }
}
