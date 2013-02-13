namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="MetadataType", Namespace="http://lexs.gov/digest/4.0")]
    public partial class MetadataType3 : MetadataType2
    {
        
        private TextType capturingOrganizationTextField;
        
        private TextType logicalIDTextField;
        
        private boolean nonCriminalIdentifierIndicatorField;
        
        private boolean privacyInformationIndicatorField;
        
        private TextType verifyingOrganizationTextField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public TextType CapturingOrganizationText
        {
            get
            {
                return this.capturingOrganizationTextField;
            }
            set
            {
                this.capturingOrganizationTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public TextType LogicalIDText
        {
            get
            {
                return this.logicalIDTextField;
            }
            set
            {
                this.logicalIDTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public boolean NonCriminalIdentifierIndicator
        {
            get
            {
                return this.nonCriminalIdentifierIndicatorField;
            }
            set
            {
                this.nonCriminalIdentifierIndicatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public boolean PrivacyInformationIndicator
        {
            get
            {
                return this.privacyInformationIndicatorField;
            }
            set
            {
                this.privacyInformationIndicatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=4)]
        public TextType VerifyingOrganizationText
        {
            get
            {
                return this.verifyingOrganizationTextField;
            }
            set
            {
                this.verifyingOrganizationTextField = value;
            }
        }
    }
}
