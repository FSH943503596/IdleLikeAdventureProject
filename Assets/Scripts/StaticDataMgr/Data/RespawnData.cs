using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace StaticData.Data
{
    public class RespawnData : BaseDataObject
    {
        
		public ushort RespawnName = 0;	//名称文本
		public ushort mInfo = 0;	//说明文本
		public string PrefabPath = "";	//资源
		public ushort GenerateObjID = 0;	//生成单位（Drop表）
		public ushort GenerateTime = 0;	//生成间隔s
		public ushort GenerateMaxCount = 0;	//最大数量
		public ushort IsReGenerate = 0;	//消失后生成下一个
		
        public override void ReadFromStream(BinaryReader br)
        {
            mID = br.ReadUInt16();	//ID
			RespawnName = br.ReadUInt16();	//名称文本
			mInfo = br.ReadUInt16();	//说明文本
			PrefabPath = br.ReadString();	//资源
			GenerateObjID = br.ReadUInt16();	//生成单位（Drop表）
			GenerateTime = br.ReadUInt16();	//生成间隔s
			GenerateMaxCount = br.ReadUInt16();	//最大数量
			IsReGenerate = br.ReadUInt16();	//消失后生成下一个
			
        }
    } 
} 