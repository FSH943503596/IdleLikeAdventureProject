using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace StaticData.Data
{
    public class AbilityPassiveData : BaseDataObject
    {
        
		public byte Condition = 0;	//生效条件
		public byte Times = 0;	//生效次数
		public ushort[] EnergyIncrease = new ushort[2];	//能源/怒气增加
		public ushort[] PropertyIncrease = new ushort[2];	//属性增加
		public ushort[] PropertyReduce = new ushort[2];	//属性减弱
		
        public override void ReadFromStream(BinaryReader br)
        {
            mID = br.ReadUInt16();	//ID
			Condition = br.ReadByte();	//生效条件
			Times = br.ReadByte();	//生效次数
			ushort cnt2_3 = br.ReadUInt16();
			for(ushort i = 0; i < cnt2_3; i++)
				EnergyIncrease[i] = br.ReadUInt16();	//能源/怒气增加
			ushort cnt2_4 = br.ReadUInt16();
			for(ushort i = 0; i < cnt2_4; i++)
				PropertyIncrease[i] = br.ReadUInt16();	//属性增加
			ushort cnt2_5 = br.ReadUInt16();
			for(ushort i = 0; i < cnt2_5; i++)
				PropertyReduce[i] = br.ReadUInt16();	//属性减弱
			
        }
    } 
} 