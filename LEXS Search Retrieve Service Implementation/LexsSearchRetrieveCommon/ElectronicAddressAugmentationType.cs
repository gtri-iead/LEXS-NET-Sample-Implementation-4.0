namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://lexs.gov/digest/4.0")]
    public partial class ElectronicAddressAugmentationType : AugmentationType
    {
        
        private DateType[] electronicAddressCaptureDateField;
        
        private TextType electronicAddressDescriptionTextField;
        
        private IdentificationType[] electronicAddressHardwareAddressIdentificationField;
        
        private TextType[] serviceProviderNameTextField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ElectronicAddressCaptureDate", IsNullable=true, Order=0)]
        public DateType[] ElectronicAddressCaptureDate
        {
            get
            {
                return this.electronicAddressCaptureDateField;
            }
            set
            {
                this.electronicAddressCaptureDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public TextType ElectronicAddressDescriptionText
        {
            get
            {
                return this.electronicAddressDescriptionTextField;
            }
            set
            {
                this.electronicAddressDescriptionTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ElectronicAddressHardwareAddressIdentification", IsNullable=true, Order=2)]
        public IdentificationType[] ElectronicAddressHardwareAddressIdentification
        {
            get
            {
                return this.electronicAddressHardwareAddressIdentificationField;
            }
            set
            {
                this.electronicAddressHardwareAddressIdentificationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ServiceProviderNameText", IsNullable=true, Order=3)]
        public TextType[] ServiceProviderNameText
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
