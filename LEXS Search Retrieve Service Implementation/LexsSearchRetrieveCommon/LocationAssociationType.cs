namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/domains/screening/2.1")]
    public partial class LocationAssociationType : AssociationType
    {
        
        private ReferenceType2[] primaryLocationReferenceField;
        
        private ReferenceType2[] secondaryLocationReferenceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PrimaryLocationReference", Order=0)]
        public ReferenceType2[] PrimaryLocationReference
        {
            get
            {
                return this.primaryLocationReferenceField;
            }
            set
            {
                this.primaryLocationReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SecondaryLocationReference", Order=1)]
        public ReferenceType2[] SecondaryLocationReference
        {
            get
            {
                return this.secondaryLocationReferenceField;
            }
            set
            {
                this.secondaryLocationReferenceField = value;
            }
        }
    }
}
