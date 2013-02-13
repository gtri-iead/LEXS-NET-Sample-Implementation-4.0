namespace Lexs4SearchRetrieveWebService
{
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doTextSearchRequest", WrapperNamespace="http://ulex.gov/searchretrieve/2.0", IsWrapped=true)]
    public partial class doTextSearchRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ulex.gov/ulex/2.0", Order=0)]
        public TextSearchRequestMessageType TextSearchRequestMessage;
        
        public doTextSearchRequest()
        {
        }
        
        public doTextSearchRequest(TextSearchRequestMessageType TextSearchRequestMessage)
        {
            this.TextSearchRequestMessage = TextSearchRequestMessage;
        }
    }
}
