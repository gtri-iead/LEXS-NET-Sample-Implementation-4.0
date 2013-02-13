namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SubjectType2))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="SubjectType", Namespace="http://niem.gov/niem/domains/jxdm/4.1")]
    public partial class SubjectType1 : ComplexObjectType
    {
        
        private ReferenceType2 roleOfPersonReferenceField;
        
        private ReferenceType2 roleOfOrganizationReferenceField;
        
        private CMCCodeType subjectCautionInformationCodeField;
        
        private CriminalTraitDetailsType subjectCriminalTraitDetailsField;
        
        private TextType subjectOffenderNoticeTextField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://niem.gov/niem/niem-core/2.0", Order=0)]
        public ReferenceType2 RoleOfPersonReference
        {
            get
            {
                return this.roleOfPersonReferenceField;
            }
            set
            {
                this.roleOfPersonReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://niem.gov/niem/niem-core/2.0", Order=1)]
        public ReferenceType2 RoleOfOrganizationReference
        {
            get
            {
                return this.roleOfOrganizationReferenceField;
            }
            set
            {
                this.roleOfOrganizationReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public CMCCodeType SubjectCautionInformationCode
        {
            get
            {
                return this.subjectCautionInformationCodeField;
            }
            set
            {
                this.subjectCautionInformationCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public CriminalTraitDetailsType SubjectCriminalTraitDetails
        {
            get
            {
                return this.subjectCriminalTraitDetailsField;
            }
            set
            {
                this.subjectCriminalTraitDetailsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=4)]
        public TextType SubjectOffenderNoticeText
        {
            get
            {
                return this.subjectOffenderNoticeTextField;
            }
            set
            {
                this.subjectOffenderNoticeTextField = value;
            }
        }
    }
}
