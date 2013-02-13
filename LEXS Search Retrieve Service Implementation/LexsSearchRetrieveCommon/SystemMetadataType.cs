namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ulex.gov/ulex/2.0")]
    public partial class SystemMetadataType
    {
        
        private object systemIdentifierAbstractField;
        
        private object systemContactAbstractField;
        
        private DomainAttributeType[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("SystemIdentifier", typeof(SystemIdentifierType), Namespace="http://lexs.gov/lexs/4.0", IsNullable=false, Order=0)]
        public object SystemIdentifierAbstract
        {
            get
            {
                return this.systemIdentifierAbstractField;
            }
            set
            {
                this.systemIdentifierAbstractField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        [System.Xml.Serialization.XmlElementAttribute("SystemContact", typeof(DataContactType), Namespace="http://lexs.gov/lexs/4.0", IsNullable=false, Order=1)]
        public object SystemContactAbstract
        {
            get
            {
                return this.systemContactAbstractField;
            }
            set
            {
                this.systemContactAbstractField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SystemMetadataDomainAttribute", Order=2)]
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
