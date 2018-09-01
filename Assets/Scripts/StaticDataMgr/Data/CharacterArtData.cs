using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace StaticData.Data
{
    public class CharacterArtData : BaseDataObject
    {
        
		public string PrefabName = "";	//预制体名称
		public ushort[] Rect = new ushort[4];	//身体体积Rect
		public string JoinEffectName = "";	//入队特效名称
		public string JoinAudioName = "";	//入队音效名称
		public string MoveEffectName = "";	//移动特效名称
		public string HelpEffectName = "";	//求救特效名称
		public string CrashEffectName = "";	//碰撞特效名称
		public string ReviveEffectName = "";	//复活特效名称
		public string InjuryEffectNames = "";	//受击特效名称， 多个
		public string InjuryAudioName = "";	//受击音效名称名称
		public string DeadEffectName = "";	//死亡特效名称
		public string DeadAudioName = "";	//死亡音效名称
		public string DispearEffectName = "";	//消失特效名称
		public string RestoryEffectName = "";	//回复特效名称
		public string RestoryAudioName = "";	//回复音效名称
		public string DropEffectName = "";	//掉落特效
		public string TurnUpEffectName = "";	//出场特效名称
		
        public override void ReadFromStream(BinaryReader br)
        {
            mID = br.ReadUInt16();	//ID
			PrefabName = br.ReadString();	//预制体名称
			ushort cnt4_3 = br.ReadUInt16();
			for(ushort i = 0; i < cnt4_3; i++)
				Rect[i] = br.ReadUInt16();	//身体体积Rect
			JoinEffectName = br.ReadString();	//入队特效名称
			JoinAudioName = br.ReadString();	//入队音效名称
			MoveEffectName = br.ReadString();	//移动特效名称
			HelpEffectName = br.ReadString();	//求救特效名称
			CrashEffectName = br.ReadString();	//碰撞特效名称
			ReviveEffectName = br.ReadString();	//复活特效名称
			InjuryEffectNames = br.ReadString();	//受击特效名称， 多个
			InjuryAudioName = br.ReadString();	//受击音效名称名称
			DeadEffectName = br.ReadString();	//死亡特效名称
			DeadAudioName = br.ReadString();	//死亡音效名称
			DispearEffectName = br.ReadString();	//消失特效名称
			RestoryEffectName = br.ReadString();	//回复特效名称
			RestoryAudioName = br.ReadString();	//回复音效名称
			DropEffectName = br.ReadString();	//掉落特效
			TurnUpEffectName = br.ReadString();	//出场特效名称
			
        }
    } 
} 