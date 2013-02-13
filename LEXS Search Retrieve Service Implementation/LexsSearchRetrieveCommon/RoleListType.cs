namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://lexs.gov/lexs/4.0")]
    public partial class RoleListType : ComplexObjectType
    {
        
        private boolean roleInclusiveIndicatorField;
        
        private RoleTypeCodeType[] roleTypeCodeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public boolean RoleInclusiveIndicator
        {
            get
            {
                return this.roleInclusiveIndicatorField;
            }
            set
            {
                this.roleInclusiveIndicatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RoleTypeCode", Order=1)]
        public RoleTypeCodeType[] RoleTypeCode
        {
            get
            {
                return this.roleTypeCodeField;
            }
            set
            {
                this.roleTypeCodeField = value;
            }
        }
    }
}
