using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace StaticData.Data
{
    public class BuffData : BaseDataObject
    {
        
		public ushort mBuffName = 0;	//名称文本
		public ushort mBuffInfoID = 0;	//说明文本
		public string mBuffPath = "";	//特效
		public ushort mBuffRange = 0;	//范围（0单体，1全队）
		public ushort HeathVariety = 0;	//生命变化%
		public int HeathNum = 0;	//生命变化值
		public ushort HeathTime = 0;	//持续时间s（0一次性）
		public int SpeedVariety = 0;	//速度变化%
		public int SpeedNum = 0;	//速度变化值
		public ushort SpeedTime = 0;	//持续时间
		public ushort AttackVariety = 0;	//攻击变化%
		public int AttackNum = 0;	//攻击变化值
		public ushort AttackTime = 0;	//持续时间
		public ushort AbnormalVariety = 0;	//异常状态
		public ushort AbnormalTime = 0;	//持续时间
		public ushort RevivalCount = 0;	//复活数量
		public ushort RevivalHeath = 0;	//复活血量%
		
        public override void ReadFromStream(BinaryReader br)
        {
            mID = br.ReadUInt16();	//ID
			mBuffName = br.ReadUInt16();	//名称文本
			mBuffInfoID = br.ReadUInt16();	//说明文本
			mBuffPath = br.ReadString();	//特效
			mBuffRange = br.ReadUInt16();	//范围（0单体，1全队）
			HeathVariety = br.ReadUInt16();	//生命变化%
			HeathNum = br.ReadInt32();	//生命变化值
			HeathTime = br.ReadUInt16();	//持续时间s（0一次性）
			SpeedVariety = br.ReadInt32();	//速度变化%
			SpeedNum = br.ReadInt32();	//速度变化值
			SpeedTime = br.ReadUInt16();	//持续时间
			AttackVariety = br.ReadUInt16();	//攻击变化%
			AttackNum = br.ReadInt32();	//攻击变化值
			AttackTime = br.ReadUInt16();	//持续时间
			AbnormalVariety = br.ReadUInt16();	//异常状态
			AbnormalTime = br.ReadUInt16();	//持续时间
			RevivalCount = br.ReadUInt16();	//复活数量
			RevivalHeath = br.ReadUInt16();	//复活血量%
			
        }
    } 
} 