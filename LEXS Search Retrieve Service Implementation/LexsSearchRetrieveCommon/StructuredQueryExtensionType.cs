namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://lexs.gov/lexs/4.0")]
    public partial class StructuredQueryExtensionType : ComplexObjectType
    {
        
        private RoleListType roleListField;
        
        private System.Xml.XmlQualifiedName[] associationQNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public RoleListType RoleList
        {
            get
            {
                return this.roleListField;
            }
            set
            {
                this.roleListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AssociationQName", Order=1)]
        public System.Xml.XmlQualifiedName[] AssociationQName
        {
            get
            {
                return this.associationQNameField;
            }
            set
            {
                this.associationQNameField = value;
            }
        }
    }
}
