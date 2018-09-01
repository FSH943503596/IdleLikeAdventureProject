using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace StaticData.Data
{
    public class AbilityActiveData : BaseDataObject
    {
        
		public string Description = "";	//效果描述(备注)
		public byte EffectType = 0;	//技能效果类型
		public byte TargetType = 0;	//目标类型
		public byte TargetPriority = 0;	//目标优先级
		public byte LauchType = 0;	//发射类型
		public string BulletPrefabName = "";	//效果参数
		public ushort BulletSpeed = 0;	//子弹速度（格子/秒）
		public byte AreaType = 0;	//1级范围类型
		public string AreaParams = "";	//1级范围参数
		public byte TargetCount = 0;	//1级目标数量
		public byte DamageType = 0;	//1级伤害类型
		public int[] DamageParams = new int[2];	//1级伤害参数
		public int ExAreaType = 0;	//2级范围类型 
		public string ExAreaParams = "";	//2级范围参数 
		public int ExTargetCount = 0;	//2级目标数量
		public string ExDamageType = "";	//2段伤害类型
		public int[] ExDamageParams = new int[2];	//2段伤害
		public List<ushort> BuffID = new List<ushort>();	//添加状态ID，2段伤害结束时触发
		public string EffectName = "";	//1级命中特效
		public string Sound = "";	//1级播放音效
		public string ExEffectName = "";	//2级命中特效
		public string ExSound = "";	//2级播放音效
		public float[] ScreenShake = new float[3];	//震动
		
        public override void ReadFromStream(BinaryReader br)
        {
            mID = br.ReadUInt16();	//ID
			Description = br.ReadString();	//效果描述(备注)
			EffectType = br.ReadByte();	//技能效果类型
			TargetType = br.ReadByte();	//目标类型
			TargetPriority = br.ReadByte();	//目标优先级
			LauchType = br.ReadByte();	//发射类型
			BulletPrefabName = br.ReadString();	//效果参数
			BulletSpeed = br.ReadUInt16();	//子弹速度（格子/秒）
			AreaType = br.ReadByte();	//1级范围类型
			AreaParams = br.ReadString();	//1级范围参数
			TargetCount = br.ReadByte();	//1级目标数量
			DamageType = br.ReadByte();	//1级伤害类型
			ushort cnt2_12 = br.ReadUInt16();
			for(ushort i = 0; i < cnt2_12; i++)
				DamageParams[i] = br.ReadInt32();	//1级伤害参数
			ExAreaType = br.ReadInt32();	//2级范围类型 
			ExAreaParams = br.ReadString();	//2级范围参数 
			ExTargetCount = br.ReadInt32();	//2级目标数量
			ExDamageType = br.ReadString();	//2段伤害类型
			ushort cnt2_17 = br.ReadUInt16();
			for(ushort i = 0; i < cnt2_17; i++)
				ExDamageParams[i] = br.ReadInt32();	//2段伤害
			ushort listCount_18 = br.ReadUInt16();
			for(ushort i = 0; i < listCount_18; i++)
				BuffID.Add(br.ReadUInt16());	//添加状态ID，2段伤害结束时触发
			EffectName = br.ReadString();	//1级命中特效
			Sound = br.ReadString();	//1级播放音效
			ExEffectName = br.ReadString();	//2级命中特效
			ExSound = br.ReadString();	//2级播放音效
			ushort cnt3_23 = br.ReadUInt16();
			for(ushort i = 0; i < cnt3_23; i++)
				ScreenShake[i] = br.ReadSingle();	//震动
			
        }
    } 
} 