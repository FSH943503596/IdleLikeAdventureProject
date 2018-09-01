using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace StaticData.Data
{
    public class TerrainsData : BaseDataObject
    {
        
		public ushort mMapName = 0;	//名称文本
		public ushort mInfo = 0;	//说明文本
		public string PrefabPath = "";	//资源
		public ushort IsThough = 0;	//能否穿过
		public ushort IsDestory = 0;	//能否破坏
		public ushort ObjHeath = 0;	//生命值
		public ushort[] BuffID = new ushort[3];	//接触时buff（多个）
		
        public override void ReadFromStream(BinaryReader br)
        {
            mID = br.ReadUInt16();	//ID
			mMapName = br.ReadUInt16();	//名称文本
			mInfo = br.ReadUInt16();	//说明文本
			PrefabPath = br.ReadString();	//资源
			IsThough = br.ReadUInt16();	//能否穿过
			IsDestory = br.ReadUInt16();	//能否破坏
			ObjHeath = br.ReadUInt16();	//生命值
			ushort cnt3_8 = br.ReadUInt16();
			for(ushort i = 0; i < cnt3_8; i++)
				BuffID[i] = br.ReadUInt16();	//接触时buff（多个）
			
        }
    } 
} 