namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ulex.gov/ulex/2.0")]
    public partial class SubscribeNotifyType
    {
        
        private bool matchSubscriptionIndicatorField;
        
        private bool identicalSearchSubscriptionIndicatorField;
        
        private bool similarSearchSubscriptionIndicatorField;
        
        private bool dataItemSearchSubscriptionIndicatorField;
        
        private bool dataItemRetrievalSubscriptionIndicatorField;
        
        private NotificationProducerRP notificationProducerRPField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public bool MatchSubscriptionIndicator
        {
            get
            {
                return this.matchSubscriptionIndicatorField;
            }
            set
            {
                this.matchSubscriptionIndicatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public bool IdenticalSearchSubscriptionIndicator
        {
            get
            {
                return this.identicalSearchSubscriptionIndicatorField;
            }
            set
            {
                this.identicalSearchSubscriptionIndicatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public bool SimilarSearchSubscriptionIndicator
        {
            get
            {
                return this.similarSearchSubscriptionIndicatorField;
            }
            set
            {
                this.similarSearchSubscriptionIndicatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public bool DataItemSearchSubscriptionIndicator
        {
            get
            {
                return this.dataItemSearchSubscriptionIndicatorField;
            }
            set
            {
                this.dataItemSearchSubscriptionIndicatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public bool DataItemRetrievalSubscriptionIndicator
        {
            get
            {
                return this.dataItemRetrievalSubscriptionIndicatorField;
            }
            set
            {
                this.dataItemRetrievalSubscriptionIndicatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://docs.oasis-open.org/wsn/b-2", Order=5)]
        public NotificationProducerRP NotificationProducerRP
        {
            get
            {
                return this.notificationProducerRPField;
            }
            set
            {
                this.notificationProducerRPField = value;
            }
        }
    }
}
