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
using SubstrateNET.NetApi.Generated.Model.PalletStateTrieMigration;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace SubstrateNET.NetApi.Generated.Model.PalletStateTrieMigration
{
    
    
    public sealed class StateTrieMigrationStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        public StateTrieMigrationStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("StateTrieMigration", "MigrationProcess"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(SubstrateNET.NetApi.Generated.Model.PalletStateTrieMigration.MigrationTask)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("StateTrieMigration", "AutoLimits"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(BaseOpt<SubstrateNET.NetApi.Generated.Model.PalletStateTrieMigration.MigrationLimits>)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("StateTrieMigration", "SignedMigrationMaxLimits"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(SubstrateNET.NetApi.Generated.Model.PalletStateTrieMigration.MigrationLimits)));
        }
        
        /// <summary>
        /// >> MigrationProcessParams
        ///  Migration progress.
        /// 
        ///  This stores the snapshot of the last migrated keys. It can be set into motion and move
        ///  forward by any of the means provided by this pallet.
        /// </summary>
        public static string MigrationProcessParams()
        {
            return RequestGenerator.GetStorage("StateTrieMigration", "MigrationProcess", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> MigrationProcess
        ///  Migration progress.
        /// 
        ///  This stores the snapshot of the last migrated keys. It can be set into motion and move
        ///  forward by any of the means provided by this pallet.
        /// </summary>
        public async Task<SubstrateNET.NetApi.Generated.Model.PalletStateTrieMigration.MigrationTask> MigrationProcess(CancellationToken token)
        {
            string parameters = StateTrieMigrationStorage.MigrationProcessParams();
            return await _client.GetStorageAsync<SubstrateNET.NetApi.Generated.Model.PalletStateTrieMigration.MigrationTask>(parameters, token);
        }
        
        /// <summary>
        /// >> AutoLimitsParams
        ///  The limits that are imposed on automatic migrations.
        /// 
        ///  If set to None, then no automatic migration happens.
        /// </summary>
        public static string AutoLimitsParams()
        {
            return RequestGenerator.GetStorage("StateTrieMigration", "AutoLimits", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> AutoLimits
        ///  The limits that are imposed on automatic migrations.
        /// 
        ///  If set to None, then no automatic migration happens.
        /// </summary>
        public async Task<BaseOpt<SubstrateNET.NetApi.Generated.Model.PalletStateTrieMigration.MigrationLimits>> AutoLimits(CancellationToken token)
        {
            string parameters = StateTrieMigrationStorage.AutoLimitsParams();
            return await _client.GetStorageAsync<BaseOpt<SubstrateNET.NetApi.Generated.Model.PalletStateTrieMigration.MigrationLimits>>(parameters, token);
        }
        
        /// <summary>
        /// >> SignedMigrationMaxLimitsParams
        ///  The maximum limits that the signed migration could use.
        /// 
        ///  If not set, no signed submission is allowed.
        /// </summary>
        public static string SignedMigrationMaxLimitsParams()
        {
            return RequestGenerator.GetStorage("StateTrieMigration", "SignedMigrationMaxLimits", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> SignedMigrationMaxLimits
        ///  The maximum limits that the signed migration could use.
        /// 
        ///  If not set, no signed submission is allowed.
        /// </summary>
        public async Task<SubstrateNET.NetApi.Generated.Model.PalletStateTrieMigration.MigrationLimits> SignedMigrationMaxLimits(CancellationToken token)
        {
            string parameters = StateTrieMigrationStorage.SignedMigrationMaxLimitsParams();
            return await _client.GetStorageAsync<SubstrateNET.NetApi.Generated.Model.PalletStateTrieMigration.MigrationLimits>(parameters, token);
        }
    }
    
    public sealed class StateTrieMigrationCalls
    {
        
        /// <summary>
        /// >> control_auto_migration
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ControlAutoMigration(BaseOpt<SubstrateNET.NetApi.Generated.Model.PalletStateTrieMigration.MigrationLimits> maybe_config)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(maybe_config.Encode());
            return new Method(43, "StateTrieMigration", 0, "control_auto_migration", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> continue_migrate
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ContinueMigrate(SubstrateNET.NetApi.Generated.Model.PalletStateTrieMigration.MigrationLimits limits, Ajuna.NetApi.Model.Types.Primitive.U32 real_size_upper, SubstrateNET.NetApi.Generated.Model.PalletStateTrieMigration.MigrationTask witness_task)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(limits.Encode());
            byteArray.AddRange(real_size_upper.Encode());
            byteArray.AddRange(witness_task.Encode());
            return new Method(43, "StateTrieMigration", 1, "continue_migrate", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> migrate_custom_top
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method MigrateCustomTop(BaseVec<BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8>> keys, Ajuna.NetApi.Model.Types.Primitive.U32 witness_size)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(keys.Encode());
            byteArray.AddRange(witness_size.Encode());
            return new Method(43, "StateTrieMigration", 2, "migrate_custom_top", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> migrate_custom_child
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method MigrateCustomChild(BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8> root, BaseVec<BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8>> child_keys, Ajuna.NetApi.Model.Types.Primitive.U32 total_size)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(root.Encode());
            byteArray.AddRange(child_keys.Encode());
            byteArray.AddRange(total_size.Encode());
            return new Method(43, "StateTrieMigration", 3, "migrate_custom_child", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_signed_max_limits
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method SetSignedMaxLimits(SubstrateNET.NetApi.Generated.Model.PalletStateTrieMigration.MigrationLimits limits)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(limits.Encode());
            return new Method(43, "StateTrieMigration", 4, "set_signed_max_limits", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> force_set_progress
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ForceSetProgress(SubstrateNET.NetApi.Generated.Model.PalletStateTrieMigration.EnumProgress progress_top, SubstrateNET.NetApi.Generated.Model.PalletStateTrieMigration.EnumProgress progress_child)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(progress_top.Encode());
            byteArray.AddRange(progress_child.Encode());
            return new Method(43, "StateTrieMigration", 5, "force_set_progress", byteArray.ToArray());
        }
    }
    
    public enum StateTrieMigrationErrors
    {
        
        /// <summary>
        /// >> MaxSignedLimits
        /// max signed limits not respected.
        /// </summary>
        MaxSignedLimits,
        
        /// <summary>
        /// >> KeyTooLong
        /// A key was longer than the configured maximum.
        /// 
        /// This means that the migration halted at the current [`Progress`] and
        /// can be resumed with a larger [`crate::Config::MaxKeyLen`] value.
        /// Retrying with the same [`crate::Config::MaxKeyLen`] value will not work.
        /// The value should only be increased to avoid a storage migration for the currently
        /// stored [`crate::Progress::LastKey`].
        /// </summary>
        KeyTooLong,
        
        /// <summary>
        /// >> NotEnoughFunds
        /// submitter does not have enough funds.
        /// </summary>
        NotEnoughFunds,
        
        /// <summary>
        /// >> BadWitness
        /// bad witness data provided.
        /// </summary>
        BadWitness,
        
        /// <summary>
        /// >> SizeUpperBoundExceeded
        /// upper bound of size is exceeded,
        /// </summary>
        SizeUpperBoundExceeded,
        
        /// <summary>
        /// >> SignedMigrationNotAllowed
        /// Signed migration is not allowed because the maximum limit is not set yet.
        /// </summary>
        SignedMigrationNotAllowed,
    }
}