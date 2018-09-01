using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace StaticData.Data
{
    public class StagesData : BaseDataObject
    {
        
		public GlobalDefine.Label mLableType;	//页签
		public GlobalDefine.Classify mClassType;	//类型：
		public ushort[] mItem = new ushort[5];	//包含stage id
		public ushort isOnOrFalse = 0;	//默认开启
		public ushort mUnlock = 0;	//解锁关卡
		public ushort mTitleID = 0;	//标题id
		public string mHeadIcon = "";	//boss头像
		public ushort mHard = 0;	//关卡难度
		public string mOpenTime = "";	//开放时间
		public string mCloseTime = "";	//结束时间
		public string mCondition = "";	//进入条件
		public string mLevelTask = "";	//关卡任务12345（Task表）
		
        public override void ReadFromStream(BinaryReader br)
        {
            mID = br.ReadUInt16();	//ID
			mLableType = (GlobalDefine.Label)br.ReadUInt16();	//页签
			mClassType = (GlobalDefine.Classify)br.ReadUInt16();	//类型：
			ushort cnt5_3 = br.ReadUInt16();
			for(ushort i = 0; i < cnt5_3; i++)
				mItem[i] = br.ReadUInt16();	//包含stage id
			isOnOrFalse = br.ReadUInt16();	//默认开启
			mUnlock = br.ReadUInt16();	//解锁关卡
			mTitleID = br.ReadUInt16();	//标题id
			mHeadIcon = br.ReadString();	//boss头像
			mHard = br.ReadUInt16();	//关卡难度
			mOpenTime = br.ReadString();	//开放时间
			mCloseTime = br.ReadString();	//结束时间
			mCondition = br.ReadString();	//进入条件
			mLevelTask = br.ReadString();	//关卡任务12345（Task表）
			
        }
    } 
} 