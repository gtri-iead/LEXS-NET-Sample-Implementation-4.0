namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/domains/familyServices/2.1")]
    public partial class MarriageAssociationAugmentationType : AugmentationType
    {
        
        private boolean divorcePendingIndicatorField;
        
        private date[] maritalSeparationDateField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public boolean DivorcePendingIndicator
        {
            get
            {
                return this.divorcePendingIndicatorField;
            }
            set
            {
                this.divorcePendingIndicatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaritalSeparationDate", IsNullable=true, Order=1)]
        public date[] MaritalSeparationDate
        {
            get
            {
                return this.maritalSeparationDateField;
            }
            set
            {
                this.maritalSeparationDateField = value;
            }
        }
    }
}
