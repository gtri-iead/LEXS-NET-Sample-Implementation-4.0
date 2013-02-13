namespace Lexs4SearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/niem-core/2.0")]
    public partial class PersonEmploymentAssociationType : AssociationType
    {
        
        private ReferenceType2[] employeeReferenceField;
        
        private EntityType1[] employerField;
        
        private TextType employeeDepartmentNameField;
        
        private TextType employeePositionNameField;
        
        private object itemField;
        
        private TextType employeeRankTextField;
        
        private IdentificationType employeeIdentificationField;
        
        private StatusType employmentStatusField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EmployeeReference", Order=0)]
        public ReferenceType2[] EmployeeReference
        {
            get
            {
                return this.employeeReferenceField;
            }
            set
            {
                this.employeeReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Employer", IsNullable=true, Order=1)]
        public EntityType1[] Employer
        {
            get
            {
                return this.employerField;
            }
            set
            {
                this.employerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public TextType EmployeeDepartmentName
        {
            get
            {
                return this.employeeDepartmentNameField;
            }
            set
            {
                this.employeeDepartmentNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public TextType EmployeePositionName
        {
            get
            {
                return this.employeePositionNameField;
            }
            set
            {
                this.employeePositionNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EmployeeOccupationCode", typeof(OccupationCodeType), IsNullable=true, Order=4)]
        [System.Xml.Serialization.XmlElementAttribute("EmployeeOccupationText", typeof(TextType), IsNullable=true, Order=4)]
        public object Item
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=5)]
        public TextType EmployeeRankText
        {
            get
            {
                return this.employeeRankTextField;
            }
            set
            {
                this.employeeRankTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=6)]
        public IdentificationType EmployeeIdentification
        {
            get
            {
                return this.employeeIdentificationField;
            }
            set
            {
                this.employeeIdentificationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=7)]
        public StatusType EmploymentStatus
        {
            get
            {
                return this.employmentStatusField;
            }
            set
            {
                this.employmentStatusField = value;
            }
        }
    }
}
