namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/domains/familyServices/2.1")]
    public partial class MarriageAssociationType : PersonUnionAssociationType
    {
        
        private MarriageAssociationAugmentationType marriageAssociationAugmentationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public MarriageAssociationAugmentationType MarriageAssociationAugmentation
        {
            get
            {
                return this.marriageAssociationAugmentationField;
            }
            set
            {
                this.marriageAssociationAugmentationField = value;
            }
        }
    }
}
