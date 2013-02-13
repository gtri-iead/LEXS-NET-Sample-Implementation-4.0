namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.oasis-open.org/wsn/b-2")]
    public partial class FilterType
    {
        
        private TopicExpressionType topicExpressionField;
        
        private object itemField;
        
        private ItemChoiceType itemElementNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public TopicExpressionType TopicExpression
        {
            get
            {
                return this.topicExpressionField;
            }
            set
            {
                this.topicExpressionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DataItemRetrievalSubscription", typeof(DataItemSubscriptionType), Namespace="http://ulex.gov/subscribenotify/2.0", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute("DataItemSearchSubscription", typeof(DataItemSubscriptionType), Namespace="http://ulex.gov/subscribenotify/2.0", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute("IdenticalSearchSubscription", typeof(SubscriptionType), Namespace="http://ulex.gov/subscribenotify/2.0", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute("MatchSubscription", typeof(SubscriptionType), Namespace="http://ulex.gov/subscribenotify/2.0", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute("SimilarSearchSubscription", typeof(SubscriptionType), Namespace="http://ulex.gov/subscribenotify/2.0", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute("TopicSubscription", typeof(TopicSubscriptionType), Namespace="http://ulex.gov/subscribenotify/2.0", Order=1)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }
    }
}
