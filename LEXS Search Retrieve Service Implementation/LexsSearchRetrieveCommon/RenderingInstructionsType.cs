namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ulex.gov/ulex/2.0")]
    public partial class RenderingInstructionsType
    {
        
        private string attachmentURIField;
        
        private decimal attachmentSizeValueField;
        
        private bool attachmentSizeValueFieldSpecified;
        
        private RenderingMethodCodeSimpleType renderingMethodCodeField;
        
        private string renderingOutputFormatIDField;
        
        private string renderingOutputFormatStandardNameField;
        
        private RenderingParameterType[] renderingParameterField;
        
        private string renderingDescriptionTextField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI", Order=0)]
        public string AttachmentURI
        {
            get
            {
                return this.attachmentURIField;
            }
            set
            {
                this.attachmentURIField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public decimal AttachmentSizeValue
        {
            get
            {
                return this.attachmentSizeValueField;
            }
            set
            {
                this.attachmentSizeValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AttachmentSizeValueSpecified
        {
            get
            {
                return this.attachmentSizeValueFieldSpecified;
            }
            set
            {
                this.attachmentSizeValueFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public RenderingMethodCodeSimpleType RenderingMethodCode
        {
            get
            {
                return this.renderingMethodCodeField;
            }
            set
            {
                this.renderingMethodCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string RenderingOutputFormatID
        {
            get
            {
                return this.renderingOutputFormatIDField;
            }
            set
            {
                this.renderingOutputFormatIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string RenderingOutputFormatStandardName
        {
            get
            {
                return this.renderingOutputFormatStandardNameField;
            }
            set
            {
                this.renderingOutputFormatStandardNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RenderingParameter", Order=5)]
        public RenderingParameterType[] RenderingParameter
        {
            get
            {
                return this.renderingParameterField;
            }
            set
            {
                this.renderingParameterField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string RenderingDescriptionText
        {
            get
            {
                return this.renderingDescriptionTextField;
            }
            set
            {
                this.renderingDescriptionTextField = value;
            }
        }
    }
}
