/*
 * ASCOM Alpaca Device API
 *
 * The Alpaca API uses RESTful techniques and TCP/IP to enable ASCOM applications and devices to communicate across modern network environments.  ## Interface Behaviour The ASCOM Interface behavioural requirements for Alpaca drivers are the same as for COM based drivers and are documented in the <a href=\"https://ascom-standards.org/Help/Developer/html/N_ASCOM_DeviceInterface.htm\">API Interface Definitions</a> e.g. the <a href=\"https://ascom-standards.org/Help/Developer/html/M_ASCOM_DeviceInterface_ITelescopeV3_SlewToCoordinates.htm\">Telescope.SlewToCoordinates</a> method.       This document focuses on how to use the ASCOM Interface standards in their RESTful Alpaca form. ## Alpaca URLs, Case Sensitivity, Parameters and Returned values **Alpaca Device API URLs** are of the form **http(s)://host:port/path** where path comprises **\"/api/v1/\"** followed by one of the method names below. e.g. for an Alpaca interface running on port 7843 of a device with IP address 192.168.1.89: * A telescope \"Interface Version\" method URL would be **http://192.168.1.89:7843/api/v1/telescope/0/InterfaceVersion**      * A first focuser \"Position\" method URL would be  **http://192.168.1.89:7843/api/v1/focuser/0/position**      * A second focuser \"StepSize\" method URL would be  **http://192.168.1.89:7843/api/v1/focuser/1/stepsize** * A rotator \"Halt\" method URL would be  **http://192.168.1.89:7843/api/v1/rotator/0/halt**   URLs are case sensitive and all elements must be in lower case. This means that both the device type and command name must always be in lower case. Parameter names are not case sensitive, so clients and drivers should be prepared for parameter names to be supplied and returned with any casing. Parameter values can be in mixed case as required.  For GET operations, parameters should be placed in the URL query string and for PUT operations they should be placed in the body of the message.  Responses, as described below, are returned in JSON format and always include a common set of values including the client's transaction number,  the server's transaction number together with any error message and error number. If the transaction completes successfully, the ErrorMessage field will be an empty string and the ErrorNumber field will be zero.  ## HTTP Status Codes and ASCOM Error codes The returned HTTP status code gives a high level view of whether the device understood the request and whether it attempted to process it.  Under most circumstances the returned status will be `200`, indicating that the request was correctly formatted and that it was passed to the device's handler to execute. A `200` status does not necessarily mean that the operation completed as expected, without error, and you must always check the ErrorMessage and ErrorNumber fields to confirm whether the returned result is valid. The `200` status simply means that the transaction was successfully managed by the device's transaction management layer.  An HTTP status code of `400` indicates that the device could not interpret the request e.g. an invalid device number or misspelt device type was supplied. Check the body of the response for a text error message.  An HTTP status code of `500` indicates an unexpected error within the device from which it could not recover. Check the body of the response for a text error message. ## SetupDialog and Alpaca Device Configuration The SetupDialog method has been omitted from the Alpaca Device API because it presents a user interface rather than returning data. Alpaca device configuration is covered in the \"ASCOM Alpaca Management API\" specification, which can be selected through the drop-down box at the head of this page. 
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Org.OpenAPITools.Client;
using Org.OpenAPITools.Api;
using ASCOM.Alpaca.Responses;
// uncomment below to import models
//using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Test.Api
{
    /// <summary>
    ///  Class for testing SafetyMonitorSpecificMethodsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class SafetyMonitorSpecificMethodsApiTests : IDisposable
    {
        private SafetyMonitorSpecificMethodsApi instance;

        public SafetyMonitorSpecificMethodsApiTests()
        {
            instance = new SafetyMonitorSpecificMethodsApi("http://localhost:5000/api/v1/");
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SafetyMonitorSpecificMethodsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SafetyMonitorSpecificMethodsApi
            Assert.IsType<SafetyMonitorSpecificMethodsApi>(instance);
        }

        /// <summary>
        /// Test SafetymonitorDeviceNumberIssafeGet
        /// </summary>
        [Fact]
        public void SafetymonitorDeviceNumberIssafeGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            int deviceNumber = 0;
            int? clientID = null;
            int? clientTransactionID = null;
            var response = instance.SafetymonitorIssafeGet(deviceNumber, clientID, clientTransactionID);
            Assert.IsType<BoolResponse>(response);
        }
    }
}
