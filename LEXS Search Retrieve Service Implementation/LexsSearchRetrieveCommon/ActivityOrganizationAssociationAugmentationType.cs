namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://lexs.gov/digest/4.0")]
    public partial class ActivityOrganizationAssociationAugmentationType : AugmentationType
    {
        
        private TextType organizationActivityInvolvementTextField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public TextType OrganizationActivityInvolvementText
        {
            get
            {
                return this.organizationActivityInvolvementTextField;
            }
            set
            {
                this.organizationActivityInvolvementTextField = value;
            }
        }
    }
}
