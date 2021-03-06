/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the rds-data-2018-08-01.normal.json service model.
 */


using System;
using System.Globalization;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.RDSDataService;
using Amazon.RDSDataService.Model;
using Amazon.RDSDataService.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public partial class RDSDataServiceMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("rds-data");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RDSDataService")]
        public void BatchExecuteStatementMarshallTest()
        {
            var operation = service_model.FindOperation("BatchExecuteStatement");

            var request = InstantiateClassGenerator.Execute<BatchExecuteStatementRequest>();
            var marshaller = new BatchExecuteStatementRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("BatchExecuteStatement", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = BatchExecuteStatementResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as BatchExecuteStatementResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RDSDataService")]
        public void BeginTransactionMarshallTest()
        {
            var operation = service_model.FindOperation("BeginTransaction");

            var request = InstantiateClassGenerator.Execute<BeginTransactionRequest>();
            var marshaller = new BeginTransactionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("BeginTransaction", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = BeginTransactionResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as BeginTransactionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RDSDataService")]
        public void CommitTransactionMarshallTest()
        {
            var operation = service_model.FindOperation("CommitTransaction");

            var request = InstantiateClassGenerator.Execute<CommitTransactionRequest>();
            var marshaller = new CommitTransactionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("CommitTransaction", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = CommitTransactionResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as CommitTransactionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RDSDataService")]
        public void ExecuteSqlMarshallTest()
        {
            var operation = service_model.FindOperation("ExecuteSql");

            var request = InstantiateClassGenerator.Execute<ExecuteSqlRequest>();
            var marshaller = new ExecuteSqlRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ExecuteSql", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ExecuteSqlResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ExecuteSqlResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RDSDataService")]
        public void ExecuteStatementMarshallTest()
        {
            var operation = service_model.FindOperation("ExecuteStatement");

            var request = InstantiateClassGenerator.Execute<ExecuteStatementRequest>();
            var marshaller = new ExecuteStatementRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("ExecuteStatement", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = ExecuteStatementResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as ExecuteStatementResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RDSDataService")]
        public void RollbackTransactionMarshallTest()
        {
            var operation = service_model.FindOperation("RollbackTransaction");

            var request = InstantiateClassGenerator.Execute<RollbackTransactionRequest>();
            var marshaller = new RollbackTransactionRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("RollbackTransaction", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = RollbackTransactionResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as RollbackTransactionResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

            }
}