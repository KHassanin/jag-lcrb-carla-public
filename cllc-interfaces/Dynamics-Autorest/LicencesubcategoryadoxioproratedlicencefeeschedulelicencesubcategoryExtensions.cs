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
    /// Extension methods for Licencesubcategoryadoxioproratedlicencefeeschedulelicencesubcategory.
    /// </summary>
    public static partial class LicencesubcategoryadoxioproratedlicencefeeschedulelicencesubcategoryExtensions
    {
            /// <summary>
            /// Get
            /// adoxio_licencesubcategory_adoxio_proratedlicencefeeschedule_LicenceSubCategory
            /// from adoxio_licencesubcategories
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioLicencesubcategoryid'>
            /// key: adoxio_licencesubcategoryid of adoxio_licencesubcategory
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
            public static MicrosoftDynamicsCRMadoxioProratedlicencefeescheduleCollection Get(this ILicencesubcategoryadoxioproratedlicencefeeschedulelicencesubcategory operations, string adoxioLicencesubcategoryid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetAsync(adoxioLicencesubcategoryid, top, skip, search, filter, count, orderby, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get
            /// adoxio_licencesubcategory_adoxio_proratedlicencefeeschedule_LicenceSubCategory
            /// from adoxio_licencesubcategories
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioLicencesubcategoryid'>
            /// key: adoxio_licencesubcategoryid of adoxio_licencesubcategory
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
            public static async Task<MicrosoftDynamicsCRMadoxioProratedlicencefeescheduleCollection> GetAsync(this ILicencesubcategoryadoxioproratedlicencefeeschedulelicencesubcategory operations, string adoxioLicencesubcategoryid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(adoxioLicencesubcategoryid, top, skip, search, filter, count, orderby, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get
            /// adoxio_licencesubcategory_adoxio_proratedlicencefeeschedule_LicenceSubCategory
            /// from adoxio_licencesubcategories
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioLicencesubcategoryid'>
            /// key: adoxio_licencesubcategoryid of adoxio_licencesubcategory
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMadoxioProratedlicencefeescheduleCollection> GetWithHttpMessages(this ILicencesubcategoryadoxioproratedlicencefeeschedulelicencesubcategory operations, string adoxioLicencesubcategoryid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.GetWithHttpMessagesAsync(adoxioLicencesubcategoryid, top, skip, search, filter, count, orderby, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get
            /// adoxio_licencesubcategory_adoxio_proratedlicencefeeschedule_LicenceSubCategory
            /// from adoxio_licencesubcategories
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioLicencesubcategoryid'>
            /// key: adoxio_licencesubcategoryid of adoxio_licencesubcategory
            /// </param>
            /// <param name='adoxioProratedlicencefeescheduleid'>
            /// key: adoxio_proratedlicencefeescheduleid of
            /// adoxio_proratedlicencefeeschedule
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMadoxioProratedlicencefeeschedule LicenceSubCategoryByKey(this ILicencesubcategoryadoxioproratedlicencefeeschedulelicencesubcategory operations, string adoxioLicencesubcategoryid, string adoxioProratedlicencefeescheduleid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.LicenceSubCategoryByKeyAsync(adoxioLicencesubcategoryid, adoxioProratedlicencefeescheduleid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get
            /// adoxio_licencesubcategory_adoxio_proratedlicencefeeschedule_LicenceSubCategory
            /// from adoxio_licencesubcategories
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioLicencesubcategoryid'>
            /// key: adoxio_licencesubcategoryid of adoxio_licencesubcategory
            /// </param>
            /// <param name='adoxioProratedlicencefeescheduleid'>
            /// key: adoxio_proratedlicencefeescheduleid of
            /// adoxio_proratedlicencefeeschedule
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
            public static async Task<MicrosoftDynamicsCRMadoxioProratedlicencefeeschedule> LicenceSubCategoryByKeyAsync(this ILicencesubcategoryadoxioproratedlicencefeeschedulelicencesubcategory operations, string adoxioLicencesubcategoryid, string adoxioProratedlicencefeescheduleid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.LicenceSubCategoryByKeyWithHttpMessagesAsync(adoxioLicencesubcategoryid, adoxioProratedlicencefeescheduleid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get
            /// adoxio_licencesubcategory_adoxio_proratedlicencefeeschedule_LicenceSubCategory
            /// from adoxio_licencesubcategories
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioLicencesubcategoryid'>
            /// key: adoxio_licencesubcategoryid of adoxio_licencesubcategory
            /// </param>
            /// <param name='adoxioProratedlicencefeescheduleid'>
            /// key: adoxio_proratedlicencefeescheduleid of
            /// adoxio_proratedlicencefeeschedule
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMadoxioProratedlicencefeeschedule> LicenceSubCategoryByKeyWithHttpMessages(this ILicencesubcategoryadoxioproratedlicencefeeschedulelicencesubcategory operations, string adoxioLicencesubcategoryid, string adoxioProratedlicencefeescheduleid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.LicenceSubCategoryByKeyWithHttpMessagesAsync(adoxioLicencesubcategoryid, adoxioProratedlicencefeescheduleid, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

    }
}