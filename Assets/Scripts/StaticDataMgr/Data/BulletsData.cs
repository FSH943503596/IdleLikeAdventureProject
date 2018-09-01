using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace StaticData.Data
{
    public class BulletsData : BaseDataObject
    {
        
		public string PrefabName = "";	//预制体名称
		public int Speed = 0;	//速度(1格子 = 100)
		public string ICON = "";	//贴图
		
        public override void ReadFromStream(BinaryReader br)
        {
            mID = br.ReadUInt16();	//ID
			PrefabName = br.ReadString();	//预制体名称
			Speed = br.ReadInt32();	//速度(1格子 = 100)
			ICON = br.ReadString();	//贴图
			
        }
    } 
} 