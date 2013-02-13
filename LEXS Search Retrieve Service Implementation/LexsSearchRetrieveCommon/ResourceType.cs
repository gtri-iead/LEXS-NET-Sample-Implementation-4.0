namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/domains/emergencyManagement/2.1")]
    public partial class ResourceType : ComplexObjectType
    {
        
        private ReferenceType2 roleOfPersonReferenceField;
        
        private ReferenceType2 roleOfItemReferenceField;
        
        private TextType resourceNameField;
        
        private TextType resourceDescriptionTextField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://niem.gov/niem/niem-core/2.0", Order=0)]
        public ReferenceType2 RoleOfPersonReference
        {
            get
            {
                return this.roleOfPersonReferenceField;
            }
            set
            {
                this.roleOfPersonReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://niem.gov/niem/niem-core/2.0", Order=1)]
        public ReferenceType2 RoleOfItemReference
        {
            get
            {
                return this.roleOfItemReferenceField;
            }
            set
            {
                this.roleOfItemReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public TextType ResourceName
        {
            get
            {
                return this.resourceNameField;
            }
            set
            {
                this.resourceNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public TextType ResourceDescriptionText
        {
            get
            {
                return this.resourceDescriptionTextField;
            }
            set
            {
                this.resourceDescriptionTextField = value;
            }
        }
    }
}
