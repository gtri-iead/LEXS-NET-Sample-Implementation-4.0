namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/niem-core/2.0")]
    public partial class TransportationAssociationType : AssociationType
    {
        
        private ReferenceType2[] conveyanceReferenceField;
        
        private ReferenceType2[] conveyedItemReferenceField;
        
        private ReferenceType2[] conveyanceOperatorReferenceField;
        
        private ReferenceType2[] conveyedPersonReferenceField;
        
        private QuantityType[] conveyancePassengerQuantityField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ConveyanceReference", Order=0)]
        public ReferenceType2[] ConveyanceReference
        {
            get
            {
                return this.conveyanceReferenceField;
            }
            set
            {
                this.conveyanceReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ConveyedItemReference", Order=1)]
        public ReferenceType2[] ConveyedItemReference
        {
            get
            {
                return this.conveyedItemReferenceField;
            }
            set
            {
                this.conveyedItemReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ConveyanceOperatorReference", Order=2)]
        public ReferenceType2[] ConveyanceOperatorReference
        {
            get
            {
                return this.conveyanceOperatorReferenceField;
            }
            set
            {
                this.conveyanceOperatorReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ConveyedPersonReference", Order=3)]
        public ReferenceType2[] ConveyedPersonReference
        {
            get
            {
                return this.conveyedPersonReferenceField;
            }
            set
            {
                this.conveyedPersonReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ConveyancePassengerQuantity", IsNullable=true, Order=4)]
        public QuantityType[] ConveyancePassengerQuantity
        {
            get
            {
                return this.conveyancePassengerQuantityField;
            }
            set
            {
                this.conveyancePassengerQuantityField = value;
            }
        }
    }
}
