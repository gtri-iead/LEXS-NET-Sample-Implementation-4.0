namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/niem-core/2.0")]
    public partial class ItemContainerAssociationType : AssociationType
    {
        
        private ReferenceType2[] itemReferenceField;
        
        private ReferenceType2[] containerReferenceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemReference", Order=0)]
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ContainerReference", Order=1)]
        public ReferenceType2[] ContainerReference
        {
            get
            {
                return this.containerReferenceField;
            }
            set
            {
                this.containerReferenceField = value;
            }
        }
    }
}
