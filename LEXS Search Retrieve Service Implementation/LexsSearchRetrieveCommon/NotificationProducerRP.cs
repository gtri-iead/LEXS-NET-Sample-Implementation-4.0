namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.oasis-open.org/wsn/b-2")]
    public partial class NotificationProducerRP
    {
        
        private TopicExpressionType[] topicExpressionField;
        
        private bool fixedTopicSetField;
        
        private bool fixedTopicSetFieldSpecified;
        
        private string[] topicExpressionDialectField;
        
        private TopicSetType topicSetField;
        
        public NotificationProducerRP()
        {
            this.fixedTopicSetField = true;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TopicExpression", Order=0)]
        public TopicExpressionType[] TopicExpression
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
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public bool FixedTopicSet
        {
            get
            {
                return this.fixedTopicSetField;
            }
            set
            {
                this.fixedTopicSetField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FixedTopicSetSpecified
        {
            get
            {
                return this.fixedTopicSetFieldSpecified;
            }
            set
            {
                this.fixedTopicSetFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TopicExpressionDialect", DataType="anyURI", Order=2)]
        public string[] TopicExpressionDialect
        {
            get
            {
                return this.topicExpressionDialectField;
            }
            set
            {
                this.topicExpressionDialectField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://docs.oasis-open.org/wsn/t-1", Order=3)]
        public TopicSetType TopicSet
        {
            get
            {
                return this.topicSetField;
            }
            set
            {
                this.topicSetField = value;
            }
        }
    }
}
