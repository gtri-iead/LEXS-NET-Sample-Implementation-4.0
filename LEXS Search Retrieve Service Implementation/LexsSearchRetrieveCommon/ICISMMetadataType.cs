namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/icism/2.0")]
    public partial class ICISMMetadataType : MetadataType1
    {
        
        private ClassificationType classificationField;
        
        private bool classificationFieldSpecified;
        
        private string ownerProducerField;
        
        private string sCIcontrolsField;
        
        private string sARIdentifierField;
        
        private string disseminationControlsField;
        
        private string fGIsourceOpenField;
        
        private string fGIsourceProtectedField;
        
        private string releasableToField;
        
        private string nonICmarkingsField;
        
        private string classifiedByField;
        
        private string classificationReasonField;
        
        private string derivedFromField;
        
        private System.DateTime declassDateField;
        
        private bool declassDateFieldSpecified;
        
        private string declassEventField;
        
        private string declassExceptionField;
        
        private string typeOfExemptedSourceField;
        
        private System.DateTime dateOfExemptedSourceField;
        
        private bool dateOfExemptedSourceFieldSpecified;
        
        private bool declassManualReviewField;
        
        private bool declassManualReviewFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="urn:us:gov:ic:ism:v2")]
        public ClassificationType classification
        {
            get
            {
                return this.classificationField;
            }
            set
            {
                this.classificationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool classificationSpecified
        {
            get
            {
                return this.classificationFieldSpecified;
            }
            set
            {
                this.classificationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="urn:us:gov:ic:ism:v2", DataType="NMTOKENS")]
        public string ownerProducer
        {
            get
            {
                return this.ownerProducerField;
            }
            set
            {
                this.ownerProducerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="urn:us:gov:ic:ism:v2", DataType="NMTOKENS")]
        public string SCIcontrols
        {
            get
            {
                return this.sCIcontrolsField;
            }
            set
            {
                this.sCIcontrolsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="urn:us:gov:ic:ism:v2", DataType="NMTOKENS")]
        public string SARIdentifier
        {
            get
            {
                return this.sARIdentifierField;
            }
            set
            {
                this.sARIdentifierField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="urn:us:gov:ic:ism:v2", DataType="NMTOKENS")]
        public string disseminationControls
        {
            get
            {
                return this.disseminationControlsField;
            }
            set
            {
                this.disseminationControlsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="urn:us:gov:ic:ism:v2", DataType="NMTOKENS")]
        public string FGIsourceOpen
        {
            get
            {
                return this.fGIsourceOpenField;
            }
            set
            {
                this.fGIsourceOpenField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="urn:us:gov:ic:ism:v2", DataType="NMTOKENS")]
        public string FGIsourceProtected
        {
            get
            {
                return this.fGIsourceProtectedField;
            }
            set
            {
                this.fGIsourceProtectedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="urn:us:gov:ic:ism:v2", DataType="NMTOKENS")]
        public string releasableTo
        {
            get
            {
                return this.releasableToField;
            }
            set
            {
                this.releasableToField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="urn:us:gov:ic:ism:v2", DataType="NMTOKENS")]
        public string nonICmarkings
        {
            get
            {
                return this.nonICmarkingsField;
            }
            set
            {
                this.nonICmarkingsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="urn:us:gov:ic:ism:v2")]
        public string classifiedBy
        {
            get
            {
                return this.classifiedByField;
            }
            set
            {
                this.classifiedByField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="urn:us:gov:ic:ism:v2")]
        public string classificationReason
        {
            get
            {
                return this.classificationReasonField;
            }
            set
            {
                this.classificationReasonField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="urn:us:gov:ic:ism:v2")]
        public string derivedFrom
        {
            get
            {
                return this.derivedFromField;
            }
            set
            {
                this.derivedFromField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="urn:us:gov:ic:ism:v2", DataType="date")]
        public System.DateTime declassDate
        {
            get
            {
                return this.declassDateField;
            }
            set
            {
                this.declassDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool declassDateSpecified
        {
            get
            {
                return this.declassDateFieldSpecified;
            }
            set
            {
                this.declassDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="urn:us:gov:ic:ism:v2")]
        public string declassEvent
        {
            get
            {
                return this.declassEventField;
            }
            set
            {
                this.declassEventField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="urn:us:gov:ic:ism:v2", DataType="NMTOKENS")]
        public string declassException
        {
            get
            {
                return this.declassExceptionField;
            }
            set
            {
                this.declassExceptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="urn:us:gov:ic:ism:v2", DataType="NMTOKENS")]
        public string typeOfExemptedSource
        {
            get
            {
                return this.typeOfExemptedSourceField;
            }
            set
            {
                this.typeOfExemptedSourceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="urn:us:gov:ic:ism:v2", DataType="date")]
        public System.DateTime dateOfExemptedSource
        {
            get
            {
                return this.dateOfExemptedSourceField;
            }
            set
            {
                this.dateOfExemptedSourceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dateOfExemptedSourceSpecified
        {
            get
            {
                return this.dateOfExemptedSourceFieldSpecified;
            }
            set
            {
                this.dateOfExemptedSourceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="urn:us:gov:ic:ism:v2")]
        public bool declassManualReview
        {
            get
            {
                return this.declassManualReviewField;
            }
            set
            {
                this.declassManualReviewField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool declassManualReviewSpecified
        {
            get
            {
                return this.declassManualReviewFieldSpecified;
            }
            set
            {
                this.declassManualReviewFieldSpecified = value;
            }
        }
    }
}
