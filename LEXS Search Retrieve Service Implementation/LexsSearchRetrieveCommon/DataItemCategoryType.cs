namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ulex.gov/ulex/2.0")]
    public partial class DataItemCategoryType
    {
        
        private string dataItemCategoryTextField;
        
        private string dataItemCategoryDescriptionTextField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string DataItemCategoryText
        {
            get
            {
                return this.dataItemCategoryTextField;
            }
            set
            {
                this.dataItemCategoryTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string DataItemCategoryDescriptionText
        {
            get
            {
                return this.dataItemCategoryDescriptionTextField;
            }
            set
            {
                this.dataItemCategoryDescriptionTextField = value;
            }
        }
    }
}
