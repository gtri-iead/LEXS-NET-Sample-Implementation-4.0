namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="DocumentType", Namespace="http://lexs.gov/digest/4.0")]
    public partial class DocumentType1 : DocumentType
    {
        
        private DocumentAugmentationType documentAugmentationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public DocumentAugmentationType DocumentAugmentation
        {
            get
            {
                return this.documentAugmentationField;
            }
            set
            {
                this.documentAugmentationField = value;
            }
        }
    }
}
