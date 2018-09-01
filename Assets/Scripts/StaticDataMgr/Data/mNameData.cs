using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace StaticData.Data
{
    public class mNameData : BaseDataObject
    {
        
		public string mPartOne = "";	//组合一
		public string mPartTwo = "";	//组合二
		
        public override void ReadFromStream(BinaryReader br)
        {
            mID = br.ReadUInt16();	//ID
			mPartOne = br.ReadString();	//组合一
			mPartTwo = br.ReadString();	//组合二
			
        }
    } 
} 