namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ulex.gov/ulex/2.0")]
    public partial class SubscriptionDataItemMetadataQueryType
    {
        
        private System.Xml.XmlQualifiedName[] attachmentSummaryConnectionQNameField;
        
        private bool attachmentRequiredIndicatorField;
        
        private bool attachmentRequiredIndicatorFieldSpecified;
        
        private System.Nullable<System.DateTime> dataItemAfterDateField;
        
        private bool dataItemAfterDateFieldSpecified;
        
        private System.Nullable<System.DateTime> dataItemBeforeDateField;
        
        private bool dataItemBeforeDateFieldSpecified;
        
        private DataItemGroupIdentifierType[] dataItemGroupAggregationIdentifierField;
        
        private DataItemGroupIdentifierType[] dataItemGroupCorrelationIdentifierField;
        
        private string dataItemKeywordsTextField;
        
        private string dataItemReferenceIDField;
        
        private object[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AttachmentSummaryConnectionQName", Order=0)]
        public System.Xml.XmlQualifiedName[] AttachmentSummaryConnectionQName
        {
            get
            {
                return this.attachmentSummaryConnectionQNameField;
            }
            set
            {
                this.attachmentSummaryConnectionQNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public bool AttachmentRequiredIndicator
        {
            get
            {
                return this.attachmentRequiredIndicatorField;
            }
            set
            {
                this.attachmentRequiredIndicatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AttachmentRequiredIndicatorSpecified
        {
            get
            {
                return this.attachmentRequiredIndicatorFieldSpecified;
            }
            set
            {
                this.attachmentRequiredIndicatorFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", IsNullable=true, Order=2)]
        public System.Nullable<System.DateTime> DataItemAfterDate
        {
            get
            {
                return this.dataItemAfterDateField;
            }
            set
            {
                this.dataItemAfterDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DataItemAfterDateSpecified
        {
            get
            {
                return this.dataItemAfterDateFieldSpecified;
            }
            set
            {
                this.dataItemAfterDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", IsNullable=true, Order=3)]
        public System.Nullable<System.DateTime> DataItemBeforeDate
        {
            get
            {
                return this.dataItemBeforeDateField;
            }
            set
            {
                this.dataItemBeforeDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DataItemBeforeDateSpecified
        {
            get
            {
                return this.dataItemBeforeDateFieldSpecified;
            }
            set
            {
                this.dataItemBeforeDateFieldSpecified = value;
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
        [System.Xml.Serialization.XmlElementAttribute("PackageMetadataDomainAttribute", Order=8)]
        [System.Xml.Serialization.XmlElementAttribute("DataItemICISMMetadata", typeof(ICISMMetadataType), Namespace="http://lexs.gov/lexs/4.0", IsNullable=true, Order=8)]
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
