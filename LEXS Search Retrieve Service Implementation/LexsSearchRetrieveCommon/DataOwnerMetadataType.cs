namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ulex.gov/ulex/2.0")]
    public partial class DataOwnerMetadataType
    {
        
        private object dataOwnerIdentifierAbstractField;
        
        private object dataOwnerContactAbstractField;
        
        private DomainAttributeType[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("DataOwnerIdentifier", typeof(DataOwnerIdentifierType), Namespace="http://lexs.gov/lexs/4.0", IsNullable=false, Order=0)]
        public object DataOwnerIdentifierAbstract
        {
            get
            {
                return this.dataOwnerIdentifierAbstractField;
            }
            set
            {
                this.dataOwnerIdentifierAbstractField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        [System.Xml.Serialization.XmlElementAttribute("DataOwnerContact", typeof(DataContactType), Namespace="http://lexs.gov/lexs/4.0", IsNullable=false, Order=1)]
        public object DataOwnerContactAbstract
        {
            get
            {
                return this.dataOwnerContactAbstractField;
            }
            set
            {
                this.dataOwnerContactAbstractField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DataOwnerMetadataDomainAttribute", Order=2)]
        public DomainAttributeType[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }
}
