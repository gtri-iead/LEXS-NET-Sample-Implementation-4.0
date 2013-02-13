namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ulex.gov/ulex/2.0")]
    public partial class StructuredPayloadMetadataType
    {
        
        private string communityURIField;
        
        private string communityDescriptionTextField;
        
        private string communityVersionTextField;
        
        private CommunityPedigreeURIType[] communityPedigreeURIField;
        
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
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string CommunityDescriptionText
        {
            get
            {
                return this.communityDescriptionTextField;
            }
            set
            {
                this.communityDescriptionTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string CommunityVersionText
        {
            get
            {
                return this.communityVersionTextField;
            }
            set
            {
                this.communityVersionTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommunityPedigreeURI", Order=3)]
        public CommunityPedigreeURIType[] CommunityPedigreeURI
        {
            get
            {
                return this.communityPedigreeURIField;
            }
            set
            {
                this.communityPedigreeURIField = value;
            }
        }
    }
}
