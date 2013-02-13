namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://lexs.gov/digest/4.0")]
    public partial class BailBondAssociationType : AssociationType
    {
        
        private EntityType1[] bailingEntityField;
        
        private ReferenceType2 baileePersonReferenceField;
        
        private EntityType1[] bailBondsmanEntityField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BailingEntity", IsNullable=true, Order=0)]
        public EntityType1[] BailingEntity
        {
            get
            {
                return this.bailingEntityField;
            }
            set
            {
                this.bailingEntityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public ReferenceType2 BaileePersonReference
        {
            get
            {
                return this.baileePersonReferenceField;
            }
            set
            {
                this.baileePersonReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BailBondsmanEntity", IsNullable=true, Order=2)]
        public EntityType1[] BailBondsmanEntity
        {
            get
            {
                return this.bailBondsmanEntityField;
            }
            set
            {
                this.bailBondsmanEntityField = value;
            }
        }
    }
}
