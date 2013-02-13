namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ulex.gov/ulex/2.0")]
    public partial class OriginMetadataType
    {
        
        private SystemMetadataType messageOriginMetadataField;
        
        private object itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public SystemMetadataType MessageOriginMetadata
        {
            get
            {
                return this.messageOriginMetadataField;
            }
            set
            {
                this.messageOriginMetadataField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UserAssertion", typeof(DomainAttributeType), Order=1)]
        [System.Xml.Serialization.XmlElementAttribute("UserAssertionSAML", typeof(UserAssertionSAMLType), Order=1)]
        [System.Xml.Serialization.XmlElementAttribute("UserAssertion", typeof(UserAssertionType), Namespace="http://lexs.gov/lexs/4.0", IsNullable=false, Order=1)]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }
}
