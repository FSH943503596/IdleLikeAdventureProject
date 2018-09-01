using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace StaticData.Data
{
    public class ItemData : BaseDataObject
    {
        
		public string mName = "";	//名称 
		public ushort mItemName = 0;	//名称文本
		public ushort mInfo = 0;	//说明文本
		public string mPicPath = "";	//图片引用名称
		public string PrefabInfo = "";	//资源引用名称
		public int mNums = 0;	//数量
		public int mBuyPrice = 0;	//买入价格
		public int mSellPrice = 0;	//卖出价格
		public GlobalDefine.EItemType mEltemType;	//类型
		public int mMaxCount = 0;	//最大堆叠数
		public ushort ItemBuffID = 0;	//buff
		public ushort Experience = 0;	//经验值
		public ushort FullValue = 0;	//满腹值
		
        public override void ReadFromStream(BinaryReader br)
        {
            mID = br.ReadUInt16();	//ID
			mName = br.ReadString();	//名称 
			mItemName = br.ReadUInt16();	//名称文本
			mInfo = br.ReadUInt16();	//说明文本
			mPicPath = br.ReadString();	//图片引用名称
			PrefabInfo = br.ReadString();	//资源引用名称
			mNums = br.ReadInt32();	//数量
			mBuyPrice = br.ReadInt32();	//买入价格
			mSellPrice = br.ReadInt32();	//卖出价格
			mEltemType = (GlobalDefine.EItemType)br.ReadUInt16();	//类型
			mMaxCount = br.ReadInt32();	//最大堆叠数
			ItemBuffID = br.ReadUInt16();	//buff
			Experience = br.ReadUInt16();	//经验值
			FullValue = br.ReadUInt16();	//满腹值
			
        }
    } 
} 