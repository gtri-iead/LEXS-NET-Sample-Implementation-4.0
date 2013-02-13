namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:tc:SAML:2.0:assertion")]
    public partial class SubjectConfirmationType
    {
        
        private object itemField;
        
        private SubjectConfirmationDataType subjectConfirmationDataField;
        
        private string methodField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BaseID", typeof(BaseIDAbstractType), Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EncryptedID", typeof(EncryptedElementType), Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("NameID", typeof(NameIDType), Order=0)]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public SubjectConfirmationDataType SubjectConfirmationData
        {
            get
            {
                return this.subjectConfirmationDataField;
            }
            set
            {
                this.subjectConfirmationDataField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string Method
        {
            get
            {
                return this.methodField;
            }
            set
            {
                this.methodField = value;
            }
        }
    }
}
