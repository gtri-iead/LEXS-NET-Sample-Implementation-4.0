namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://lexs.gov/digest/4.0")]
    public partial class InstantMessengerAugmentationType : AugmentationType
    {
        
        private TextType instantMessengerDescriptionTextField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public TextType InstantMessengerDescriptionText
        {
            get
            {
                return this.instantMessengerDescriptionTextField;
            }
            set
            {
                this.instantMessengerDescriptionTextField = value;
            }
        }
    }
}
