namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://lexs.gov/digest/4.0")]
    public partial class ServiceCallInstantMessengerAssociationType : AssociationType
    {
        
        private ReferenceType2 serviceCallReferenceField;
        
        private ReferenceType2[] instantMessengerReferenceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://niem.gov/niem/domains/jxdm/4.1", Order=0)]
        public ReferenceType2 ServiceCallReference
        {
            get
            {
                return this.serviceCallReferenceField;
            }
            set
            {
                this.serviceCallReferenceField = value;
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
