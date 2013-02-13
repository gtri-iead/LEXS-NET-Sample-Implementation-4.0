namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ulex.gov/ulex/2.0")]
    public partial class TextSearchType
    {
        
        private bool exactPhraseIndicatorField;
        
        private bool logicalOperatorIndicatorField;
        
        private bool wildcardIndicatorField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public bool ExactPhraseIndicator
        {
            get
            {
                return this.exactPhraseIndicatorField;
            }
            set
            {
                this.exactPhraseIndicatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public bool LogicalOperatorIndicator
        {
            get
            {
                return this.logicalOperatorIndicatorField;
            }
            set
            {
                this.logicalOperatorIndicatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public bool WildcardIndicator
        {
            get
            {
                return this.wildcardIndicatorField;
            }
            set
            {
                this.wildcardIndicatorField = value;
            }
        }
    }
}
