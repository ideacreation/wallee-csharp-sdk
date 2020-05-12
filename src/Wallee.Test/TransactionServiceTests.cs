/**
* wallee SDK
*
* This library allows to interact with the wallee payment service.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
*      http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Wallee.Model;
using Wallee.Service;
using Wallee.Client;

namespace Wallee.Test
{
    /// <summary>
    ///  Class for testing TransactionService
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class TransactionServiceTests
    {
        private readonly long SpaceId = 405;
        private readonly string ApplicationUserID = "512";
        private readonly string AuthenticationKey = "FKrO76r5VwJtBrqZawBspljbBNOxp5veKQQkOnZxucQ=";

        private TransactionService TransactionService;
        private TransactionCreate TransactionPayload;
        private Configuration Configuration;
        private Transaction Transaction;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            if (this.Configuration == null) {
                this.Configuration = new Configuration(this.ApplicationUserID, this.AuthenticationKey);
            }
            if (this.TransactionPayload == null) {
                this.TransactionService = new TransactionService(this.Configuration);
            }
            this.Transaction = this.GetTransaction();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        // <summary>
        // Get transaction payload
        // <summary>
        private TransactionCreate GetTransactionPayload()
        {
            if (this.TransactionPayload == null) {
                // Line item
                LineItemCreate lineItem1 = new LineItemCreate(
                    name: "Red T-Shirt",
                    uniqueId: "5412",
                    type: LineItemType.PRODUCT,
                    quantity: 1,
                    amountIncludingTax: (decimal)29.95
                )
                {
                    Sku = "red-t-shirt-123"
                };

                // Customer Billing Address
                AddressCreate billingAddress = new AddressCreate
                {
                    City = "Winterthur",
                    Country = "CH",
                    EmailAddress = "test@example.com",
                    FamilyName = "Customer",
                    GivenName = "Good",
                    Postcode = "8400",
                    PostalState = "ZH",
                    OrganizationName = "Test GmbH",
                    MobilePhoneNumber = "+41791234567",
                    Salutation = "Ms"
                };

                this.TransactionPayload = new TransactionCreate(new List<LineItemCreate>() { lineItem1 })
                {
                    Currency = "CHF",
                    AutoConfirmationEnabled = true,
                    BillingAddress = billingAddress,
                    ShippingAddress = billingAddress,
                    Language = "en-US"
                };
            }
            return this.TransactionPayload;
        }

        /// <summary>
        /// Create Transaction
        /// </summary>
        private Transaction GetTransaction()
        {
            if (this.Transaction == null)
            {
                try
                {
                    this.Transaction = this.TransactionService.Create(this.SpaceId, this.GetTransactionPayload());
                }
                catch (ApiException e)
                {
                    Assert.Fail("Failed to create transaction. Reason: " + e.Message + " Details: " + e.ErrorContent);
                }
            }
            return this.Transaction;
        }

        /// <summary>
        /// Test an instance of TransactionService
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<TransactionService>(this.TransactionService, "instance is a TransactionService");
        }

        
        /// <summary>
        /// Test Confirm
        /// </summary>
        [Test]
        public void ConfirmTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? spaceId = null;
            //TransactionPending transactionModel = null;
            //var response = TransactionService.Confirm(spaceId, transactionModel);
            //Assert.IsInstanceOf<Transaction> (response, "response is Transaction");
        }
        
        /// <summary>
        /// Test Count
        /// </summary>
        [Test]
        public void CountTest()
        {
            EntityQueryFilter EntityQueryFilter = new EntityQueryFilter(EntityQueryFilterType.LEAF)
            {
                FieldName = "id",
                Value = this.Transaction.Id,
                Operator = CriteriaOperator.EQUALS
            };

            var response = this.TransactionService.Count(this.SpaceId, EntityQueryFilter);
            Assert.IsInstanceOf<long?>(response, "response is long?");
        }
        
        /// <summary>
        /// Test Create
        /// </summary>
        [Test]
        public void CreateTest()
        {
            var response = this.TransactionService.Create(this.SpaceId, this.TransactionPayload);
            Assert.IsInstanceOf<Transaction> (response, "response is Transaction");
        }
        
        /// <summary>
        /// Test CreateTransactionCredentials
        /// </summary>
        [Test]
        public void CreateTransactionCredentialsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? spaceId = null;
            //long? id = null;
            //var response = TransactionService.CreateTransactionCredentials(spaceId, id);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test DeleteOneClickTokenWithCredentials
        /// </summary>
        [Test]
        public void DeleteOneClickTokenWithCredentialsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string credentials = null;
            //long? tokenId = null;
            //TransactionService.DeleteOneClickTokenWithCredentials(credentials, tokenId);
            
        }
        
        /// <summary>
        /// Test Export
        /// </summary>
        [Test]
        public void ExportTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? spaceId = null;
            //EntityExportRequest request = null;
            //var response = TransactionService.Export(spaceId, request);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test FetchOneClickTokensWithCredentials
        /// </summary>
        [Test]
        public void FetchOneClickTokensWithCredentialsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string credentials = null;
            //var response = TransactionService.FetchOneClickTokensWithCredentials(credentials);
            //Assert.IsInstanceOf<List<TokenVersion>> (response, "response is List<TokenVersion>");
        }
        
        /// <summary>
        /// Test FetchPaymentMethods
        /// payment_page, iframe, lightbox, mobile_web_view, terminal, payment_link, charge_flow, direct_card_processing
        /// </summary>
        [Test]
        public void FetchPaymentMethodsTest()
        {
            var response = this.TransactionService.FetchPaymentMethods(this.SpaceId, this.Transaction.Id, "payment_page");
            Assert.IsInstanceOf<List<PaymentMethodConfiguration>> (response, "response is List<PaymentMethodConfiguration>");
        }
        
        /// <summary>
        /// Test FetchPaymentMethodsWithCredentials
        /// </summary>
        [Test]
        public void FetchPaymentMethodsWithCredentialsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string credentials = null;
            //var response = TransactionService.FetchPossiblePaymentMethodsWithCredentials(credentials);
            //Assert.IsInstanceOf<List<PaymentMethodConfiguration>> (response, "response is List<PaymentMethodConfiguration>");
        }
        
        /// <summary>
        /// Test GetInvoiceDocument
        /// </summary>
        [Test]
        public void GetInvoiceDocumentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? spaceId = null;
            //long? id = null;
            //var response = TransactionService.GetInvoiceDocument(spaceId, id);
            //Assert.IsInstanceOf<RenderedDocument> (response, "response is RenderedDocument");
        }
        
        /// <summary>
        /// Test GetLatestTransactionLineItemVersion
        /// </summary>
        [Test]
        public void GetLatestTransactionLineItemVersionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? spaceId = null;
            //long? id = null;
            //var response = TransactionService.GetLatestTransactionLineItemVersion(spaceId, id);
            //Assert.IsInstanceOf<TransactionLineItemVersion> (response, "response is TransactionLineItemVersion");
        }
        
        /// <summary>
        /// Test GetPackingSlip
        /// </summary>
        [Test]
        public void GetPackingSlipTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? spaceId = null;
            //long? id = null;
            //var response = TransactionService.GetPackingSlip(spaceId, id);
            //Assert.IsInstanceOf<RenderedDocument> (response, "response is RenderedDocument");
        }
        
        /// <summary>
        /// Test ProcessOneClickTokenAndRedirectWithCredentials
        /// </summary>
        [Test]
        public void ProcessOneClickTokenAndRedirectWithCredentialsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string credentials = null;
            //long? tokenId = null;
            //var response = TransactionService.ProcessOneClickTokenAndRedirectWithCredentials(credentials, tokenId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test ProcessWithoutUserInteraction
        /// </summary>
        [Test]
        public void ProcessWithoutUserInteractionTest()
        {
            var transaction = this.TransactionService.ProcessWithoutUserInteraction(this.SpaceId, this.Transaction.Id);
            TransactionState[] TransactionStates = {
                TransactionState.AUTHORIZED,
                TransactionState.FULFILL
            };
            Assert.AreEqual(true, Array.Exists(TransactionStates, element => element == transaction.State));
        }
        
        /// <summary>
        /// Test Read
        /// </summary>
        [Test]
        public void ReadTest()
        {
            var response = this.TransactionService.Read(this.SpaceId, this.Transaction.Id);
            Assert.AreEqual(response.Id, this.Transaction.Id);
        }
        
        /// <summary>
        /// Test ReadWithCredentials
        /// </summary>
        [Test]
        public void ReadWithCredentialsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string credentials = null;
            //var response = TransactionService.ReadWithCredentials(credentials);
            //Assert.IsInstanceOf<Transaction> (response, "response is Transaction");
        }
        
        /// <summary>
        /// Test Search
        /// </summary>
        [Test]
        public void SearchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? spaceId = null;
            //EntityQuery query = null;
            //var response = TransactionService.Search(spaceId, query);
            //Assert.IsInstanceOf<List<Transaction>> (response, "response is List<Transaction>");
        }
        
        /// <summary>
        /// Test Update
        /// </summary>
        [Test]
        public void UpdateTest()
        {
            Transaction Transaction = this.TransactionService.Create(this.SpaceId, this.GetTransactionPayload());
            TransactionPending TransactionPending = new TransactionPending(Transaction.Version, Transaction.Id)
            {
                Currency = "CHF",
                Language = "en-us"
            };
            Transaction TransactionUpdate = this.TransactionService.Update(this.SpaceId, TransactionPending);
            Assert.AreEqual(Transaction.Language, TransactionUpdate.Language);
        }
        
        /// <summary>
        /// Test UpdateTransactionLineItems
        /// </summary>
        [Test]
        public void UpdateTransactionLineItemsTest()
        {
            EntityQueryFilter entityQueryFilter = new EntityQueryFilter(EntityQueryFilterType.LEAF)
            {
                FieldName = "id",
                Value = this.Transaction.Id,
                Operator = CriteriaOperator.EQUALS
            };

            EntityQuery entityQuery = new EntityQuery
            {
                Filter = entityQueryFilter
            };

            var response = this.TransactionService.Search(this.SpaceId, entityQuery);

            Assert.IsInstanceOf<List<Transaction>>(response, "response is List<Transaction>");
        }
        
    }

}
