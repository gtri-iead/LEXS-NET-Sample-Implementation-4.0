namespace Lexs4SearchRetrieveWebService
{
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doStructuredSearchRequest", WrapperNamespace="http://ulex.gov/searchretrieve/2.0", IsWrapped=true)]
    public partial class doStructuredSearchRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ulex.gov/ulex/2.0", Order=0)]
        public StructuredSearchRequestMessageType StructuredSearchRequestMessage;
        
        public doStructuredSearchRequest()
        {
        }
        
        public doStructuredSearchRequest(StructuredSearchRequestMessageType StructuredSearchRequestMessage)
        {
            this.StructuredSearchRequestMessage = StructuredSearchRequestMessage;
        }
    }
}
