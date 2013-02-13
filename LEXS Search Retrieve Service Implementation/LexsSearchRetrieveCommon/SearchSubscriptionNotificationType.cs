namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ulex.gov/subscribenotify/2.0")]
    public partial class SearchSubscriptionNotificationType
    {
        
        private SNMessageMetadataType sNMessageMetadataField;
        
        private OriginMetadataType searchOriginMetadataField;
        
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://ulex.gov/ulex/2.0", Order=1)]
        public OriginMetadataType SearchOriginMetadata
        {
            get
            {
                return this.searchOriginMetadataField;
            }
            set
            {
                this.searchOriginMetadataField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SubscriptionDataItemMetadataQuery", typeof(SubscriptionDataItemMetadataQueryType), Namespace="http://ulex.gov/ulex/2.0", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute("SubscriptionStructuredQuery", typeof(SubscriptionStructuredQueryType), Namespace="http://ulex.gov/ulex/2.0", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute("SubscriptionTextQuery", typeof(SubscriptionTextQueryType), Namespace="http://ulex.gov/ulex/2.0", Order=2)]
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
