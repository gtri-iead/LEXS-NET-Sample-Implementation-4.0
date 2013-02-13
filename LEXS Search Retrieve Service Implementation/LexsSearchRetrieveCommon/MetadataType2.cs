namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MetadataType3))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="MetadataType", Namespace="http://niem.gov/niem/niem-core/2.0")]
    public partial class MetadataType2 : MetadataType1
    {
        
        private TextType[] commentTextField;
        
        private TextType[] distributionTextField;
        
        private DateType effectiveDateField;
        
        private DateType expirationDateField;
        
        private DateType lastUpdatedDateField;
        
        private DateType lastVerifiedDateField;
        
        private PercentageType probabilityNumericField;
        
        private TextType qualityCommentTextField;
        
        private QualityValidityCategoryCodeType qualityValidityCodeField;
        
        private DateType reportedDateField;
        
        private TextType reportingOrganizationTextField;
        
        private TextType sourceIDTextField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommentText", IsNullable=true, Order=0)]
        public TextType[] CommentText
        {
            get
            {
                return this.commentTextField;
            }
            set
            {
                this.commentTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DistributionText", IsNullable=true, Order=1)]
        public TextType[] DistributionText
        {
            get
            {
                return this.distributionTextField;
            }
            set
            {
                this.distributionTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public DateType EffectiveDate
        {
            get
            {
                return this.effectiveDateField;
            }
            set
            {
                this.effectiveDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public DateType ExpirationDate
        {
            get
            {
                return this.expirationDateField;
            }
            set
            {
                this.expirationDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=4)]
        public DateType LastUpdatedDate
        {
            get
            {
                return this.lastUpdatedDateField;
            }
            set
            {
                this.lastUpdatedDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=5)]
        public DateType LastVerifiedDate
        {
            get
            {
                return this.lastVerifiedDateField;
            }
            set
            {
                this.lastVerifiedDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=6)]
        public PercentageType ProbabilityNumeric
        {
            get
            {
                return this.probabilityNumericField;
            }
            set
            {
                this.probabilityNumericField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=7)]
        public TextType QualityCommentText
        {
            get
            {
                return this.qualityCommentTextField;
            }
            set
            {
                this.qualityCommentTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=8)]
        public QualityValidityCategoryCodeType QualityValidityCode
        {
            get
            {
                return this.qualityValidityCodeField;
            }
            set
            {
                this.qualityValidityCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=9)]
        public DateType ReportedDate
        {
            get
            {
                return this.reportedDateField;
            }
            set
            {
                this.reportedDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=10)]
        public TextType ReportingOrganizationText
        {
            get
            {
                return this.reportingOrganizationTextField;
            }
            set
            {
                this.reportingOrganizationTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=11)]
        public TextType SourceIDText
        {
            get
            {
                return this.sourceIDTextField;
            }
            set
            {
                this.sourceIDTextField = value;
            }
        }
    }
}
