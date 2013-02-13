namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/domains/intelligence/2.1")]
    public partial class IdentityAssociationType : AssociationType
    {
        
        private ReferenceType2 authenticatedIdentityReferenceField;
        
        private ReferenceType2 primaryIdentityReferenceField;
        
        private ReferenceType2[] identityReferenceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ReferenceType2 AuthenticatedIdentityReference
        {
            get
            {
                return this.authenticatedIdentityReferenceField;
            }
            set
            {
                this.authenticatedIdentityReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public ReferenceType2 PrimaryIdentityReference
        {
            get
            {
                return this.primaryIdentityReferenceField;
            }
            set
            {
                this.primaryIdentityReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IdentityReference", Order=2)]
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
    }
}
