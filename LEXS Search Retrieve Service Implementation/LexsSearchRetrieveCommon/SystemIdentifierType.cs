namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://lexs.gov/lexs/4.0")]
    public partial class SystemIdentifierType : ComplexObjectType
    {
        
        private @string originatingAgencyIDField;
        
        private TextType organizationNameField;
        
        private @string systemIDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public @string OriginatingAgencyID
        {
            get
            {
                return this.originatingAgencyIDField;
            }
            set
            {
                this.originatingAgencyIDField = value;
            }
        }

        // Note: This is a manual modification to prevent NULL elements from being serialized
        public bool ShouldSerializeOrganizationName()
        {
            return organizationNameField != null;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://niem.gov/niem/niem-core/2.0", IsNullable=true, Order=1)]
        public TextType OrganizationName
        {
            get
            {
                return this.organizationNameField;
            }
            set
            {
                this.organizationNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public @string SystemID
        {
            get
            {
                return this.systemIDField;
            }
            set
            {
                this.systemIDField = value;
            }
        }
    }
}
