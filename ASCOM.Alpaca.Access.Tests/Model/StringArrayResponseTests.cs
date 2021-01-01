/*
 * ASCOM Alpaca Device API
 *
 * The Alpaca API uses RESTful techniques and TCP/IP to enable ASCOM applications and devices to communicate across modern network environments.  ## Interface Behaviour The ASCOM Interface behavioural requirements for Alpaca drivers are the same as for COM based drivers and are documented in the <a href=\"https://ascom-standards.org/Help/Developer/html/N_ASCOM_DeviceInterface.htm\">API Interface Definitions</a> e.g. the <a href=\"https://ascom-standards.org/Help/Developer/html/M_ASCOM_DeviceInterface_ITelescopeV3_SlewToCoordinates.htm\">Telescope.SlewToCoordinates</a> method.       This document focuses on how to use the ASCOM Interface standards in their RESTful Alpaca form. ## Alpaca URLs, Case Sensitivity, Parameters and Returned values **Alpaca Device API URLs** are of the form **http(s)://host:port/path** where path comprises **\"/api/v1/\"** followed by one of the method names below. e.g. for an Alpaca interface running on port 7843 of a device with IP address 192.168.1.89: * A telescope \"Interface Version\" method URL would be **http://192.168.1.89:7843/api/v1/telescope/0/InterfaceVersion**      * A first focuser \"Position\" method URL would be  **http://192.168.1.89:7843/api/v1/focuser/0/position**      * A second focuser \"StepSize\" method URL would be  **http://192.168.1.89:7843/api/v1/focuser/1/stepsize** * A rotator \"Halt\" method URL would be  **http://192.168.1.89:7843/api/v1/rotator/0/halt**   URLs are case sensitive and all elements must be in lower case. This means that both the device type and command name must always be in lower case. Parameter names are not case sensitive, so clients and drivers should be prepared for parameter names to be supplied and returned with any casing. Parameter values can be in mixed case as required.  For GET operations, parameters should be placed in the URL query string and for PUT operations they should be placed in the body of the message.  Responses, as described below, are returned in JSON format and always include a common set of values including the client's transaction number,  the server's transaction number together with any error message and error number. If the transaction completes successfully, the ErrorMessage field will be an empty string and the ErrorNumber field will be zero.  ## HTTP Status Codes and ASCOM Error codes The returned HTTP status code gives a high level view of whether the device understood the request and whether it attempted to process it.  Under most circumstances the returned status will be `200`, indicating that the request was correctly formatted and that it was passed to the device's handler to execute. A `200` status does not necessarily mean that the operation completed as expected, without error, and you must always check the ErrorMessage and ErrorNumber fields to confirm whether the returned result is valid. The `200` status simply means that the transaction was successfully managed by the device's transaction management layer.  An HTTP status code of `400` indicates that the device could not interpret the request e.g. an invalid device number or misspelt device type was supplied. Check the body of the response for a text error message.  An HTTP status code of `500` indicates an unexpected error within the device from which it could not recover. Check the body of the response for a text error message. ## SetupDialog and Alpaca Device Configuration The SetupDialog method has been omitted from the Alpaca Device API because it presents a user interface rather than returning data. Alpaca device configuration is covered in the \"ASCOM Alpaca Management API\" specification, which can be selected through the drop-down box at the head of this page. 
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Org.OpenAPITools.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Test.Model
{
    /// <summary>
    ///  Class for testing StringArrayResponse
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class StringArrayResponseTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for StringArrayResponse
        //private StringArrayResponse instance;

        public StringArrayResponseTests()
        {
            // TODO uncomment below to create an instance of StringArrayResponse
            //instance = new StringArrayResponse();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of StringArrayResponse
        /// </summary>
        [Fact]
        public void StringArrayResponseInstanceTest()
        {
            // TODO uncomment below to test "IsType" StringArrayResponse
            //Assert.IsType<StringArrayResponse>(instance);
        }


        /// <summary>
        /// Test the property 'Value'
        /// </summary>
        [Fact]
        public void ValueTest()
        {
            // TODO unit test for the property 'Value'
        }
        /// <summary>
        /// Test the property 'ClientTransactionID'
        /// </summary>
        [Fact]
        public void ClientTransactionIDTest()
        {
            // TODO unit test for the property 'ClientTransactionID'
        }
        /// <summary>
        /// Test the property 'ServerTransactionID'
        /// </summary>
        [Fact]
        public void ServerTransactionIDTest()
        {
            // TODO unit test for the property 'ServerTransactionID'
        }
        /// <summary>
        /// Test the property 'ErrorNumber'
        /// </summary>
        [Fact]
        public void ErrorNumberTest()
        {
            // TODO unit test for the property 'ErrorNumber'
        }
        /// <summary>
        /// Test the property 'ErrorMessage'
        /// </summary>
        [Fact]
        public void ErrorMessageTest()
        {
            // TODO unit test for the property 'ErrorMessage'
        }

    }

}
