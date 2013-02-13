namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://lexs.gov/digest/4.0")]
    public partial class EmailAddressType : ComplexObjectType
    {
        
        private @string emailAddressIDField;
        
        private TextType emailAddressDescriptionTextField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public @string EmailAddressID
        {
            get
            {
                return this.emailAddressIDField;
            }
            set
            {
                this.emailAddressIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public TextType EmailAddressDescriptionText
        {
            get
            {
                return this.emailAddressDescriptionTextField;
            }
            set
            {
                this.emailAddressDescriptionTextField = value;
            }
        }
    }
}
