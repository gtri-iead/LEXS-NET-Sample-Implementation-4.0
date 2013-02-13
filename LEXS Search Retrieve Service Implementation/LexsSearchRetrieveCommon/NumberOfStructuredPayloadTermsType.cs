namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ulex.gov/ulex/2.0")]
    public partial class NumberOfStructuredPayloadTermsType
    {
        
        private string communityURIField;
        
        private string searchTermsQuantityField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI", Order=0)]
        public string CommunityURI
        {
            get
            {
                return this.communityURIField;
            }
            set
            {
                this.communityURIField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="nonNegativeInteger", Order=1)]
        public string SearchTermsQuantity
        {
            get
            {
                return this.searchTermsQuantityField;
            }
            set
            {
                this.searchTermsQuantityField = value;
            }
        }
    }
}
