namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://lexs.gov/digest/4.0")]
    public partial class PawnItemSalesAssociationType : AssociationType
    {
        
        private ReferenceType2 pawnShopReferenceField;
        
        private ReferenceType2 buyerPersonReferenceField;
        
        private ReferenceType2[] itemReferenceField;
        
        private TextType transactionDescriptionTextField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ReferenceType2 PawnShopReference
        {
            get
            {
                return this.pawnShopReferenceField;
            }
            set
            {
                this.pawnShopReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public ReferenceType2 BuyerPersonReference
        {
            get
            {
                return this.buyerPersonReferenceField;
            }
            set
            {
                this.buyerPersonReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemReference", Namespace="http://niem.gov/niem/niem-core/2.0", Order=2)]
        public ReferenceType2[] ItemReference
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public TextType TransactionDescriptionText
        {
            get
            {
                return this.transactionDescriptionTextField;
            }
            set
            {
                this.transactionDescriptionTextField = value;
            }
        }
    }
}
