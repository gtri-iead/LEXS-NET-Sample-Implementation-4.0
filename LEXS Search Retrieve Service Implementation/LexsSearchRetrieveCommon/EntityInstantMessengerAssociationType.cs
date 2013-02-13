namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://lexs.gov/digest/4.0")]
    public partial class EntityInstantMessengerAssociationType : AssociationType
    {
        
        private ComplexObjectType[] itemsField;
        
        private ReferenceType2[] instantMessengerReferenceField;
        
        private boolean subscriberIndicatorField;
        
        private boolean userIndicatorField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EntityActivity", typeof(EntityActivityType), IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityAircraft", typeof(EntityAircraftType), IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityArrest", typeof(EntityArrestType), IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityBooking", typeof(EntityBookingType), IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityCase", typeof(EntityCaseType), IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityCitation", typeof(EntityCitationType), IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityCourtActivity", typeof(EntityCourtActivityType), IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityCreditCard", typeof(EntityCreditCardType), IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityDocument", typeof(EntityDocumentType), IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityDrug", typeof(EntityDrugType), IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityEmail", typeof(EntityEmailType), IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityExplosive", typeof(EntityExplosiveType), IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityFirearm", typeof(EntityFirearmType), IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityHash", typeof(EntityHashType), IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityIncident", typeof(EntityIncidentType), IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityInstantMessenger", typeof(EntityInstantMessengerType), IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityIntangibleItem", typeof(EntityIntangibleItemType), IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityLocation", typeof(EntityLocationType), IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityNetworkAddress", typeof(EntityNetworkAddressType), IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityNotification", typeof(EntityNotificationType), IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityOffense", typeof(EntityOffenseType), IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityOrganization", typeof(EntityOrganizationType), IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityOther", typeof(EntityOtherType), IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityPerson", typeof(EntityPersonType), IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityProgram", typeof(EntityProgramType), IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityProsecution", typeof(EntityProsecutionType), IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntitySentence", typeof(EntitySentenceType), IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityServiceCall", typeof(EntityServiceCallType), IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntitySubstance", typeof(EntitySubstanceType), IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntitySupervision", typeof(EntitySupervisionType), IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityTangibleItem", typeof(EntityTangibleItemType), IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityTelephoneNumber", typeof(EntityTelephoneNumberType), IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityVehicle", typeof(EntityVehicleType), IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityVessel", typeof(EntityVesselType), IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityWarrant", typeof(EntityWarrantType), IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("Entity", typeof(EntityType1), Namespace="http://niem.gov/niem/niem-core/2.0", IsNullable=true, Order=0)]
        public ComplexObjectType[] Items
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
        [System.Xml.Serialization.XmlElementAttribute("InstantMessengerReference", Order=1)]
        public ReferenceType2[] InstantMessengerReference
        {
            get
            {
                return this.instantMessengerReferenceField;
            }
            set
            {
                this.instantMessengerReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public boolean SubscriberIndicator
        {
            get
            {
                return this.subscriberIndicatorField;
            }
            set
            {
                this.subscriberIndicatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public boolean UserIndicator
        {
            get
            {
                return this.userIndicatorField;
            }
            set
            {
                this.userIndicatorField = value;
            }
        }
    }
}
