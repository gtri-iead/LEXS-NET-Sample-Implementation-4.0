namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://lexs.gov/digest/4.0")]
    public partial class PhysicalMailAssociationType : AssociationType
    {
        
        private EntityType1[] recipientEntityField;
        
        private ReferenceType2 recipientLocationReferenceField;
        
        private EntityType1[] senderEntityField;
        
        private ReferenceType2 senderLocationReferenceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RecipientEntity", IsNullable=true, Order=0)]
        public EntityType1[] RecipientEntity
        {
            get
            {
                return this.recipientEntityField;
            }
            set
            {
                this.recipientEntityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public ReferenceType2 RecipientLocationReference
        {
            get
            {
                return this.recipientLocationReferenceField;
            }
            set
            {
                this.recipientLocationReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SenderEntity", IsNullable=true, Order=2)]
        public EntityType1[] SenderEntity
        {
            get
            {
                return this.senderEntityField;
            }
            set
            {
                this.senderEntityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public ReferenceType2 SenderLocationReference
        {
            get
            {
                return this.senderLocationReferenceField;
            }
            set
            {
                this.senderLocationReferenceField = value;
            }
        }
    }
}
