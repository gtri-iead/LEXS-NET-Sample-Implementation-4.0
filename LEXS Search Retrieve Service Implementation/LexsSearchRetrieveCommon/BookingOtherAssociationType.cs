namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://lexs.gov/digest/4.0")]
    public partial class BookingOtherAssociationType : AssociationType
    {
        
        private ReferenceType2[] bookingReferenceField;
        
        private ReferenceType2[] otherReferenceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BookingReference", Order=0)]
        public ReferenceType2[] BookingReference
        {
            get
            {
                return this.bookingReferenceField;
            }
            set
            {
                this.bookingReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OtherReference", Order=1)]
        public ReferenceType2[] OtherReference
        {
            get
            {
                return this.otherReferenceField;
            }
            set
            {
                this.otherReferenceField = value;
            }
        }
    }
}
