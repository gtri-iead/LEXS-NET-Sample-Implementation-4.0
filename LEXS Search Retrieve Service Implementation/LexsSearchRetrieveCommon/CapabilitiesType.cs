namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ulex.gov/ulex/2.0")]
    public partial class CapabilitiesType
    {
        
        private DataItemCategoryType[] dataItemCategoryField;
        
        private bool pagingIndicatorField;
        
        private string maxHitsReturnedNumericField;
        
        private StructuredSearchType structuredSearchField;
        
        private TextSearchType textSearchField;
        
        private SubscribeNotifyType subscribeNotifyField;
        
        private DomainAttributeType[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DataItemCategory", Order=0)]
        public DataItemCategoryType[] DataItemCategory
        {
            get
            {
                return this.dataItemCategoryField;
            }
            set
            {
                this.dataItemCategoryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public bool PagingIndicator
        {
            get
            {
                return this.pagingIndicatorField;
            }
            set
            {
                this.pagingIndicatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="nonNegativeInteger", Order=2)]
        public string MaxHitsReturnedNumeric
        {
            get
            {
                return this.maxHitsReturnedNumericField;
            }
            set
            {
                this.maxHitsReturnedNumericField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public StructuredSearchType StructuredSearch
        {
            get
            {
                return this.structuredSearchField;
            }
            set
            {
                this.structuredSearchField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public TextSearchType TextSearch
        {
            get
            {
                return this.textSearchField;
            }
            set
            {
                this.textSearchField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public SubscribeNotifyType SubscribeNotify
        {
            get
            {
                return this.subscribeNotifyField;
            }
            set
            {
                this.subscribeNotifyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CapabilitiesDomainAttribute", Order=6)]
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
