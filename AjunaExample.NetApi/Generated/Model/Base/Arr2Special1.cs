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
using SubstrateNET.NetApi.Generated.Model.SpArithmetic;
using System.Collections.Generic;


namespace SubstrateNET.NetApi.Generated.Model.Base
{
    
    
    /// <summary>
    /// >> 186 - Array
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Array)]
    public sealed class Arr2Special1 : BaseType
    {
        
        private BaseTuple<BaseCom<Ajuna.NetApi.Model.Types.Primitive.U16>,BaseCom<SubstrateNET.NetApi.Generated.Model.SpArithmetic.PerU16>>[] _value;
        
        public override int TypeSize
        {
            get
            {
                return 2;
            }
        }
        
        public BaseTuple<BaseCom<Ajuna.NetApi.Model.Types.Primitive.U16>,BaseCom<SubstrateNET.NetApi.Generated.Model.SpArithmetic.PerU16>>[] Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
        
        public override string TypeName()
        {
            return string.Format("[{0}; {1}]", new BaseTuple<BaseCom<Ajuna.NetApi.Model.Types.Primitive.U16>,BaseCom<SubstrateNET.NetApi.Generated.Model.SpArithmetic.PerU16>>().TypeName(), this.TypeSize);
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            foreach (var v in Value){result.AddRange(v.Encode());};
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            var array = new BaseTuple<BaseCom<Ajuna.NetApi.Model.Types.Primitive.U16>,BaseCom<SubstrateNET.NetApi.Generated.Model.SpArithmetic.PerU16>>[TypeSize];
            for (var i = 0; i < array.Length; i++) {var t = new BaseTuple<BaseCom<Ajuna.NetApi.Model.Types.Primitive.U16>,BaseCom<SubstrateNET.NetApi.Generated.Model.SpArithmetic.PerU16>>();t.Decode(byteArray, ref p);array[i] = t;};
            var bytesLength = p - start;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
            Value = array;
        }
        
        public void Create(BaseTuple<BaseCom<Ajuna.NetApi.Model.Types.Primitive.U16>,BaseCom<SubstrateNET.NetApi.Generated.Model.SpArithmetic.PerU16>>[] array)
        {
            Value = array;
            Bytes = Encode();
        }
    }
}