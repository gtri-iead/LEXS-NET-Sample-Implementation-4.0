namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/niem-core/2.0")]
    public partial class PersonItemAssociationType : AssociationType
    {
        
        private ReferenceType2[] personReferenceField;
        
        private ReferenceType2[] itemReferenceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonReference", Order=0)]
        public ReferenceType2[] PersonReference
        {
            get
            {
                return this.personReferenceField;
            }
            set
            {
                this.personReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemReference", Order=1)]
        public ReferenceType2[] ItemReference
        {
            get
            {
                return this.itemReferenceField;
            }
            set
            {
                this.itemReferenceField = value;
            }
        }
    }
}
