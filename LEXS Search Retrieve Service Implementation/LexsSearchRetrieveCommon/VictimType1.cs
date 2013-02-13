namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="VictimType", Namespace="http://lexs.gov/digest/4.0")]
    public partial class VictimType1 : VictimType
    {
        
        private VictimAugmentationType victimAugmentationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public VictimAugmentationType VictimAugmentation
        {
            get
            {
                return this.victimAugmentationField;
            }
            set
            {
                this.victimAugmentationField = value;
            }
        }
    }
}
