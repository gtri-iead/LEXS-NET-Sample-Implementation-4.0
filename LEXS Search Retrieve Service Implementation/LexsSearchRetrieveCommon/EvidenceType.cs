namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:tc:SAML:2.0:assertion")]
    public partial class EvidenceType
    {
        
        private object[] itemsField;
        
        private ItemsChoiceType6[] itemsElementNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Assertion", typeof(AssertionType), Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("AssertionIDRef", typeof(string), DataType="NCName", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("AssertionURIRef", typeof(string), DataType="anyURI", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EncryptedAssertion", typeof(EncryptedElementType), Order=0)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName", Order=1)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType6[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }
    }
}
