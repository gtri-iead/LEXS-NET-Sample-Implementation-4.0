namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="TelephoneNumberType", Namespace="http://lexs.gov/digest/4.0")]
    public partial class TelephoneNumberType1 : TelephoneNumberType
    {
        
        private TelephoneNumberCategoryCodeType telephoneNumberCategoryCodeField;
        
        private TextType telephoneNumberCategoryTextField;
        
        private TextType telephoneNumberDescriptionTextField;
        
        private TextType serviceProviderNameTextField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public TelephoneNumberCategoryCodeType TelephoneNumberCategoryCode
        {
            get
            {
                return this.telephoneNumberCategoryCodeField;
            }
            set
            {
                this.telephoneNumberCategoryCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public TextType TelephoneNumberCategoryText
        {
            get
            {
                return this.telephoneNumberCategoryTextField;
            }
            set
            {
                this.telephoneNumberCategoryTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public TextType TelephoneNumberDescriptionText
        {
            get
            {
                return this.telephoneNumberDescriptionTextField;
            }
            set
            {
                this.telephoneNumberDescriptionTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public TextType ServiceProviderNameText
        {
            get
            {
                return this.serviceProviderNameTextField;
            }
            set
            {
                this.serviceProviderNameTextField = value;
            }
        }
    }
}
