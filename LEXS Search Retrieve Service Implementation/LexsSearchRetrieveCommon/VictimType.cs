namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VictimType1))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/domains/jxdm/4.1")]
    public partial class VictimType : ComplexObjectType
    {
        
        private ReferenceType2 roleOfPersonReferenceField;
        
        private ReferenceType2 roleOfOrganizationReferenceField;
        
        private ReferenceType2 roleOfItemReferenceField;
        
        private TextType victimDispositionTextField;
        
        private boolean victimSeeksProsecutionIndicatorField;
        
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://niem.gov/niem/niem-core/2.0", Order=2)]
        public ReferenceType2 RoleOfItemReference
        {
            get
            {
                return this.roleOfItemReferenceField;
            }
            set
            {
                this.roleOfItemReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public TextType VictimDispositionText
        {
            get
            {
                return this.victimDispositionTextField;
            }
            set
            {
                this.victimDispositionTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=4)]
        public boolean VictimSeeksProsecutionIndicator
        {
            get
            {
                return this.victimSeeksProsecutionIndicatorField;
            }
            set
            {
                this.victimSeeksProsecutionIndicatorField = value;
            }
        }
    }
}
