namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ulex.gov/ulex/2.0")]
    public partial class DomainRequestMessageType
    {
        
        private DEMessageMetadataType dEMessageMetadataField;
        
        private object itemField;
        
        private object userAttentionToAbstractField;
        
        private DomainAttributeType[] domainAttributeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public DEMessageMetadataType DEMessageMetadata
        {
            get
            {
                return this.dEMessageMetadataField;
            }
            set
            {
                this.dEMessageMetadataField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UserAssertion", typeof(DomainAttributeType), Order=1)]
        [System.Xml.Serialization.XmlElementAttribute("UserAssertionSAML", typeof(UserAssertionSAMLType), Order=1)]
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        [System.Xml.Serialization.XmlElementAttribute("UserAttentionTo", typeof(UserAssertionType), Namespace="http://lexs.gov/lexs/4.0", IsNullable=false, Order=2)]
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DomainAttribute", Order=3)]
        public DomainAttributeType[] DomainAttribute
        {
            get
            {
                return this.domainAttributeField;
            }
            set
            {
                this.domainAttributeField = value;
            }
        }
    }
}
