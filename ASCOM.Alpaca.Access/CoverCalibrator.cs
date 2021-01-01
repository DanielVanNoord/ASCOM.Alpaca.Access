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
    public interface ICoverCalibratorSpecificMethodsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Returns the current calibrator brightness
        /// </summary>
        /// <remarks>
        /// Returns the current calibrator brightness in the range 0 (completely off) to MaxBrightness (fully on)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <returns>IntResponse</returns>
        IntResponse BrightnessGet(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?));

        /// <summary>
        /// Returns the current calibrator brightness
        /// </summary>
        /// <remarks>
        /// Returns the current calibrator brightness in the range 0 (completely off) to MaxBrightness (fully on)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <returns>ApiResponse of IntResponse</returns>
        ApiResponse<IntResponse> BrightnessGetWithHttpInfo(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?));
        /// <summary>
        /// Turns the calibrator off
        /// </summary>
        /// <remarks>
        /// Turns the calibrator off if the device has calibration capability.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="UNKNOWN_BASE_TYPE"> (optional)</param>
        /// <returns>Response</returns>
        Response CalibratorOffPut(int deviceNumber, Payload payload);

        /// <summary>
        /// Turns the calibrator off
        /// </summary>
        /// <remarks>
        /// Turns the calibrator off if the device has calibration capability.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="UNKNOWN_BASE_TYPE"> (optional)</param>
        /// <returns>ApiResponse of Response</returns>
        ApiResponse<Response> CalibratorOffPutWithHttpInfo(int deviceNumber, Payload payload);
        /// <summary>
        /// Turns the calibrator on at the specified brightness
        /// </summary>
        /// <remarks>
        /// Turns the calibrator on at the specified brightness if the device has calibration capability.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="brightness">The required brightness in the range 0 to MaxBrightness (optional)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional)</param>
        /// <returns>Response</returns>
        Response CalibratorOnPut(int deviceNumber, int? brightness = default(int?), int? clientID = default(int?), int? clientTransactionID = default(int?));

        /// <summary>
        /// Turns the calibrator on at the specified brightness
        /// </summary>
        /// <remarks>
        /// Turns the calibrator on at the specified brightness if the device has calibration capability.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="brightness">The required brightness in the range 0 to MaxBrightness (optional)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional)</param>
        /// <returns>ApiResponse of Response</returns>
        ApiResponse<Response> CalibratorOnPutWithHttpInfo(int deviceNumber, int? brightness = default(int?), int? clientID = default(int?), int? clientTransactionID = default(int?));
        /// <summary>
        /// Returns the state of the calibration device
        /// </summary>
        /// <remarks>
        /// Returns the state of the calibration device, if present, otherwise returns \&quot;NotPresent\&quot;.  The calibrator state mode is specified as an integer value from the CalibratorStatus Enum.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <returns>IntResponse</returns>
        IntResponse CalibratorStateGet(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?));

        /// <summary>
        /// Returns the state of the calibration device
        /// </summary>
        /// <remarks>
        /// Returns the state of the calibration device, if present, otherwise returns \&quot;NotPresent\&quot;.  The calibrator state mode is specified as an integer value from the CalibratorStatus Enum.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <returns>ApiResponse of IntResponse</returns>
        ApiResponse<IntResponse> CalibratorStateGetWithHttpInfo(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?));
        /// <summary>
        /// Initiates cover closing
        /// </summary>
        /// <remarks>
        /// Initiates cover closing if a cover is present.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="UNKNOWN_BASE_TYPE"> (optional)</param>
        /// <returns>Response</returns>
        Response CloseCoverPut(int deviceNumber, Payload payload);

        /// <summary>
        /// Initiates cover closing
        /// </summary>
        /// <remarks>
        /// Initiates cover closing if a cover is present.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="UNKNOWN_BASE_TYPE"> (optional)</param>
        /// <returns>ApiResponse of Response</returns>
        ApiResponse<Response> CloseCoverPutWithHttpInfo(int deviceNumber, Payload payload);
        /// <summary>
        /// Returns the state of the device cover\&quot;
        /// </summary>
        /// <remarks>
        /// Returns the state of the device cover, if present, otherwise returns \&quot;NotPresent\&quot;.  The cover state mode is specified as an integer value from the CoverStatus Enum.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <returns>IntResponse</returns>
        IntResponse CoverStateGet(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?));

        /// <summary>
        /// Returns the state of the device cover\&quot;
        /// </summary>
        /// <remarks>
        /// Returns the state of the device cover, if present, otherwise returns \&quot;NotPresent\&quot;.  The cover state mode is specified as an integer value from the CoverStatus Enum.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <returns>ApiResponse of IntResponse</returns>
        ApiResponse<IntResponse> CoverStateGetWithHttpInfo(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?));
        /// <summary>
        /// Stops any cover movement that may be in progress
        /// </summary>
        /// <remarks>
        /// Stops any cover movement that may be in progress if a cover is present and cover movement can be interrupted.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="UNKNOWN_BASE_TYPE"> (optional)</param>
        /// <returns>Response</returns>
        Response HaltcoverPut(int deviceNumber, Payload payload);

        /// <summary>
        /// Stops any cover movement that may be in progress
        /// </summary>
        /// <remarks>
        /// Stops any cover movement that may be in progress if a cover is present and cover movement can be interrupted.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="UNKNOWN_BASE_TYPE"> (optional)</param>
        /// <returns>ApiResponse of Response</returns>
        ApiResponse<Response> HaltcoverPutWithHttpInfo(int deviceNumber, Payload payload);
        /// <summary>
        /// Returns the calibrator&#39;s maximum Brightness value.
        /// </summary>
        /// <remarks>
        /// The Brightness value that makes the calibrator deliver its maximum illumination.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <returns>IntResponse</returns>
        IntResponse MaxbrightnessGet(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?));

        /// <summary>
        /// Returns the calibrator&#39;s maximum Brightness value.
        /// </summary>
        /// <remarks>
        /// The Brightness value that makes the calibrator deliver its maximum illumination.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <returns>ApiResponse of IntResponse</returns>
        ApiResponse<IntResponse> MaxbrightnessGetWithHttpInfo(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?));
        /// <summary>
        /// Initiates cover opening
        /// </summary>
        /// <remarks>
        /// Initiates cover opening if a cover is present.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="UNKNOWN_BASE_TYPE"> (optional)</param>
        /// <returns>Response</returns>
        Response OpencoverPut(int deviceNumber, Payload payload);

        /// <summary>
        /// Initiates cover opening
        /// </summary>
        /// <remarks>
        /// Initiates cover opening if a cover is present.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="UNKNOWN_BASE_TYPE"> (optional)</param>
        /// <returns>ApiResponse of Response</returns>
        ApiResponse<Response> OpencoverPutWithHttpInfo(int deviceNumber, Payload payload);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICoverCalibratorSpecificMethodsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Returns the current calibrator brightness
        /// </summary>
        /// <remarks>
        /// Returns the current calibrator brightness in the range 0 (completely off) to MaxBrightness (fully on)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of IntResponse</returns>
        System.Threading.Tasks.Task<IntResponse> BrightnessGetAsync(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Returns the current calibrator brightness
        /// </summary>
        /// <remarks>
        /// Returns the current calibrator brightness in the range 0 (completely off) to MaxBrightness (fully on)
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (IntResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<IntResponse>> BrightnessGetWithHttpInfoAsync(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Turns the calibrator off
        /// </summary>
        /// <remarks>
        /// Turns the calibrator off if the device has calibration capability.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="UNKNOWN_BASE_TYPE"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Response</returns>
        System.Threading.Tasks.Task<Response> CalibratorOffPutAsync(int deviceNumber, Payload payload, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Turns the calibrator off
        /// </summary>
        /// <remarks>
        /// Turns the calibrator off if the device has calibration capability.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="UNKNOWN_BASE_TYPE"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<Response>> CalibratorOffPutWithHttpInfoAsync(int deviceNumber, Payload payload, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Turns the calibrator on at the specified brightness
        /// </summary>
        /// <remarks>
        /// Turns the calibrator on at the specified brightness if the device has calibration capability.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="brightness">The required brightness in the range 0 to MaxBrightness (optional)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Response</returns>
        System.Threading.Tasks.Task<Response> CalibratorOnPutAsync(int deviceNumber, int? brightness = default(int?), int? clientID = default(int?), int? clientTransactionID = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Turns the calibrator on at the specified brightness
        /// </summary>
        /// <remarks>
        /// Turns the calibrator on at the specified brightness if the device has calibration capability.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="brightness">The required brightness in the range 0 to MaxBrightness (optional)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<Response>> CalibratorOnPutWithHttpInfoAsync(int deviceNumber, int? brightness = default(int?), int? clientID = default(int?), int? clientTransactionID = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Returns the state of the calibration device
        /// </summary>
        /// <remarks>
        /// Returns the state of the calibration device, if present, otherwise returns \&quot;NotPresent\&quot;.  The calibrator state mode is specified as an integer value from the CalibratorStatus Enum.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of IntResponse</returns>
        System.Threading.Tasks.Task<IntResponse> CalibratorStateGetAsync(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Returns the state of the calibration device
        /// </summary>
        /// <remarks>
        /// Returns the state of the calibration device, if present, otherwise returns \&quot;NotPresent\&quot;.  The calibrator state mode is specified as an integer value from the CalibratorStatus Enum.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (IntResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<IntResponse>> CalibratorStateGetWithHttpInfoAsync(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Initiates cover closing
        /// </summary>
        /// <remarks>
        /// Initiates cover closing if a cover is present.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="UNKNOWN_BASE_TYPE"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Response</returns>
        System.Threading.Tasks.Task<Response> CloseCoverPutAsync(int deviceNumber, Payload payload, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Initiates cover closing
        /// </summary>
        /// <remarks>
        /// Initiates cover closing if a cover is present.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="UNKNOWN_BASE_TYPE"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<Response>> CloseCoverPutWithHttpInfoAsync(int deviceNumber, Payload payload, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Returns the state of the device cover\&quot;
        /// </summary>
        /// <remarks>
        /// Returns the state of the device cover, if present, otherwise returns \&quot;NotPresent\&quot;.  The cover state mode is specified as an integer value from the CoverStatus Enum.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of IntResponse</returns>
        System.Threading.Tasks.Task<IntResponse> CoverStateGetAsync(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Returns the state of the device cover\&quot;
        /// </summary>
        /// <remarks>
        /// Returns the state of the device cover, if present, otherwise returns \&quot;NotPresent\&quot;.  The cover state mode is specified as an integer value from the CoverStatus Enum.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (IntResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<IntResponse>> CoverStateGetWithHttpInfoAsync(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Stops any cover movement that may be in progress
        /// </summary>
        /// <remarks>
        /// Stops any cover movement that may be in progress if a cover is present and cover movement can be interrupted.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="UNKNOWN_BASE_TYPE"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Response</returns>
        System.Threading.Tasks.Task<Response> HaltcoverPutAsync(int deviceNumber, Payload payload, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Stops any cover movement that may be in progress
        /// </summary>
        /// <remarks>
        /// Stops any cover movement that may be in progress if a cover is present and cover movement can be interrupted.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="UNKNOWN_BASE_TYPE"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<Response>> HaltcoverPutWithHttpInfoAsync(int deviceNumber, Payload payload, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Returns the calibrator&#39;s maximum Brightness value.
        /// </summary>
        /// <remarks>
        /// The Brightness value that makes the calibrator deliver its maximum illumination.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of IntResponse</returns>
        System.Threading.Tasks.Task<IntResponse> MaxbrightnessGetAsync(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Returns the calibrator&#39;s maximum Brightness value.
        /// </summary>
        /// <remarks>
        /// The Brightness value that makes the calibrator deliver its maximum illumination.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (IntResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<IntResponse>> MaxbrightnessGetWithHttpInfoAsync(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Initiates cover opening
        /// </summary>
        /// <remarks>
        /// Initiates cover opening if a cover is present.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="UNKNOWN_BASE_TYPE"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Response</returns>
        System.Threading.Tasks.Task<Response> OpencoverPutAsync(int deviceNumber, Payload payload, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Initiates cover opening
        /// </summary>
        /// <remarks>
        /// Initiates cover opening if a cover is present.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="UNKNOWN_BASE_TYPE"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<Response>> OpencoverPutWithHttpInfoAsync(int deviceNumber, Payload payload, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICoverCalibratorSpecificMethodsApi : ICoverCalibratorSpecificMethodsApiSync, ICoverCalibratorSpecificMethodsApiAsync
    {

    }

    public class CoverCalibrator : AlpacaBase, IAlpacaBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CoverCalibratorSpecificMethodsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CoverCalibrator() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CoverCalibratorSpecificMethodsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CoverCalibrator(string basePath) : base("covercalibrator", basePath)
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CoverCalibratorSpecificMethodsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CoverCalibrator(Org.OpenAPITools.Client.Configuration configuration) : base("covercalibrator", configuration)
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CoverCalibratorSpecificMethodsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public CoverCalibrator(Org.OpenAPITools.Client.ISynchronousClient client, Org.OpenAPITools.Client.IAsynchronousClient asyncClient, Org.OpenAPITools.Client.IReadableConfiguration configuration) : base("covercalibrator", client, asyncClient, configuration)
        {

        }

        /// <summary>
        /// Returns the current calibrator brightness Returns the current calibrator brightness in the range 0 (completely off) to MaxBrightness (fully on)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <returns>IntResponse</returns>
        public IntResponse BrightnessGet(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?))
        {
            Org.OpenAPITools.Client.ApiResponse<IntResponse> localVarResponse = BrightnessGetWithHttpInfo(deviceNumber, clientID, clientTransactionID);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Returns the current calibrator brightness Returns the current calibrator brightness in the range 0 (completely off) to MaxBrightness (fully on)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <returns>ApiResponse of IntResponse</returns>
        public Org.OpenAPITools.Client.ApiResponse<IntResponse> BrightnessGetWithHttpInfo(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?))
        {
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
            var localVarResponse = this.Client.Get<IntResponse>("/covercalibrator/{device_number}/brightness", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BrightnessGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Returns the current calibrator brightness Returns the current calibrator brightness in the range 0 (completely off) to MaxBrightness (fully on)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of IntResponse</returns>
        public async System.Threading.Tasks.Task<IntResponse> BrightnessGetAsync(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Org.OpenAPITools.Client.ApiResponse<IntResponse> localVarResponse = await BrightnessGetWithHttpInfoAsync(deviceNumber, clientID, clientTransactionID, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Returns the current calibrator brightness Returns the current calibrator brightness in the range 0 (completely off) to MaxBrightness (fully on)
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (IntResponse)</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<IntResponse>> BrightnessGetWithHttpInfoAsync(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

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

            var localVarResponse = await this.AsynchronousClient.GetAsync<IntResponse>("/covercalibrator/{device_number}/brightness", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("BrightnessGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Turns the calibrator off Turns the calibrator off if the device has calibration capability.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="UNKNOWN_BASE_TYPE"> (optional)</param>
        /// <returns>Response</returns>
        public Response CalibratorOffPut(int deviceNumber, Payload payload)
        {
            Org.OpenAPITools.Client.ApiResponse<Response> localVarResponse = CalibratorOffPutWithHttpInfo(deviceNumber, payload);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Turns the calibrator off Turns the calibrator off if the device has calibration capability.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="UNKNOWN_BASE_TYPE"> (optional)</param>
        /// <returns>ApiResponse of Response</returns>
        public Org.OpenAPITools.Client.ApiResponse<Response> CalibratorOffPutWithHttpInfo(int deviceNumber, Payload payload)
        {
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

            localVarRequestOptions.PathParameters.Add("device_number", Org.OpenAPITools.Client.ClientUtils.ParameterToString(deviceNumber)); // path parameter
            localVarRequestOptions.Data = payload;


            // make the HTTP request
            var localVarResponse = this.Client.Put<Response>("/covercalibrator/{device_number}/calibratorOff", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CalibratorOffPut", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Turns the calibrator off Turns the calibrator off if the device has calibration capability.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="UNKNOWN_BASE_TYPE"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Response</returns>
        public async System.Threading.Tasks.Task<Response> CalibratorOffPutAsync(int deviceNumber, Payload payload, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Org.OpenAPITools.Client.ApiResponse<Response> localVarResponse = await CalibratorOffPutWithHttpInfoAsync(deviceNumber, payload, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Turns the calibrator off Turns the calibrator off if the device has calibration capability.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="UNKNOWN_BASE_TYPE"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Response)</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<Response>> CalibratorOffPutWithHttpInfoAsync(int deviceNumber, Payload payload, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

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

            localVarRequestOptions.PathParameters.Add("device_number", Org.OpenAPITools.Client.ClientUtils.ParameterToString(deviceNumber)); // path parameter
            localVarRequestOptions.Data = payload;


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<Response>("/covercalibrator/{device_number}/calibratorOff", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CalibratorOffPut", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Turns the calibrator on at the specified brightness Turns the calibrator on at the specified brightness if the device has calibration capability.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="brightness">The required brightness in the range 0 to MaxBrightness (optional)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional)</param>
        /// <returns>Response</returns>
        public Response CalibratorOnPut(int deviceNumber, int? brightness = default(int?), int? clientID = default(int?), int? clientTransactionID = default(int?))
        {
            Org.OpenAPITools.Client.ApiResponse<Response> localVarResponse = CalibratorOnPutWithHttpInfo(deviceNumber, brightness, clientID, clientTransactionID);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Turns the calibrator on at the specified brightness Turns the calibrator on at the specified brightness if the device has calibration capability.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="brightness">The required brightness in the range 0 to MaxBrightness (optional)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional)</param>
        /// <returns>ApiResponse of Response</returns>
        public Org.OpenAPITools.Client.ApiResponse<Response> CalibratorOnPutWithHttpInfo(int deviceNumber, int? brightness = default(int?), int? clientID = default(int?), int? clientTransactionID = default(int?))
        {
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

            localVarRequestOptions.PathParameters.Add("device_number", Org.OpenAPITools.Client.ClientUtils.ParameterToString(deviceNumber)); // path parameter
            if (brightness != null)
            {
                localVarRequestOptions.FormParameters.Add("Brightness", Org.OpenAPITools.Client.ClientUtils.ParameterToString(brightness)); // form parameter
            }
            if (clientID != null)
            {
                localVarRequestOptions.FormParameters.Add("ClientID", Org.OpenAPITools.Client.ClientUtils.ParameterToString(clientID)); // form parameter
            }
            if (clientTransactionID != null)
            {
                localVarRequestOptions.FormParameters.Add("ClientTransactionID", Org.OpenAPITools.Client.ClientUtils.ParameterToString(clientTransactionID)); // form parameter
            }


            // make the HTTP request
            var localVarResponse = this.Client.Put<Response>("/covercalibrator/{device_number}/calibratoron", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CalibratorOnPut", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Turns the calibrator on at the specified brightness Turns the calibrator on at the specified brightness if the device has calibration capability.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="brightness">The required brightness in the range 0 to MaxBrightness (optional)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Response</returns>
        public async System.Threading.Tasks.Task<Response> CalibratorOnPutAsync(int deviceNumber, int? brightness = default(int?), int? clientID = default(int?), int? clientTransactionID = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Org.OpenAPITools.Client.ApiResponse<Response> localVarResponse = await CalibratorOnPutWithHttpInfoAsync(deviceNumber, brightness, clientID, clientTransactionID, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Turns the calibrator on at the specified brightness Turns the calibrator on at the specified brightness if the device has calibration capability.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="brightness">The required brightness in the range 0 to MaxBrightness (optional)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Response)</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<Response>> CalibratorOnPutWithHttpInfoAsync(int deviceNumber, int? brightness = default(int?), int? clientID = default(int?), int? clientTransactionID = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

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

            localVarRequestOptions.PathParameters.Add("device_number", Org.OpenAPITools.Client.ClientUtils.ParameterToString(deviceNumber)); // path parameter
            if (brightness != null)
            {
                localVarRequestOptions.FormParameters.Add("Brightness", Org.OpenAPITools.Client.ClientUtils.ParameterToString(brightness)); // form parameter
            }
            if (clientID != null)
            {
                localVarRequestOptions.FormParameters.Add("ClientID", Org.OpenAPITools.Client.ClientUtils.ParameterToString(clientID)); // form parameter
            }
            if (clientTransactionID != null)
            {
                localVarRequestOptions.FormParameters.Add("ClientTransactionID", Org.OpenAPITools.Client.ClientUtils.ParameterToString(clientTransactionID)); // form parameter
            }


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<Response>("/covercalibrator/{device_number}/calibratoron", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CalibratorOnPut", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Returns the state of the calibration device Returns the state of the calibration device, if present, otherwise returns \&quot;NotPresent\&quot;.  The calibrator state mode is specified as an integer value from the CalibratorStatus Enum.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <returns>IntResponse</returns>
        public IntResponse CalibratorStateGet(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?))
        {
            Org.OpenAPITools.Client.ApiResponse<IntResponse> localVarResponse = CalibratorStateGetWithHttpInfo(deviceNumber, clientID, clientTransactionID);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Returns the state of the calibration device Returns the state of the calibration device, if present, otherwise returns \&quot;NotPresent\&quot;.  The calibrator state mode is specified as an integer value from the CalibratorStatus Enum.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <returns>ApiResponse of IntResponse</returns>
        public Org.OpenAPITools.Client.ApiResponse<IntResponse> CalibratorStateGetWithHttpInfo(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?))
        {
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
            var localVarResponse = this.Client.Get<IntResponse>("/covercalibrator/{device_number}/calibratorState", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CalibratorStateGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Returns the state of the calibration device Returns the state of the calibration device, if present, otherwise returns \&quot;NotPresent\&quot;.  The calibrator state mode is specified as an integer value from the CalibratorStatus Enum.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of IntResponse</returns>
        public async System.Threading.Tasks.Task<IntResponse> CalibratorStateGetAsync(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Org.OpenAPITools.Client.ApiResponse<IntResponse> localVarResponse = await CalibratorStateGetWithHttpInfoAsync(deviceNumber, clientID, clientTransactionID, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Returns the state of the calibration device Returns the state of the calibration device, if present, otherwise returns \&quot;NotPresent\&quot;.  The calibrator state mode is specified as an integer value from the CalibratorStatus Enum.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (IntResponse)</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<IntResponse>> CalibratorStateGetWithHttpInfoAsync(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

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

            var localVarResponse = await this.AsynchronousClient.GetAsync<IntResponse>("/covercalibrator/{device_number}/calibratorState", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CalibratorStateGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Initiates cover closing Initiates cover closing if a cover is present.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="UNKNOWN_BASE_TYPE"> (optional)</param>
        /// <returns>Response</returns>
        public Response CloseCoverPut(int deviceNumber, Payload payload)
        {
            Org.OpenAPITools.Client.ApiResponse<Response> localVarResponse = CloseCoverPutWithHttpInfo(deviceNumber, payload);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Initiates cover closing Initiates cover closing if a cover is present.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="UNKNOWN_BASE_TYPE"> (optional)</param>
        /// <returns>ApiResponse of Response</returns>
        public Org.OpenAPITools.Client.ApiResponse<Response> CloseCoverPutWithHttpInfo(int deviceNumber, Payload payload)
        {
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

            localVarRequestOptions.PathParameters.Add("device_number", Org.OpenAPITools.Client.ClientUtils.ParameterToString(deviceNumber)); // path parameter
            localVarRequestOptions.Data = payload;


            // make the HTTP request
            var localVarResponse = this.Client.Put<Response>("/covercalibrator/{device_number}/closecover", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CloseCoverPut", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Initiates cover closing Initiates cover closing if a cover is present.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="UNKNOWN_BASE_TYPE"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Response</returns>
        public async System.Threading.Tasks.Task<Response> CloseCoverPutAsync(int deviceNumber, Payload payload, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Org.OpenAPITools.Client.ApiResponse<Response> localVarResponse = await CloseCoverPutWithHttpInfoAsync(deviceNumber, payload, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Initiates cover closing Initiates cover closing if a cover is present.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="UNKNOWN_BASE_TYPE"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Response)</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<Response>> CloseCoverPutWithHttpInfoAsync(int deviceNumber, Payload payload, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

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

            localVarRequestOptions.PathParameters.Add("device_number", Org.OpenAPITools.Client.ClientUtils.ParameterToString(deviceNumber)); // path parameter
            localVarRequestOptions.Data = payload;


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<Response>("/covercalibrator/{device_number}/closecover", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CloseCoverPut", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Returns the state of the device cover\&quot; Returns the state of the device cover, if present, otherwise returns \&quot;NotPresent\&quot;.  The cover state mode is specified as an integer value from the CoverStatus Enum.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <returns>IntResponse</returns>
        public IntResponse CoverStateGet(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?))
        {
            Org.OpenAPITools.Client.ApiResponse<IntResponse> localVarResponse = CoverStateGetWithHttpInfo(deviceNumber, clientID, clientTransactionID);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Returns the state of the device cover\&quot; Returns the state of the device cover, if present, otherwise returns \&quot;NotPresent\&quot;.  The cover state mode is specified as an integer value from the CoverStatus Enum.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <returns>ApiResponse of IntResponse</returns>
        public Org.OpenAPITools.Client.ApiResponse<IntResponse> CoverStateGetWithHttpInfo(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?))
        {
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
            var localVarResponse = this.Client.Get<IntResponse>("/covercalibrator/{device_number}/coverState", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CoverStateGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Returns the state of the device cover\&quot; Returns the state of the device cover, if present, otherwise returns \&quot;NotPresent\&quot;.  The cover state mode is specified as an integer value from the CoverStatus Enum.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of IntResponse</returns>
        public async System.Threading.Tasks.Task<IntResponse> CoverStateGetAsync(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Org.OpenAPITools.Client.ApiResponse<IntResponse> localVarResponse = await CoverStateGetWithHttpInfoAsync(deviceNumber, clientID, clientTransactionID, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Returns the state of the device cover\&quot; Returns the state of the device cover, if present, otherwise returns \&quot;NotPresent\&quot;.  The cover state mode is specified as an integer value from the CoverStatus Enum.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (IntResponse)</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<IntResponse>> CoverStateGetWithHttpInfoAsync(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

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

            var localVarResponse = await this.AsynchronousClient.GetAsync<IntResponse>("/covercalibrator/{device_number}/coverState", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CoverStateGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Stops any cover movement that may be in progress Stops any cover movement that may be in progress if a cover is present and cover movement can be interrupted.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="UNKNOWN_BASE_TYPE"> (optional)</param>
        /// <returns>Response</returns>
        public Response HaltCoverPut(int deviceNumber, Payload payload)
        {
            Org.OpenAPITools.Client.ApiResponse<Response> localVarResponse = HaltcoverPutWithHttpInfo(deviceNumber, payload);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Stops any cover movement that may be in progress Stops any cover movement that may be in progress if a cover is present and cover movement can be interrupted.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="UNKNOWN_BASE_TYPE"> (optional)</param>
        /// <returns>ApiResponse of Response</returns>
        public Org.OpenAPITools.Client.ApiResponse<Response> HaltcoverPutWithHttpInfo(int deviceNumber, Payload payload)
        {
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

            localVarRequestOptions.PathParameters.Add("device_number", Org.OpenAPITools.Client.ClientUtils.ParameterToString(deviceNumber)); // path parameter
            localVarRequestOptions.Data = payload;


            // make the HTTP request
            var localVarResponse = this.Client.Put<Response>("/covercalibrator/{device_number}/haltcover", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HaltcoverPut", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Stops any cover movement that may be in progress Stops any cover movement that may be in progress if a cover is present and cover movement can be interrupted.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="UNKNOWN_BASE_TYPE"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Response</returns>
        public async System.Threading.Tasks.Task<Response> HaltcoverPutAsync(int deviceNumber, Payload payload, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Org.OpenAPITools.Client.ApiResponse<Response> localVarResponse = await HaltcoverPutWithHttpInfoAsync(deviceNumber, payload, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Stops any cover movement that may be in progress Stops any cover movement that may be in progress if a cover is present and cover movement can be interrupted.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="UNKNOWN_BASE_TYPE"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Response)</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<Response>> HaltcoverPutWithHttpInfoAsync(int deviceNumber, Payload payload, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

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

            localVarRequestOptions.PathParameters.Add("device_number", Org.OpenAPITools.Client.ClientUtils.ParameterToString(deviceNumber)); // path parameter
            localVarRequestOptions.Data = payload;


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<Response>("/covercalibrator/{device_number}/haltcover", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HaltcoverPut", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Returns the calibrator&#39;s maximum Brightness value. The Brightness value that makes the calibrator deliver its maximum illumination.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <returns>IntResponse</returns>
        public IntResponse MaxBrightnessGet(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?))
        {
            Org.OpenAPITools.Client.ApiResponse<IntResponse> localVarResponse = MaxbrightnessGetWithHttpInfo(deviceNumber, clientID, clientTransactionID);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Returns the calibrator&#39;s maximum Brightness value. The Brightness value that makes the calibrator deliver its maximum illumination.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <returns>ApiResponse of IntResponse</returns>
        public Org.OpenAPITools.Client.ApiResponse<IntResponse> MaxbrightnessGetWithHttpInfo(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?))
        {
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
            var localVarResponse = this.Client.Get<IntResponse>("/covercalibrator/{device_number}/maxbrightness", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("MaxbrightnessGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Returns the calibrator&#39;s maximum Brightness value. The Brightness value that makes the calibrator deliver its maximum illumination.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of IntResponse</returns>
        public async System.Threading.Tasks.Task<IntResponse> MaxbrightnessGetAsync(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Org.OpenAPITools.Client.ApiResponse<IntResponse> localVarResponse = await MaxbrightnessGetWithHttpInfoAsync(deviceNumber, clientID, clientTransactionID, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Returns the calibrator&#39;s maximum Brightness value. The Brightness value that makes the calibrator deliver its maximum illumination.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="clientID">Client&#39;s unique ID. (0 to 4294967295). The client should choose a value at start-up, e.g. a random value between 0 and 65535, and send this value on every transaction to help associate entries in device logs with this particular client. (optional, default to 1)</param>
        /// <param name="clientTransactionID">Client&#39;s transaction ID. (0 to 4294967295). The client should start this count at 1 and increment by one on each successive transaction. This will aid associating entries in device logs with corresponding entries in client side logs. (optional, default to 1234)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (IntResponse)</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<IntResponse>> MaxbrightnessGetWithHttpInfoAsync(int deviceNumber, int? clientID = default(int?), int? clientTransactionID = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

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

            var localVarResponse = await this.AsynchronousClient.GetAsync<IntResponse>("/covercalibrator/{device_number}/maxbrightness", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("MaxbrightnessGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Initiates cover opening Initiates cover opening if a cover is present.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="UNKNOWN_BASE_TYPE"> (optional)</param>
        /// <returns>Response</returns>
        public Response OpenCoverPut(int deviceNumber, Payload payload)
        {
            Org.OpenAPITools.Client.ApiResponse<Response> localVarResponse = OpencoverPutWithHttpInfo(deviceNumber, payload);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Initiates cover opening Initiates cover opening if a cover is present.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="UNKNOWN_BASE_TYPE"> (optional)</param>
        /// <returns>ApiResponse of Response</returns>
        public Org.OpenAPITools.Client.ApiResponse<Response> OpencoverPutWithHttpInfo(int deviceNumber, Payload payload)
        {
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

            localVarRequestOptions.PathParameters.Add("device_number", Org.OpenAPITools.Client.ClientUtils.ParameterToString(deviceNumber)); // path parameter
            localVarRequestOptions.Data = payload;


            // make the HTTP request
            var localVarResponse = this.Client.Put<Response>("/covercalibrator/{device_number}/opencover", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("OpencoverPut", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Initiates cover opening Initiates cover opening if a cover is present.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="UNKNOWN_BASE_TYPE"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Response</returns>
        public async System.Threading.Tasks.Task<Response> OpencoverPutAsync(int deviceNumber, Payload payload, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Org.OpenAPITools.Client.ApiResponse<Response> localVarResponse = await OpencoverPutWithHttpInfoAsync(deviceNumber, payload, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Initiates cover opening Initiates cover opening if a cover is present.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deviceNumber">Zero based device number as set on the server (0 to 4294967295)</param>
        /// <param name="UNKNOWN_BASE_TYPE"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Response)</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<Response>> OpencoverPutWithHttpInfoAsync(int deviceNumber, Payload payload, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

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

            localVarRequestOptions.PathParameters.Add("device_number", Org.OpenAPITools.Client.ClientUtils.ParameterToString(deviceNumber)); // path parameter
            localVarRequestOptions.Data = payload;


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<Response>("/covercalibrator/{device_number}/opencover", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("OpencoverPut", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }
    }
}
