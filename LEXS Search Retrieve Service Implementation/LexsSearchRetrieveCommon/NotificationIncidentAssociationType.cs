namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/domains/emergencyManagement/2.1")]
    public partial class NotificationIncidentAssociationType : AssociationType
    {
        
        private ReferenceType2[] notificationReferenceField;
        
        private ReferenceType2[] incidentReferenceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NotificationReference", Order=0)]
        public ReferenceType2[] NotificationReference
        {
            get
            {
                return this.notificationReferenceField;
            }
            set
            {
                this.notificationReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IncidentReference", Namespace="http://niem.gov/niem/niem-core/2.0", Order=1)]
        public ReferenceType2[] IncidentReference
        {
            get
            {
                return this.incidentReferenceField;
            }
            set
            {
                this.incidentReferenceField = value;
            }
        }
    }
}
