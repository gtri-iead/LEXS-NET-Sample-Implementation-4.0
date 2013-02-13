namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.oasis-open.org/wsn/b-2")]
    public partial class InvalidFilterFaultType : BaseFaultType
    {
        
        private System.Xml.XmlQualifiedName[] unknownFilterField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UnknownFilter", Order=0)]
        public System.Xml.XmlQualifiedName[] UnknownFilter
        {
            get
            {
                return this.unknownFilterField;
            }
            set
            {
                this.unknownFilterField = value;
            }
        }
    }
}
