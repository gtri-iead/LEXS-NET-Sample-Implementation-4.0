namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://lexs.gov/digest/4.0")]
    public partial class ArrestOtherAssociationType : AssociationType
    {
        
        private ReferenceType2[] arrestReferenceField;
        
        private ReferenceType2[] otherReferenceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ArrestReference", Namespace="http://niem.gov/niem/domains/jxdm/4.1", Order=0)]
        public ReferenceType2[] ArrestReference
        {
            get
            {
                return this.arrestReferenceField;
            }
            set
            {
                this.arrestReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OtherReference", Order=1)]
        public ReferenceType2[] OtherReference
        {
            get
            {
                return this.otherReferenceField;
            }
            set
            {
                this.otherReferenceField = value;
            }
        }
    }
}
