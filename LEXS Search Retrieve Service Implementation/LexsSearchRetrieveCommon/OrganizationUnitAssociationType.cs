namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/niem-core/2.0")]
    public partial class OrganizationUnitAssociationType : AssociationType
    {
        
        private ReferenceType2[] organizationReferenceField;
        
        private ReferenceType2[] organizationUnitReferenceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OrganizationReference", Order=0)]
        public ReferenceType2[] OrganizationReference
        {
            get
            {
                return this.organizationReferenceField;
            }
            set
            {
                this.organizationReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OrganizationUnitReference", Order=1)]
        public ReferenceType2[] OrganizationUnitReference
        {
            get
            {
                return this.organizationUnitReferenceField;
            }
            set
            {
                this.organizationUnitReferenceField = value;
            }
        }
    }
}
