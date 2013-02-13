namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ulex.gov/ulex/2.0")]
    public partial class MatchObjectDetailsType
    {
        
        private ValidatingObjectReferenceType matchDigestEntityReferenceField;
        
        private MatchDigestElementReferenceType[] matchDigestElementReferenceField;
        
        private NonValidatingObjectReferenceType matchStructuredPayloadEntityReferenceField;
        
        private MatchStructuredPayloadElementReferenceType[] matchStructuredPayloadElementReferenceField;
        
        private string matchObjectDescriptionTextField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ValidatingObjectReferenceType MatchDigestEntityReference
        {
            get
            {
                return this.matchDigestEntityReferenceField;
            }
            set
            {
                this.matchDigestEntityReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MatchDigestElementReference", Order=1)]
        public MatchDigestElementReferenceType[] MatchDigestElementReference
        {
            get
            {
                return this.matchDigestElementReferenceField;
            }
            set
            {
                this.matchDigestElementReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public NonValidatingObjectReferenceType MatchStructuredPayloadEntityReference
        {
            get
            {
                return this.matchStructuredPayloadEntityReferenceField;
            }
            set
            {
                this.matchStructuredPayloadEntityReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MatchStructuredPayloadElementReference", Order=3)]
        public MatchStructuredPayloadElementReferenceType[] MatchStructuredPayloadElementReference
        {
            get
            {
                return this.matchStructuredPayloadElementReferenceField;
            }
            set
            {
                this.matchStructuredPayloadElementReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string MatchObjectDescriptionText
        {
            get
            {
                return this.matchObjectDescriptionTextField;
            }
            set
            {
                this.matchObjectDescriptionTextField = value;
            }
        }
    }
}
