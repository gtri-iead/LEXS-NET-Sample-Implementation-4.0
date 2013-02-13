namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ulex.gov/searchretrieve/2.0")]
    public partial class getDataItemRequestType
    {
        
        private DataItemRequestMessageType dataItemRequestMessageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://ulex.gov/ulex/2.0", Order=0)]
        public DataItemRequestMessageType DataItemRequestMessage
        {
            get
            {
                return this.dataItemRequestMessageField;
            }
            set
            {
                this.dataItemRequestMessageField = value;
            }
        }
    }
}
