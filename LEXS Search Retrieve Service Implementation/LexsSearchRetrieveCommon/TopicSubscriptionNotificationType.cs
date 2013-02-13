namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ulex.gov/subscribenotify/2.0")]
    public partial class TopicSubscriptionNotificationType
    {
        
        private SNMessageMetadataType sNMessageMetadataField;
        
        private object[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://ulex.gov/ulex/2.0", Order=0)]
        public SNMessageMetadataType SNMessageMetadata
        {
            get
            {
                return this.sNMessageMetadataField;
            }
            set
            {
                this.sNMessageMetadataField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Attachment", typeof(AttachmentType), Namespace="http://ulex.gov/ulex/2.0", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute("DataItemPackage", typeof(DataItemPackageType), Namespace="http://ulex.gov/ulex/2.0", Order=1)]
        public object[] Items
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
    }
}
