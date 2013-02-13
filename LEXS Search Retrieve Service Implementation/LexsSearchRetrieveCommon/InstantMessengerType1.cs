namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="InstantMessengerType", Namespace="http://lexs.gov/digest/4.0")]
    public partial class InstantMessengerType1 : InstantMessengerType
    {
        
        private InstantMessengerAugmentationType instantMessengerAugmentationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public InstantMessengerAugmentationType InstantMessengerAugmentation
        {
            get
            {
                return this.instantMessengerAugmentationField;
            }
            set
            {
                this.instantMessengerAugmentationField = value;
            }
        }
    }
}
