namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ulex.gov/ulex/2.0")]
    public partial class ResponseMetadataType
    {
        
        private ResultCodeSimpleType resultCodeField;
        
        private bool resultCodeFieldSpecified;
        
        private AdvisoryType[] advisoryField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ResultCodeSimpleType ResultCode
        {
            get
            {
                return this.resultCodeField;
            }
            set
            {
                this.resultCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ResultCodeSpecified
        {
            get
            {
                return this.resultCodeFieldSpecified;
            }
            set
            {
                this.resultCodeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Advisory", Order=1)]
        public AdvisoryType[] Advisory
        {
            get
            {
                return this.advisoryField;
            }
            set
            {
                this.advisoryField = value;
            }
        }
    }
}
