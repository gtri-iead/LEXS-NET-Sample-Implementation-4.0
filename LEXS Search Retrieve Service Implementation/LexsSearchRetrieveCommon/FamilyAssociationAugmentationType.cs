namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/domains/screening/2.1")]
    public partial class FamilyAssociationAugmentationType : AugmentationType
    {
        
        private FamilyAssociationCategoryCodeType familyAssociationCategoryCodeField;
        
        private TextType familyAssociationCategoryDescriptionTextField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public FamilyAssociationCategoryCodeType FamilyAssociationCategoryCode
        {
            get
            {
                return this.familyAssociationCategoryCodeField;
            }
            set
            {
                this.familyAssociationCategoryCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public TextType FamilyAssociationCategoryDescriptionText
        {
            get
            {
                return this.familyAssociationCategoryDescriptionTextField;
            }
            set
            {
                this.familyAssociationCategoryDescriptionTextField = value;
            }
        }
    }
}
