using ASCOM.Alpaca.Responses;
using Org.OpenAPITools.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASCOM.Alpaca.Access
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAlpacaDeviceSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Invokes the named device-specific action.
        /// </summary>
        /// <remarks>
        /// Actions and SupportedActions are a standardised means for drivers to extend functionality beyond the built-in capabilities of the ASCOM device interfaces.  The key advantage of using Actions is that drivers can expose any device specific functionality required. The downside is that, in order to use these unique features, every application author would need to create bespoke code to present or exploit them.  The Action parameter and return strings are deceptively simple, but can support transmission of arbitrarily complex data structures, for example through JSON encoding.  This capability will be of primary value to  * &lt;span style&#x3D;\&quot;font-size:14px;\&quot;&gt;bespoke software and hardware configurations where a single entity controls both the consuming application software and the hardware / driver environment&lt;/span&gt;  * &lt;span style&#x3D;\&quot;font-size:14px;\&quot;&gt;a group of application and device authors to quickly formulate and try out new interface capabilities without requiring an immediate change to the ASCOM device interface, which will take a lot longer than just agreeing a name, input parameters and a standard response for an Action command.&lt;/span&gt;   The list of Action commands supported by a driver can be discovered through the SupportedActions property.  This method should return an error message and NotImplementedException error number (0x400) if the driver just implements the standard ASCOM device methods and has no bespoke, unique, functionality.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="action">A well known name that represents the action to be carried out.</param>
        /// <param name="parameters">List of required parameters or an Empty String if none are required</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional)</param>
        /// <returns>StringResponse</returns>
        StringResponse ActionPut(int deviceNumber, string action, string parameters, int? clientID = default(int?), int? clientTransactionID = default(int?));

        /// <summary>
        /// Invokes the named device-specific action.
        /// </summary>
        /// <remarks>
        /// Actions and SupportedActions are a standardised means for drivers to extend functionality beyond the built-in capabilities of the ASCOM device interfaces.  The key advantage of using Actions is that drivers can expose any device specific functionality required. The downside is that, in order to use these unique features, every application author would need to create bespoke code to present or exploit them.  The Action parameter and return strings are deceptively simple, but can support transmission of arbitrarily complex data structures, for example through JSON encoding.  This capability will be of primary value to  * &lt;span style&#x3D;\&quot;font-size:14px;\&quot;&gt;bespoke software and hardware configurations where a single entity controls both the consuming application software and the hardware / driver environment&lt;/span&gt;  * &lt;span style&#x3D;\&quot;font-size:14px;\&quot;&gt;a group of application and device authors to quickly formulate and try out new interface capabilities without requiring an immediate change to the ASCOM device interface, which will take a lot longer than just agreeing a name, input parameters and a standard response for an Action command.&lt;/span&gt;   The list of Action commands supported by a driver can be discovered through the SupportedActions property.  This method should return an error message and NotImplementedException error number (0x400) if the driver just implements the standard ASCOM device methods and has no bespoke, unique, functionality.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="action">A well known name that represents the action to be carried out.</param>
        /// <param name="parameters">List of required parameters or an Empty String if none are required</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional)</param>
        /// <returns>ApiResponse of StringResponse</returns>
        ApiResponse<StringResponse> ActionPutWithHttpInfo(int deviceNumber, string action, string parameters, int? clientID = default(int?), int? clientTransactionID = default(int?));
        /// <summary>
        /// Transmits an arbitrary string to the device
        /// </summary>
        /// <remarks>
        /// Transmits an arbitrary string to the device and does not wait for a response. Optionally, protocol framing characters may be added to the string before transmission.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="UNKNOWN_BASE_TYPE"> (optional)</param>
        /// <returns>Response</returns>
        Response CommandBlindPut(int deviceNumber, CommandPayload commandPayload);

        /// <summary>
        /// Transmits an arbitrary string to the device
        /// </summary>
        /// <remarks>
        /// Transmits an arbitrary string to the device and does not wait for a response. Optionally, protocol framing characters may be added to the string before transmission.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="UNKNOWN_BASE_TYPE"> (optional)</param>
        /// <returns>ApiResponse of Response</returns>
        ApiResponse<Response> CommandBlindPutWithHttpInfo(int deviceNumber, CommandPayload commandPayload);
        /// <summary>
        /// Transmits an arbitrary string to the device and returns a boolean value from the device.
        /// </summary>
        /// <remarks>
        /// Transmits an arbitrary string to the device and waits for a boolean response. Optionally, protocol framing characters may be added to the string before transmission.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="UNKNOWN_BASE_TYPE"> (optional)</param>
        /// <returns>BoolResponse</returns>
        BoolResponse CommandBoolPut(int deviceNumber, CommandPayload commandPayload);

        /// <summary>
        /// Transmits an arbitrary string to the device and returns a boolean value from the device.
        /// </summary>
        /// <remarks>
        /// Transmits an arbitrary string to the device and waits for a boolean response. Optionally, protocol framing characters may be added to the string before transmission.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="UNKNOWN_BASE_TYPE"> (optional)</param>
        /// <returns>ApiResponse of BoolResponse</returns>
        ApiResponse<BoolResponse> CommandBoolPutWithHttpInfo(int deviceNumber, CommandPayload commandPayload);
        /// <summary>
        /// Transmits an arbitrary string to the device and returns a string value from the device.
        /// </summary>
        /// <remarks>
        /// Transmits an arbitrary string to the device and waits for a string response. Optionally, protocol framing characters may be added to the string before transmission.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="UNKNOWN_BASE_TYPE"> (optional)</param>
        /// <returns>StringResponse</returns>
        StringResponse CommandStringPut(int deviceNumber, CommandPayload commandPayload);

        /// <summary>
        /// Transmits an arbitrary string to the device and returns a string value from the device.
        /// </summary>
        /// <remarks>
        /// Transmits an arbitrary string to the device and waits for a string response. Optionally, protocol framing characters may be added to the string before transmission.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="UNKNOWN_BASE_TYPE"> (optional)</param>
        /// <returns>ApiResponse of StringResponse</returns>
        ApiResponse<StringResponse> CommandStringPutWithHttpInfo(int deviceNumber, CommandPayload commandPayload);
        /// <summary>
        /// Retrieves the connected state of the device
        /// </summary>
        /// <remarks>
        /// Retrieves the connected state of the device
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <returns>BoolResponse</returns>
        BoolResponse ConnectedGet(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?));

        /// <summary>
        /// Retrieves the connected state of the device
        /// </summary>
        /// <remarks>
        /// Retrieves the connected state of the device
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <returns>ApiResponse of BoolResponse</returns>
        ApiResponse<BoolResponse> ConnectedGetWithHttpInfo(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?));
        /// <summary>
        /// Sets the connected state of the device
        /// </summary>
        /// <remarks>
        /// Sets the connected state of the device
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="connected">Set True to connect to the device hardware, set False to disconnect from the device hardware</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional)</param>
        /// <returns>Response</returns>
        Response ConnectedPut(int deviceNumber, bool connected, int? clientID = default(int?), int? clientTransactionID = default(int?));

        /// <summary>
        /// Sets the connected state of the device
        /// </summary>
        /// <remarks>
        /// Sets the connected state of the device
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="connected">Set True to connect to the device hardware, set False to disconnect from the device hardware</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional)</param>
        /// <returns>ApiResponse of Response</returns>
        ApiResponse<Response> ConnectedPutWithHttpInfo(int deviceNumber, bool connected, int? clientID = default(int?), int? clientTransactionID = default(int?));
        /// <summary>
        /// Device description
        /// </summary>
        /// <remarks>
        /// The description of the device
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <returns>StringResponse</returns>
        StringResponse DescriptionGet(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?));

        /// <summary>
        /// Device description
        /// </summary>
        /// <remarks>
        /// The description of the device
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <returns>ApiResponse of StringResponse</returns>
        ApiResponse<StringResponse> DescriptionGetWithHttpInfo(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?));
        /// <summary>
        /// Device driver description
        /// </summary>
        /// <remarks>
        /// The description of the driver
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <returns>StringResponse</returns>
        StringResponse DriverInfoGet(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?));

        /// <summary>
        /// Device driver description
        /// </summary>
        /// <remarks>
        /// The description of the driver
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <returns>ApiResponse of StringResponse</returns>
        ApiResponse<StringResponse> DriverInfoGetWithHttpInfo(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?));
        /// <summary>
        /// Driver Version
        /// </summary>
        /// <remarks>
        /// A string containing only the major and minor version of the driver.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <returns>StringResponse</returns>
        StringResponse DriverVersionGet(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?));

        /// <summary>
        /// Driver Version
        /// </summary>
        /// <remarks>
        /// A string containing only the major and minor version of the driver.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <returns>ApiResponse of StringResponse</returns>
        ApiResponse<StringResponse> DriverVersionGetWithHttpInfo(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?));
        /// <summary>
        /// The ASCOM Device interface version number that this device supports.
        /// </summary>
        /// <remarks>
        /// This method returns the version of the ASCOM device interface contract to which this device complies. Only one interface version is current at a moment in time and all new devices should be built to the latest interface version. Applications can choose which device interface versions they support and it is in their interest to support  previous versions as well as the current version to ensure thay can use the largest number of devices.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <returns>IntResponse</returns>
        IntResponse InterfaceVersionGet(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?));

        /// <summary>
        /// The ASCOM Device interface version number that this device supports.
        /// </summary>
        /// <remarks>
        /// This method returns the version of the ASCOM device interface contract to which this device complies. Only one interface version is current at a moment in time and all new devices should be built to the latest interface version. Applications can choose which device interface versions they support and it is in their interest to support  previous versions as well as the current version to ensure thay can use the largest number of devices.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <returns>ApiResponse of IntResponse</returns>
        ApiResponse<IntResponse> InterfaceVersionGetWithHttpInfo(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?));
        /// <summary>
        /// Device name
        /// </summary>
        /// <remarks>
        /// The name of the device
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <returns>StringResponse</returns>
        StringResponse NameGet(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?));

        /// <summary>
        /// Device name
        /// </summary>
        /// <remarks>
        /// The name of the device
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <returns>ApiResponse of StringResponse</returns>
        ApiResponse<StringResponse> NameGetWithHttpInfo(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?));
        /// <summary>
        /// Returns the list of action names supported by this driver.
        /// </summary>
        /// <remarks>
        /// Returns the list of action names supported by this driver.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <returns>StringListResponse</returns>
        StringListResponse SupportedActionsGet(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?));

        /// <summary>
        /// Returns the list of action names supported by this driver.
        /// </summary>
        /// <remarks>
        /// Returns the list of action names supported by this driver.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <returns>ApiResponse of StringListResponse</returns>
        ApiResponse<StringListResponse> SupportedActionsGetWithHttpInfo(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAlpacaDeviceAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Invokes the named device-specific action.
        /// </summary>
        /// <remarks>
        /// Actions and SupportedActions are a standardised means for drivers to extend functionality beyond the built-in capabilities of the ASCOM device interfaces.  The key advantage of using Actions is that drivers can expose any device specific functionality required. The downside is that, in order to use these unique features, every application author would need to create bespoke code to present or exploit them.  The Action parameter and return strings are deceptively simple, but can support transmission of arbitrarily complex data structures, for example through JSON encoding.  This capability will be of primary value to  * &lt;span style&#x3D;\&quot;font-size:14px;\&quot;&gt;bespoke software and hardware configurations where a single entity controls both the consuming application software and the hardware / driver environment&lt;/span&gt;  * &lt;span style&#x3D;\&quot;font-size:14px;\&quot;&gt;a group of application and device authors to quickly formulate and try out new interface capabilities without requiring an immediate change to the ASCOM device interface, which will take a lot longer than just agreeing a name, input parameters and a standard response for an Action command.&lt;/span&gt;   The list of Action commands supported by a driver can be discovered through the SupportedActions property.  This method should return an error message and NotImplementedException error number (0x400) if the driver just implements the standard ASCOM device methods and has no bespoke, unique, functionality.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="action">A well known name that represents the action to be carried out.</param>
        /// <param name="parameters">List of required parameters or an Empty String if none are required</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of StringResponse</returns>
        System.Threading.Tasks.Task<StringResponse> ActionPutAsync(int deviceNumber, string action, string parameters, int? clientID = default(int?), int? clientTransactionID = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Invokes the named device-specific action.
        /// </summary>
        /// <remarks>
        /// Actions and SupportedActions are a standardised means for drivers to extend functionality beyond the built-in capabilities of the ASCOM device interfaces.  The key advantage of using Actions is that drivers can expose any device specific functionality required. The downside is that, in order to use these unique features, every application author would need to create bespoke code to present or exploit them.  The Action parameter and return strings are deceptively simple, but can support transmission of arbitrarily complex data structures, for example through JSON encoding.  This capability will be of primary value to  * &lt;span style&#x3D;\&quot;font-size:14px;\&quot;&gt;bespoke software and hardware configurations where a single entity controls both the consuming application software and the hardware / driver environment&lt;/span&gt;  * &lt;span style&#x3D;\&quot;font-size:14px;\&quot;&gt;a group of application and device authors to quickly formulate and try out new interface capabilities without requiring an immediate change to the ASCOM device interface, which will take a lot longer than just agreeing a name, input parameters and a standard response for an Action command.&lt;/span&gt;   The list of Action commands supported by a driver can be discovered through the SupportedActions property.  This method should return an error message and NotImplementedException error number (0x400) if the driver just implements the standard ASCOM device methods and has no bespoke, unique, functionality.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="action">A well known name that represents the action to be carried out.</param>
        /// <param name="parameters">List of required parameters or an Empty String if none are required</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (StringResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<StringResponse>> ActionPutWithHttpInfoAsync(int deviceNumber, string action, string parameters, int? clientID = default(int?), int? clientTransactionID = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Transmits an arbitrary string to the device
        /// </summary>
        /// <remarks>
        /// Transmits an arbitrary string to the device and does not wait for a response. Optionally, protocol framing characters may be added to the string before transmission.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="UNKNOWN_BASE_TYPE"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Response</returns>
        System.Threading.Tasks.Task<Response> CommandBlindPutAsync(int deviceNumber, CommandPayload commandPayload, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Transmits an arbitrary string to the device
        /// </summary>
        /// <remarks>
        /// Transmits an arbitrary string to the device and does not wait for a response. Optionally, protocol framing characters may be added to the string before transmission.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="UNKNOWN_BASE_TYPE"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<Response>> CommandBlindPutWithHttpInfoAsync(int deviceNumber, CommandPayload commandPayload, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Transmits an arbitrary string to the device and returns a boolean value from the device.
        /// </summary>
        /// <remarks>
        /// Transmits an arbitrary string to the device and waits for a boolean response. Optionally, protocol framing characters may be added to the string before transmission.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="UNKNOWN_BASE_TYPE"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of BoolResponse</returns>
        System.Threading.Tasks.Task<BoolResponse> CommandBoolPutAsync(int deviceNumber, CommandPayload commandPayload, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Transmits an arbitrary string to the device and returns a boolean value from the device.
        /// </summary>
        /// <remarks>
        /// Transmits an arbitrary string to the device and waits for a boolean response. Optionally, protocol framing characters may be added to the string before transmission.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="UNKNOWN_BASE_TYPE"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (BoolResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<BoolResponse>> CommandBoolPutWithHttpInfoAsync(int deviceNumber, CommandPayload commandPayload, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Transmits an arbitrary string to the device and returns a string value from the device.
        /// </summary>
        /// <remarks>
        /// Transmits an arbitrary string to the device and waits for a string response. Optionally, protocol framing characters may be added to the string before transmission.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="UNKNOWN_BASE_TYPE"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of StringResponse</returns>
        System.Threading.Tasks.Task<StringResponse> CommandStringPutAsync(int deviceNumber, CommandPayload commandPayload, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Transmits an arbitrary string to the device and returns a string value from the device.
        /// </summary>
        /// <remarks>
        /// Transmits an arbitrary string to the device and waits for a string response. Optionally, protocol framing characters may be added to the string before transmission.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="UNKNOWN_BASE_TYPE"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (StringResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<StringResponse>> CommandStringPutWithHttpInfoAsync(int deviceNumber, CommandPayload commandPayload, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Retrieves the connected state of the device
        /// </summary>
        /// <remarks>
        /// Retrieves the connected state of the device
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of BoolResponse</returns>
        System.Threading.Tasks.Task<BoolResponse> ConnectedGetAsync(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Retrieves the connected state of the device
        /// </summary>
        /// <remarks>
        /// Retrieves the connected state of the device
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (BoolResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<BoolResponse>> ConnectedGetWithHttpInfoAsync(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Sets the connected state of the device
        /// </summary>
        /// <remarks>
        /// Sets the connected state of the device
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="connected">Set True to connect to the device hardware, set False to disconnect from the device hardware</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Response</returns>
        System.Threading.Tasks.Task<Response> ConnectedPutAsync(int deviceNumber, bool connected, int? clientID = default(int?), int? clientTransactionID = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Sets the connected state of the device
        /// </summary>
        /// <remarks>
        /// Sets the connected state of the device
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="connected">Set True to connect to the device hardware, set False to disconnect from the device hardware</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<Response>> ConnectedPutWithHttpInfoAsync(int deviceNumber, bool connected, int? clientID = default(int?), int? clientTransactionID = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Device description
        /// </summary>
        /// <remarks>
        /// The description of the device
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of StringResponse</returns>
        System.Threading.Tasks.Task<StringResponse> DescriptionGetAsync(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Device description
        /// </summary>
        /// <remarks>
        /// The description of the device
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (StringResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<StringResponse>> DescriptionGetWithHttpInfoAsync(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Device driver description
        /// </summary>
        /// <remarks>
        /// The description of the driver
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of StringResponse</returns>
        System.Threading.Tasks.Task<StringResponse> DriverInfoGetAsync(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Device driver description
        /// </summary>
        /// <remarks>
        /// The description of the driver
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (StringResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<StringResponse>> DriverInfoGetWithHttpInfoAsync(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Driver Version
        /// </summary>
        /// <remarks>
        /// A string containing only the major and minor version of the driver.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of StringResponse</returns>
        System.Threading.Tasks.Task<StringResponse> DriverVersionGetAsync(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Driver Version
        /// </summary>
        /// <remarks>
        /// A string containing only the major and minor version of the driver.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (StringResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<StringResponse>> DriverVersionGetWithHttpInfoAsync(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// The ASCOM Device interface version number that this device supports.
        /// </summary>
        /// <remarks>
        /// This method returns the version of the ASCOM device interface contract to which this device complies. Only one interface version is current at a moment in time and all new devices should be built to the latest interface version. Applications can choose which device interface versions they support and it is in their interest to support  previous versions as well as the current version to ensure thay can use the largest number of devices.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of IntResponse</returns>
        System.Threading.Tasks.Task<IntResponse> InterfaceVersionGetAsync(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// The ASCOM Device interface version number that this device supports.
        /// </summary>
        /// <remarks>
        /// This method returns the version of the ASCOM device interface contract to which this device complies. Only one interface version is current at a moment in time and all new devices should be built to the latest interface version. Applications can choose which device interface versions they support and it is in their interest to support  previous versions as well as the current version to ensure thay can use the largest number of devices.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (IntResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<IntResponse>> InterfaceVersionGetWithHttpInfoAsync(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Device name
        /// </summary>
        /// <remarks>
        /// The name of the device
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of StringResponse</returns>
        System.Threading.Tasks.Task<StringResponse> NameGetAsync(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Device name
        /// </summary>
        /// <remarks>
        /// The name of the device
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (StringResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<StringResponse>> NameGetWithHttpInfoAsync(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Returns the list of action names supported by this driver.
        /// </summary>
        /// <remarks>
        /// Returns the list of action names supported by this driver.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of StringListResponse</returns>
        System.Threading.Tasks.Task<StringListResponse> SupportedActionsGetAsync(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Returns the list of action names supported by this driver.
        /// </summary>
        /// <remarks>
        /// Returns the list of action names supported by this driver.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (StringListResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<StringListResponse>> SupportedActionsGetWithHttpInfoAsync(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAlpacaBase : IAlpacaDeviceSync, IAlpacaDeviceAsync
    {

    }

    public class AlpacaBase : IAlpacaBase
    {
        private Org.OpenAPITools.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        private string DeviceType
        {
            get;
            set;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ASCOMMethodsCommonToAllDevicesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlpacaBase(string deviceType) : this(deviceType, (string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ASCOMMethodsCommonToAllDevicesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlpacaBase(string deviceType, string basePath)
        {
            this.Configuration = Org.OpenAPITools.Client.Configuration.MergeConfigurations(
                Org.OpenAPITools.Client.GlobalConfiguration.Instance,
                new Org.OpenAPITools.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;

            DeviceType = deviceType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ASCOMMethodsCommonToAllDevicesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AlpacaBase(string deviceType, Org.OpenAPITools.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Org.OpenAPITools.Client.Configuration.MergeConfigurations(
                Org.OpenAPITools.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;

            DeviceType = deviceType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ASCOMMethodsCommonToAllDevicesApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AlpacaBase(Org.OpenAPITools.Client.ISynchronousClient client, Org.OpenAPITools.Client.IAsynchronousClient asyncClient, Org.OpenAPITools.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Org.OpenAPITools.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Org.OpenAPITools.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Org.OpenAPITools.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Org.OpenAPITools.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Invokes the named device-specific action. Actions and SupportedActions are a standardised means for drivers to extend functionality beyond the built-in capabilities of the ASCOM device interfaces.  The key advantage of using Actions is that drivers can expose any device specific functionality required. The downside is that, in order to use these unique features, every application author would need to create bespoke code to present or exploit them.  The Action parameter and return strings are deceptively simple, but can support transmission of arbitrarily complex data structures, for example through JSON encoding.  This capability will be of primary value to  * &lt;span style&#x3D;\&quot;font-size:14px;\&quot;&gt;bespoke software and hardware configurations where a single entity controls both the consuming application software and the hardware / driver environment&lt;/span&gt;  * &lt;span style&#x3D;\&quot;font-size:14px;\&quot;&gt;a group of application and device authors to quickly formulate and try out new interface capabilities without requiring an immediate change to the ASCOM device interface, which will take a lot longer than just agreeing a name, input parameters and a standard response for an Action command.&lt;/span&gt;   The list of Action commands supported by a driver can be discovered through the SupportedActions property.  This method should return an error message and NotImplementedException error number (0x400) if the driver just implements the standard ASCOM device methods and has no bespoke, unique, functionality.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="action">A well known name that represents the action to be carried out.</param>
        /// <param name="parameters">List of required parameters or an Empty String if none are required</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional)</param>
        /// <returns>StringResponse</returns>
        public StringResponse ActionPut(int deviceNumber, string action, string parameters, int? clientID = default(int?), int? clientTransactionID = default(int?))
        {
            Org.OpenAPITools.Client.ApiResponse<StringResponse> localVarResponse = ActionPutWithHttpInfo(deviceNumber, action, parameters, clientID, clientTransactionID);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Invokes the named device-specific action. Actions and SupportedActions are a standardised means for drivers to extend functionality beyond the built-in capabilities of the ASCOM device interfaces.  The key advantage of using Actions is that drivers can expose any device specific functionality required. The downside is that, in order to use these unique features, every application author would need to create bespoke code to present or exploit them.  The Action parameter and return strings are deceptively simple, but can support transmission of arbitrarily complex data structures, for example through JSON encoding.  This capability will be of primary value to  * &lt;span style&#x3D;\&quot;font-size:14px;\&quot;&gt;bespoke software and hardware configurations where a single entity controls both the consuming application software and the hardware / driver environment&lt;/span&gt;  * &lt;span style&#x3D;\&quot;font-size:14px;\&quot;&gt;a group of application and device authors to quickly formulate and try out new interface capabilities without requiring an immediate change to the ASCOM device interface, which will take a lot longer than just agreeing a name, input parameters and a standard response for an Action command.&lt;/span&gt;   The list of Action commands supported by a driver can be discovered through the SupportedActions property.  This method should return an error message and NotImplementedException error number (0x400) if the driver just implements the standard ASCOM device methods and has no bespoke, unique, functionality.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="action">A well known name that represents the action to be carried out.</param>
        /// <param name="parameters">List of required parameters or an Empty String if none are required</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional)</param>
        /// <returns>ApiResponse of StringResponse</returns>
        public Org.OpenAPITools.Client.ApiResponse<StringResponse> ActionPutWithHttpInfo(int deviceNumber, string action, string parameters, int? clientID = default(int?), int? clientTransactionID = default(int?))
        {
            // verify the required parameter 'DeviceType' is set
            if (DeviceType == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'DeviceType' when calling ASCOMMethodsCommonToAllDevicesApi->ActionPut");

            // verify the required parameter 'action' is set
            if (action == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'action' when calling ASCOMMethodsCommonToAllDevicesApi->ActionPut");

            // verify the required parameter 'parameters' is set
            if (parameters == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'parameters' when calling ASCOMMethodsCommonToAllDevicesApi->ActionPut");

            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/x-www-form-urlencoded"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("device_type", Org.OpenAPITools.Client.ClientUtils.ParameterToString(DeviceType)); // path parameter
            localVarRequestOptions.PathParameters.Add("device_number", Org.OpenAPITools.Client.ClientUtils.ParameterToString(deviceNumber)); // path parameter
            localVarRequestOptions.FormParameters.Add("Action", Org.OpenAPITools.Client.ClientUtils.ParameterToString(action)); // form parameter
            localVarRequestOptions.FormParameters.Add("Parameters", Org.OpenAPITools.Client.ClientUtils.ParameterToString(parameters)); // form parameter
            if (clientID != null)
            {
                localVarRequestOptions.FormParameters.Add("ClientID", Org.OpenAPITools.Client.ClientUtils.ParameterToString(clientID)); // form parameter
            }
            if (clientTransactionID != null)
            {
                localVarRequestOptions.FormParameters.Add("ClientTransactionID", Org.OpenAPITools.Client.ClientUtils.ParameterToString(clientTransactionID)); // form parameter
            }


            // make the HTTP request
            var localVarResponse = this.Client.Put<StringResponse>("/{device_type}/{device_number}/action", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ActionPut", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Invokes the named device-specific action. Actions and SupportedActions are a standardised means for drivers to extend functionality beyond the built-in capabilities of the ASCOM device interfaces.  The key advantage of using Actions is that drivers can expose any device specific functionality required. The downside is that, in order to use these unique features, every application author would need to create bespoke code to present or exploit them.  The Action parameter and return strings are deceptively simple, but can support transmission of arbitrarily complex data structures, for example through JSON encoding.  This capability will be of primary value to  * &lt;span style&#x3D;\&quot;font-size:14px;\&quot;&gt;bespoke software and hardware configurations where a single entity controls both the consuming application software and the hardware / driver environment&lt;/span&gt;  * &lt;span style&#x3D;\&quot;font-size:14px;\&quot;&gt;a group of application and device authors to quickly formulate and try out new interface capabilities without requiring an immediate change to the ASCOM device interface, which will take a lot longer than just agreeing a name, input parameters and a standard response for an Action command.&lt;/span&gt;   The list of Action commands supported by a driver can be discovered through the SupportedActions property.  This method should return an error message and NotImplementedException error number (0x400) if the driver just implements the standard ASCOM device methods and has no bespoke, unique, functionality.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="action">A well known name that represents the action to be carried out.</param>
        /// <param name="parameters">List of required parameters or an Empty String if none are required</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of StringResponse</returns>
        public async System.Threading.Tasks.Task<StringResponse> ActionPutAsync(int deviceNumber, string action, string parameters, int? clientID = default(int?), int? clientTransactionID = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Org.OpenAPITools.Client.ApiResponse<StringResponse> localVarResponse = await ActionPutWithHttpInfoAsync(deviceNumber, action, parameters, clientID, clientTransactionID, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Invokes the named device-specific action. Actions and SupportedActions are a standardised means for drivers to extend functionality beyond the built-in capabilities of the ASCOM device interfaces.  The key advantage of using Actions is that drivers can expose any device specific functionality required. The downside is that, in order to use these unique features, every application author would need to create bespoke code to present or exploit them.  The Action parameter and return strings are deceptively simple, but can support transmission of arbitrarily complex data structures, for example through JSON encoding.  This capability will be of primary value to  * &lt;span style&#x3D;\&quot;font-size:14px;\&quot;&gt;bespoke software and hardware configurations where a single entity controls both the consuming application software and the hardware / driver environment&lt;/span&gt;  * &lt;span style&#x3D;\&quot;font-size:14px;\&quot;&gt;a group of application and device authors to quickly formulate and try out new interface capabilities without requiring an immediate change to the ASCOM device interface, which will take a lot longer than just agreeing a name, input parameters and a standard response for an Action command.&lt;/span&gt;   The list of Action commands supported by a driver can be discovered through the SupportedActions property.  This method should return an error message and NotImplementedException error number (0x400) if the driver just implements the standard ASCOM device methods and has no bespoke, unique, functionality.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="action">A well known name that represents the action to be carried out.</param>
        /// <param name="parameters">List of required parameters or an Empty String if none are required</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (StringResponse)</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<StringResponse>> ActionPutWithHttpInfoAsync(int deviceNumber, string action, string parameters, int? clientID = default(int?), int? clientTransactionID = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'DeviceType' is set
            if (DeviceType == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'DeviceType' when calling ASCOMMethodsCommonToAllDevicesApi->ActionPut");

            // verify the required parameter 'action' is set
            if (action == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'action' when calling ASCOMMethodsCommonToAllDevicesApi->ActionPut");

            // verify the required parameter 'parameters' is set
            if (parameters == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'parameters' when calling ASCOMMethodsCommonToAllDevicesApi->ActionPut");


            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/x-www-form-urlencoded"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("device_type", Org.OpenAPITools.Client.ClientUtils.ParameterToString(DeviceType)); // path parameter
            localVarRequestOptions.PathParameters.Add("device_number", Org.OpenAPITools.Client.ClientUtils.ParameterToString(deviceNumber)); // path parameter
            localVarRequestOptions.FormParameters.Add("Action", Org.OpenAPITools.Client.ClientUtils.ParameterToString(action)); // form parameter
            localVarRequestOptions.FormParameters.Add("Parameters", Org.OpenAPITools.Client.ClientUtils.ParameterToString(parameters)); // form parameter
            if (clientID != null)
            {
                localVarRequestOptions.FormParameters.Add("ClientID", Org.OpenAPITools.Client.ClientUtils.ParameterToString(clientID)); // form parameter
            }
            if (clientTransactionID != null)
            {
                localVarRequestOptions.FormParameters.Add("ClientTransactionID", Org.OpenAPITools.Client.ClientUtils.ParameterToString(clientTransactionID)); // form parameter
            }


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<StringResponse>("/{device_type}/{device_number}/action", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ActionPut", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Transmits an arbitrary string to the device Transmits an arbitrary string to the device and does not wait for a response. Optionally, protocol framing characters may be added to the string before transmission.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="UNKNOWN_BASE_TYPE"> (optional)</param>
        /// <returns>Response</returns>
        public Response CommandBlindPut(int deviceNumber, CommandPayload commandPayload)
        {
            Org.OpenAPITools.Client.ApiResponse<Response> localVarResponse = CommandBlindPutWithHttpInfo(deviceNumber, commandPayload);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Transmits an arbitrary string to the device Transmits an arbitrary string to the device and does not wait for a response. Optionally, protocol framing characters may be added to the string before transmission.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="UNKNOWN_BASE_TYPE"> (optional)</param>
        /// <returns>ApiResponse of Response</returns>
        public Org.OpenAPITools.Client.ApiResponse<Response> CommandBlindPutWithHttpInfo(int deviceNumber, CommandPayload commandPayload)
        {
            // verify the required parameter 'DeviceType' is set
            if (DeviceType == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'DeviceType' when calling ASCOMMethodsCommonToAllDevicesApi->CommandBlindPut");

            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/x-www-form-urlencoded"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("device_type", Org.OpenAPITools.Client.ClientUtils.ParameterToString(DeviceType)); // path parameter
            localVarRequestOptions.PathParameters.Add("device_number", Org.OpenAPITools.Client.ClientUtils.ParameterToString(deviceNumber)); // path parameter
            localVarRequestOptions.Data = commandPayload;


            // make the HTTP request
            var localVarResponse = this.Client.Put<Response>("/{device_type}/{device_number}/CommandBlind", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CommandBlindPut", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Transmits an arbitrary string to the device Transmits an arbitrary string to the device and does not wait for a response. Optionally, protocol framing characters may be added to the string before transmission.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="UNKNOWN_BASE_TYPE"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Response</returns>
        public async System.Threading.Tasks.Task<Response> CommandBlindPutAsync(int deviceNumber, CommandPayload commandPayload, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Org.OpenAPITools.Client.ApiResponse<Response> localVarResponse = await CommandBlindPutWithHttpInfoAsync(deviceNumber, commandPayload, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Transmits an arbitrary string to the device Transmits an arbitrary string to the device and does not wait for a response. Optionally, protocol framing characters may be added to the string before transmission.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="UNKNOWN_BASE_TYPE"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Response)</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<Response>> CommandBlindPutWithHttpInfoAsync(int deviceNumber, CommandPayload commandPayload, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'DeviceType' is set
            if (DeviceType == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'DeviceType' when calling ASCOMMethodsCommonToAllDevicesApi->CommandBlindPut");


            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/x-www-form-urlencoded"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("device_type", Org.OpenAPITools.Client.ClientUtils.ParameterToString(DeviceType)); // path parameter
            localVarRequestOptions.PathParameters.Add("device_number", Org.OpenAPITools.Client.ClientUtils.ParameterToString(deviceNumber)); // path parameter
            localVarRequestOptions.Data = commandPayload;


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<Response>("/{device_type}/{device_number}/CommandBlind", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CommandBlindPut", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Transmits an arbitrary string to the device and returns a boolean value from the device. Transmits an arbitrary string to the device and waits for a boolean response. Optionally, protocol framing characters may be added to the string before transmission.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="UNKNOWN_BASE_TYPE"> (optional)</param>
        /// <returns>BoolResponse</returns>
        public BoolResponse CommandBoolPut(int deviceNumber, CommandPayload commandPayload)
        {
            Org.OpenAPITools.Client.ApiResponse<BoolResponse> localVarResponse = CommandBoolPutWithHttpInfo(deviceNumber, commandPayload);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Transmits an arbitrary string to the device and returns a boolean value from the device. Transmits an arbitrary string to the device and waits for a boolean response. Optionally, protocol framing characters may be added to the string before transmission.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="UNKNOWN_BASE_TYPE"> (optional)</param>
        /// <returns>ApiResponse of BoolResponse</returns>
        public Org.OpenAPITools.Client.ApiResponse<BoolResponse> CommandBoolPutWithHttpInfo(int deviceNumber, CommandPayload commandPayload)
        {
            // verify the required parameter 'DeviceType' is set
            if (DeviceType == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'DeviceType' when calling ASCOMMethodsCommonToAllDevicesApi->CommandBoolPut");

            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/x-www-form-urlencoded"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("device_type", Org.OpenAPITools.Client.ClientUtils.ParameterToString(DeviceType)); // path parameter
            localVarRequestOptions.PathParameters.Add("device_number", Org.OpenAPITools.Client.ClientUtils.ParameterToString(deviceNumber)); // path parameter
            localVarRequestOptions.Data = commandPayload;


            // make the HTTP request
            var localVarResponse = this.Client.Put<BoolResponse>("/{device_type}/{device_number}/CommandBool", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CommandBoolPut", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Transmits an arbitrary string to the device and returns a boolean value from the device. Transmits an arbitrary string to the device and waits for a boolean response. Optionally, protocol framing characters may be added to the string before transmission.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="UNKNOWN_BASE_TYPE"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of BoolResponse</returns>
        public async System.Threading.Tasks.Task<BoolResponse> CommandBoolPutAsync(int deviceNumber, CommandPayload commandPayload, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Org.OpenAPITools.Client.ApiResponse<BoolResponse> localVarResponse = await CommandBoolPutWithHttpInfoAsync(deviceNumber, commandPayload, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Transmits an arbitrary string to the device and returns a boolean value from the device. Transmits an arbitrary string to the device and waits for a boolean response. Optionally, protocol framing characters may be added to the string before transmission.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="UNKNOWN_BASE_TYPE"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (BoolResponse)</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<BoolResponse>> CommandBoolPutWithHttpInfoAsync(int deviceNumber, CommandPayload commandPayload, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'DeviceType' is set
            if (DeviceType == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'DeviceType' when calling ASCOMMethodsCommonToAllDevicesApi->CommandBoolPut");


            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/x-www-form-urlencoded"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("device_type", Org.OpenAPITools.Client.ClientUtils.ParameterToString(DeviceType)); // path parameter
            localVarRequestOptions.PathParameters.Add("device_number", Org.OpenAPITools.Client.ClientUtils.ParameterToString(deviceNumber)); // path parameter
            localVarRequestOptions.Data = commandPayload;


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<BoolResponse>("/{device_type}/{device_number}/CommandBool", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CommandBoolPut", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Transmits an arbitrary string to the device and returns a string value from the device. Transmits an arbitrary string to the device and waits for a string response. Optionally, protocol framing characters may be added to the string before transmission.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="UNKNOWN_BASE_TYPE"> (optional)</param>
        /// <returns>StringResponse</returns>
        public StringResponse CommandStringPut(int deviceNumber, CommandPayload commandPayload)
        {
            Org.OpenAPITools.Client.ApiResponse<StringResponse> localVarResponse = CommandStringPutWithHttpInfo(deviceNumber, commandPayload);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Transmits an arbitrary string to the device and returns a string value from the device. Transmits an arbitrary string to the device and waits for a string response. Optionally, protocol framing characters may be added to the string before transmission.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="UNKNOWN_BASE_TYPE"> (optional)</param>
        /// <returns>ApiResponse of StringResponse</returns>
        public Org.OpenAPITools.Client.ApiResponse<StringResponse> CommandStringPutWithHttpInfo(int deviceNumber, CommandPayload commandPayload)
        {
            // verify the required parameter 'DeviceType' is set
            if (DeviceType == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'DeviceType' when calling ASCOMMethodsCommonToAllDevicesApi->CommandStringPut");

            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/x-www-form-urlencoded"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("device_type", Org.OpenAPITools.Client.ClientUtils.ParameterToString(DeviceType)); // path parameter
            localVarRequestOptions.PathParameters.Add("device_number", Org.OpenAPITools.Client.ClientUtils.ParameterToString(deviceNumber)); // path parameter
            localVarRequestOptions.Data = commandPayload;


            // make the HTTP request
            var localVarResponse = this.Client.Put<StringResponse>("/{device_type}/{device_number}/CommandString", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CommandStringPut", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Transmits an arbitrary string to the device and returns a string value from the device. Transmits an arbitrary string to the device and waits for a string response. Optionally, protocol framing characters may be added to the string before transmission.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="UNKNOWN_BASE_TYPE"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of StringResponse</returns>
        public async System.Threading.Tasks.Task<StringResponse> CommandStringPutAsync(int deviceNumber, CommandPayload commandPayload, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Org.OpenAPITools.Client.ApiResponse<StringResponse> localVarResponse = await CommandStringPutWithHttpInfoAsync(deviceNumber, commandPayload, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Transmits an arbitrary string to the device and returns a string value from the device. Transmits an arbitrary string to the device and waits for a string response. Optionally, protocol framing characters may be added to the string before transmission.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="UNKNOWN_BASE_TYPE"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (StringResponse)</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<StringResponse>> CommandStringPutWithHttpInfoAsync(int deviceNumber, CommandPayload commandPayload, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'DeviceType' is set
            if (DeviceType == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'DeviceType' when calling ASCOMMethodsCommonToAllDevicesApi->CommandStringPut");


            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/x-www-form-urlencoded"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("device_type", Org.OpenAPITools.Client.ClientUtils.ParameterToString(DeviceType)); // path parameter
            localVarRequestOptions.PathParameters.Add("device_number", Org.OpenAPITools.Client.ClientUtils.ParameterToString(deviceNumber)); // path parameter
            localVarRequestOptions.Data = commandPayload;


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<StringResponse>("/{device_type}/{device_number}/CommandString", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CommandStringPut", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retrieves the connected state of the device Retrieves the connected state of the device
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <returns>BoolResponse</returns>
        public BoolResponse ConnectedGet(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?))
        {
            Org.OpenAPITools.Client.ApiResponse<BoolResponse> localVarResponse = ConnectedGetWithHttpInfo(deviceNumber, clientID, clientTransactionID);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves the connected state of the device Retrieves the connected state of the device
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <returns>ApiResponse of BoolResponse</returns>
        public Org.OpenAPITools.Client.ApiResponse<BoolResponse> ConnectedGetWithHttpInfo(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?))
        {
            // verify the required parameter 'DeviceType' is set
            if (DeviceType == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'DeviceType' when calling ASCOMMethodsCommonToAllDevicesApi->ConnectedGet");

            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("device_type", Org.OpenAPITools.Client.ClientUtils.ParameterToString(DeviceType)); // path parameter
            localVarRequestOptions.PathParameters.Add("device_number", Org.OpenAPITools.Client.ClientUtils.ParameterToString(deviceNumber)); // path parameter
            if (clientID != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "ClientID", clientID));
            }
            if (clientTransactionID != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "ClientTransactionID", clientTransactionID));
            }


            // make the HTTP request
            var localVarResponse = this.Client.Get<BoolResponse>("/{device_type}/{device_number}/connected", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConnectedGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retrieves the connected state of the device Retrieves the connected state of the device
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of BoolResponse</returns>
        public async System.Threading.Tasks.Task<BoolResponse> ConnectedGetAsync(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Org.OpenAPITools.Client.ApiResponse<BoolResponse> localVarResponse = await ConnectedGetWithHttpInfoAsync(deviceNumber, clientID, clientTransactionID, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves the connected state of the device Retrieves the connected state of the device
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (BoolResponse)</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<BoolResponse>> ConnectedGetWithHttpInfoAsync(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'DeviceType' is set
            if (DeviceType == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'DeviceType' when calling ASCOMMethodsCommonToAllDevicesApi->ConnectedGet");


            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("device_type", Org.OpenAPITools.Client.ClientUtils.ParameterToString(DeviceType)); // path parameter
            localVarRequestOptions.PathParameters.Add("device_number", Org.OpenAPITools.Client.ClientUtils.ParameterToString(deviceNumber)); // path parameter
            if (clientID != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "ClientID", clientID));
            }
            if (clientTransactionID != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "ClientTransactionID", clientTransactionID));
            }


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<BoolResponse>("/{device_type}/{device_number}/connected", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConnectedGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Sets the connected state of the device Sets the connected state of the device
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="connected">Set True to connect to the device hardware, set False to disconnect from the device hardware</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional)</param>
        /// <returns>Response</returns>
        public Response ConnectedPut(int deviceNumber, bool connected, int? clientID = default(int?), int? clientTransactionID = default(int?))
        {
            Org.OpenAPITools.Client.ApiResponse<Response> localVarResponse = ConnectedPutWithHttpInfo(deviceNumber, connected, clientID, clientTransactionID);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Sets the connected state of the device Sets the connected state of the device
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="connected">Set True to connect to the device hardware, set False to disconnect from the device hardware</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional)</param>
        /// <returns>ApiResponse of Response</returns>
        public Org.OpenAPITools.Client.ApiResponse<Response> ConnectedPutWithHttpInfo(int deviceNumber, bool connected, int? clientID = default(int?), int? clientTransactionID = default(int?))
        {
            // verify the required parameter 'DeviceType' is set
            if (DeviceType == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'DeviceType' when calling ASCOMMethodsCommonToAllDevicesApi->ConnectedPut");

            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/x-www-form-urlencoded"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("device_type", Org.OpenAPITools.Client.ClientUtils.ParameterToString(DeviceType)); // path parameter
            localVarRequestOptions.PathParameters.Add("device_number", Org.OpenAPITools.Client.ClientUtils.ParameterToString(deviceNumber)); // path parameter
            localVarRequestOptions.FormParameters.Add("Connected", Org.OpenAPITools.Client.ClientUtils.ParameterToString(connected)); // form parameter
            if (clientID != null)
            {
                localVarRequestOptions.FormParameters.Add("ClientID", Org.OpenAPITools.Client.ClientUtils.ParameterToString(clientID)); // form parameter
            }
            if (clientTransactionID != null)
            {
                localVarRequestOptions.FormParameters.Add("ClientTransactionID", Org.OpenAPITools.Client.ClientUtils.ParameterToString(clientTransactionID)); // form parameter
            }


            // make the HTTP request
            var localVarResponse = this.Client.Put<Response>("/{device_type}/{device_number}/connected", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConnectedPut", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Sets the connected state of the device Sets the connected state of the device
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="connected">Set True to connect to the device hardware, set False to disconnect from the device hardware</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Response</returns>
        public async System.Threading.Tasks.Task<Response> ConnectedPutAsync(int deviceNumber, bool connected, int? clientID = default(int?), int? clientTransactionID = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Org.OpenAPITools.Client.ApiResponse<Response> localVarResponse = await ConnectedPutWithHttpInfoAsync(deviceNumber, connected, clientID, clientTransactionID, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Sets the connected state of the device Sets the connected state of the device
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="connected">Set True to connect to the device hardware, set False to disconnect from the device hardware</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Response)</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<Response>> ConnectedPutWithHttpInfoAsync(int deviceNumber, bool connected, int? clientID = default(int?), int? clientTransactionID = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'DeviceType' is set
            if (DeviceType == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'DeviceType' when calling ASCOMMethodsCommonToAllDevicesApi->ConnectedPut");


            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/x-www-form-urlencoded"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("device_type", Org.OpenAPITools.Client.ClientUtils.ParameterToString(DeviceType)); // path parameter
            localVarRequestOptions.PathParameters.Add("device_number", Org.OpenAPITools.Client.ClientUtils.ParameterToString(deviceNumber)); // path parameter
            localVarRequestOptions.FormParameters.Add("Connected", Org.OpenAPITools.Client.ClientUtils.ParameterToString(connected)); // form parameter
            if (clientID != null)
            {
                localVarRequestOptions.FormParameters.Add("ClientID", Org.OpenAPITools.Client.ClientUtils.ParameterToString(clientID)); // form parameter
            }
            if (clientTransactionID != null)
            {
                localVarRequestOptions.FormParameters.Add("ClientTransactionID", Org.OpenAPITools.Client.ClientUtils.ParameterToString(clientTransactionID)); // form parameter
            }


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<Response>("/{device_type}/{device_number}/connected", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConnectedPut", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Device description The description of the device
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <returns>StringResponse</returns>
        public StringResponse DescriptionGet(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?))
        {
            Org.OpenAPITools.Client.ApiResponse<StringResponse> localVarResponse = DescriptionGetWithHttpInfo(deviceNumber, clientID, clientTransactionID);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Device description The description of the device
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <returns>ApiResponse of StringResponse</returns>
        public Org.OpenAPITools.Client.ApiResponse<StringResponse> DescriptionGetWithHttpInfo(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?))
        {
            // verify the required parameter 'DeviceType' is set
            if (DeviceType == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'DeviceType' when calling ASCOMMethodsCommonToAllDevicesApi->DescriptionGet");

            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("device_type", Org.OpenAPITools.Client.ClientUtils.ParameterToString(DeviceType)); // path parameter
            localVarRequestOptions.PathParameters.Add("device_number", Org.OpenAPITools.Client.ClientUtils.ParameterToString(deviceNumber)); // path parameter
            if (clientID != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "ClientID", clientID));
            }
            if (clientTransactionID != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "ClientTransactionID", clientTransactionID));
            }


            // make the HTTP request
            var localVarResponse = this.Client.Get<StringResponse>("/{device_type}/{device_number}/description", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DescriptionGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Device description The description of the device
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of StringResponse</returns>
        public async System.Threading.Tasks.Task<StringResponse> DescriptionGetAsync(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Org.OpenAPITools.Client.ApiResponse<StringResponse> localVarResponse = await DescriptionGetWithHttpInfoAsync(deviceNumber, clientID, clientTransactionID, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Device description The description of the device
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (StringResponse)</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<StringResponse>> DescriptionGetWithHttpInfoAsync(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'DeviceType' is set
            if (DeviceType == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'DeviceType' when calling ASCOMMethodsCommonToAllDevicesApi->DescriptionGet");


            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("device_type", Org.OpenAPITools.Client.ClientUtils.ParameterToString(DeviceType)); // path parameter
            localVarRequestOptions.PathParameters.Add("device_number", Org.OpenAPITools.Client.ClientUtils.ParameterToString(deviceNumber)); // path parameter
            if (clientID != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "ClientID", clientID));
            }
            if (clientTransactionID != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "ClientTransactionID", clientTransactionID));
            }


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<StringResponse>("/{device_type}/{device_number}/description", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DescriptionGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Device driver description The description of the driver
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <returns>StringResponse</returns>
        public StringResponse DriverInfoGet(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?))
        {
            Org.OpenAPITools.Client.ApiResponse<StringResponse> localVarResponse = DriverInfoGetWithHttpInfo(deviceNumber, clientID, clientTransactionID);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Device driver description The description of the driver
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <returns>ApiResponse of StringResponse</returns>
        public Org.OpenAPITools.Client.ApiResponse<StringResponse> DriverInfoGetWithHttpInfo(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?))
        {
            // verify the required parameter 'DeviceType' is set
            if (DeviceType == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'DeviceType' when calling ASCOMMethodsCommonToAllDevicesApi->DriverInfoGet");

            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("device_type", Org.OpenAPITools.Client.ClientUtils.ParameterToString(DeviceType)); // path parameter
            localVarRequestOptions.PathParameters.Add("device_number", Org.OpenAPITools.Client.ClientUtils.ParameterToString(deviceNumber)); // path parameter
            if (clientID != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "ClientID", clientID));
            }
            if (clientTransactionID != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "ClientTransactionID", clientTransactionID));
            }


            // make the HTTP request
            var localVarResponse = this.Client.Get<StringResponse>("/{device_type}/{device_number}/DriverInfo", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DriverInfoGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Device driver description The description of the driver
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of StringResponse</returns>
        public async System.Threading.Tasks.Task<StringResponse> DriverInfoGetAsync(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Org.OpenAPITools.Client.ApiResponse<StringResponse> localVarResponse = await DriverInfoGetWithHttpInfoAsync(deviceNumber, clientID, clientTransactionID, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Device driver description The description of the driver
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (StringResponse)</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<StringResponse>> DriverInfoGetWithHttpInfoAsync(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'DeviceType' is set
            if (DeviceType == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'DeviceType' when calling ASCOMMethodsCommonToAllDevicesApi->DriverInfoGet");


            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("device_type", Org.OpenAPITools.Client.ClientUtils.ParameterToString(DeviceType)); // path parameter
            localVarRequestOptions.PathParameters.Add("device_number", Org.OpenAPITools.Client.ClientUtils.ParameterToString(deviceNumber)); // path parameter
            if (clientID != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "ClientID", clientID));
            }
            if (clientTransactionID != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "ClientTransactionID", clientTransactionID));
            }


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<StringResponse>("/{device_type}/{device_number}/DriverInfo", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DriverInfoGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Driver Version A string containing only the major and minor version of the driver.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <returns>StringResponse</returns>
        public StringResponse DriverVersionGet(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?))
        {
            Org.OpenAPITools.Client.ApiResponse<StringResponse> localVarResponse = DriverVersionGetWithHttpInfo(deviceNumber, clientID, clientTransactionID);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Driver Version A string containing only the major and minor version of the driver.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <returns>ApiResponse of StringResponse</returns>
        public Org.OpenAPITools.Client.ApiResponse<StringResponse> DriverVersionGetWithHttpInfo(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?))
        {
            // verify the required parameter 'DeviceType' is set
            if (DeviceType == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'DeviceType' when calling ASCOMMethodsCommonToAllDevicesApi->DriverVersionGet");

            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("device_type", Org.OpenAPITools.Client.ClientUtils.ParameterToString(DeviceType)); // path parameter
            localVarRequestOptions.PathParameters.Add("device_number", Org.OpenAPITools.Client.ClientUtils.ParameterToString(deviceNumber)); // path parameter
            if (clientID != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "ClientID", clientID));
            }
            if (clientTransactionID != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "ClientTransactionID", clientTransactionID));
            }


            // make the HTTP request
            var localVarResponse = this.Client.Get<StringResponse>("/{device_type}/{device_number}/DriverVersion", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DriverVersionGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Driver Version A string containing only the major and minor version of the driver.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of StringResponse</returns>
        public async System.Threading.Tasks.Task<StringResponse> DriverVersionGetAsync(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Org.OpenAPITools.Client.ApiResponse<StringResponse> localVarResponse = await DriverVersionGetWithHttpInfoAsync(deviceNumber, clientID, clientTransactionID, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Driver Version A string containing only the major and minor version of the driver.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (StringResponse)</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<StringResponse>> DriverVersionGetWithHttpInfoAsync(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'DeviceType' is set
            if (DeviceType == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'DeviceType' when calling ASCOMMethodsCommonToAllDevicesApi->DriverVersionGet");


            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("device_type", Org.OpenAPITools.Client.ClientUtils.ParameterToString(DeviceType)); // path parameter
            localVarRequestOptions.PathParameters.Add("device_number", Org.OpenAPITools.Client.ClientUtils.ParameterToString(deviceNumber)); // path parameter
            if (clientID != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "ClientID", clientID));
            }
            if (clientTransactionID != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "ClientTransactionID", clientTransactionID));
            }


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<StringResponse>("/{device_type}/{device_number}/DriverVersion", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DriverVersionGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// The ASCOM Device interface version number that this device supports. This method returns the version of the ASCOM device interface contract to which this device complies. Only one interface version is current at a moment in time and all new devices should be built to the latest interface version. Applications can choose which device interface versions they support and it is in their interest to support  previous versions as well as the current version to ensure thay can use the largest number of devices.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <returns>IntResponse</returns>
        public IntResponse InterfaceVersionGet(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?))
        {
            Org.OpenAPITools.Client.ApiResponse<IntResponse> localVarResponse = InterfaceVersionGetWithHttpInfo(deviceNumber, clientID, clientTransactionID);
            return localVarResponse.Data;
        }

        /// <summary>
        /// The ASCOM Device interface version number that this device supports. This method returns the version of the ASCOM device interface contract to which this device complies. Only one interface version is current at a moment in time and all new devices should be built to the latest interface version. Applications can choose which device interface versions they support and it is in their interest to support  previous versions as well as the current version to ensure thay can use the largest number of devices.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <returns>ApiResponse of IntResponse</returns>
        public Org.OpenAPITools.Client.ApiResponse<IntResponse> InterfaceVersionGetWithHttpInfo(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?))
        {
            // verify the required parameter 'DeviceType' is set
            if (DeviceType == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'DeviceType' when calling ASCOMMethodsCommonToAllDevicesApi->InterfaceVersionGet");

            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("device_type", Org.OpenAPITools.Client.ClientUtils.ParameterToString(DeviceType)); // path parameter
            localVarRequestOptions.PathParameters.Add("device_number", Org.OpenAPITools.Client.ClientUtils.ParameterToString(deviceNumber)); // path parameter
            if (clientID != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "ClientID", clientID));
            }
            if (clientTransactionID != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "ClientTransactionID", clientTransactionID));
            }


            // make the HTTP request
            var localVarResponse = this.Client.Get<IntResponse>("/{device_type}/{device_number}/InterfaceVersion", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("InterfaceVersionGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// The ASCOM Device interface version number that this device supports. This method returns the version of the ASCOM device interface contract to which this device complies. Only one interface version is current at a moment in time and all new devices should be built to the latest interface version. Applications can choose which device interface versions they support and it is in their interest to support  previous versions as well as the current version to ensure thay can use the largest number of devices.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of IntResponse</returns>
        public async System.Threading.Tasks.Task<IntResponse> InterfaceVersionGetAsync(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Org.OpenAPITools.Client.ApiResponse<IntResponse> localVarResponse = await InterfaceVersionGetWithHttpInfoAsync(deviceNumber, clientID, clientTransactionID, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// The ASCOM Device interface version number that this device supports. This method returns the version of the ASCOM device interface contract to which this device complies. Only one interface version is current at a moment in time and all new devices should be built to the latest interface version. Applications can choose which device interface versions they support and it is in their interest to support  previous versions as well as the current version to ensure thay can use the largest number of devices.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (IntResponse)</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<IntResponse>> InterfaceVersionGetWithHttpInfoAsync(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'DeviceType' is set
            if (DeviceType == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'DeviceType' when calling ASCOMMethodsCommonToAllDevicesApi->InterfaceVersionGet");


            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("device_type", Org.OpenAPITools.Client.ClientUtils.ParameterToString(DeviceType)); // path parameter
            localVarRequestOptions.PathParameters.Add("device_number", Org.OpenAPITools.Client.ClientUtils.ParameterToString(deviceNumber)); // path parameter
            if (clientID != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "ClientID", clientID));
            }
            if (clientTransactionID != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "ClientTransactionID", clientTransactionID));
            }


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<IntResponse>("/{device_type}/{device_number}/InterfaceVersion", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("InterfaceVersionGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Device name The name of the device
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <returns>StringResponse</returns>
        public StringResponse NameGet(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?))
        {
            Org.OpenAPITools.Client.ApiResponse<StringResponse> localVarResponse = NameGetWithHttpInfo(deviceNumber, clientID, clientTransactionID);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Device name The name of the device
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <returns>ApiResponse of StringResponse</returns>
        public Org.OpenAPITools.Client.ApiResponse<StringResponse> NameGetWithHttpInfo(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?))
        {
            // verify the required parameter 'DeviceType' is set
            if (DeviceType == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'DeviceType' when calling ASCOMMethodsCommonToAllDevicesApi->NameGet");

            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("device_type", Org.OpenAPITools.Client.ClientUtils.ParameterToString(DeviceType)); // path parameter
            localVarRequestOptions.PathParameters.Add("device_number", Org.OpenAPITools.Client.ClientUtils.ParameterToString(deviceNumber)); // path parameter
            if (clientID != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "ClientID", clientID));
            }
            if (clientTransactionID != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "ClientTransactionID", clientTransactionID));
            }


            // make the HTTP request
            var localVarResponse = this.Client.Get<StringResponse>("/{device_type}/{device_number}/name", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("NameGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Device name The name of the device
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of StringResponse</returns>
        public async System.Threading.Tasks.Task<StringResponse> NameGetAsync(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Org.OpenAPITools.Client.ApiResponse<StringResponse> localVarResponse = await NameGetWithHttpInfoAsync(deviceNumber, clientID, clientTransactionID, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Device name The name of the device
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (StringResponse)</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<StringResponse>> NameGetWithHttpInfoAsync(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'DeviceType' is set
            if (DeviceType == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'DeviceType' when calling ASCOMMethodsCommonToAllDevicesApi->NameGet");


            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("device_type", Org.OpenAPITools.Client.ClientUtils.ParameterToString(DeviceType)); // path parameter
            localVarRequestOptions.PathParameters.Add("device_number", Org.OpenAPITools.Client.ClientUtils.ParameterToString(deviceNumber)); // path parameter
            if (clientID != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "ClientID", clientID));
            }
            if (clientTransactionID != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "ClientTransactionID", clientTransactionID));
            }


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<StringResponse>("/{device_type}/{device_number}/name", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("NameGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Returns the list of action names supported by this driver. Returns the list of action names supported by this driver.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <returns>StringListResponse</returns>
        public StringListResponse SupportedActionsGet(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?))
        {
            Org.OpenAPITools.Client.ApiResponse<StringListResponse> localVarResponse = SupportedActionsGetWithHttpInfo( deviceNumber, clientID, clientTransactionID);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Returns the list of action names supported by this driver. Returns the list of action names supported by this driver.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <returns>ApiResponse of StringListResponse</returns>
        public Org.OpenAPITools.Client.ApiResponse<StringListResponse> SupportedActionsGetWithHttpInfo(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?))
        {
            // verify the required parameter 'DeviceType' is set
            if (DeviceType == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'DeviceType' when calling ASCOMMethodsCommonToAllDevicesApi->SupportedActionsGet");

            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("device_type", Org.OpenAPITools.Client.ClientUtils.ParameterToString(DeviceType)); // path parameter
            localVarRequestOptions.PathParameters.Add("device_number", Org.OpenAPITools.Client.ClientUtils.ParameterToString(deviceNumber)); // path parameter
            if (clientID != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "ClientID", clientID));
            }
            if (clientTransactionID != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "ClientTransactionID", clientTransactionID));
            }


            // make the HTTP request
            var localVarResponse = this.Client.Get<StringListResponse>("/{device_type}/{device_number}/SupportedActions", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SupportedActionsGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Returns the list of action names supported by this driver. Returns the list of action names supported by this driver.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of StringListResponse</returns>
        public async System.Threading.Tasks.Task<StringListResponse> SupportedActionsGetAsync(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Org.OpenAPITools.Client.ApiResponse<StringListResponse> localVarResponse = await SupportedActionsGetWithHttpInfoAsync(deviceNumber, clientID, clientTransactionID, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Returns the list of action names supported by this driver. Returns the list of action names supported by this driver.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (StringListResponse)</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<StringListResponse>> SupportedActionsGetWithHttpInfoAsync(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'DeviceType' is set
            if (DeviceType == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'DeviceType' when calling ASCOMMethodsCommonToAllDevicesApi->SupportedActionsGet");


            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("device_type", Org.OpenAPITools.Client.ClientUtils.ParameterToString(DeviceType)); // path parameter
            localVarRequestOptions.PathParameters.Add("device_number", Org.OpenAPITools.Client.ClientUtils.ParameterToString(deviceNumber)); // path parameter
            if (clientID != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "ClientID", clientID));
            }
            if (clientTransactionID != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "ClientTransactionID", clientTransactionID));
            }


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<StringListResponse>("/{device_type}/{device_number}/SupportedActions", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SupportedActionsGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }
    }
}
