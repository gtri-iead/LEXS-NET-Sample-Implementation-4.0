namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ulex.gov/ulex/2.0")]
    public partial class LinkagesType
    {
        
        private SameAsConnectionType[] sameAsConnectionField;

        private AttachmentSummaryConnectionType[] itemsField;

        // DEBUG
        private object[] items1Field;
        private ItemsChoiceType9[] itemsElementNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SameAsConnection", Namespace="http://ulex.gov/library/2.0")]
        public SameAsConnectionType[] SameAsConnection
        {
            get
            {
                return this.sameAsConnectionField;
            }
            set
            {
                this.sameAsConnectionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AttachmentSummaryConnection", Namespace = "http://ulex.gov/library/2.0")]
        public AttachmentSummaryConnectionType[] Items
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
        [System.Xml.Serialization.XmlElementAttribute("CommunicationCaptureAttachmentConnection", typeof(AttachmentSummaryConnectionType1), Namespace="http://lexs.gov/digest/4.0", IsNullable=true)]
        [System.Xml.Serialization.XmlElementAttribute("CrimeSceneImageConnection", typeof(AttachmentSummaryConnectionType1), Namespace="http://lexs.gov/digest/4.0", IsNullable=true)]
        [System.Xml.Serialization.XmlElementAttribute("DocumentAttachmentConnection", typeof(AttachmentSummaryConnectionType1), Namespace="http://lexs.gov/digest/4.0", IsNullable=true)]
        [System.Xml.Serialization.XmlElementAttribute("ItemImageConnection", typeof(AttachmentSummaryConnectionType1), Namespace="http://lexs.gov/digest/4.0", IsNullable=true)]
        [System.Xml.Serialization.XmlElementAttribute("PersonBiometricConnection", typeof(AttachmentSummaryConnectionType1), Namespace="http://lexs.gov/digest/4.0", IsNullable=true)]
        [System.Xml.Serialization.XmlElementAttribute("PersonFacialImageConnection", typeof(AttachmentSummaryConnectionType1), Namespace="http://lexs.gov/digest/4.0", IsNullable=true)]
        [System.Xml.Serialization.XmlElementAttribute("PersonFingerprintConnection", typeof(AttachmentSummaryConnectionType1), Namespace="http://lexs.gov/digest/4.0", IsNullable=true)]
        [System.Xml.Serialization.XmlElementAttribute("PersonImageConnection", typeof(AttachmentSummaryConnectionType1), Namespace="http://lexs.gov/digest/4.0", IsNullable=true)]
        [System.Xml.Serialization.XmlElementAttribute("PersonSMTImageConnection", typeof(AttachmentSummaryConnectionType1), Namespace="http://lexs.gov/digest/4.0", IsNullable=true)]
        [System.Xml.Serialization.XmlElementAttribute("SupportingDocumentationConnection", typeof(AttachmentSummaryConnectionType1), Namespace="http://lexs.gov/digest/4.0", IsNullable=true)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items1
        {
            get
            {
                return this.items1Field;
            }
            set
            {
                this.items1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType9[] ItemsElementName
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://lexs.gov/digest/4.0", IncludeInSchema = false)]
    public enum ItemsChoiceType9
    {

        /// <remarks/>
        CommunicationCaptureAttachmentConnection,

        /// <remarks/>
        CrimeSceneImageConnection,

        /// <remarks/>
        DocumentAttachmentConnection,

        /// <remarks/>
        ItemImageConnection,

        /// <remarks/>
        PersonBiometricConnection,

        /// <remarks/>
        PersonFacialImageConnection,

        /// <remarks/>
        PersonFingerprintConnection,

        /// <remarks/>
        PersonImageConnection,

        /// <remarks/>
        PersonSMTImageConnection,

        /// <remarks/>
        SupportingDocumentationConnection,
    }
}
