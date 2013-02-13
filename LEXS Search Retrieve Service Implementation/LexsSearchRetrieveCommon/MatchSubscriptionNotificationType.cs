namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ulex.gov/subscribenotify/2.0")]
    public partial class MatchSubscriptionNotificationType
    {
        
        private SNMessageMetadataType sNMessageMetadataField;
        
        private ResponseMetadataType responseMetadataField;
        
        private SearchResponseMetadataType searchResponseMetadataField;
        
        private SearchResultPackageType[] searchResultPackageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://ulex.gov/ulex/2.0", Order=0)]
        public SNMessageMetadataType SNMessageMetadata
        {
            get
            {
                return this.sNMessageMetadataField;
            }
            set
            {
                this.sNMessageMetadataField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://ulex.gov/ulex/2.0", Order=1)]
        public ResponseMetadataType ResponseMetadata
        {
            get
            {
                return this.responseMetadataField;
            }
            set
            {
                this.responseMetadataField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://ulex.gov/ulex/2.0", Order=2)]
        public SearchResponseMetadataType SearchResponseMetadata
        {
            get
            {
                return this.searchResponseMetadataField;
            }
            set
            {
                this.searchResponseMetadataField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SearchResultPackage", Namespace="http://ulex.gov/ulex/2.0", Order=3)]
        public SearchResultPackageType[] SearchResultPackage
        {
            get
            {
                return this.searchResultPackageField;
            }
            set
            {
                this.searchResultPackageField = value;
            }
        }
    }
}
