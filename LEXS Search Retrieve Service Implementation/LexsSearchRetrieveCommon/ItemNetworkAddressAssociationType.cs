namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://lexs.gov/digest/4.0")]
    public partial class ItemNetworkAddressAssociationType : AssociationType
    {
        
        private ReferenceType2 itemReferenceField;
        
        private ReferenceType2[] networkAddressReferenceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://niem.gov/niem/niem-core/2.0", Order=0)]
        public ReferenceType2 ItemReference
        {
            get
            {
                return this.itemReferenceField;
            }
            set
            {
                this.itemReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NetworkAddressReference", Order=1)]
        public ReferenceType2[] NetworkAddressReference
        {
            get
            {
                return this.networkAddressReferenceField;
            }
            set
            {
                this.networkAddressReferenceField = value;
            }
        }
    }
}
