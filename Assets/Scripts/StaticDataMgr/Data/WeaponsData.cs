using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace StaticData.Data
{
    public class WeaponsData : BaseDataObject
    {
        
		public ushort WeaponName = 0;	//名称文本
		public ushort mInfo = 0;	//说明文本
		public string PrefabPath = "";	//资源
		public GlobalDefine.EWeaponType mEweaponType;	//武器类型（Melee  近战，Bow  弓箭，Spells  法术）
		public ushort MinAttack = 0;	//最低攻击
		public ushort MaxAttack = 0;	//最高攻击
		public GlobalDefine.EAttackTarget mEAttackTarget;	//攻击目标（Enemy敌，Self我）
		public GlobalDefine.EAttackType mEAttackType;	//攻击类型（OnePlayer 单体，Range范围）
		public ushort AttackAngle = 0;	//攻击角度（以队伍行进方向左右各多少度，90即为半圆）
		public ushort AttackDistance = 0;	//攻击距离
		public ushort BeShaking = 0;	//攻击前摇s
		public ushort AfShaking = 0;	//攻击后摇
		public string NormalBuffPath = "";	//默认动画
		public ushort BuffID = 0;	//buff
		public string BallisticBuffPath = "";	//弹道动画
		public ushort BulletNum = 0;	//子弹数量
		public GlobalDefine.EBallisticType EBallisticType;	//弹道类型（Line 直线，Track  追踪，Parabola  抛物线）
		public ushort BallisticSpeed = 0;	//弹道速度
		public bool mIsEDeathExplosion = false;	//死亡爆破（False 否，True 是）
		public ushort BlastingRange = 0;	//爆破半径
		public ushort BlastingHurt = 0;	//爆破伤害
		public string BlastingBuffPath = "";	//爆破动画
		
        public override void ReadFromStream(BinaryReader br)
        {
            mID = br.ReadUInt16();	//ID
			WeaponName = br.ReadUInt16();	//名称文本
			mInfo = br.ReadUInt16();	//说明文本
			PrefabPath = br.ReadString();	//资源
			mEweaponType = (GlobalDefine.EWeaponType)br.ReadUInt16();	//武器类型（Melee  近战，Bow  弓箭，Spells  法术）
			MinAttack = br.ReadUInt16();	//最低攻击
			MaxAttack = br.ReadUInt16();	//最高攻击
			mEAttackTarget = (GlobalDefine.EAttackTarget)br.ReadUInt16();	//攻击目标（Enemy敌，Self我）
			mEAttackType = (GlobalDefine.EAttackType)br.ReadUInt16();	//攻击类型（OnePlayer 单体，Range范围）
			AttackAngle = br.ReadUInt16();	//攻击角度（以队伍行进方向左右各多少度，90即为半圆）
			AttackDistance = br.ReadUInt16();	//攻击距离
			BeShaking = br.ReadUInt16();	//攻击前摇s
			AfShaking = br.ReadUInt16();	//攻击后摇
			NormalBuffPath = br.ReadString();	//默认动画
			BuffID = br.ReadUInt16();	//buff
			BallisticBuffPath = br.ReadString();	//弹道动画
			BulletNum = br.ReadUInt16();	//子弹数量
			EBallisticType = (GlobalDefine.EBallisticType)br.ReadUInt16();	//弹道类型（Line 直线，Track  追踪，Parabola  抛物线）
			BallisticSpeed = br.ReadUInt16();	//弹道速度
			mIsEDeathExplosion = br.ReadBoolean();	//死亡爆破（False 否，True 是）
			BlastingRange = br.ReadUInt16();	//爆破半径
			BlastingHurt = br.ReadUInt16();	//爆破伤害
			BlastingBuffPath = br.ReadString();	//爆破动画
			
        }
    } 
} 