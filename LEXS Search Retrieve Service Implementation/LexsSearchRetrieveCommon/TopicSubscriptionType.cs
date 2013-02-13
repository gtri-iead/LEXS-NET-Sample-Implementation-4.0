namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ulex.gov/subscribenotify/2.0")]
    public partial class TopicSubscriptionType
    {
        
        private SNMessageMetadataType sNMessageMetadataField;
        
        private object itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://ulex.gov/ulex/2.0", Order=0)]
        public SNMessageMetadataType SNMessageMetadata
        {
            get
            {
                return this.sNMessageMetadataField;
            }
            set
            {
                this.sNMessageMetadataField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UserAssertion", typeof(DomainAttributeType), Namespace="http://ulex.gov/ulex/2.0", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute("UserAssertionSAML", typeof(UserAssertionSAMLType), Namespace="http://ulex.gov/ulex/2.0", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute("UserAssertion", typeof(UserAssertionType), Namespace="http://lexs.gov/lexs/4.0", IsNullable=false, Order=1)]
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
    }
}
