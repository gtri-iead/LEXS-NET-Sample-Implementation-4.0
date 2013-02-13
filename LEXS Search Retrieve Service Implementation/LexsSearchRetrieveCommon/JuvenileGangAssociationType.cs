namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/domains/familyServices/2.1")]
    public partial class JuvenileGangAssociationType : AssociationType
    {
        
        private ReferenceType2[] juvenileGangMemberReferenceField;
        
        private ReferenceType2[] gangOrganizationReferenceField;
        
        private TextType juvenileGangAssociationDescriptionTextField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("JuvenileGangMemberReference", Order=0)]
        public ReferenceType2[] JuvenileGangMemberReference
        {
            get
            {
                return this.juvenileGangMemberReferenceField;
            }
            set
            {
                this.juvenileGangMemberReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("GangOrganizationReference", Order=1)]
        public ReferenceType2[] GangOrganizationReference
        {
            get
            {
                return this.gangOrganizationReferenceField;
            }
            set
            {
                this.gangOrganizationReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public TextType JuvenileGangAssociationDescriptionText
        {
            get
            {
                return this.juvenileGangAssociationDescriptionTextField;
            }
            set
            {
                this.juvenileGangAssociationDescriptionTextField = value;
            }
        }
    }
}
