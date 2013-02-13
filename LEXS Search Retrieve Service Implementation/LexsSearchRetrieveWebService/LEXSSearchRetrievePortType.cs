using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Schema;
using System.IO;
using System.Diagnostics;
using System.Web;
using System.Web.Hosting;
using System.Configuration;
using XmlSerializationUtils;

namespace Lexs4SearchRetrieveWebService
{  
    [System.ServiceModel.ServiceBehaviorAttribute(InstanceContextMode=System.ServiceModel.InstanceContextMode.PerCall, ConcurrencyMode=System.ServiceModel.ConcurrencyMode.Single)]
    public class LEXSSearchRetrievePortType : ILEXSSearchRetrievePortType
    {
        
        public virtual doSearchResponse doAttachmentSearch(doAttachmentSearchRequest request)
        {
            throw new System.NotImplementedException();
        }
        
        public virtual doSearchResponse doDataItemMetadataSearch(doDataItemMetadataSearchRequest request)
        {
            throw new System.NotImplementedException();
        }
        
        public virtual doSearchResponse doStructuredSearch(doStructuredSearchRequest request)
        {
            try
            {
                string appDataDir = HostingEnvironment.ApplicationPhysicalPath;

                string samplesFolder = ConfigurationManager.AppSettings["SamplesFolder"];

                string sampleInstance = ConfigurationManager.AppSettings["ResponseXmlInstance"];

                string samplesDir = string.Empty;

                if (appDataDir == null)
                {
                    samplesDir = samplesFolder;
                }
                else
                {
                    samplesDir = appDataDir + Path.DirectorySeparatorChar + samplesFolder;
                }

                SaveRequest(request, samplesDir);

                return GetResponse(request, sampleInstance, samplesDir);
            }
            catch (Exception e)
            {
                Debug.WriteLine("Server exception: " + e.ToString());

                throw e;
            }
        }

        private static void SaveRequest(doStructuredSearchRequest request, string samplesDir)
        {
            doStructuredSearchRequestType requestType = new doStructuredSearchRequestType();
            requestType.StructuredSearchRequestMessage = request.StructuredSearchRequestMessage;

            string xmlPublish = SerializationUtils.SerializeToXmlString(requestType,
                "doStructuredSearchRequest", "http://ulex.gov/searchretrieve/2.0");

            string xmlFilePath = samplesDir + Path.DirectorySeparatorChar + ConfigurationManager.AppSettings["IncomingRequestSampleXmlInstance"];

            XmlDocument outputXmlDoc = new XmlDocument();
            outputXmlDoc.LoadXml(xmlPublish);

            outputXmlDoc.Save(xmlFilePath);
        }

        private static doSearchResponse GetResponse(doStructuredSearchRequest request, string sampleInstance, string samplesDir)
        {
            string xmlFilePath = samplesDir + Path.DirectorySeparatorChar + sampleInstance;

            if (!File.Exists(xmlFilePath))
            {
                return null;
            }

            string xmlText = SerializationUtils.XmlStringFromFile(xmlFilePath);

            Type type = typeof(doSearchResponseType);
            doSearchResponseType searchResponseType = SerializationUtils.DeserializeFromXmlString(xmlText,
                "doSearchResponse", "http://ulex.gov/searchretrieve/2.0", type) as doSearchResponseType;

            doSearchResponse structuredSearchResponse = new doSearchResponse(searchResponseType.SearchResponseMessage);

            return structuredSearchResponse;
        }
        
        public virtual doSearchResponse doTextSearch(doTextSearchRequest request)
        {
            throw new System.NotImplementedException();
        }
        
        public virtual getDataItemResponse getDataItem(getDataItemRequest request)
        {
            throw new System.NotImplementedException();
        }
        
        public virtual getDataItemWithAttachmentsResponse getDataItemWithAttachments(getDataItemWithAttachmentsRequest request)
        {
            throw new System.NotImplementedException();
        }
        
        public virtual getRenderedDataItemResponse getRenderedDataItem(getRenderedDataItemRequest request)
        {
            throw new System.NotImplementedException();
        }
        
        public virtual getRenderedDataItemResponse getAttachment(getAttachmentRequest request)
        {
            throw new System.NotImplementedException();
        }
        
        public virtual getCapabilitiesResponse getCapabilities(getCapabilitiesRequest request)
        {
            throw new System.NotImplementedException();
        }
        
        public virtual getDataOwnersResponse getDataOwners(getDataOwnersRequest request)
        {
            throw new System.NotImplementedException();
        }
        
        public virtual getAvailabilityResponse getAvailability(getAvailabilityRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}
