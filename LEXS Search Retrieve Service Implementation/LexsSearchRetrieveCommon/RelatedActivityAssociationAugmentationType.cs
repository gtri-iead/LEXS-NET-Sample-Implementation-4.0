namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://lexs.gov/digest/4.0")]
    public partial class RelatedActivityAssociationAugmentationType : AugmentationType
    {
        
        private ReferenceType2 primaryActivityReferenceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ReferenceType2 PrimaryActivityReference
        {
            get
            {
                return this.primaryActivityReferenceField;
            }
            set
            {
                this.primaryActivityReferenceField = value;
            }
        }
    }
}
