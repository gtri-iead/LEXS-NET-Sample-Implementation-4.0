namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="SubjectType", Namespace="http://lexs.gov/digest/4.0")]
    public partial class SubjectType2 : SubjectType1
    {
        
        private SubjectAugmentationType subjectAugmentationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public SubjectAugmentationType SubjectAugmentation
        {
            get
            {
                return this.subjectAugmentationField;
            }
            set
            {
                this.subjectAugmentationField = value;
            }
        }
    }
}
