namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="RelatedActivityAssociationType", Namespace="http://lexs.gov/digest/4.0")]
    public partial class RelatedActivityAssociationType1 : RelatedActivityAssociationType
    {
        
        private RelatedActivityAssociationAugmentationType relatedActivityAssociationAugmentationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public RelatedActivityAssociationAugmentationType RelatedActivityAssociationAugmentation
        {
            get
            {
                return this.relatedActivityAssociationAugmentationField;
            }
            set
            {
                this.relatedActivityAssociationAugmentationField = value;
            }
        }
    }
}
