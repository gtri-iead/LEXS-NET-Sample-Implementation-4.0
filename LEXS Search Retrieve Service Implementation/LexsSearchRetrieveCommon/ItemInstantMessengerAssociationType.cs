namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://lexs.gov/digest/4.0")]
    public partial class ItemInstantMessengerAssociationType : AssociationType
    {
        
        private ReferenceType2 itemReferenceField;
        
        private ReferenceType2[] instantMessengerReferenceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://niem.gov/niem/niem-core/2.0", Order=0)]
        public ReferenceType2 ItemReference
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
        [System.Xml.Serialization.XmlElementAttribute("InstantMessengerReference", Order=1)]
        public ReferenceType2[] InstantMessengerReference
        {
            get
            {
                return this.instantMessengerReferenceField;
            }
            set
            {
                this.instantMessengerReferenceField = value;
            }
        }
    }
}
