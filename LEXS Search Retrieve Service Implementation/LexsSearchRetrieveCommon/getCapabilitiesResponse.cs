namespace Lexs4SearchRetrieveWebService
{
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getCapabilitiesResponse", WrapperNamespace="http://ulex.gov/searchretrieve/2.0", IsWrapped=true)]
    public partial class getCapabilitiesResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ulex.gov/ulex/2.0", Order=0)]
        public CapabilitiesResponseMessageType CapabilitiesResponseMessage;
        
        public getCapabilitiesResponse()
        {
        }
        
        public getCapabilitiesResponse(CapabilitiesResponseMessageType CapabilitiesResponseMessage)
        {
            this.CapabilitiesResponseMessage = CapabilitiesResponseMessage;
        }
    }
}
