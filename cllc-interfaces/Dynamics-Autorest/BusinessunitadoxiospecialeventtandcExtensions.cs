// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Businessunitadoxiospecialeventtandc.
    /// </summary>
    public static partial class BusinessunitadoxiospecialeventtandcExtensions
    {
            /// <summary>
            /// Get business_unit_adoxio_specialeventtandc from businessunits
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='businessunitid'>
            /// key: businessunitid of businessunit
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='skip'>
            /// </param>
            /// <param name='search'>
            /// </param>
            /// <param name='filter'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMadoxioSpecialeventtandcCollection Get(this IBusinessunitadoxiospecialeventtandc operations, string businessunitid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetAsync(businessunitid, top, skip, search, filter, count, orderby, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get business_unit_adoxio_specialeventtandc from businessunits
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='businessunitid'>
            /// key: businessunitid of businessunit
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='skip'>
            /// </param>
            /// <param name='search'>
            /// </param>
            /// <param name='filter'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MicrosoftDynamicsCRMadoxioSpecialeventtandcCollection> GetAsync(this IBusinessunitadoxiospecialeventtandc operations, string businessunitid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(businessunitid, top, skip, search, filter, count, orderby, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get business_unit_adoxio_specialeventtandc from businessunits
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='businessunitid'>
            /// key: businessunitid of businessunit
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='skip'>
            /// </param>
            /// <param name='search'>
            /// </param>
            /// <param name='filter'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse<MicrosoftDynamicsCRMadoxioSpecialeventtandcCollection> GetWithHttpMessages(this IBusinessunitadoxiospecialeventtandc operations, string businessunitid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.GetWithHttpMessagesAsync(businessunitid, top, skip, search, filter, count, orderby, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get business_unit_adoxio_specialeventtandc from businessunits
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='businessunitid'>
            /// key: businessunitid of businessunit
            /// </param>
            /// <param name='adoxioSpecialeventtandcid'>
            /// key: adoxio_specialeventtandcid of adoxio_specialeventtandc
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMadoxioSpecialeventtandc SpecialeventtandcByKey(this IBusinessunitadoxiospecialeventtandc operations, string businessunitid, string adoxioSpecialeventtandcid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.SpecialeventtandcByKeyAsync(businessunitid, adoxioSpecialeventtandcid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get business_unit_adoxio_specialeventtandc from businessunits
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='businessunitid'>
            /// key: businessunitid of businessunit
            /// </param>
            /// <param name='adoxioSpecialeventtandcid'>
            /// key: adoxio_specialeventtandcid of adoxio_specialeventtandc
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MicrosoftDynamicsCRMadoxioSpecialeventtandc> SpecialeventtandcByKeyAsync(this IBusinessunitadoxiospecialeventtandc operations, string businessunitid, string adoxioSpecialeventtandcid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.SpecialeventtandcByKeyWithHttpMessagesAsync(businessunitid, adoxioSpecialeventtandcid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get business_unit_adoxio_specialeventtandc from businessunits
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='businessunitid'>
            /// key: businessunitid of businessunit
            /// </param>
            /// <param name='adoxioSpecialeventtandcid'>
            /// key: adoxio_specialeventtandcid of adoxio_specialeventtandc
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse<MicrosoftDynamicsCRMadoxioSpecialeventtandc> SpecialeventtandcByKeyWithHttpMessages(this IBusinessunitadoxiospecialeventtandc operations, string businessunitid, string adoxioSpecialeventtandcid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.SpecialeventtandcByKeyWithHttpMessagesAsync(businessunitid, adoxioSpecialeventtandcid, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

    }
}
