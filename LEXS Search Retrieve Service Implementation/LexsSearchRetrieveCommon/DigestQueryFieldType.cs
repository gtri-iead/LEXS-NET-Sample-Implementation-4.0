namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://lexs.gov/lexs/4.0")]
    public partial class DigestQueryFieldType : ComplexObjectType
    {
        
        private EntityType itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EntityActivity", typeof(EntityActivityType), Namespace="http://lexs.gov/digest/4.0", IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityAircraft", typeof(EntityAircraftType), Namespace="http://lexs.gov/digest/4.0", IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityArrest", typeof(EntityArrestType), Namespace="http://lexs.gov/digest/4.0", IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityBooking", typeof(EntityBookingType), Namespace="http://lexs.gov/digest/4.0", IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityCase", typeof(EntityCaseType), Namespace="http://lexs.gov/digest/4.0", IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityCitation", typeof(EntityCitationType), Namespace="http://lexs.gov/digest/4.0", IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityCourtActivity", typeof(EntityCourtActivityType), Namespace="http://lexs.gov/digest/4.0", IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityCreditCard", typeof(EntityCreditCardType), Namespace="http://lexs.gov/digest/4.0", IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityDocument", typeof(EntityDocumentType), Namespace="http://lexs.gov/digest/4.0", IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityDrug", typeof(EntityDrugType), Namespace="http://lexs.gov/digest/4.0", IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityEmail", typeof(EntityEmailType), Namespace="http://lexs.gov/digest/4.0", IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityExplosive", typeof(EntityExplosiveType), Namespace="http://lexs.gov/digest/4.0", IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityFirearm", typeof(EntityFirearmType), Namespace="http://lexs.gov/digest/4.0", IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityHash", typeof(EntityHashType), Namespace="http://lexs.gov/digest/4.0", IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityIncident", typeof(EntityIncidentType), Namespace="http://lexs.gov/digest/4.0", IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityInstantMessenger", typeof(EntityInstantMessengerType), Namespace="http://lexs.gov/digest/4.0", IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityIntangibleItem", typeof(EntityIntangibleItemType), Namespace="http://lexs.gov/digest/4.0", IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityLocation", typeof(EntityLocationType), Namespace="http://lexs.gov/digest/4.0", IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityNetworkAddress", typeof(EntityNetworkAddressType), Namespace="http://lexs.gov/digest/4.0", IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityNotification", typeof(EntityNotificationType), Namespace="http://lexs.gov/digest/4.0", IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityOffense", typeof(EntityOffenseType), Namespace="http://lexs.gov/digest/4.0", IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityOrganization", typeof(EntityOrganizationType), Namespace="http://lexs.gov/digest/4.0", IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityOther", typeof(EntityOtherType), Namespace="http://lexs.gov/digest/4.0", IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityPerson", typeof(EntityPersonType), Namespace="http://lexs.gov/digest/4.0", IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityProgram", typeof(EntityProgramType), Namespace="http://lexs.gov/digest/4.0", IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityProsecution", typeof(EntityProsecutionType), Namespace="http://lexs.gov/digest/4.0", IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntitySentence", typeof(EntitySentenceType), Namespace="http://lexs.gov/digest/4.0", IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityServiceCall", typeof(EntityServiceCallType), Namespace="http://lexs.gov/digest/4.0", IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntitySubstance", typeof(EntitySubstanceType), Namespace="http://lexs.gov/digest/4.0", IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntitySupervision", typeof(EntitySupervisionType), Namespace="http://lexs.gov/digest/4.0", IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityTangibleItem", typeof(EntityTangibleItemType), Namespace="http://lexs.gov/digest/4.0", IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityTelephoneNumber", typeof(EntityTelephoneNumberType), Namespace="http://lexs.gov/digest/4.0", IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityVehicle", typeof(EntityVehicleType), Namespace="http://lexs.gov/digest/4.0", IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityVessel", typeof(EntityVesselType), Namespace="http://lexs.gov/digest/4.0", IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("EntityWarrant", typeof(EntityWarrantType), Namespace="http://lexs.gov/digest/4.0", IsNullable=true, Order=0)]
        public EntityType Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }
}
