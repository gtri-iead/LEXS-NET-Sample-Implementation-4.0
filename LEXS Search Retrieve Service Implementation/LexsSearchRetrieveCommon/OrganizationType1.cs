namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="OrganizationType", Namespace="http://niem.gov/niem/domains/jxdm/4.1")]
    public partial class OrganizationType1 : OrganizationType
    {
        
        private OrganizationAugmentationType organizationAugmentationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public OrganizationAugmentationType OrganizationAugmentation
        {
            get
            {
                return this.organizationAugmentationField;
            }
            set
            {
                this.organizationAugmentationField = value;
            }
        }
    }
}
