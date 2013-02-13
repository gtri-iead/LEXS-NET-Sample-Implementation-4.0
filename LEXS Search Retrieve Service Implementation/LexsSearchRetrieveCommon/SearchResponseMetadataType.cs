namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ulex.gov/ulex/2.0")]
    public partial class SearchResponseMetadataType
    {
        
        private string maxItemMatchesRequestedNumericField;
        
        private string numberItemMatchesTextField;
        
        private bool serverLimitIndicatorField;
        
        private string matchBeginPointTextField;
        
        private string matchEndPointTextField;
        
        private StructuredQueryType performedStructuredQueryField;
        
        private StructuredQueryType requestedStructuredQueryField;
        
        private string serviceProviderSearchIDField;
        
        private DomainAttributeType[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="nonNegativeInteger", Order=0)]
        public string MaxItemMatchesRequestedNumeric
        {
            get
            {
                return this.maxItemMatchesRequestedNumericField;
            }
            set
            {
                this.maxItemMatchesRequestedNumericField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string NumberItemMatchesText
        {
            get
            {
                return this.numberItemMatchesTextField;
            }
            set
            {
                this.numberItemMatchesTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public bool ServerLimitIndicator
        {
            get
            {
                return this.serverLimitIndicatorField;
            }
            set
            {
                this.serverLimitIndicatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string MatchBeginPointText
        {
            get
            {
                return this.matchBeginPointTextField;
            }
            set
            {
                this.matchBeginPointTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string MatchEndPointText
        {
            get
            {
                return this.matchEndPointTextField;
            }
            set
            {
                this.matchEndPointTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public StructuredQueryType PerformedStructuredQuery
        {
            get
            {
                return this.performedStructuredQueryField;
            }
            set
            {
                this.performedStructuredQueryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public StructuredQueryType RequestedStructuredQuery
        {
            get
            {
                return this.requestedStructuredQueryField;
            }
            set
            {
                this.requestedStructuredQueryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string ServiceProviderSearchID
        {
            get
            {
                return this.serviceProviderSearchIDField;
            }
            set
            {
                this.serviceProviderSearchIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SearchResponseMetadataDomainAttribute", Order=8)]
        public DomainAttributeType[] Items
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
    }
}
