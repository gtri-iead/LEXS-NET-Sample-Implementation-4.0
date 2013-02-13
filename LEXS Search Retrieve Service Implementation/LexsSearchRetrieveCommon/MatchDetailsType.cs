namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ulex.gov/ulex/2.0")]
    public partial class MatchDetailsType
    {
        
        private MatchObjectDetailsType[] matchObjectDetailsField;
        
        private string snippetTextField;
        
        private decimal structuredQueryMatchScorePercentField;
        
        private bool structuredQueryMatchScorePercentFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MatchObjectDetails", Order=0)]
        public MatchObjectDetailsType[] MatchObjectDetails
        {
            get
            {
                return this.matchObjectDetailsField;
            }
            set
            {
                this.matchObjectDetailsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string SnippetText
        {
            get
            {
                return this.snippetTextField;
            }
            set
            {
                this.snippetTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public decimal StructuredQueryMatchScorePercent
        {
            get
            {
                return this.structuredQueryMatchScorePercentField;
            }
            set
            {
                this.structuredQueryMatchScorePercentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StructuredQueryMatchScorePercentSpecified
        {
            get
            {
                return this.structuredQueryMatchScorePercentFieldSpecified;
            }
            set
            {
                this.structuredQueryMatchScorePercentFieldSpecified = value;
            }
        }
    }
}
