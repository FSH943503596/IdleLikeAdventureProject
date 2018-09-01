using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.IO;
using System;
using StaticData;
using System.Reflection;
using GlobalDefine;
using StaticData.Data;
using UnityEngine;
using StaticDataTool;

namespace StaticData
{
    public class StaticDataMgr
    {
        private static StaticDataMgr instance = null;
        public static StaticDataMgr mInstance
        {
            get
            {
                if (instance == null)
                    instance = new StaticDataMgr();
                return instance;
            }
            protected set { instance = value; }
        }

        // *************				data	 	***************
		public Dictionary<ushort, AbilityData> mAbilityDataMap = new Dictionary<ushort, AbilityData>(); //Ability Data
		public Dictionary<ushort, AbilityActiveData> mAbilityActiveDataMap = new Dictionary<ushort, AbilityActiveData>(); //AbilityActive Data
		public Dictionary<ushort, AbilityPassiveData> mAbilityPassiveDataMap = new Dictionary<ushort, AbilityPassiveData>(); //AbilityPassive Data
		public Dictionary<ushort, BuffData> mBuffDataMap = new Dictionary<ushort, BuffData>(); //Buff Data
		public Dictionary<ushort, BulletsData> mBulletsDataMap = new Dictionary<ushort, BulletsData>(); //Bullets Data
		public Dictionary<ushort, CharacterData> mCharacterDataMap = new Dictionary<ushort, CharacterData>(); //Character Data
		public Dictionary<ushort, CharacterArtData> mCharacterArtDataMap = new Dictionary<ushort, CharacterArtData>(); //CharacterArt Data
		public Dictionary<ushort, DropData> mDropDataMap = new Dictionary<ushort, DropData>(); //Drop Data
		public Dictionary<ushort, EnemyData> mEnemyDataMap = new Dictionary<ushort, EnemyData>(); //Enemy Data
		public Dictionary<ushort, ItemData> mItemDataMap = new Dictionary<ushort, ItemData>(); //Item Data
		public Dictionary<ushort, LevelData> mLevelDataMap = new Dictionary<ushort, LevelData>(); //Level Data
		public Dictionary<ushort, mNameData> mmNameDataMap = new Dictionary<ushort, mNameData>(); //mName Data
		public Dictionary<ushort, RespawnData> mRespawnDataMap = new Dictionary<ushort, RespawnData>(); //Respawn Data
		public Dictionary<ushort, SkillData> mSkillDataMap = new Dictionary<ushort, SkillData>(); //Skill Data
		public Dictionary<ushort, StagesData> mStagesDataMap = new Dictionary<ushort, StagesData>(); //Stages Data
		public Dictionary<ushort, StringData> mStringDataMap = new Dictionary<ushort, StringData>(); //String Data
		public Dictionary<ushort, TasksData> mTasksDataMap = new Dictionary<ushort, TasksData>(); //Tasks Data
		public Dictionary<ushort, TempStageData> mTempStageDataMap = new Dictionary<ushort, TempStageData>(); //TempStage Data
		public Dictionary<ushort, TerrainsData> mTerrainsDataMap = new Dictionary<ushort, TerrainsData>(); //Terrains Data
		public Dictionary<ushort, WeaponsData> mWeaponsDataMap = new Dictionary<ushort, WeaponsData>(); //Weapons Data

        //加载数据
        public void LoadData()
        {
			LoadDataBinWorker<AbilityData>("Ability.bytes", mAbilityDataMap); //Ability Data
			LoadDataBinWorker<AbilityActiveData>("AbilityActive.bytes", mAbilityActiveDataMap); //AbilityActive Data
			LoadDataBinWorker<AbilityPassiveData>("AbilityPassive.bytes", mAbilityPassiveDataMap); //AbilityPassive Data
			LoadDataBinWorker<BuffData>("Buff.bytes", mBuffDataMap); //Buff Data
			LoadDataBinWorker<BulletsData>("Bullets.bytes", mBulletsDataMap); //Bullets Data
			LoadDataBinWorker<CharacterData>("Character.bytes", mCharacterDataMap); //Character Data
			LoadDataBinWorker<CharacterArtData>("CharacterArt.bytes", mCharacterArtDataMap); //CharacterArt Data
			LoadDataBinWorker<DropData>("Drop.bytes", mDropDataMap); //Drop Data
			LoadDataBinWorker<EnemyData>("Enemy.bytes", mEnemyDataMap); //Enemy Data
			LoadDataBinWorker<ItemData>("Item.bytes", mItemDataMap); //Item Data
			LoadDataBinWorker<LevelData>("Level.bytes", mLevelDataMap); //Level Data
			LoadDataBinWorker<mNameData>("mName.bytes", mmNameDataMap); //mName Data
			LoadDataBinWorker<RespawnData>("Respawn.bytes", mRespawnDataMap); //Respawn Data
			LoadDataBinWorker<SkillData>("Skill.bytes", mSkillDataMap); //Skill Data
			LoadDataBinWorker<StagesData>("Stages.bytes", mStagesDataMap); //Stages Data
			LoadDataBinWorker<StringData>("String.bytes", mStringDataMap); //String Data
			LoadDataBinWorker<TasksData>("Tasks.bytes", mTasksDataMap); //Tasks Data
			LoadDataBinWorker<TempStageData>("TempStage.bytes", mTempStageDataMap); //TempStage Data
			LoadDataBinWorker<TerrainsData>("Terrains.bytes", mTerrainsDataMap); //Terrains Data
			LoadDataBinWorker<WeaponsData>("Weapons.bytes", mWeaponsDataMap); //Weapons Data

						
			//定义如型： void SheetNameDataProcess(ClassType data) 的函数, 会被自动调用

            //设置进度
            Console.WriteLine("Read All Data Done!");
        }

        //根据指定的数据文件名，创建流。 参数格式：“Strings.bytes”
        private Stream OpenBinDataFile(string filename)
        {//
			TextAsset binDataAsset = Resources.Load(FolderCfg.BinFolder() + filename.Substring(0, filename.Length - 6)) as TextAsset;
            return FileDes.DecryptDataToStream(binDataAsset.bytes);
        }

        void LoadDataBinWorker<ClassType>(string filename, object dic, Action<ClassType> process = null) where ClassType : BaseDataObject, new()
        {
            Dictionary<ushort, ClassType> dataMap = dic as Dictionary<ushort, ClassType>;

            BinaryReader br = null;
            Stream ds = OpenBinDataFile(filename);
            br = new BinaryReader(ds);
            try
            {
                while (true)
                {
                    ClassType tNewData = new ClassType();
                    tNewData.ReadFromStream(br);
                    dataMap.Add(tNewData.mID, tNewData);
                    if (process != null)
                    {
                        process(tNewData);
                    }
                }
            }
            catch (EndOfStreamException)
            {
                Console.WriteLine(filename + "Load Data Done");
            }
            catch (IOException e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                br.Close();
                FileDes.CloseStream();
            }
            return;
        }
    }//class
    //数据结构基类
    public abstract class BaseDataObject
    {
        public ushort mID = 0; // ID
        public abstract void ReadFromStream(BinaryReader br);
    }
    
  /*  public class StringMgr
    {
        enum ELanguage
        {
            English,
            S_Chinese,
            T_Chinese
        }
        static bool mInitialized = false;
        static ELanguage mLanguage = ELanguage.English;
        static void Initialize()
        {
            mInitialized = true;
            if(Application.systemLanguage == SystemLanguage.ChineseSimplified)
                mLanguage = ELanguage.S_Chinese;
            else if(Application.systemLanguage == SystemLanguage.ChineseTraditional)
                mLanguage = ELanguage.T_Chinese;
            else
                mLanguage = ELanguage.English;
        }
        //查找字符串数据
        public static string Get(ushort strID)
        {
            if(mInitialized == false)
                Initialize();
            if(StaticDataMgr.mInstance.mStringsDataMap.ContainsKey(strID) == false)
                return "";
            return StaticDataMgr.mInstance.mStringsDataMap[strID].mStrings[(int)mLanguage];
        }
        public static bool IsChinese
        {
            get{
                if(mInitialized == false)
                    Initialize();
                return (mLanguage == ELanguage.S_Chinese || mLanguage == ELanguage.T_Chinese);
            }
        }
    }
*/
}


