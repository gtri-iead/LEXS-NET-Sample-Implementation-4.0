namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ulex.gov/ulex/2.0")]
    public partial class AttachmentSummaryType
    {
        
        private string attachmentCategoryTextField;
        
        private string attachmentDescriptionTextField;
        
        private string attachmentFormatIDField;
        
        private string attachmentFormatStandardNameField;
        
        private decimal attachmentSizeValueField;
        
        private bool attachmentSizeValueFieldSpecified;
        
        private string attachmentURIField;
        
        private bool attachmentViewableIndicatorField;
        
        private DomainAttributeType[] itemsField;
        
        private string idField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string AttachmentCategoryText
        {
            get
            {
                return this.attachmentCategoryTextField;
            }
            set
            {
                this.attachmentCategoryTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string AttachmentDescriptionText
        {
            get
            {
                return this.attachmentDescriptionTextField;
            }
            set
            {
                this.attachmentDescriptionTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string AttachmentFormatID
        {
            get
            {
                return this.attachmentFormatIDField;
            }
            set
            {
                this.attachmentFormatIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string AttachmentFormatStandardName
        {
            get
            {
                return this.attachmentFormatStandardNameField;
            }
            set
            {
                this.attachmentFormatStandardNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public decimal AttachmentSizeValue
        {
            get
            {
                return this.attachmentSizeValueField;
            }
            set
            {
                this.attachmentSizeValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AttachmentSizeValueSpecified
        {
            get
            {
                return this.attachmentSizeValueFieldSpecified;
            }
            set
            {
                this.attachmentSizeValueFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI", Order=5)]
        public string AttachmentURI
        {
            get
            {
                return this.attachmentURIField;
            }
            set
            {
                this.attachmentURIField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public bool AttachmentViewableIndicator
        {
            get
            {
                return this.attachmentViewableIndicatorField;
            }
            set
            {
                this.attachmentViewableIndicatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AttachmentSummaryDomainAttribute", Order=7)]
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://ulex.gov/library/2.0", DataType="ID")]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }
}
