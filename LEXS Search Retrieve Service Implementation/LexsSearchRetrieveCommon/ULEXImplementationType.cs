namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ulex.gov/ulex/2.0")]
    public partial class ULEXImplementationType
    {
        
        private string uLEXImplementationVersionTextField;
        
        private string uLEXImplementationNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string ULEXImplementationVersionText
        {
            get
            {
                return this.uLEXImplementationVersionTextField;
            }
            set
            {
                this.uLEXImplementationVersionTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string ULEXImplementationName
        {
            get
            {
                return this.uLEXImplementationNameField;
            }
            set
            {
                this.uLEXImplementationNameField = value;
            }
        }
    }
}
