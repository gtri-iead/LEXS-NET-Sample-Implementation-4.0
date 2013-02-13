namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://lexs.gov/digest/4.0")]
    public partial class TelephoneCallAssociationType : AssociationType
    {
        
        private EntityType1[] originatorEntityField;
        
        private ReferenceType2 originatorTelephoneNumberReferenceField;
        
        private EntityType1[] receiverEntityField;
        
        private ReferenceType2[] receiverTelephoneNumberReferenceField;
        
        private duration callDurationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OriginatorEntity", IsNullable=true, Order=0)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public ReferenceType2 OriginatorTelephoneNumberReference
        {
            get
            {
                return this.originatorTelephoneNumberReferenceField;
            }
            set
            {
                this.originatorTelephoneNumberReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ReceiverEntity", IsNullable=true, Order=2)]
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ReceiverTelephoneNumberReference", Order=3)]
        public ReferenceType2[] ReceiverTelephoneNumberReference
        {
            get
            {
                return this.receiverTelephoneNumberReferenceField;
            }
            set
            {
                this.receiverTelephoneNumberReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=4)]
        public duration CallDuration
        {
            get
            {
                return this.callDurationField;
            }
            set
            {
                this.callDurationField = value;
            }
        }
    }
}
