//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace AjunaExample.NetApiExt.Generated.Model.frame_system.pallet
{
    
    
    public enum Event
    {
        
        ExtrinsicSuccess = 0,
        
        ExtrinsicFailed = 1,
        
        CodeUpdated = 2,
        
        NewAccount = 3,
        
        KilledAccount = 4,
        
        Remarked = 5,
    }
    
    /// <summary>
    /// >> 18 - Variant[frame_system.pallet.Event]
    /// Event for the System pallet.
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, AjunaExample.NetApiExt.Generated.Model.frame_support.weights.DispatchInfo, BaseTuple<AjunaExample.NetApiExt.Generated.Model.sp_runtime.EnumDispatchError, AjunaExample.NetApiExt.Generated.Model.frame_support.weights.DispatchInfo>, BaseVoid, AjunaExample.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, AjunaExample.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, BaseTuple<AjunaExample.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, AjunaExample.NetApiExt.Generated.Model.primitive_types.H256>>
    {
    }
}