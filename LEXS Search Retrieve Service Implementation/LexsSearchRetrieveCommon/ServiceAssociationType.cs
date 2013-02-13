namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://lexs.gov/digest/4.0")]
    public partial class ServiceAssociationType : AssociationType
    {
        
        private TextType serviceDescriptionTextField;
        
        private EntityType1[] serviceProviderEntityField;
        
        private EntityType1[] serviceRecipientEntityField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public TextType ServiceDescriptionText
        {
            get
            {
                return this.serviceDescriptionTextField;
            }
            set
            {
                this.serviceDescriptionTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ServiceProviderEntity", IsNullable=true, Order=1)]
        public EntityType1[] ServiceProviderEntity
        {
            get
            {
                return this.serviceProviderEntityField;
            }
            set
            {
                this.serviceProviderEntityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ServiceRecipientEntity", IsNullable=true, Order=2)]
        public EntityType1[] ServiceRecipientEntity
        {
            get
            {
                return this.serviceRecipientEntityField;
            }
            set
            {
                this.serviceRecipientEntityField = value;
            }
        }
    }
}
