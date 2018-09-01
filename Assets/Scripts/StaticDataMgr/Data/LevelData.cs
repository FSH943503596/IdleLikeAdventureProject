using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace StaticData.Data
{
    public class LevelData : BaseDataObject
    {
        
		public ushort LevelUpValue = 0;	//升级需要经验
		public ushort AddHeath = 0;	//增加生命
		public ushort AddAttack = 0;	//增加攻击
		public ushort NearDefense = 0;	//增加近战防御
		public ushort BowDefense = 0;	//增加弓箭防御
		public ushort SpellsDefense = 0;	//增加法术防御
		public ushort MedicalValue = 0;	//增加医疗
		public ushort MiningValue = 0;	//增加挖矿
		public ushort LoggingValue = 0;	//增加伐木
		public ushort FarmingValue = 0;	//增加农耕
		
        public override void ReadFromStream(BinaryReader br)
        {
            mID = br.ReadUInt16();	//等级
			LevelUpValue = br.ReadUInt16();	//升级需要经验
			AddHeath = br.ReadUInt16();	//增加生命
			AddAttack = br.ReadUInt16();	//增加攻击
			NearDefense = br.ReadUInt16();	//增加近战防御
			BowDefense = br.ReadUInt16();	//增加弓箭防御
			SpellsDefense = br.ReadUInt16();	//增加法术防御
			MedicalValue = br.ReadUInt16();	//增加医疗
			MiningValue = br.ReadUInt16();	//增加挖矿
			LoggingValue = br.ReadUInt16();	//增加伐木
			FarmingValue = br.ReadUInt16();	//增加农耕
			
        }
    } 
} 