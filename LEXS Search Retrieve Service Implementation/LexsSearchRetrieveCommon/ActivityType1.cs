namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="ActivityType", Namespace="http://lexs.gov/digest/4.0")]
    public partial class ActivityType1 : ActivityType
    {
        
        private ActivityAugmentationType activityAugmentationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ActivityAugmentationType ActivityAugmentation
        {
            get
            {
                return this.activityAugmentationField;
            }
            set
            {
                this.activityAugmentationField = value;
            }
        }
    }
}
