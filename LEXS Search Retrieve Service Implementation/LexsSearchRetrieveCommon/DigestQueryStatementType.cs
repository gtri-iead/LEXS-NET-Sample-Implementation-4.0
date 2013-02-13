namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ulex.gov/ulex/2.0")]
    public partial class DigestQueryStatementType
    {
        
        private object[] digestQueryFieldAbstractField;
        
        private QueryMatchCodeSimpleType queryMatchCodeField;
        
        /// <remarks/>
        
        // DEBUG
        //[System.Xml.Serialization.XmlElementAttribute("DigestQueryFieldAbstract", Order=0)]

        [System.Xml.Serialization.XmlElementAttribute("DigestQueryField", typeof(DigestQueryFieldType), Namespace="http://lexs.gov/lexs/4.0", IsNullable=false, Order=0)]
        public object[] DigestQueryFieldAbstract
        {
            get
            {
                return this.digestQueryFieldAbstractField;
            }
            set
            {
                this.digestQueryFieldAbstractField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public QueryMatchCodeSimpleType QueryMatchCode
        {
            get
            {
                return this.queryMatchCodeField;
            }
            set
            {
                this.queryMatchCodeField = value;
            }
        }
    }
}
