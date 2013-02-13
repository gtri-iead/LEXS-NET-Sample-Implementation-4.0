namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://lexs.gov/digest/4.0")]
    public partial class HashType : ComplexObjectType
    {
        
        private HashValueType[] hashValueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HashValue", IsNullable=true, Order=0)]
        public HashValueType[] HashValue
        {
            get
            {
                return this.hashValueField;
            }
            set
            {
                this.hashValueField = value;
            }
        }
    }
}
