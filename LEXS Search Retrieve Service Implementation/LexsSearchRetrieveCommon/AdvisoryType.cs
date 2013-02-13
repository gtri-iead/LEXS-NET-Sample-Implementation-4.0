namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ulex.gov/ulex/2.0")]
    public partial class AdvisoryType
    {
        
        private AdvisoryCategoryCodeSimpleType advisoryCategoryCodeField;
        
        private string advisoryTextField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public AdvisoryCategoryCodeSimpleType AdvisoryCategoryCode
        {
            get
            {
                return this.advisoryCategoryCodeField;
            }
            set
            {
                this.advisoryCategoryCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string AdvisoryText
        {
            get
            {
                return this.advisoryTextField;
            }
            set
            {
                this.advisoryTextField = value;
            }
        }
    }
}
