namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://lexs.gov/digest/4.0")]
    public partial class TelephoneCallExchangeAssociationType : AssociationType
    {
        
        private TextType exchangeFrequencyTextField;
        
        private TelephoneCallExchangeParticipantType[] telephoneCallExchangeParticipantField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TelephoneCallExchangeParticipant", IsNullable=true, Order=1)]
        public TelephoneCallExchangeParticipantType[] TelephoneCallExchangeParticipant
        {
            get
            {
                return this.telephoneCallExchangeParticipantField;
            }
            set
            {
                this.telephoneCallExchangeParticipantField = value;
            }
        }
    }
}
