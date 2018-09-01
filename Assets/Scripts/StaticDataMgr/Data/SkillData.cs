using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace StaticData.Data
{
    public class SkillData : BaseDataObject
    {
        
		public string Name = "";	//名称
		public string Info = "";	//简介
		public string ICON = "";	//图标
		public string SkillType = "";	//类型
		public int Power = 0;	//POWER
		public ushort MaxLevel = 0;	//最高等级
		public string CostType = "";	//消耗类型
		public int Cost = 0;	//消耗
		public int CD = 0;	//冷却时间（秒）
		public int ForeAttackTime = 0;	//前摇时间（毫秒）
		public int CastTime = 0;	//释放时间（毫秒）
		public int BackAttackTime = 0;	//后摇时间（毫秒）
		public string TargetType = "";	//目标类型（多个）
		public string TargetPriority = "";	//目标优先级
		public int TargetMaxCount = 0;	//目标数量
		public int Distance = 0;	//技能射程(1格子=100)
		public string AreaType = "";	//1段范围类型
		public string AreaParams = "";	//1段范围参数（多个）
		public string DamageType = "";	//1段伤害类型
		public float[] Damage = new float[2];	//1段伤害（倍率|绝对值）
		public ushort BuffOrDeBuff = 0;	//1段buff/Debuff
		public ushort BulletID = 0;	//飞行道具ID
		public string ExAreaType = "";	//2段范围类型
		public string ExAreaParam = "";	//2段范围参数（多个）
		public string ExDamageType = "";	//2段伤害类型
		public float[] ExDamage = new float[2];	//2段伤害（倍率|绝对值）
		public ushort ExBuffOrDeBuff = 0;	//2段buff/Debuff
		public int SummonRadio = 0;	//召唤半径
		public string SummonIDs = "";	//ID（多个）
		public string SummonCont = "";	//数量（多个）
		public string SummonTime = "";	//时间（多个）
		public int Fury = 0;	//怒气
		public ushort AnimationIndex = 0;	//技能动作索引
		public int DamageFrame = 0;	//伤害延迟（毫秒）
		public string Effect = "";	//施法特效
		public int EffectFrame = 0;	//施法特效延迟（毫秒）
		public string Audio = "";	//施法音效
		public int AudioFrame = 0;	//施法音效延迟（毫秒）
		public string HitTargetEffect = "";	//1段命中特效
		public string HitTargetAudio = "";	//1段命中音效
		public string ExHitTargetEffect = "";	//2段命中特效
		public string ExHitTargetAudio = "";	//2段命中音效
		public bool IsShockScreen = false;	//震屏？
		
        public override void ReadFromStream(BinaryReader br)
        {
            mID = br.ReadUInt16();	//ID
			Name = br.ReadString();	//名称
			Info = br.ReadString();	//简介
			ICON = br.ReadString();	//图标
			SkillType = br.ReadString();	//类型
			Power = br.ReadInt32();	//POWER
			MaxLevel = br.ReadUInt16();	//最高等级
			CostType = br.ReadString();	//消耗类型
			Cost = br.ReadInt32();	//消耗
			CD = br.ReadInt32();	//冷却时间（秒）
			ForeAttackTime = br.ReadInt32();	//前摇时间（毫秒）
			CastTime = br.ReadInt32();	//释放时间（毫秒）
			BackAttackTime = br.ReadInt32();	//后摇时间（毫秒）
			TargetType = br.ReadString();	//目标类型（多个）
			TargetPriority = br.ReadString();	//目标优先级
			TargetMaxCount = br.ReadInt32();	//目标数量
			Distance = br.ReadInt32();	//技能射程(1格子=100)
			AreaType = br.ReadString();	//1段范围类型
			AreaParams = br.ReadString();	//1段范围参数（多个）
			DamageType = br.ReadString();	//1段伤害类型
			ushort cnt2_20 = br.ReadUInt16();
			for(ushort i = 0; i < cnt2_20; i++)
				Damage[i] = br.ReadSingle();	//1段伤害（倍率|绝对值）
			BuffOrDeBuff = br.ReadUInt16();	//1段buff/Debuff
			BulletID = br.ReadUInt16();	//飞行道具ID
			ExAreaType = br.ReadString();	//2段范围类型
			ExAreaParam = br.ReadString();	//2段范围参数（多个）
			ExDamageType = br.ReadString();	//2段伤害类型
			ushort cnt2_26 = br.ReadUInt16();
			for(ushort i = 0; i < cnt2_26; i++)
				ExDamage[i] = br.ReadSingle();	//2段伤害（倍率|绝对值）
			ExBuffOrDeBuff = br.ReadUInt16();	//2段buff/Debuff
			SummonRadio = br.ReadInt32();	//召唤半径
			SummonIDs = br.ReadString();	//ID（多个）
			SummonCont = br.ReadString();	//数量（多个）
			SummonTime = br.ReadString();	//时间（多个）
			Fury = br.ReadInt32();	//怒气
			AnimationIndex = br.ReadUInt16();	//技能动作索引
			DamageFrame = br.ReadInt32();	//伤害延迟（毫秒）
			Effect = br.ReadString();	//施法特效
			EffectFrame = br.ReadInt32();	//施法特效延迟（毫秒）
			Audio = br.ReadString();	//施法音效
			AudioFrame = br.ReadInt32();	//施法音效延迟（毫秒）
			HitTargetEffect = br.ReadString();	//1段命中特效
			HitTargetAudio = br.ReadString();	//1段命中音效
			ExHitTargetEffect = br.ReadString();	//2段命中特效
			ExHitTargetAudio = br.ReadString();	//2段命中音效
			IsShockScreen = br.ReadBoolean();	//震屏？
			
        }
    } 
} 