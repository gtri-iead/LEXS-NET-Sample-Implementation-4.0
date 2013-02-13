namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ulex.gov/ulex/2.0")]
    public partial class SearchResultPackageType : PackageAbstractType
    {
        
        private SystemMetadataType dataSubmitterMetadataField;
        
        private MatchDetailsType matchDetailsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public SystemMetadataType DataSubmitterMetadata
        {
            get
            {
                return this.dataSubmitterMetadataField;
            }
            set
            {
                this.dataSubmitterMetadataField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public MatchDetailsType MatchDetails
        {
            get
            {
                return this.matchDetailsField;
            }
            set
            {
                this.matchDetailsField = value;
            }
        }
    }
}
