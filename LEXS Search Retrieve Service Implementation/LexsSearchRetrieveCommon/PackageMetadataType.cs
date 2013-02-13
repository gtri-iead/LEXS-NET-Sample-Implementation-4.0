namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ulex.gov/ulex/2.0")]
    public partial class PackageMetadataType
    {
        
        private string dataItemIDField;
        
        private bool dataItemCompleteIndicatorField;
        
        private bool dataItemCompleteIndicatorFieldSpecified;
        
        private object[] dataItemContactAbstractField;
        
        private System.Nullable<System.DateTime> dataItemDateField;
        
        private bool dataItemDateFieldSpecified;
        
        private DataItemGroupIdentifierType[] dataItemGroupAggregationIdentifierField;
        
        private DataItemGroupIdentifierType[] dataItemGroupCorrelationIdentifierField;
        
        private ULEXImplementationType dataItemULEXImplementationField;
        
        private string dataItemReferenceIDField;
        
        private System.Nullable<DataItemPublishInstructionCodeSimpleType> dataItemPublishInstructionCodeField;
        
        private bool dataItemPublishInstructionCodeFieldSpecified;
        
        private object dataItemStatusAbstractField;
        
        private DataOwnerMetadataType dataOwnerMetadataField;
        
        private object disseminationCriteriaAbstractField;
        
        private string caveatTextField;
        
        private DataItemCategoryType[] dataItemCategoryField;
        
        private string dataItemKeywordsTextField;
        
        private object[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string DataItemID
        {
            get
            {
                return this.dataItemIDField;
            }
            set
            {
                this.dataItemIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public bool DataItemCompleteIndicator
        {
            get
            {
                return this.dataItemCompleteIndicatorField;
            }
            set
            {
                this.dataItemCompleteIndicatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DataItemCompleteIndicatorSpecified
        {
            get
            {
                return this.dataItemCompleteIndicatorFieldSpecified;
            }
            set
            {
                this.dataItemCompleteIndicatorFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DataItemContactAbstract", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute("DataItemContact", typeof(DataContactType), Namespace="http://lexs.gov/lexs/4.0", IsNullable=true, Order=2)]
        public object[] DataItemContactAbstract
        {
            get
            {
                return this.dataItemContactAbstractField;
            }
            set
            {
                this.dataItemContactAbstractField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", IsNullable=true, Order=3)]
        public System.Nullable<System.DateTime> DataItemDate
        {
            get
            {
                return this.dataItemDateField;
            }
            set
            {
                this.dataItemDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DataItemDateSpecified
        {
            get
            {
                return this.dataItemDateFieldSpecified;
            }
            set
            {
                this.dataItemDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DataItemGroupAggregationIdentifier", Order=4)]
        public DataItemGroupIdentifierType[] DataItemGroupAggregationIdentifier
        {
            get
            {
                return this.dataItemGroupAggregationIdentifierField;
            }
            set
            {
                this.dataItemGroupAggregationIdentifierField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DataItemGroupCorrelationIdentifier", Order=5)]
        public DataItemGroupIdentifierType[] DataItemGroupCorrelationIdentifier
        {
            get
            {
                return this.dataItemGroupCorrelationIdentifierField;
            }
            set
            {
                this.dataItemGroupCorrelationIdentifierField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public ULEXImplementationType DataItemULEXImplementation
        {
            get
            {
                return this.dataItemULEXImplementationField;
            }
            set
            {
                this.dataItemULEXImplementationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=7)]
        public string DataItemReferenceID
        {
            get
            {
                return this.dataItemReferenceIDField;
            }
            set
            {
                this.dataItemReferenceIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=8)]
        public System.Nullable<DataItemPublishInstructionCodeSimpleType> DataItemPublishInstructionCode
        {
            get
            {
                return this.dataItemPublishInstructionCodeField;
            }
            set
            {
                this.dataItemPublishInstructionCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DataItemPublishInstructionCodeSpecified
        {
            get
            {
                return this.dataItemPublishInstructionCodeFieldSpecified;
            }
            set
            {
                this.dataItemPublishInstructionCodeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        [System.Xml.Serialization.XmlElementAttribute("DataItemStatusText", typeof(@string), Namespace="http://lexs.gov/lexs/4.0", IsNullable=true, Order=9)]
        public object DataItemStatusAbstract
        {
            get
            {
                return this.dataItemStatusAbstractField;
            }
            set
            {
                this.dataItemStatusAbstractField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public DataOwnerMetadataType DataOwnerMetadata
        {
            get
            {
                return this.dataOwnerMetadataField;
            }
            set
            {
                this.dataOwnerMetadataField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        [System.Xml.Serialization.XmlElementAttribute("DisseminationCriteria", typeof(DisseminationCriteriaType), Namespace="http://lexs.gov/lexs/4.0", IsNullable=false, Order=11)]
        public object DisseminationCriteriaAbstract
        {
            get
            {
                return this.disseminationCriteriaAbstractField;
            }
            set
            {
                this.disseminationCriteriaAbstractField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=12)]
        public string CaveatText
        {
            get
            {
                return this.caveatTextField;
            }
            set
            {
                this.caveatTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DataItemCategory", Order=13)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=14)]
        public string DataItemKeywordsText
        {
            get
            {
                return this.dataItemKeywordsTextField;
            }
            set
            {
                this.dataItemKeywordsTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PackageMetadataDomainAttribute", Order=15)]
        [System.Xml.Serialization.XmlElementAttribute("DataItemICISMMetadata", typeof(ICISMMetadataType), Namespace="http://lexs.gov/lexs/4.0", IsNullable=true, Order=15)]
        public object[] Items
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
