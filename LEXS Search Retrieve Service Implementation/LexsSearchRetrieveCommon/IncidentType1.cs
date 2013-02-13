namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="IncidentType", Namespace="http://niem.gov/niem/domains/jxdm/4.1")]
    public partial class IncidentType1 : IncidentType
    {
        
        private IncidentAugmentationType incidentAugmentationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public IncidentAugmentationType IncidentAugmentation
        {
            get
            {
                return this.incidentAugmentationField;
            }
            set
            {
                this.incidentAugmentationField = value;
            }
        }
    }
}
