namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/domains/maritime/2.1")]
    public partial class WatchListAssociationType : AssociationType
    {
        
        private ReferenceType2[] organizationReferenceField;
        
        private ReferenceType2[] itemsField;
        
        private ItemsChoiceType8[] itemsElementNameField;
        
        private TextType watchListEntryReasonOfInterestField;
        
        private TextType watchListEntryTitleField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OrganizationReference", Namespace="http://niem.gov/niem/niem-core/2.0", Order=0)]
        public ReferenceType2[] OrganizationReference
        {
            get
            {
                return this.organizationReferenceField;
            }
            set
            {
                this.organizationReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WatchListAircraftReference", typeof(ReferenceType2), Order=1)]
        [System.Xml.Serialization.XmlElementAttribute("WatchListOrganizationReference", typeof(ReferenceType2), Order=1)]
        [System.Xml.Serialization.XmlElementAttribute("WatchListPersonReference", typeof(ReferenceType2), Order=1)]
        [System.Xml.Serialization.XmlElementAttribute("WatchListVehicleReference", typeof(ReferenceType2), Order=1)]
        [System.Xml.Serialization.XmlElementAttribute("WatchListVesselReference", typeof(ReferenceType2), Order=1)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public ReferenceType2[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName", Order=2)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType8[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public TextType WatchListEntryReasonOfInterest
        {
            get
            {
                return this.watchListEntryReasonOfInterestField;
            }
            set
            {
                this.watchListEntryReasonOfInterestField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=4)]
        public TextType WatchListEntryTitle
        {
            get
            {
                return this.watchListEntryTitleField;
            }
            set
            {
                this.watchListEntryTitleField = value;
            }
        }
    }
}
