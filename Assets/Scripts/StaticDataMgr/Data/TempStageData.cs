using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace StaticData.Data
{
    public class TempStageData : BaseDataObject
    {
        
		public ushort[] mStageTaskID = new ushort[5];	//关卡任务ID
		
        public override void ReadFromStream(BinaryReader br)
        {
            mID = br.ReadUInt16();	//关卡ID
			ushort cnt5_1 = br.ReadUInt16();
			for(ushort i = 0; i < cnt5_1; i++)
				mStageTaskID[i] = br.ReadUInt16();	//关卡任务ID
			
        }
    } 
} 