using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace StaticData.Data
{
    public class CharacterData : BaseDataObject
    {
        
		public ushort ArtMID = 0;	//美术资源ID
		public ushort LifeMID = 0;	//生活属性ID
		public string Name = "";	//英雄名
		public string CharacterType = "";	//单位类型
		public ushort Speed = 0;	//移速
		public ushort HP = 0;	//HP
		public string AttackAttributes = "";	//战斗属性
		public ushort Attack = 0;	//攻击力
		public ushort[] Damage = new ushort[2];	//伤害值
		public ushort AttackInterval = 0;	//攻击间隔
		public ushort FrontAttackCD = 0;	//前摇
		public ushort BackAttackCD = 0;	//后摇
		public ushort AttackDistance = 0;	//射程
		public ushort CritisRate = 0;	//暴击
		public ushort CritisDamageRate = 0;	//爆伤
		public ushort Tenacity = 0;	//坚韧
		public ushort PhysicDefence = 0;	//物理防御
		public ushort MagicDefence = 0;	//魔法耐性
		public ushort FireDefence = 0;	//火焰耐性
		public ushort IceDefence = 0;	//寒冰耐性
		public ushort WaterDefence = 0;	//流水耐性
		public ushort ThunderDefence = 0;	//雷电耐性
		public ushort EarthDefence = 0;	//大地耐性
		public ushort SacredDefence = 0;	//神圣耐性
		public ushort DamnationDefence = 0;	//诅咒耐性
		public ushort RepelPower = 0;	//冲击
		public ushort Determination = 0;	//坚毅
		public ushort Storm = 0;	//强击
		public ushort SuperArmor = 0;	//霸体
		
        public override void ReadFromStream(BinaryReader br)
        {
            mID = br.ReadUInt16();	//ID
			ArtMID = br.ReadUInt16();	//美术资源ID
			LifeMID = br.ReadUInt16();	//生活属性ID
			Name = br.ReadString();	//英雄名
			CharacterType = br.ReadString();	//单位类型
			Speed = br.ReadUInt16();	//移速
			HP = br.ReadUInt16();	//HP
			AttackAttributes = br.ReadString();	//战斗属性
			Attack = br.ReadUInt16();	//攻击力
			ushort cnt2_9 = br.ReadUInt16();
			for(ushort i = 0; i < cnt2_9; i++)
				Damage[i] = br.ReadUInt16();	//伤害值
			AttackInterval = br.ReadUInt16();	//攻击间隔
			FrontAttackCD = br.ReadUInt16();	//前摇
			BackAttackCD = br.ReadUInt16();	//后摇
			AttackDistance = br.ReadUInt16();	//射程
			CritisRate = br.ReadUInt16();	//暴击
			CritisDamageRate = br.ReadUInt16();	//爆伤
			Tenacity = br.ReadUInt16();	//坚韧
			PhysicDefence = br.ReadUInt16();	//物理防御
			MagicDefence = br.ReadUInt16();	//魔法耐性
			FireDefence = br.ReadUInt16();	//火焰耐性
			IceDefence = br.ReadUInt16();	//寒冰耐性
			WaterDefence = br.ReadUInt16();	//流水耐性
			ThunderDefence = br.ReadUInt16();	//雷电耐性
			EarthDefence = br.ReadUInt16();	//大地耐性
			SacredDefence = br.ReadUInt16();	//神圣耐性
			DamnationDefence = br.ReadUInt16();	//诅咒耐性
			RepelPower = br.ReadUInt16();	//冲击
			Determination = br.ReadUInt16();	//坚毅
			Storm = br.ReadUInt16();	//强击
			SuperArmor = br.ReadUInt16();	//霸体
			
        }
    } 
} 