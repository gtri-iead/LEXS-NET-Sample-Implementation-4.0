namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://lexs.gov/digest/4.0")]
    public partial class WeaponUserAssociationType : AssociationType
    {
        
        private ReferenceType2[] weaponUserReferenceField;
        
        private ReferenceType2[] weaponReferenceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WeaponUserReference", Namespace="http://niem.gov/niem/niem-core/2.0", Order=0)]
        public ReferenceType2[] WeaponUserReference
        {
            get
            {
                return this.weaponUserReferenceField;
            }
            set
            {
                this.weaponUserReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WeaponReference", Order=1)]
        public ReferenceType2[] WeaponReference
        {
            get
            {
                return this.weaponReferenceField;
            }
            set
            {
                this.weaponReferenceField = value;
            }
        }
    }
}
