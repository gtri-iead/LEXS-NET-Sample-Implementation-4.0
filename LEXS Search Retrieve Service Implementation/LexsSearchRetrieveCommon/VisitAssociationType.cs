namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://lexs.gov/digest/4.0")]
    public partial class VisitAssociationType : AssociationType
    {
        
        private EntityType1[] visitorEntityField;
        
        private TextType visitDescriptionTextField;
        
        private EntityType1[] visitedEntityField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("VisitorEntity", IsNullable=true, Order=0)]
        public EntityType1[] VisitorEntity
        {
            get
            {
                return this.visitorEntityField;
            }
            set
            {
                this.visitorEntityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public TextType VisitDescriptionText
        {
            get
            {
                return this.visitDescriptionTextField;
            }
            set
            {
                this.visitDescriptionTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("VisitedEntity", IsNullable=true, Order=2)]
        public EntityType1[] VisitedEntity
        {
            get
            {
                return this.visitedEntityField;
            }
            set
            {
                this.visitedEntityField = value;
            }
        }
    }
}
