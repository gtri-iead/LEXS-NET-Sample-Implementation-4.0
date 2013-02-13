namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/domains/jxdm/4.1")]
    public partial class BookingType : ActivityType
    {
        
        private IdentificationType bookingAgencyRecordIdentificationField;
        
        private IdentificationType bookingDocumentControlIdentificationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public IdentificationType BookingAgencyRecordIdentification
        {
            get
            {
                return this.bookingAgencyRecordIdentificationField;
            }
            set
            {
                this.bookingAgencyRecordIdentificationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public IdentificationType BookingDocumentControlIdentification
        {
            get
            {
                return this.bookingDocumentControlIdentificationField;
            }
            set
            {
                this.bookingDocumentControlIdentificationField = value;
            }
        }
    }
}
