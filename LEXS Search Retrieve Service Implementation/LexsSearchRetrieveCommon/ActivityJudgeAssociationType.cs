namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/domains/jxdm/4.1")]
    public partial class ActivityJudgeAssociationType : AssociationType
    {
        
        private ReferenceType2[] activityReferenceField;
        
        private ReferenceType2[] judgeReferenceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ActivityReference", Namespace="http://niem.gov/niem/niem-core/2.0", Order=0)]
        public ReferenceType2[] ActivityReference
        {
            get
            {
                return this.activityReferenceField;
            }
            set
            {
                this.activityReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("JudgeReference", Order=1)]
        public ReferenceType2[] JudgeReference
        {
            get
            {
                return this.judgeReferenceField;
            }
            set
            {
                this.judgeReferenceField = value;
            }
        }
    }
}
