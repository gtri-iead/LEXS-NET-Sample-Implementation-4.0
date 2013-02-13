namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SearchRequestMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TextSearchRequestMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StructuredSearchRequestMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DataItemMetadataSearchRequestMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AttachmentSearchRequestMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DataItemRequestMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AttachmentRequestMessageType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ulex.gov/ulex/2.0")]
    public partial class RequestMessageType : SRMessageType
    {
        
        private object itemField;
        
        private object userAttentionToAbstractField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UserAssertion", typeof(DomainAttributeType), Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("UserAssertionSAML", typeof(UserAssertionSAMLType), Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("UserAssertion", typeof(UserAssertionType), Namespace="http://lexs.gov/lexs/4.0", IsNullable=false, Order=0)]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        [System.Xml.Serialization.XmlElementAttribute("UserAttentionTo", typeof(UserAssertionType), Namespace="http://lexs.gov/lexs/4.0", IsNullable=false, Order=1)]
        public object UserAttentionToAbstract
        {
            get
            {
                return this.userAttentionToAbstractField;
            }
            set
            {
                this.userAttentionToAbstractField = value;
            }
        }
    }
}
