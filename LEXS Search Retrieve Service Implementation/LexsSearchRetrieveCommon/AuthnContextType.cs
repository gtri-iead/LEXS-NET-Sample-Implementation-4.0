namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:tc:SAML:2.0:assertion")]
    public partial class AuthnContextType
    {
        
        private object[] itemsField;
        
        private ItemsChoiceType5[] itemsElementNameField;
        
        private string[] authenticatingAuthorityField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AuthnContextClassRef", typeof(string), DataType="anyURI", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("AuthnContextDecl", typeof(object), Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("AuthnContextDeclRef", typeof(string), DataType="anyURI", Order=0)]
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
        public ItemsChoiceType5[] ItemsElementName
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AuthenticatingAuthority", DataType="anyURI", Order=2)]
        public string[] AuthenticatingAuthority
        {
            get
            {
                return this.authenticatingAuthorityField;
            }
            set
            {
                this.authenticatingAuthorityField = value;
            }
        }
    }
}
