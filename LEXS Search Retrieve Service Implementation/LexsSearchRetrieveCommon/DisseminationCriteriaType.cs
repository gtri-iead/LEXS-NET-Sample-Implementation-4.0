namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://lexs.gov/lexs/4.0")]
    public partial class DisseminationCriteriaType : ComplexObjectType
    {
        
        private @string disseminationCriteriaDomainNameField;
        
        private @string disseminationCriteriaTextField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public @string DisseminationCriteriaDomainName
        {
            get
            {
                return this.disseminationCriteriaDomainNameField;
            }
            set
            {
                this.disseminationCriteriaDomainNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public @string DisseminationCriteriaText
        {
            get
            {
                return this.disseminationCriteriaTextField;
            }
            set
            {
                this.disseminationCriteriaTextField = value;
            }
        }
    }
}
