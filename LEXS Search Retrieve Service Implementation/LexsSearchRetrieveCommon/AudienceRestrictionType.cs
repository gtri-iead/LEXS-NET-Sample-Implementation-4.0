namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:tc:SAML:2.0:assertion")]
    public partial class AudienceRestrictionType : ConditionAbstractType
    {
        
        private string[] audienceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Audience", DataType="anyURI", Order=0)]
        public string[] Audience
        {
            get
            {
                return this.audienceField;
            }
            set
            {
                this.audienceField = value;
            }
        }
    }
}
