namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityWarrantType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityVesselType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityVehicleType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityTelephoneNumberType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityTangibleItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntitySupervisionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntitySubstanceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityServiceCallType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntitySentenceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityProsecutionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityProgramType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityPersonType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityOtherType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityOrganizationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityOffenseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityNotificationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityNetworkAddressType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityLocationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityIntangibleItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityInstantMessengerType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityIncidentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityHashType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityFirearmType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityExplosiveType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityEmailType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityDrugType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityDocumentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityCreditCardType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityCourtActivityType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityCitationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityCaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityBookingType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityAssociationsType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityArrestType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityAircraftType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityActivityType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://lexs.gov/digest/4.0")]
    public partial class EntityType : ComplexObjectType
    {
        
        private ICISMMetadataType[] iCISMMetadataField;
        
        private MetadataType3[] metadataField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ICISMMetadata", Namespace="http://niem.gov/niem/icism/2.0", Order=0)]
        public ICISMMetadataType[] ICISMMetadata
        {
            get
            {
                return this.iCISMMetadataField;
            }
            set
            {
                this.iCISMMetadataField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Metadata", IsNullable=true, Order=1)]
        public MetadataType3[] Metadata
        {
            get
            {
                return this.metadataField;
            }
            set
            {
                this.metadataField = value;
            }
        }
    }
}
