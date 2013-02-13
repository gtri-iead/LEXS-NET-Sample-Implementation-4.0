namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.oasis-open.org/wsn/b-2")]
    public partial class NotificationMessageHolderType
    {
        
        private EndpointReferenceType subscriptionReferenceField;
        
        private TopicExpressionType topicField;
        
        private EndpointReferenceType producerReferenceField;
        
        private NotificationMessageHolderTypeMessage messageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public EndpointReferenceType SubscriptionReference
        {
            get
            {
                return this.subscriptionReferenceField;
            }
            set
            {
                this.subscriptionReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public TopicExpressionType Topic
        {
            get
            {
                return this.topicField;
            }
            set
            {
                this.topicField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public EndpointReferenceType ProducerReference
        {
            get
            {
                return this.producerReferenceField;
            }
            set
            {
                this.producerReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public NotificationMessageHolderTypeMessage Message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }
    }
}
