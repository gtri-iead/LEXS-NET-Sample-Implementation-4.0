namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UnableToDestroySubscriptionFaultType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UnacceptableTerminationTimeFaultType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UnacceptableInitialTerminationTimeFaultType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TopicNotSupportedFaultType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InvalidTopicExpressionFaultType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TopicExpressionDialectUnknownFaultType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(InvalidFilterFaultType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SubscribeCreationFailedFaultType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.oasis-open.org/wsrf/bf-2")]
    public partial class BaseFaultType
    {
        
        private System.Xml.XmlElement[] anyField;
        
        private System.DateTime timestampField;
        
        private EndpointReferenceType originatorField;
        
        private BaseFaultTypeErrorCode errorCodeField;
        
        private BaseFaultTypeDescription[] descriptionField;
        
        private System.Xml.XmlElement faultCauseField;
        
        private System.Xml.XmlAttribute[] anyAttrField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
        public System.Xml.XmlElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public System.DateTime Timestamp
        {
            get
            {
                return this.timestampField;
            }
            set
            {
                this.timestampField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public EndpointReferenceType Originator
        {
            get
            {
                return this.originatorField;
            }
            set
            {
                this.originatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public BaseFaultTypeErrorCode ErrorCode
        {
            get
            {
                return this.errorCodeField;
            }
            set
            {
                this.errorCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description", Order=4)]
        public BaseFaultTypeDescription[] Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public System.Xml.XmlElement FaultCause
        {
            get
            {
                return this.faultCauseField;
            }
            set
            {
                this.faultCauseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr
        {
            get
            {
                return this.anyAttrField;
            }
            set
            {
                this.anyAttrField = value;
            }
        }
    }
}
