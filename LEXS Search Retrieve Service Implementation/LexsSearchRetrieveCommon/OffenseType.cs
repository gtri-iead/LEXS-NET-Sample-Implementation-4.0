namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/domains/jxdm/4.1")]
    public partial class OffenseType : ActivityType
    {
        
        private object item1Field;
        
        private TextType item2Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OffenseCategoryCode", typeof(CriminalActivityCategoryCodeType), IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("OffenseCategoryText", typeof(TextType), IsNullable=true, Order=0)]
        public object Item1
        {
            get
            {
                return this.item1Field;
            }
            set
            {
                this.item1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OffenseLevelText", IsNullable=true, Order=1)]
        public TextType Item2
        {
            get
            {
                return this.item2Field;
            }
            set
            {
                this.item2Field = value;
            }
        }
    }
}
