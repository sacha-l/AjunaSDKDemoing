//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Attributes;
using Ajuna.NetApi.Model.Types.Base;
using Ajuna.NetApi.Model.Types.Metadata.V14;
using Ajuna.NetApi.Model.Types.Primitive;
using SubstrateNET.NetApi.Generated.Model.SpRuntime;
using System.Collections.Generic;


namespace SubstrateNET.NetApi.Generated.Model.PalletStaking
{
    
    
    /// <summary>
    /// >> 421 - Composite[pallet_staking.Nominations]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class Nominations : BaseType
    {
        
        /// <summary>
        /// >> targets
        /// </summary>
        private SubstrateNET.NetApi.Generated.Model.SpRuntime.BoundedVecT11 _targets;
        
        /// <summary>
        /// >> submitted_in
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _submittedIn;
        
        /// <summary>
        /// >> suppressed
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.Bool _suppressed;
        
        public SubstrateNET.NetApi.Generated.Model.SpRuntime.BoundedVecT11 Targets
        {
            get
            {
                return this._targets;
            }
            set
            {
                this._targets = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 SubmittedIn
        {
            get
            {
                return this._submittedIn;
            }
            set
            {
                this._submittedIn = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.Bool Suppressed
        {
            get
            {
                return this._suppressed;
            }
            set
            {
                this._suppressed = value;
            }
        }
        
        public override string TypeName()
        {
            return "Nominations";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Targets.Encode());
            result.AddRange(SubmittedIn.Encode());
            result.AddRange(Suppressed.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Targets = new SubstrateNET.NetApi.Generated.Model.SpRuntime.BoundedVecT11();
            Targets.Decode(byteArray, ref p);
            SubmittedIn = new Ajuna.NetApi.Model.Types.Primitive.U32();
            SubmittedIn.Decode(byteArray, ref p);
            Suppressed = new Ajuna.NetApi.Model.Types.Primitive.Bool();
            Suppressed.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}