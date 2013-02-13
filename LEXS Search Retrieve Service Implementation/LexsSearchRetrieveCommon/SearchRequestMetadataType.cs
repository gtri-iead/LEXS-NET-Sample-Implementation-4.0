namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ulex.gov/ulex/2.0")]
    public partial class SearchRequestMetadataType
    {
        
        private object[] requestedDataAbstractField;
        
        private object[] dataOwnerIdentifierAbstractField;
        
        private string maxItemMatchesNumericField;
        
        private string matchBeginAfterTextField;
        
        private string matchEndBeforeTextField;
        
        private string serviceProviderSearchIDField;
        
        private string[] dataItemCategoryTextField;
        
        private object sortOrderAbstractField;
        
        private string timeoutDurationField;
        
        private NumberOfStructuredPayloadTermsType[] numberOfStructuredPayloadTermsField;
        
        private object itemField;
        
        private DomainAttributeType[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RequestedDataAbstract", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("RequestedDataCategoryCode", typeof(DataCategoryCodeType), Namespace="http://lexs.gov/lexs/4.0", IsNullable=false, Order=0)]
        public object[] RequestedDataAbstract
        {
            get
            {
                return this.requestedDataAbstractField;
            }
            set
            {
                this.requestedDataAbstractField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DataOwnerIdentifierAbstract", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute("DataOwnerIdentifier", typeof(DataOwnerIdentifierType), Namespace="http://lexs.gov/lexs/4.0", IsNullable=false, Order=1)]
        public object[] DataOwnerIdentifierAbstract
        {
            get
            {
                return this.dataOwnerIdentifierAbstractField;
            }
            set
            {
                this.dataOwnerIdentifierAbstractField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="nonNegativeInteger", Order=2)]
        public string MaxItemMatchesNumeric
        {
            get
            {
                return this.maxItemMatchesNumericField;
            }
            set
            {
                this.maxItemMatchesNumericField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string MatchBeginAfterText
        {
            get
            {
                return this.matchBeginAfterTextField;
            }
            set
            {
                this.matchBeginAfterTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string MatchEndBeforeText
        {
            get
            {
                return this.matchEndBeforeTextField;
            }
            set
            {
                this.matchEndBeforeTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
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
        [System.Xml.Serialization.XmlElementAttribute("DataItemCategoryText", Order=6)]
        public string[] DataItemCategoryText
        {
            get
            {
                return this.dataItemCategoryTextField;
            }
            set
            {
                this.dataItemCategoryTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        [System.Xml.Serialization.XmlElementAttribute("SortOrderCode", typeof(SortOrderCodeType), Namespace="http://lexs.gov/lexs/4.0", IsNullable=false, Order=7)]
        public object SortOrderAbstract
        {
            get
            {
                return this.sortOrderAbstractField;
            }
            set
            {
                this.sortOrderAbstractField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="duration", Order=8)]
        public string TimeoutDuration
        {
            get
            {
                return this.timeoutDurationField;
            }
            set
            {
                this.timeoutDurationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NumberOfStructuredPayloadTerms", Order=9)]
        public NumberOfStructuredPayloadTermsType[] NumberOfStructuredPayloadTerms
        {
            get
            {
                return this.numberOfStructuredPayloadTermsField;
            }
            set
            {
                this.numberOfStructuredPayloadTermsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("StructuredPayloadsRequestedCode", typeof(StructuredPayloadsRequestedCodeSimpleType), Order=10)]
        [System.Xml.Serialization.XmlElementAttribute("StructuredPayloadsRequestedList", typeof(StructuredPayloadsRequestedListType), Order=10)]
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
        [System.Xml.Serialization.XmlElementAttribute("SearchRequestMetadataDomainAttribute", Order=11)]
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
