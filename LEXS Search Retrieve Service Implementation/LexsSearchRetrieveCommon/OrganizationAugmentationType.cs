namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/domains/jxdm/4.1")]
    public partial class OrganizationAugmentationType : AugmentationType
    {
        
        private IdentificationType organizationORIIdentificationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public IdentificationType OrganizationORIIdentification
        {
            get
            {
                return this.organizationORIIdentificationField;
            }
            set
            {
                this.organizationORIIdentificationField = value;
            }
        }
    }
}
