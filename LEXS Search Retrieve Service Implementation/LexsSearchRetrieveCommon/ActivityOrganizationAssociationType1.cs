namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="ActivityOrganizationAssociationType", Namespace="http://lexs.gov/digest/4.0")]
    public partial class ActivityOrganizationAssociationType1 : ActivityOrganizationAssociationType
    {
        
        private ActivityOrganizationAssociationAugmentationType activityOrganizationAssociationAugmentationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ActivityOrganizationAssociationAugmentationType ActivityOrganizationAssociationAugmentation
        {
            get
            {
                return this.activityOrganizationAssociationAugmentationField;
            }
            set
            {
                this.activityOrganizationAssociationAugmentationField = value;
            }
        }
    }
}
