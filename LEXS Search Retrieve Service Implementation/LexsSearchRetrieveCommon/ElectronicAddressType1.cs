namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="ElectronicAddressType", Namespace="http://lexs.gov/digest/4.0")]
    public partial class ElectronicAddressType1 : ElectronicAddressType
    {
        
        private ElectronicAddressAugmentationType electronicAddressAugmentationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ElectronicAddressAugmentationType ElectronicAddressAugmentation
        {
            get
            {
                return this.electronicAddressAugmentationField;
            }
            set
            {
                this.electronicAddressAugmentationField = value;
            }
        }
    }
}
