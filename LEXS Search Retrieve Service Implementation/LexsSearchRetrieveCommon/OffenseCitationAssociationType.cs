namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/domains/jxdm/4.1")]
    public partial class OffenseCitationAssociationType : AssociationType
    {
        
        private ReferenceType2[] offenseReferenceField;
        
        private ReferenceType2[] citationReferenceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OffenseReference", Order=0)]
        public ReferenceType2[] OffenseReference
        {
            get
            {
                return this.offenseReferenceField;
            }
            set
            {
                this.offenseReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CitationReference", Order=1)]
        public ReferenceType2[] CitationReference
        {
            get
            {
                return this.citationReferenceField;
            }
            set
            {
                this.citationReferenceField = value;
            }
        }
    }
}
