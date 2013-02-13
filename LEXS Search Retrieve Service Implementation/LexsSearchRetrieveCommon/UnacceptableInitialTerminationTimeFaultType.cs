namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.oasis-open.org/wsn/b-2")]
    public partial class UnacceptableInitialTerminationTimeFaultType : BaseFaultType
    {
        
        private System.DateTime minimumTimeField;
        
        private System.DateTime maximumTimeField;
        
        private bool maximumTimeFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public System.DateTime MinimumTime
        {
            get
            {
                return this.minimumTimeField;
            }
            set
            {
                this.minimumTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public System.DateTime MaximumTime
        {
            get
            {
                return this.maximumTimeField;
            }
            set
            {
                this.maximumTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaximumTimeSpecified
        {
            get
            {
                return this.maximumTimeFieldSpecified;
            }
            set
            {
                this.maximumTimeFieldSpecified = value;
            }
        }
    }
}
