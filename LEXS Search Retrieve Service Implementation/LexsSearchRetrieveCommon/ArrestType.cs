namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/domains/jxdm/4.1")]
    public partial class ArrestType : ActivityType
    {
        
        private IdentificationType arrestAgencyRecordIdentificationField;
        
        private ArrestCategoryCodeType arrestCategoryCodeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public IdentificationType ArrestAgencyRecordIdentification
        {
            get
            {
                return this.arrestAgencyRecordIdentificationField;
            }
            set
            {
                this.arrestAgencyRecordIdentificationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public ArrestCategoryCodeType ArrestCategoryCode
        {
            get
            {
                return this.arrestCategoryCodeField;
            }
            set
            {
                this.arrestCategoryCodeField = value;
            }
        }
    }
}
