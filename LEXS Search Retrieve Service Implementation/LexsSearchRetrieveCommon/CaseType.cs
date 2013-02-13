namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/niem-core/2.0")]
    public partial class CaseType : ActivityType
    {
        
        private TextType caseTitleTextField;
        
        private TextType caseCategoryTextField;
        
        private TextType caseGeneralCategoryTextField;
        
        private @string caseTrackingIDField;
        
        private @string caseSubCategoryTextField;
        
        private @string caseDocketIDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public TextType CaseTitleText
        {
            get
            {
                return this.caseTitleTextField;
            }
            set
            {
                this.caseTitleTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public TextType CaseCategoryText
        {
            get
            {
                return this.caseCategoryTextField;
            }
            set
            {
                this.caseCategoryTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public TextType CaseGeneralCategoryText
        {
            get
            {
                return this.caseGeneralCategoryTextField;
            }
            set
            {
                this.caseGeneralCategoryTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public @string CaseTrackingID
        {
            get
            {
                return this.caseTrackingIDField;
            }
            set
            {
                this.caseTrackingIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=4)]
        public @string CaseSubCategoryText
        {
            get
            {
                return this.caseSubCategoryTextField;
            }
            set
            {
                this.caseSubCategoryTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=5)]
        public @string CaseDocketID
        {
            get
            {
                return this.caseDocketIDField;
            }
            set
            {
                this.caseDocketIDField = value;
            }
        }
    }
}
