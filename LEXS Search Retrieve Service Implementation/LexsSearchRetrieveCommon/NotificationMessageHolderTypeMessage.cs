namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.oasis-open.org/wsn/b-2")]
    public partial class NotificationMessageHolderTypeMessage
    {
        
        private object itemField;
        
        private ItemChoiceType1 itemElementNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DataItemRetrievalSubscriptionNotification", typeof(RetrievalSubscriptionNotificationType), Namespace="http://ulex.gov/subscribenotify/2.0", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("DataItemSearchSubscriptionNotification", typeof(SearchSubscriptionNotificationType), Namespace="http://ulex.gov/subscribenotify/2.0", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("MatchSubscriptionNotification", typeof(MatchSubscriptionNotificationType), Namespace="http://ulex.gov/subscribenotify/2.0", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("SearchSubscriptionNotification", typeof(SearchSubscriptionNotificationType), Namespace="http://ulex.gov/subscribenotify/2.0", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("TopicSubscriptionNotification", typeof(TopicSubscriptionNotificationType), Namespace="http://ulex.gov/subscribenotify/2.0", Order=0)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType1 ItemElementName
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
