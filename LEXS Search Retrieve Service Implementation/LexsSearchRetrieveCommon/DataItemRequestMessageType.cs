namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ulex.gov/ulex/2.0")]
    public partial class DataItemRequestMessageType : RequestMessageType
    {
        
        private string dataItemIDField;
        
        private object item1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string DataItemID
        {
            get
            {
                return this.dataItemIDField;
            }
            set
            {
                this.dataItemIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("StructuredPayloadsRequestedCode", typeof(StructuredPayloadsRequestedCodeSimpleType), Order=1)]
        [System.Xml.Serialization.XmlElementAttribute("StructuredPayloadsRequestedList", typeof(StructuredPayloadsRequestedListType), Order=1)]
        public object Item1
        {
            get
            {
                return this.item1Field;
            }
            set
            {
                this.item1Field = value;
            }
        }
    }
}
