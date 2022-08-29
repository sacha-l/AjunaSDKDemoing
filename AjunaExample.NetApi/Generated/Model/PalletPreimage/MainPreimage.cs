//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi;
using Ajuna.NetApi.Model.Extrinsics;
using Ajuna.NetApi.Model.Meta;
using Ajuna.NetApi.Model.Types;
using Ajuna.NetApi.Model.Types.Base;
using Ajuna.NetApi.Model.Types.Primitive;
using SubstrateNET.NetApi.Generated.Model.PalletPreimage;
using SubstrateNET.NetApi.Generated.Model.PrimitiveTypes;
using SubstrateNET.NetApi.Generated.Model.SpRuntime;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace SubstrateNET.NetApi.Generated.Model.PalletPreimage
{
    
    
    public sealed class PreimageStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        public PreimageStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Preimage", "StatusFor"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.Identity}, typeof(SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256), typeof(SubstrateNET.NetApi.Generated.Model.PalletPreimage.EnumRequestStatus)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Preimage", "PreimageFor"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.Identity}, typeof(SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256), typeof(SubstrateNET.NetApi.Generated.Model.SpRuntime.BoundedVecT27)));
        }
        
        /// <summary>
        /// >> StatusForParams
        ///  The request status of a given hash.
        /// </summary>
        public static string StatusForParams(SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256 key)
        {
            return RequestGenerator.GetStorage("Preimage", "StatusFor", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.Identity}, new Ajuna.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> StatusFor
        ///  The request status of a given hash.
        /// </summary>
        public async Task<SubstrateNET.NetApi.Generated.Model.PalletPreimage.EnumRequestStatus> StatusFor(SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256 key, CancellationToken token)
        {
            string parameters = PreimageStorage.StatusForParams(key);
            return await _client.GetStorageAsync<SubstrateNET.NetApi.Generated.Model.PalletPreimage.EnumRequestStatus>(parameters, token);
        }
        
        /// <summary>
        /// >> PreimageForParams
        ///  The preimages stored by this pallet.
        /// </summary>
        public static string PreimageForParams(SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256 key)
        {
            return RequestGenerator.GetStorage("Preimage", "PreimageFor", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.Identity}, new Ajuna.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> PreimageFor
        ///  The preimages stored by this pallet.
        /// </summary>
        public async Task<SubstrateNET.NetApi.Generated.Model.SpRuntime.BoundedVecT27> PreimageFor(SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256 key, CancellationToken token)
        {
            string parameters = PreimageStorage.PreimageForParams(key);
            return await _client.GetStorageAsync<SubstrateNET.NetApi.Generated.Model.SpRuntime.BoundedVecT27>(parameters, token);
        }
    }
    
    public sealed class PreimageCalls
    {
        
        /// <summary>
        /// >> note_preimage
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method NotePreimage(BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8> bytes)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(bytes.Encode());
            return new Method(31, "Preimage", 0, "note_preimage", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> unnote_preimage
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method UnnotePreimage(SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256 hash)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(hash.Encode());
            return new Method(31, "Preimage", 1, "unnote_preimage", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> request_preimage
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method RequestPreimage(SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256 hash)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(hash.Encode());
            return new Method(31, "Preimage", 2, "request_preimage", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> unrequest_preimage
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method UnrequestPreimage(SubstrateNET.NetApi.Generated.Model.PrimitiveTypes.H256 hash)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(hash.Encode());
            return new Method(31, "Preimage", 3, "unrequest_preimage", byteArray.ToArray());
        }
    }
    
    public enum PreimageErrors
    {
        
        /// <summary>
        /// >> TooLarge
        /// Preimage is too large to store on-chain.
        /// </summary>
        TooLarge,
        
        /// <summary>
        /// >> AlreadyNoted
        /// Preimage has already been noted on-chain.
        /// </summary>
        AlreadyNoted,
        
        /// <summary>
        /// >> NotAuthorized
        /// The user is not authorized to perform this action.
        /// </summary>
        NotAuthorized,
        
        /// <summary>
        /// >> NotNoted
        /// The preimage cannot be removed since it has not yet been noted.
        /// </summary>
        NotNoted,
        
        /// <summary>
        /// >> Requested
        /// A preimage may not be removed when there are outstanding requests.
        /// </summary>
        Requested,
        
        /// <summary>
        /// >> NotRequested
        /// The preimage request cannot be removed since no outstanding requests exist.
        /// </summary>
        NotRequested,
    }
}