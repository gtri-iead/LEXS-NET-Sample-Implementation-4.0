namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://lexs.gov/digest/4.0")]
    public partial class EntityTelephoneNumberAssociationType : AssociationType
    {
        
        private ComplexObjectType[] itemsField;
        
        private ReferenceType2[] telephoneNumberReferenceField;
        
        private boolean telephoneNumberPrimaryIndicatorField;
        
        private boolean telephoneNumberHomeIndicatorField;
        
        private boolean telephoneNumberWorkIndicatorField;
        
        private boolean telephoneNumberEmergencyIndicatorField;
        
        private boolean telephoneNumberDayIndicatorField;
        
        private boolean telephoneNumberEveningIndicatorField;
        
        private boolean telephoneNumberNightIndicatorField;
        
        private boolean telephoneNumberUnspecifiedIndicatorField;
        
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
        [System.Xml.Serialization.XmlElementAttribute("TelephoneNumberReference", Namespace="http://niem.gov/niem/niem-core/2.0", Order=1)]
        public ReferenceType2[] TelephoneNumberReference
        {
            get
            {
                return this.telephoneNumberReferenceField;
            }
            set
            {
                this.telephoneNumberReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public boolean TelephoneNumberPrimaryIndicator
        {
            get
            {
                return this.telephoneNumberPrimaryIndicatorField;
            }
            set
            {
                this.telephoneNumberPrimaryIndicatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public boolean TelephoneNumberHomeIndicator
        {
            get
            {
                return this.telephoneNumberHomeIndicatorField;
            }
            set
            {
                this.telephoneNumberHomeIndicatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=4)]
        public boolean TelephoneNumberWorkIndicator
        {
            get
            {
                return this.telephoneNumberWorkIndicatorField;
            }
            set
            {
                this.telephoneNumberWorkIndicatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=5)]
        public boolean TelephoneNumberEmergencyIndicator
        {
            get
            {
                return this.telephoneNumberEmergencyIndicatorField;
            }
            set
            {
                this.telephoneNumberEmergencyIndicatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=6)]
        public boolean TelephoneNumberDayIndicator
        {
            get
            {
                return this.telephoneNumberDayIndicatorField;
            }
            set
            {
                this.telephoneNumberDayIndicatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=7)]
        public boolean TelephoneNumberEveningIndicator
        {
            get
            {
                return this.telephoneNumberEveningIndicatorField;
            }
            set
            {
                this.telephoneNumberEveningIndicatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=8)]
        public boolean TelephoneNumberNightIndicator
        {
            get
            {
                return this.telephoneNumberNightIndicatorField;
            }
            set
            {
                this.telephoneNumberNightIndicatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=9)]
        public boolean TelephoneNumberUnspecifiedIndicator
        {
            get
            {
                return this.telephoneNumberUnspecifiedIndicatorField;
            }
            set
            {
                this.telephoneNumberUnspecifiedIndicatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=10)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=11)]
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
