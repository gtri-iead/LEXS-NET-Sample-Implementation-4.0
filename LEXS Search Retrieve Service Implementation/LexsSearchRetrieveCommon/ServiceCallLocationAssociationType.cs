namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://lexs.gov/digest/4.0")]
    public partial class ServiceCallLocationAssociationType : AssociationType
    {
        
        private ReferenceType2 serviceCallReferenceField;
        
        private ReferenceType2[] locationReferenceField;
        
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
        [System.Xml.Serialization.XmlElementAttribute("LocationReference", Namespace="http://niem.gov/niem/niem-core/2.0", Order=1)]
        public ReferenceType2[] LocationReference
        {
            get
            {
                return this.locationReferenceField;
            }
            set
            {
                this.locationReferenceField = value;
            }
        }
    }
}
