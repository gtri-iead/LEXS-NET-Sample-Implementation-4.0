namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://lexs.gov/digest/4.0")]
    public partial class EntityOffenseType : EntityType
    {
        
        private OffenseType offenseField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://niem.gov/niem/domains/jxdm/4.1", IsNullable=true, Order=0)]
        public OffenseType Offense
        {
            get
            {
                return this.offenseField;
            }
            set
            {
                this.offenseField = value;
            }
        }
    }
}
