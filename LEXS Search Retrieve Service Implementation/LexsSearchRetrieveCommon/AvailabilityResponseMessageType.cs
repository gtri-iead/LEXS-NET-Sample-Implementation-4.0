namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ulex.gov/ulex/2.0")]
    public partial class AvailabilityResponseMessageType : ResponseMessageType
    {
        
        private bool serviceAvailableIndicatorField;
        
        private string additionalInformationTextField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public bool ServiceAvailableIndicator
        {
            get
            {
                return this.serviceAvailableIndicatorField;
            }
            set
            {
                this.serviceAvailableIndicatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string AdditionalInformationText
        {
            get
            {
                return this.additionalInformationTextField;
            }
            set
            {
                this.additionalInformationTextField = value;
            }
        }
    }
}
