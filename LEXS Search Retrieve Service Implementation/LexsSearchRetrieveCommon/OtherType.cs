namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://lexs.gov/digest/4.0")]
    public partial class OtherType : ComplexObjectType
    {
        
        private TextType otherNameField;
        
        private TextType otherDescriptionTextField;
        
        private TextType otherCategoryTextField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public TextType OtherName
        {
            get
            {
                return this.otherNameField;
            }
            set
            {
                this.otherNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public TextType OtherDescriptionText
        {
            get
            {
                return this.otherDescriptionTextField;
            }
            set
            {
                this.otherDescriptionTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public TextType OtherCategoryText
        {
            get
            {
                return this.otherCategoryTextField;
            }
            set
            {
                this.otherCategoryTextField = value;
            }
        }
    }
}
