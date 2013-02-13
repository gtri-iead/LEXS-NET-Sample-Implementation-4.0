namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://lexs.gov/digest/4.0")]
    public partial class NetworkAddressAssociationType : AssociationType
    {
        
        private ReferenceType2 originatorNetworkAddressReferenceField;
        
        private EntityType1[] originatorEntityField;
        
        private ReferenceType2 receiverNetworkAddressReferenceField;
        
        private EntityType1[] receiverEntityField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ReferenceType2 OriginatorNetworkAddressReference
        {
            get
            {
                return this.originatorNetworkAddressReferenceField;
            }
            set
            {
                this.originatorNetworkAddressReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OriginatorEntity", IsNullable=true, Order=1)]
        public EntityType1[] OriginatorEntity
        {
            get
            {
                return this.originatorEntityField;
            }
            set
            {
                this.originatorEntityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public ReferenceType2 ReceiverNetworkAddressReference
        {
            get
            {
                return this.receiverNetworkAddressReferenceField;
            }
            set
            {
                this.receiverNetworkAddressReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ReceiverEntity", IsNullable=true, Order=3)]
        public EntityType1[] ReceiverEntity
        {
            get
            {
                return this.receiverEntityField;
            }
            set
            {
                this.receiverEntityField = value;
            }
        }
    }
}
