namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ulex.gov/ulex/2.0")]
    public partial class RenderingParameterType
    {
        
        private string renderingParameterNameField;
        
        private string renderingParameterValueTextField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string RenderingParameterName
        {
            get
            {
                return this.renderingParameterNameField;
            }
            set
            {
                this.renderingParameterNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string RenderingParameterValueText
        {
            get
            {
                return this.renderingParameterValueTextField;
            }
            set
            {
                this.renderingParameterValueTextField = value;
            }
        }
    }
}
