using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace StaticData.Data
{
    public class StringData : BaseDataObject
    {
        
		public string mCHname = "";	//中文
		public string mEnName = "";	//英文
		
        public override void ReadFromStream(BinaryReader br)
        {
            mID = br.ReadUInt16();	//ID
			mCHname = br.ReadString();	//中文
			mEnName = br.ReadString();	//英文
			
        }
    } 
} 