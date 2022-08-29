//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AjunaExample.RestClient.Mockup.Generated.Clients
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Ajuna.NetApi.Model.Types.Primitive;
   using AjunaExample.NetApiExt.Generated.Model.pallet_balances;
   using AjunaExample.NetApiExt.Generated.Model.sp_runtime.bounded.weak_bounded_vec;
   using AjunaExample.NetApiExt.Generated.Model.sp_runtime.bounded.bounded_vec;
   using AjunaExample.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class BalancesControllerMockupClient : MockupBaseClient, IBalancesControllerMockupClient
   {
      private HttpClient _httpClient;
      public BalancesControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetTotalIssuance(U128 value)
      {
         return await SendMockupRequestAsync(_httpClient, "Balances/TotalIssuance", value.Encode(), AjunaExample.NetApiExt.Generated.Storage.BalancesStorage.TotalIssuanceParams());
      }
      public async Task<bool> SetAccount(AccountData value, AjunaExample.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Balances/Account", value.Encode(), AjunaExample.NetApiExt.Generated.Storage.BalancesStorage.AccountParams(key));
      }
      public async Task<bool> SetLocks(WeakBoundedVecT2 value, AjunaExample.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Balances/Locks", value.Encode(), AjunaExample.NetApiExt.Generated.Storage.BalancesStorage.LocksParams(key));
      }
      public async Task<bool> SetReserves(BoundedVecT3 value, AjunaExample.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Balances/Reserves", value.Encode(), AjunaExample.NetApiExt.Generated.Storage.BalancesStorage.ReservesParams(key));
      }
      public async Task<bool> SetStorageVersion(EnumReleases value)
      {
         return await SendMockupRequestAsync(_httpClient, "Balances/StorageVersion", value.Encode(), AjunaExample.NetApiExt.Generated.Storage.BalancesStorage.StorageVersionParams());
      }
   }
}