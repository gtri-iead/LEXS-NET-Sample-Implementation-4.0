namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ulex.gov/ulex/2.0")]
    public partial class StructuredSearchType
    {
        
        private bool multipleValueIndicatorField;
        
        private bool wildcardIndicatorField;
        
        private bool fuzzySearchIndicatorField;
        
        private bool dateRangeIndicatorField;
        
        private bool numericRangeIndicatorField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public bool MultipleValueIndicator
        {
            get
            {
                return this.multipleValueIndicatorField;
            }
            set
            {
                this.multipleValueIndicatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public bool FuzzySearchIndicator
        {
            get
            {
                return this.fuzzySearchIndicatorField;
            }
            set
            {
                this.fuzzySearchIndicatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public bool DateRangeIndicator
        {
            get
            {
                return this.dateRangeIndicatorField;
            }
            set
            {
                this.dateRangeIndicatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public bool NumericRangeIndicator
        {
            get
            {
                return this.numericRangeIndicatorField;
            }
            set
            {
                this.numericRangeIndicatorField = value;
            }
        }
    }
}
