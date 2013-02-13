namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://lexs.gov/codes/4.0")]
    [System.Xml.Serialization.XmlRootAttribute("RequestedDataCategoryCode", Namespace="http://lexs.gov/lexs/4.0", IsNullable=false)]
    public partial class DataCategoryCodeType
    {
        
        private string idField;
        
        private string metadataField;
        
        private string linkMetadataField;
        
        private DataCategoryCodeSimpleType valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://niem.gov/niem/structures/2.0", DataType="ID")]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://niem.gov/niem/structures/2.0", DataType="IDREFS")]
        public string metadata
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://niem.gov/niem/structures/2.0", DataType="IDREFS")]
        public string linkMetadata
        {
            get
            {
                return this.linkMetadataField;
            }
            set
            {
                this.linkMetadataField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public DataCategoryCodeSimpleType Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
}