namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:tc:SAML:2.0:assertion")]
    public partial class SubjectType
    {
        
        private object[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BaseID", typeof(BaseIDAbstractType), Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EncryptedID", typeof(EncryptedElementType), Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("NameID", typeof(NameIDType), Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("SubjectConfirmation", typeof(SubjectConfirmationType), Order=0)]
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
    }
}
