namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/domains/intelligence/2.1")]
    public partial class PotentialIdentityMatchAssociationType : AssociationType
    {
        
        private ReferenceType2[] identityReferenceField;
        
        private TextType potentialIdentityMatchDescriptionTextField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IdentityReference", Order=0)]
        public ReferenceType2[] IdentityReference
        {
            get
            {
                return this.identityReferenceField;
            }
            set
            {
                this.identityReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public TextType PotentialIdentityMatchDescriptionText
        {
            get
            {
                return this.potentialIdentityMatchDescriptionTextField;
            }
            set
            {
                this.potentialIdentityMatchDescriptionTextField = value;
            }
        }
    }
}
