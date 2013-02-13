namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ulex.gov/subscribenotify/2.0")]
    public partial class SubscriptionType
    {
        
        private SNMessageMetadataType sNMessageMetadataField;
        
        private SearchRequestMetadataType searchRequestMetadataField;
        
        private object itemField;
        
        private object item1Field;
        
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://ulex.gov/ulex/2.0", Order=1)]
        public SearchRequestMetadataType SearchRequestMetadata
        {
            get
            {
                return this.searchRequestMetadataField;
            }
            set
            {
                this.searchRequestMetadataField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UserAssertion", typeof(DomainAttributeType), Namespace="http://ulex.gov/ulex/2.0", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute("UserAssertionSAML", typeof(UserAssertionSAMLType), Namespace="http://ulex.gov/ulex/2.0", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute("UserAssertion", typeof(UserAssertionType), Namespace="http://lexs.gov/lexs/4.0", IsNullable=false, Order=2)]
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
        [System.Xml.Serialization.XmlElementAttribute("SubscriptionDataItemMetadataQuery", typeof(SubscriptionDataItemMetadataQueryType), Namespace="http://ulex.gov/ulex/2.0", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute("SubscriptionStructuredQuery", typeof(SubscriptionStructuredQueryType), Namespace="http://ulex.gov/ulex/2.0", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute("SubscriptionTextQuery", typeof(SubscriptionTextQueryType), Namespace="http://ulex.gov/ulex/2.0", Order=3)]
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
