using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace StaticData.Data
{
    public class DropData : BaseDataObject
    {
        
		public string mName = "";	//名称 
		public float ExtraChance = 0;	//额外掉落几率（先判断成功掉落后再判断后面的掉落道具）
		public ushort ExtraCount = 0;	//最大额外掉落判断次数（从1到最大值随机）
		public ushort DropOneID = 0;	//掉落1
		public ushort DropOneCount = 0;	//掉落1数量
		public float DropOneChance = 0;	//掉落1几率
		public ushort DropTwoID = 0;	//掉落2
		public ushort DropTwoCount = 0;	//掉落2数量
		public float DropTwoChance = 0;	//掉落2几率
		public ushort DropThreeID = 0;	//掉落3
		public ushort DropThreeCount = 0;	//掉落3数量
		public float DropThreeChance = 0;	//掉落3几率
		public ushort DropFourID = 0;	//掉落4
		public ushort DropFourCount = 0;	//掉落4数量
		public float DropFourChance = 0;	//掉落4几率
		public ushort DropFiveID = 0;	//掉落5
		public ushort DropFiveCount = 0;	//掉落5数量
		public float DropFiveChance = 0;	//掉落5几率
		public ushort DropSixID = 0;	//掉落6
		public ushort DropSixCount = 0;	//掉落6数量
		public float DropSixChance = 0;	//掉落6几率
		public ushort DropSevenID = 0;	//掉落7
		public ushort DropSevenCount = 0;	//掉落7数量
		public ushort DropSevenChance = 0;	//掉落7几率
		public ushort DropEightID = 0;	//掉落8
		public ushort DropEightCount = 0;	//掉落8数量
		public float DropEightChance = 0;	//掉落8几率
		public ushort DropNineID = 0;	//掉落9
		public ushort DropNineCount = 0;	//掉落9数量
		public float DropNineChance = 0;	//掉落9几率
		
        public override void ReadFromStream(BinaryReader br)
        {
            mID = br.ReadUInt16();	//ID
			mName = br.ReadString();	//名称 
			ExtraChance = br.ReadSingle();	//额外掉落几率（先判断成功掉落后再判断后面的掉落道具）
			ExtraCount = br.ReadUInt16();	//最大额外掉落判断次数（从1到最大值随机）
			DropOneID = br.ReadUInt16();	//掉落1
			DropOneCount = br.ReadUInt16();	//掉落1数量
			DropOneChance = br.ReadSingle();	//掉落1几率
			DropTwoID = br.ReadUInt16();	//掉落2
			DropTwoCount = br.ReadUInt16();	//掉落2数量
			DropTwoChance = br.ReadSingle();	//掉落2几率
			DropThreeID = br.ReadUInt16();	//掉落3
			DropThreeCount = br.ReadUInt16();	//掉落3数量
			DropThreeChance = br.ReadSingle();	//掉落3几率
			DropFourID = br.ReadUInt16();	//掉落4
			DropFourCount = br.ReadUInt16();	//掉落4数量
			DropFourChance = br.ReadSingle();	//掉落4几率
			DropFiveID = br.ReadUInt16();	//掉落5
			DropFiveCount = br.ReadUInt16();	//掉落5数量
			DropFiveChance = br.ReadSingle();	//掉落5几率
			DropSixID = br.ReadUInt16();	//掉落6
			DropSixCount = br.ReadUInt16();	//掉落6数量
			DropSixChance = br.ReadSingle();	//掉落6几率
			DropSevenID = br.ReadUInt16();	//掉落7
			DropSevenCount = br.ReadUInt16();	//掉落7数量
			DropSevenChance = br.ReadUInt16();	//掉落7几率
			DropEightID = br.ReadUInt16();	//掉落8
			DropEightCount = br.ReadUInt16();	//掉落8数量
			DropEightChance = br.ReadSingle();	//掉落8几率
			DropNineID = br.ReadUInt16();	//掉落9
			DropNineCount = br.ReadUInt16();	//掉落9数量
			DropNineChance = br.ReadSingle();	//掉落9几率
			
        }
    } 
} 