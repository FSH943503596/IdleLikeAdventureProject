using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace StaticData.Data
{
    public class EnemyData : BaseDataObject
    {
        
		public ushort mEnemyName = 0;	//名称文本
		public ushort mInfo = 0;	//说明文本
		public string PrefabPath = "";	//资源
		public string AudioPath = "";	//语音（多个）
		public ushort WeaponID = 0;	//默认武器
		public ushort MoveSpeed = 0;	//速度
		public ushort mHeath = 0;	//生命
		public ushort mAttack = 0;	//攻击
		public ushort NearDefense = 0;	//近战防御
		public ushort BowDefense = 0;	//弓箭防御
		public ushort SpellsDefense = 0;	//法术防御
		public ushort NormalBuff = 0;	//自带buff
		public ushort BuffProbablity = 0;	//buff几率
		public ushort DropObjOne = 0;	//必掉道具1
		public ushort DropObjOneCount = 0;	//必掉道具1数量
		public ushort DropObjTwo = 0;	//必掉道具2
		public ushort DropObjTwoCount = 0;	//必掉道具2数量
		public ushort ExtarDropID = 0;	//额外掉落
		
        public override void ReadFromStream(BinaryReader br)
        {
            mID = br.ReadUInt16();	//ID
			mEnemyName = br.ReadUInt16();	//名称文本
			mInfo = br.ReadUInt16();	//说明文本
			PrefabPath = br.ReadString();	//资源
			AudioPath = br.ReadString();	//语音（多个）
			WeaponID = br.ReadUInt16();	//默认武器
			MoveSpeed = br.ReadUInt16();	//速度
			mHeath = br.ReadUInt16();	//生命
			mAttack = br.ReadUInt16();	//攻击
			NearDefense = br.ReadUInt16();	//近战防御
			BowDefense = br.ReadUInt16();	//弓箭防御
			SpellsDefense = br.ReadUInt16();	//法术防御
			NormalBuff = br.ReadUInt16();	//自带buff
			BuffProbablity = br.ReadUInt16();	//buff几率
			DropObjOne = br.ReadUInt16();	//必掉道具1
			DropObjOneCount = br.ReadUInt16();	//必掉道具1数量
			DropObjTwo = br.ReadUInt16();	//必掉道具2
			DropObjTwoCount = br.ReadUInt16();	//必掉道具2数量
			ExtarDropID = br.ReadUInt16();	//额外掉落
			
        }
    } 
} 