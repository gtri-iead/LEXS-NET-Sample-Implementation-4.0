namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://lexs.gov/digest/4.0")]
    public partial class PersonBOPRegisterNumberType : IdentificationType
    {
        
        private boolean bOPRegisterNumberOriginatorIndicatorField;
        
        private boolean uSMSRegisterNumberOriginatorIndicatorField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public boolean BOPRegisterNumberOriginatorIndicator
        {
            get
            {
                return this.bOPRegisterNumberOriginatorIndicatorField;
            }
            set
            {
                this.bOPRegisterNumberOriginatorIndicatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public boolean USMSRegisterNumberOriginatorIndicator
        {
            get
            {
                return this.uSMSRegisterNumberOriginatorIndicatorField;
            }
            set
            {
                this.uSMSRegisterNumberOriginatorIndicatorField = value;
            }
        }
    }
}
