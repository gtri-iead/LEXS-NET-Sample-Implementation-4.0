namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://lexs.gov/digest/4.0")]
    public partial class IncidentVictimAssociationType : AssociationType
    {
        
        private ReferenceType2[] incidentReferenceField;
        
        private ReferenceType2[] victimReferenceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IncidentReference", Namespace="http://niem.gov/niem/niem-core/2.0", Order=0)]
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("VictimReference", Namespace="http://niem.gov/niem/domains/jxdm/4.1", Order=1)]
        public ReferenceType2[] VictimReference
        {
            get
            {
                return this.victimReferenceField;
            }
            set
            {
                this.victimReferenceField = value;
            }
        }
    }
}
