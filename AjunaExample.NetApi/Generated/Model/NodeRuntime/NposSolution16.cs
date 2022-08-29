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
using SubstrateNET.NetApi.Generated.Model.Base;
using SubstrateNET.NetApi.Generated.Model.SpArithmetic;
using System.Collections.Generic;


namespace SubstrateNET.NetApi.Generated.Model.NodeRuntime
{
    
    
    /// <summary>
    /// >> 175 - Composite[node_runtime.NposSolution16]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class NposSolution16 : BaseType
    {
        
        /// <summary>
        /// >> votes1
        /// </summary>
        private BaseVec<BaseTuple<BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>,BaseCom<Ajuna.NetApi.Model.Types.Primitive.U16>>> _votes1;
        
        /// <summary>
        /// >> votes2
        /// </summary>
        private BaseVec<BaseTuple<BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>,BaseTuple<BaseCom<Ajuna.NetApi.Model.Types.Primitive.U16>,BaseCom<SubstrateNET.NetApi.Generated.Model.SpArithmetic.PerU16>>,BaseCom<Ajuna.NetApi.Model.Types.Primitive.U16>>> _votes2;
        
        /// <summary>
        /// >> votes3
        /// </summary>
        private BaseVec<BaseTuple<BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>,SubstrateNET.NetApi.Generated.Model.Base.Arr2Special1,BaseCom<Ajuna.NetApi.Model.Types.Primitive.U16>>> _votes3;
        
        /// <summary>
        /// >> votes4
        /// </summary>
        private BaseVec<BaseTuple<BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>,SubstrateNET.NetApi.Generated.Model.Base.Arr3Special3,BaseCom<Ajuna.NetApi.Model.Types.Primitive.U16>>> _votes4;
        
        /// <summary>
        /// >> votes5
        /// </summary>
        private BaseVec<BaseTuple<BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>,SubstrateNET.NetApi.Generated.Model.Base.Arr4Special5,BaseCom<Ajuna.NetApi.Model.Types.Primitive.U16>>> _votes5;
        
        /// <summary>
        /// >> votes6
        /// </summary>
        private BaseVec<BaseTuple<BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>,SubstrateNET.NetApi.Generated.Model.Base.Arr5Special7,BaseCom<Ajuna.NetApi.Model.Types.Primitive.U16>>> _votes6;
        
        /// <summary>
        /// >> votes7
        /// </summary>
        private BaseVec<BaseTuple<BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>,SubstrateNET.NetApi.Generated.Model.Base.Arr6Special9,BaseCom<Ajuna.NetApi.Model.Types.Primitive.U16>>> _votes7;
        
        /// <summary>
        /// >> votes8
        /// </summary>
        private BaseVec<BaseTuple<BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>,SubstrateNET.NetApi.Generated.Model.Base.Arr7Special11,BaseCom<Ajuna.NetApi.Model.Types.Primitive.U16>>> _votes8;
        
        /// <summary>
        /// >> votes9
        /// </summary>
        private BaseVec<BaseTuple<BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>,SubstrateNET.NetApi.Generated.Model.Base.Arr8Special13,BaseCom<Ajuna.NetApi.Model.Types.Primitive.U16>>> _votes9;
        
        /// <summary>
        /// >> votes10
        /// </summary>
        private BaseVec<BaseTuple<BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>,SubstrateNET.NetApi.Generated.Model.Base.Arr9Special15,BaseCom<Ajuna.NetApi.Model.Types.Primitive.U16>>> _votes10;
        
        /// <summary>
        /// >> votes11
        /// </summary>
        private BaseVec<BaseTuple<BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>,SubstrateNET.NetApi.Generated.Model.Base.Arr10Special17,BaseCom<Ajuna.NetApi.Model.Types.Primitive.U16>>> _votes11;
        
        /// <summary>
        /// >> votes12
        /// </summary>
        private BaseVec<BaseTuple<BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>,SubstrateNET.NetApi.Generated.Model.Base.Arr11Special19,BaseCom<Ajuna.NetApi.Model.Types.Primitive.U16>>> _votes12;
        
        /// <summary>
        /// >> votes13
        /// </summary>
        private BaseVec<BaseTuple<BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>,SubstrateNET.NetApi.Generated.Model.Base.Arr12Special21,BaseCom<Ajuna.NetApi.Model.Types.Primitive.U16>>> _votes13;
        
        /// <summary>
        /// >> votes14
        /// </summary>
        private BaseVec<BaseTuple<BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>,SubstrateNET.NetApi.Generated.Model.Base.Arr13Special23,BaseCom<Ajuna.NetApi.Model.Types.Primitive.U16>>> _votes14;
        
        /// <summary>
        /// >> votes15
        /// </summary>
        private BaseVec<BaseTuple<BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>,SubstrateNET.NetApi.Generated.Model.Base.Arr14Special25,BaseCom<Ajuna.NetApi.Model.Types.Primitive.U16>>> _votes15;
        
        /// <summary>
        /// >> votes16
        /// </summary>
        private BaseVec<BaseTuple<BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>,SubstrateNET.NetApi.Generated.Model.Base.Arr15Special27,BaseCom<Ajuna.NetApi.Model.Types.Primitive.U16>>> _votes16;
        
        public BaseVec<BaseTuple<BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>,BaseCom<Ajuna.NetApi.Model.Types.Primitive.U16>>> Votes1
        {
            get
            {
                return this._votes1;
            }
            set
            {
                this._votes1 = value;
            }
        }
        
        public BaseVec<BaseTuple<BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>,BaseTuple<BaseCom<Ajuna.NetApi.Model.Types.Primitive.U16>,BaseCom<SubstrateNET.NetApi.Generated.Model.SpArithmetic.PerU16>>,BaseCom<Ajuna.NetApi.Model.Types.Primitive.U16>>> Votes2
        {
            get
            {
                return this._votes2;
            }
            set
            {
                this._votes2 = value;
            }
        }
        
        public BaseVec<BaseTuple<BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>,SubstrateNET.NetApi.Generated.Model.Base.Arr2Special1,BaseCom<Ajuna.NetApi.Model.Types.Primitive.U16>>> Votes3
        {
            get
            {
                return this._votes3;
            }
            set
            {
                this._votes3 = value;
            }
        }
        
        public BaseVec<BaseTuple<BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>,SubstrateNET.NetApi.Generated.Model.Base.Arr3Special3,BaseCom<Ajuna.NetApi.Model.Types.Primitive.U16>>> Votes4
        {
            get
            {
                return this._votes4;
            }
            set
            {
                this._votes4 = value;
            }
        }
        
        public BaseVec<BaseTuple<BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>,SubstrateNET.NetApi.Generated.Model.Base.Arr4Special5,BaseCom<Ajuna.NetApi.Model.Types.Primitive.U16>>> Votes5
        {
            get
            {
                return this._votes5;
            }
            set
            {
                this._votes5 = value;
            }
        }
        
        public BaseVec<BaseTuple<BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>,SubstrateNET.NetApi.Generated.Model.Base.Arr5Special7,BaseCom<Ajuna.NetApi.Model.Types.Primitive.U16>>> Votes6
        {
            get
            {
                return this._votes6;
            }
            set
            {
                this._votes6 = value;
            }
        }
        
        public BaseVec<BaseTuple<BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>,SubstrateNET.NetApi.Generated.Model.Base.Arr6Special9,BaseCom<Ajuna.NetApi.Model.Types.Primitive.U16>>> Votes7
        {
            get
            {
                return this._votes7;
            }
            set
            {
                this._votes7 = value;
            }
        }
        
        public BaseVec<BaseTuple<BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>,SubstrateNET.NetApi.Generated.Model.Base.Arr7Special11,BaseCom<Ajuna.NetApi.Model.Types.Primitive.U16>>> Votes8
        {
            get
            {
                return this._votes8;
            }
            set
            {
                this._votes8 = value;
            }
        }
        
        public BaseVec<BaseTuple<BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>,SubstrateNET.NetApi.Generated.Model.Base.Arr8Special13,BaseCom<Ajuna.NetApi.Model.Types.Primitive.U16>>> Votes9
        {
            get
            {
                return this._votes9;
            }
            set
            {
                this._votes9 = value;
            }
        }
        
        public BaseVec<BaseTuple<BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>,SubstrateNET.NetApi.Generated.Model.Base.Arr9Special15,BaseCom<Ajuna.NetApi.Model.Types.Primitive.U16>>> Votes10
        {
            get
            {
                return this._votes10;
            }
            set
            {
                this._votes10 = value;
            }
        }
        
        public BaseVec<BaseTuple<BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>,SubstrateNET.NetApi.Generated.Model.Base.Arr10Special17,BaseCom<Ajuna.NetApi.Model.Types.Primitive.U16>>> Votes11
        {
            get
            {
                return this._votes11;
            }
            set
            {
                this._votes11 = value;
            }
        }
        
        public BaseVec<BaseTuple<BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>,SubstrateNET.NetApi.Generated.Model.Base.Arr11Special19,BaseCom<Ajuna.NetApi.Model.Types.Primitive.U16>>> Votes12
        {
            get
            {
                return this._votes12;
            }
            set
            {
                this._votes12 = value;
            }
        }
        
        public BaseVec<BaseTuple<BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>,SubstrateNET.NetApi.Generated.Model.Base.Arr12Special21,BaseCom<Ajuna.NetApi.Model.Types.Primitive.U16>>> Votes13
        {
            get
            {
                return this._votes13;
            }
            set
            {
                this._votes13 = value;
            }
        }
        
        public BaseVec<BaseTuple<BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>,SubstrateNET.NetApi.Generated.Model.Base.Arr13Special23,BaseCom<Ajuna.NetApi.Model.Types.Primitive.U16>>> Votes14
        {
            get
            {
                return this._votes14;
            }
            set
            {
                this._votes14 = value;
            }
        }
        
        public BaseVec<BaseTuple<BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>,SubstrateNET.NetApi.Generated.Model.Base.Arr14Special25,BaseCom<Ajuna.NetApi.Model.Types.Primitive.U16>>> Votes15
        {
            get
            {
                return this._votes15;
            }
            set
            {
                this._votes15 = value;
            }
        }
        
        public BaseVec<BaseTuple<BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>,SubstrateNET.NetApi.Generated.Model.Base.Arr15Special27,BaseCom<Ajuna.NetApi.Model.Types.Primitive.U16>>> Votes16
        {
            get
            {
                return this._votes16;
            }
            set
            {
                this._votes16 = value;
            }
        }
        
        public override string TypeName()
        {
            return "NposSolution16";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Votes1.Encode());
            result.AddRange(Votes2.Encode());
            result.AddRange(Votes3.Encode());
            result.AddRange(Votes4.Encode());
            result.AddRange(Votes5.Encode());
            result.AddRange(Votes6.Encode());
            result.AddRange(Votes7.Encode());
            result.AddRange(Votes8.Encode());
            result.AddRange(Votes9.Encode());
            result.AddRange(Votes10.Encode());
            result.AddRange(Votes11.Encode());
            result.AddRange(Votes12.Encode());
            result.AddRange(Votes13.Encode());
            result.AddRange(Votes14.Encode());
            result.AddRange(Votes15.Encode());
            result.AddRange(Votes16.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Votes1 = new BaseVec<BaseTuple<BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>,BaseCom<Ajuna.NetApi.Model.Types.Primitive.U16>>>();
            Votes1.Decode(byteArray, ref p);
            Votes2 = new BaseVec<BaseTuple<BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>,BaseTuple<BaseCom<Ajuna.NetApi.Model.Types.Primitive.U16>,BaseCom<SubstrateNET.NetApi.Generated.Model.SpArithmetic.PerU16>>,BaseCom<Ajuna.NetApi.Model.Types.Primitive.U16>>>();
            Votes2.Decode(byteArray, ref p);
            Votes3 = new BaseVec<BaseTuple<BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>,SubstrateNET.NetApi.Generated.Model.Base.Arr2Special1,BaseCom<Ajuna.NetApi.Model.Types.Primitive.U16>>>();
            Votes3.Decode(byteArray, ref p);
            Votes4 = new BaseVec<BaseTuple<BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>,SubstrateNET.NetApi.Generated.Model.Base.Arr3Special3,BaseCom<Ajuna.NetApi.Model.Types.Primitive.U16>>>();
            Votes4.Decode(byteArray, ref p);
            Votes5 = new BaseVec<BaseTuple<BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>,SubstrateNET.NetApi.Generated.Model.Base.Arr4Special5,BaseCom<Ajuna.NetApi.Model.Types.Primitive.U16>>>();
            Votes5.Decode(byteArray, ref p);
            Votes6 = new BaseVec<BaseTuple<BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>,SubstrateNET.NetApi.Generated.Model.Base.Arr5Special7,BaseCom<Ajuna.NetApi.Model.Types.Primitive.U16>>>();
            Votes6.Decode(byteArray, ref p);
            Votes7 = new BaseVec<BaseTuple<BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>,SubstrateNET.NetApi.Generated.Model.Base.Arr6Special9,BaseCom<Ajuna.NetApi.Model.Types.Primitive.U16>>>();
            Votes7.Decode(byteArray, ref p);
            Votes8 = new BaseVec<BaseTuple<BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>,SubstrateNET.NetApi.Generated.Model.Base.Arr7Special11,BaseCom<Ajuna.NetApi.Model.Types.Primitive.U16>>>();
            Votes8.Decode(byteArray, ref p);
            Votes9 = new BaseVec<BaseTuple<BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>,SubstrateNET.NetApi.Generated.Model.Base.Arr8Special13,BaseCom<Ajuna.NetApi.Model.Types.Primitive.U16>>>();
            Votes9.Decode(byteArray, ref p);
            Votes10 = new BaseVec<BaseTuple<BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>,SubstrateNET.NetApi.Generated.Model.Base.Arr9Special15,BaseCom<Ajuna.NetApi.Model.Types.Primitive.U16>>>();
            Votes10.Decode(byteArray, ref p);
            Votes11 = new BaseVec<BaseTuple<BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>,SubstrateNET.NetApi.Generated.Model.Base.Arr10Special17,BaseCom<Ajuna.NetApi.Model.Types.Primitive.U16>>>();
            Votes11.Decode(byteArray, ref p);
            Votes12 = new BaseVec<BaseTuple<BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>,SubstrateNET.NetApi.Generated.Model.Base.Arr11Special19,BaseCom<Ajuna.NetApi.Model.Types.Primitive.U16>>>();
            Votes12.Decode(byteArray, ref p);
            Votes13 = new BaseVec<BaseTuple<BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>,SubstrateNET.NetApi.Generated.Model.Base.Arr12Special21,BaseCom<Ajuna.NetApi.Model.Types.Primitive.U16>>>();
            Votes13.Decode(byteArray, ref p);
            Votes14 = new BaseVec<BaseTuple<BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>,SubstrateNET.NetApi.Generated.Model.Base.Arr13Special23,BaseCom<Ajuna.NetApi.Model.Types.Primitive.U16>>>();
            Votes14.Decode(byteArray, ref p);
            Votes15 = new BaseVec<BaseTuple<BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>,SubstrateNET.NetApi.Generated.Model.Base.Arr14Special25,BaseCom<Ajuna.NetApi.Model.Types.Primitive.U16>>>();
            Votes15.Decode(byteArray, ref p);
            Votes16 = new BaseVec<BaseTuple<BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>,SubstrateNET.NetApi.Generated.Model.Base.Arr15Special27,BaseCom<Ajuna.NetApi.Model.Types.Primitive.U16>>>();
            Votes16.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}