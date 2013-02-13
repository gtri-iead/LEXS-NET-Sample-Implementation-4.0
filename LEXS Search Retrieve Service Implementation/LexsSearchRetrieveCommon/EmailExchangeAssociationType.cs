namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://lexs.gov/digest/4.0")]
    public partial class EmailExchangeAssociationType : AssociationType
    {
        
        private EmailExchangeParticipantType[] emailExchangeParticipantField;
        
        private TextType exchangeFrequencyTextField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EmailExchangeParticipant", IsNullable=true, Order=0)]
        public EmailExchangeParticipantType[] EmailExchangeParticipant
        {
            get
            {
                return this.emailExchangeParticipantField;
            }
            set
            {
                this.emailExchangeParticipantField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public TextType ExchangeFrequencyText
        {
            get
            {
                return this.exchangeFrequencyTextField;
            }
            set
            {
                this.exchangeFrequencyTextField = value;
            }
        }
    }
}
