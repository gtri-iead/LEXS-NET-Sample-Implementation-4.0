namespace Lexs4SearchRetrieveWebService
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ulex.gov/searchretrieve/2.0/ws", ConfigurationName="ILEXSSearchRetrievePortType")]
    public interface ILEXSSearchRetrievePortType
    {
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://ulex.gov/searchretrieve/2.0) of message doAttachmentSearchRequest does not match the default value (http://ulex.gov/searchretrieve/2.0/ws)
        [System.ServiceModel.OperationContractAttribute(Action="http://ulex.gov/searchretrieve/2.0/doAttachmentSearch", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PublishMessageAcknowledgmentType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DomainResponseMessageType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DomainRequestMessageType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DomainActionMessageType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProblemActionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AgreementMethodType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MetadataType1))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ComplexObjectType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AugmentationType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SignaturePropertiesType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ManifestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(NotificationMessageHolderType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BaseFaultType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataOwnersResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataOwnersRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataItemWithAttachmentsResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataItemResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataItemRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getCapabilitiesResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getCapabilitiesRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAvailabilityResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAvailabilityRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAttachmentResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAttachmentRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doTextSearchRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doStructuredSearchRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PackageAbstractType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExtensibleDocumented))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doSearchResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doDataItemMetadataSearchRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EncryptedType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doAttachmentSearchRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MessageMetadataAbstractType))]
        doSearchResponse doAttachmentSearch(doAttachmentSearchRequest request);
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://ulex.gov/searchretrieve/2.0) of message doDataItemMetadataSearchRequest does not match the default value (http://ulex.gov/searchretrieve/2.0/ws)
        [System.ServiceModel.OperationContractAttribute(Action="http://ulex.gov/searchretrieve/2.0/doDataItemMetadataSearch", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PublishMessageAcknowledgmentType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DomainResponseMessageType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DomainRequestMessageType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DomainActionMessageType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProblemActionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AgreementMethodType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MetadataType1))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ComplexObjectType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AugmentationType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SignaturePropertiesType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ManifestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(NotificationMessageHolderType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BaseFaultType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataOwnersResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataOwnersRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataItemWithAttachmentsResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataItemResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataItemRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getCapabilitiesResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getCapabilitiesRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAvailabilityResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAvailabilityRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAttachmentResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAttachmentRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doTextSearchRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doStructuredSearchRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PackageAbstractType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExtensibleDocumented))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doSearchResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doDataItemMetadataSearchRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EncryptedType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doAttachmentSearchRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MessageMetadataAbstractType))]
        doSearchResponse doDataItemMetadataSearch(doDataItemMetadataSearchRequest request);
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://ulex.gov/searchretrieve/2.0) of message doStructuredSearchRequest does not match the default value (http://ulex.gov/searchretrieve/2.0/ws)
        [System.ServiceModel.OperationContractAttribute(Action="http://ulex.gov/searchretrieve/2.0/doStructuredSearch", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PublishMessageAcknowledgmentType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DomainResponseMessageType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DomainRequestMessageType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DomainActionMessageType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProblemActionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AgreementMethodType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MetadataType1))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ComplexObjectType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AugmentationType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SignaturePropertiesType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ManifestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(NotificationMessageHolderType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BaseFaultType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataOwnersResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataOwnersRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataItemWithAttachmentsResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataItemResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataItemRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getCapabilitiesResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getCapabilitiesRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAvailabilityResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAvailabilityRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAttachmentResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAttachmentRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doTextSearchRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doStructuredSearchRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PackageAbstractType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExtensibleDocumented))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doSearchResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doDataItemMetadataSearchRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EncryptedType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doAttachmentSearchRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MessageMetadataAbstractType))]
        doSearchResponse doStructuredSearch(doStructuredSearchRequest request);
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://ulex.gov/searchretrieve/2.0) of message doTextSearchRequest does not match the default value (http://ulex.gov/searchretrieve/2.0/ws)
        [System.ServiceModel.OperationContractAttribute(Action="http://ulex.gov/searchretrieve/2.0/doTextSearch", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PublishMessageAcknowledgmentType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DomainResponseMessageType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DomainRequestMessageType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DomainActionMessageType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProblemActionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AgreementMethodType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MetadataType1))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ComplexObjectType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AugmentationType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SignaturePropertiesType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ManifestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(NotificationMessageHolderType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BaseFaultType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataOwnersResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataOwnersRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataItemWithAttachmentsResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataItemResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataItemRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getCapabilitiesResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getCapabilitiesRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAvailabilityResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAvailabilityRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAttachmentResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAttachmentRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doTextSearchRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doStructuredSearchRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PackageAbstractType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExtensibleDocumented))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doSearchResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doDataItemMetadataSearchRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EncryptedType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doAttachmentSearchRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MessageMetadataAbstractType))]
        doSearchResponse doTextSearch(doTextSearchRequest request);
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://ulex.gov/searchretrieve/2.0) of message getDataItemRequest does not match the default value (http://ulex.gov/searchretrieve/2.0/ws)
        [System.ServiceModel.OperationContractAttribute(Action="http://ulex.gov/searchretrieve/2.0/getDataItem", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PublishMessageAcknowledgmentType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DomainResponseMessageType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DomainRequestMessageType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DomainActionMessageType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProblemActionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AgreementMethodType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MetadataType1))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ComplexObjectType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AugmentationType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SignaturePropertiesType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ManifestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(NotificationMessageHolderType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BaseFaultType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataOwnersResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataOwnersRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataItemWithAttachmentsResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataItemResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataItemRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getCapabilitiesResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getCapabilitiesRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAvailabilityResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAvailabilityRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAttachmentResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAttachmentRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doTextSearchRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doStructuredSearchRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PackageAbstractType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExtensibleDocumented))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doSearchResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doDataItemMetadataSearchRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EncryptedType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doAttachmentSearchRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MessageMetadataAbstractType))]
        getDataItemResponse getDataItem(getDataItemRequest request);
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://ulex.gov/searchretrieve/2.0) of message getDataItemWithAttachmentsRequest does not match the default value (http://ulex.gov/searchretrieve/2.0/ws)
        [System.ServiceModel.OperationContractAttribute(Action="http://ulex.gov/searchretrieve/2.0/getDataItemWithAttachments", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PublishMessageAcknowledgmentType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DomainResponseMessageType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DomainRequestMessageType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DomainActionMessageType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProblemActionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AgreementMethodType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MetadataType1))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ComplexObjectType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AugmentationType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SignaturePropertiesType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ManifestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(NotificationMessageHolderType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BaseFaultType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataOwnersResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataOwnersRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataItemWithAttachmentsResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataItemResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataItemRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getCapabilitiesResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getCapabilitiesRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAvailabilityResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAvailabilityRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAttachmentResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAttachmentRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doTextSearchRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doStructuredSearchRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PackageAbstractType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExtensibleDocumented))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doSearchResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doDataItemMetadataSearchRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EncryptedType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doAttachmentSearchRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MessageMetadataAbstractType))]
        getDataItemWithAttachmentsResponse getDataItemWithAttachments(getDataItemWithAttachmentsRequest request);
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://ulex.gov/searchretrieve/2.0) of message getRenderedDataItemRequest does not match the default value (http://ulex.gov/searchretrieve/2.0/ws)
        [System.ServiceModel.OperationContractAttribute(Action="http://ulex.gov/searchretrieve/2.0/getRenderedDataItem", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PublishMessageAcknowledgmentType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DomainResponseMessageType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DomainRequestMessageType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DomainActionMessageType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProblemActionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AgreementMethodType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MetadataType1))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ComplexObjectType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AugmentationType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SignaturePropertiesType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ManifestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(NotificationMessageHolderType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BaseFaultType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataOwnersResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataOwnersRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataItemWithAttachmentsResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataItemResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataItemRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getCapabilitiesResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getCapabilitiesRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAvailabilityResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAvailabilityRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAttachmentResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAttachmentRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doTextSearchRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doStructuredSearchRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PackageAbstractType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExtensibleDocumented))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doSearchResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doDataItemMetadataSearchRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EncryptedType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doAttachmentSearchRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MessageMetadataAbstractType))]
        getRenderedDataItemResponse getRenderedDataItem(getRenderedDataItemRequest request);
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://ulex.gov/searchretrieve/2.0) of message getAttachmentRequest does not match the default value (http://ulex.gov/searchretrieve/2.0/ws)
        [System.ServiceModel.OperationContractAttribute(Action="http://ulex.gov/searchretrieve/2.0/getAttachment", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PublishMessageAcknowledgmentType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DomainResponseMessageType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DomainRequestMessageType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DomainActionMessageType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProblemActionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AgreementMethodType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MetadataType1))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ComplexObjectType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AugmentationType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SignaturePropertiesType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ManifestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(NotificationMessageHolderType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BaseFaultType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataOwnersResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataOwnersRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataItemWithAttachmentsResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataItemResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataItemRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getCapabilitiesResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getCapabilitiesRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAvailabilityResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAvailabilityRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAttachmentResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAttachmentRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doTextSearchRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doStructuredSearchRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PackageAbstractType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExtensibleDocumented))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doSearchResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doDataItemMetadataSearchRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EncryptedType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doAttachmentSearchRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MessageMetadataAbstractType))]
        getRenderedDataItemResponse getAttachment(getAttachmentRequest request);
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://ulex.gov/searchretrieve/2.0) of message getCapabilitiesRequest does not match the default value (http://ulex.gov/searchretrieve/2.0/ws)
        [System.ServiceModel.OperationContractAttribute(Action="http://ulex.gov/searchretrieve/2.0/getCapabilities", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PublishMessageAcknowledgmentType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DomainResponseMessageType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DomainRequestMessageType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DomainActionMessageType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProblemActionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AgreementMethodType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MetadataType1))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ComplexObjectType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AugmentationType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SignaturePropertiesType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ManifestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(NotificationMessageHolderType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BaseFaultType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataOwnersResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataOwnersRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataItemWithAttachmentsResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataItemResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataItemRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getCapabilitiesResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getCapabilitiesRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAvailabilityResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAvailabilityRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAttachmentResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAttachmentRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doTextSearchRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doStructuredSearchRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PackageAbstractType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExtensibleDocumented))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doSearchResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doDataItemMetadataSearchRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EncryptedType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doAttachmentSearchRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MessageMetadataAbstractType))]
        getCapabilitiesResponse getCapabilities(getCapabilitiesRequest request);
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://ulex.gov/searchretrieve/2.0) of message getDataOwnersRequest does not match the default value (http://ulex.gov/searchretrieve/2.0/ws)
        [System.ServiceModel.OperationContractAttribute(Action="http://ulex.gov/searchretrieve/2.0/getDataOwners", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PublishMessageAcknowledgmentType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DomainResponseMessageType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DomainRequestMessageType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DomainActionMessageType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProblemActionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AgreementMethodType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MetadataType1))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ComplexObjectType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AugmentationType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SignaturePropertiesType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ManifestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(NotificationMessageHolderType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BaseFaultType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataOwnersResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataOwnersRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataItemWithAttachmentsResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataItemResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataItemRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getCapabilitiesResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getCapabilitiesRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAvailabilityResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAvailabilityRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAttachmentResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAttachmentRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doTextSearchRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doStructuredSearchRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PackageAbstractType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExtensibleDocumented))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doSearchResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doDataItemMetadataSearchRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EncryptedType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doAttachmentSearchRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MessageMetadataAbstractType))]
        getDataOwnersResponse getDataOwners(getDataOwnersRequest request);
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://ulex.gov/searchretrieve/2.0) of message getAvailabilityRequest does not match the default value (http://ulex.gov/searchretrieve/2.0/ws)
        [System.ServiceModel.OperationContractAttribute(Action="http://ulex.gov/searchretrieve/2.0/getAvailability", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PublishMessageAcknowledgmentType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DomainResponseMessageType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DomainRequestMessageType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DomainActionMessageType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ProblemActionType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AgreementMethodType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MetadataType1))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ComplexObjectType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AugmentationType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SignaturePropertiesType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ManifestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(NotificationMessageHolderType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(BaseFaultType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataOwnersResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataOwnersRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataItemWithAttachmentsResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataItemResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataItemRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getCapabilitiesResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getCapabilitiesRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAvailabilityResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAvailabilityRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAttachmentResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAttachmentRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doTextSearchRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doStructuredSearchRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PackageAbstractType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ExtensibleDocumented))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doSearchResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doDataItemMetadataSearchRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EncryptedType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doAttachmentSearchRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MessageMetadataAbstractType))]
        getAvailabilityResponse getAvailability(getAvailabilityRequest request);
    }
}
