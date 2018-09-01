using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace StaticData.Data
{
    public class TasksData : BaseDataObject
    {
        
		public string mName = "";	//任务名称
		public ushort mTaskDes = 0;	//任务说明
		public GlobalDefine.TaskType mTaskType;	//任务类型
		public bool IsActive = false;	//是否默认开启
		public GlobalDefine.TaskObjectType mTaskObjectType;	//任务目标类型
		public ushort mSuccessorTask = 0;	//后续任务
		public GlobalDefine.TaskFinshedJudge mTaskFinshedJudge;	//完成任务判断
		public ushort ParameterID = 0;	//参数a
		public float mParameterNums = 0;	//参数数量
		public float curNums = 0;	//当前数量
		public ushort AwardOne = 0;	//奖励道具一
		public int CountOne = 0;	//数量一
		public ushort AwardTwo = 0;	//奖励道具二
		public int CountTwo = 0;	//数量二
		public ushort AwardThree = 0;	//奖励道具一
		public int CountThree = 0;	//数量一
		
        public override void ReadFromStream(BinaryReader br)
        {
            mID = br.ReadUInt16();	//任务ID
			mName = br.ReadString();	//任务名称
			mTaskDes = br.ReadUInt16();	//任务说明
			mTaskType = (GlobalDefine.TaskType)br.ReadUInt16();	//任务类型
			IsActive = br.ReadBoolean();	//是否默认开启
			mTaskObjectType = (GlobalDefine.TaskObjectType)br.ReadUInt16();	//任务目标类型
			mSuccessorTask = br.ReadUInt16();	//后续任务
			mTaskFinshedJudge = (GlobalDefine.TaskFinshedJudge)br.ReadUInt16();	//完成任务判断
			ParameterID = br.ReadUInt16();	//参数a
			mParameterNums = br.ReadSingle();	//参数数量
			curNums = br.ReadSingle();	//当前数量
			AwardOne = br.ReadUInt16();	//奖励道具一
			CountOne = br.ReadInt32();	//数量一
			AwardTwo = br.ReadUInt16();	//奖励道具二
			CountTwo = br.ReadInt32();	//数量二
			AwardThree = br.ReadUInt16();	//奖励道具一
			CountThree = br.ReadInt32();	//数量一
			
        }
    } 
} 