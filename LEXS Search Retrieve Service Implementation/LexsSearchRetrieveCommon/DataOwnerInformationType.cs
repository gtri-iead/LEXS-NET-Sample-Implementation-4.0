namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ulex.gov/ulex/2.0")]
    public partial class DataOwnerInformationType
    {
        
        private DataOwnerMetadataType dataOwnerMetadataField;
        
        private bool structuredSearchIndicatorField;
        
        private bool textSearchIndicatorField;
        
        private DataItemCategoryType[] dataItemCategoryField;
        
        private DomainAttributeType[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public bool StructuredSearchIndicator
        {
            get
            {
                return this.structuredSearchIndicatorField;
            }
            set
            {
                this.structuredSearchIndicatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public bool TextSearchIndicator
        {
            get
            {
                return this.textSearchIndicatorField;
            }
            set
            {
                this.textSearchIndicatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DataItemCategory", Order=3)]
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
        [System.Xml.Serialization.XmlElementAttribute("DataOwnerInformationDomainAttribute", Order=4)]
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
