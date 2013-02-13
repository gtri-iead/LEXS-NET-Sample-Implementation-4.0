namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ulex.gov/ulex/2.0")]
    public partial class DataItemGroupIdentifierType
    {
        
        private string dataItemGroupIDField;
        
        private string dataItemGroupCategoryTextField;
        
        private string dataItemGroupReasonTextField;
        
        private string dataItemGroupOriginatorIDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string DataItemGroupID
        {
            get
            {
                return this.dataItemGroupIDField;
            }
            set
            {
                this.dataItemGroupIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string DataItemGroupCategoryText
        {
            get
            {
                return this.dataItemGroupCategoryTextField;
            }
            set
            {
                this.dataItemGroupCategoryTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string DataItemGroupReasonText
        {
            get
            {
                return this.dataItemGroupReasonTextField;
            }
            set
            {
                this.dataItemGroupReasonTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string DataItemGroupOriginatorID
        {
            get
            {
                return this.dataItemGroupOriginatorIDField;
            }
            set
            {
                this.dataItemGroupOriginatorIDField = value;
            }
        }
    }
}
