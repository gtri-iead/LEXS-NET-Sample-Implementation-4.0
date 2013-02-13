namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ulex.gov/ulex/2.0")]
    public partial class DataOwnersResponseMessageType : ResponseMessageType
    {
        
        private DataOwnerInformationType[] dataOwnerInformationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DataOwnerInformation", Order=0)]
        public DataOwnerInformationType[] DataOwnerInformation
        {
            get
            {
                return this.dataOwnerInformationField;
            }
            set
            {
                this.dataOwnerInformationField = value;
            }
        }
    }
}
