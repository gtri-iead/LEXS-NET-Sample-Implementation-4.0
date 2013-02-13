namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ulex.gov/ulex/2.0")]
    public partial class DataItemPackageType : PackageAbstractType
    {
        
        private RenderingInstructionsType[] renderingInstructionsField;
        
        private object narrativeAbstractField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RenderingInstructions", Order=0)]
        public RenderingInstructionsType[] RenderingInstructions
        {
            get
            {
                return this.renderingInstructionsField;
            }
            set
            {
                this.renderingInstructionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        [System.Xml.Serialization.XmlElementAttribute("NarrativeText", typeof(@string), Namespace="http://lexs.gov/lexs/4.0", IsNullable=true, Order=1)]
        public object NarrativeAbstract
        {
            get
            {
                return this.narrativeAbstractField;
            }
            set
            {
                this.narrativeAbstractField = value;
            }
        }
    }
}
