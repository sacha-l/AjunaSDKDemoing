//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Model.Types.Base;
using Ajuna.NetApi.Model.Types.Primitive;
using SubstrateNET.NetApi.Generated.Model.PalletConvictionVoting;
using System.Collections.Generic;


namespace SubstrateNET.NetApi.Generated.Model.PalletConvictionVoting
{
    
    
    public enum AccountVote
    {
        
        Standard,
        
        Split,
    }
    
    /// <summary>
    /// >> 359 - Variant[pallet_conviction_voting.vote.AccountVote]
    /// </summary>
    public sealed class EnumAccountVote : BaseEnumExt<AccountVote, BaseTuple<SubstrateNET.NetApi.Generated.Model.PalletConvictionVoting.Vote, Ajuna.NetApi.Model.Types.Primitive.U128>, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U128, Ajuna.NetApi.Model.Types.Primitive.U128>>
    {
    }
}