namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://lexs.gov/digest/4.0")]
    public partial class OffenseNetworkAddressAssociationType : AssociationType
    {
        
        private ReferenceType2[] offenseReferenceField;
        
        private ReferenceType2[] networkAddressReferenceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OffenseReference", Namespace="http://niem.gov/niem/domains/jxdm/4.1", Order=0)]
        public ReferenceType2[] OffenseReference
        {
            get
            {
                return this.offenseReferenceField;
            }
            set
            {
                this.offenseReferenceField = value;
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
