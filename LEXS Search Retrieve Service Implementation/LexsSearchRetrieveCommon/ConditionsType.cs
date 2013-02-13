namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:tc:SAML:2.0:assertion")]
    public partial class ConditionsType
    {
        
        private ConditionAbstractType[] itemsField;
        
        private System.DateTime notBeforeField;
        
        private bool notBeforeFieldSpecified;
        
        private System.DateTime notOnOrAfterField;
        
        private bool notOnOrAfterFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AudienceRestriction", typeof(AudienceRestrictionType), Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("Condition", typeof(ConditionAbstractType), Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("OneTimeUse", typeof(OneTimeUseType), Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("ProxyRestriction", typeof(ProxyRestrictionType), Order=0)]
        public ConditionAbstractType[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime NotBefore
        {
            get
            {
                return this.notBeforeField;
            }
            set
            {
                this.notBeforeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NotBeforeSpecified
        {
            get
            {
                return this.notBeforeFieldSpecified;
            }
            set
            {
                this.notBeforeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime NotOnOrAfter
        {
            get
            {
                return this.notOnOrAfterField;
            }
            set
            {
                this.notOnOrAfterField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NotOnOrAfterSpecified
        {
            get
            {
                return this.notOnOrAfterFieldSpecified;
            }
            set
            {
                this.notOnOrAfterFieldSpecified = value;
            }
        }
    }
}
