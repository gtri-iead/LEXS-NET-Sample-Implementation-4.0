namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://lexs.gov/digest/4.0")]
    public partial class VictimAugmentationType : AugmentationType
    {
        
        private ReferenceType2 roleOfOtherReferenceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ReferenceType2 RoleOfOtherReference
        {
            get
            {
                return this.roleOfOtherReferenceField;
            }
            set
            {
                this.roleOfOtherReferenceField = value;
            }
        }
    }
}
