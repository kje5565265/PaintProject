/******************************************************************
 Warning : 이 파일은 GDT Compiler를 통해 자동 생성된 파일입니다.
           임의로 수정하지 마시고 Excel파일을 수정해 주세요.
******************************************************************/

using System;
using System.Collections.Generic;
using System.Text;
using FlatBuffers;

namespace GDT
{
	static class Constants
	{
		public const int INT_NULL = int.MaxValue;
		public const long LONG_NULL = long.MaxValue;
		public const float FLOAT_NULL = float.MaxValue;
	}
}
public class CommonGDTManager
{
	public int MajorVersion { get; private set; }
	public int MinorVersion { get; private set; }
	public int UtcOffset { get; private set; }
	public Dictionary<int, List<GDT.AnimationInfoT>> AnimationInfoTable { get; private set; } = new Dictionary<int, List<GDT.AnimationInfoT>>();
	public Dictionary<GDT.CameraMainType, List<GDT.CameraSettingT>> CameraSettingTable { get; private set; } = new Dictionary<GDT.CameraMainType, List<GDT.CameraSettingT>>();
	public Dictionary<int, GDT.CashShopInfoT> CashShopInfoTable { get; private set; } = new Dictionary<int, GDT.CashShopInfoT>();
	public Dictionary<int, GDT.CashShopBaseT> CashShopBaseTable { get; private set; } = new Dictionary<int, GDT.CashShopBaseT>();
	public Dictionary<int, GDT.CashShopProductT> CashShopProductTable { get; private set; } = new Dictionary<int, GDT.CashShopProductT>();
	public Dictionary<int, List<GDT.PeriodPaymentDataT>> PeriodPaymentDataTable { get; private set; } = new Dictionary<int, List<GDT.PeriodPaymentDataT>>();
	public Dictionary<int, GDT.CharacterInfoT> CharacterInfoTable { get; private set; } = new Dictionary<int, GDT.CharacterInfoT>();
	public Dictionary<int, List<GDT.CharacterNpcFunctionT>> CharacterNpcFunctionTable { get; private set; } = new Dictionary<int, List<GDT.CharacterNpcFunctionT>>();
	public Dictionary<int, List<GDT.CharacterCountenanceT>> CharacterCountenanceTable { get; private set; } = new Dictionary<int, List<GDT.CharacterCountenanceT>>();
	public Dictionary<string, GDT.CheatCommandT> CheatCommandTable { get; private set; } = new Dictionary<string, GDT.CheatCommandT>();
	public Dictionary<string, List<GDT.CheatGroupT>> CheatGroupTable { get; private set; } = new Dictionary<string, List<GDT.CheatGroupT>>();
	public Dictionary<GDT.WalletType, GDT.ConnectWalletT> ConnectWalletTable { get; private set; } = new Dictionary<GDT.WalletType, GDT.ConnectWalletT>();
	public Dictionary<int, List<GDT.ContentGuideT>> ContentGuideTable { get; private set; } = new Dictionary<int, List<GDT.ContentGuideT>>();
	public Dictionary<int, GDT.ContentManagerInfoT> ContentManagerInfoTable { get; private set; } = new Dictionary<int, GDT.ContentManagerInfoT>();
	public Dictionary<GDT.ContentMainType, GDT.ContentTopDisplayDataT> ContentTopDisplayDataTable { get; private set; } = new Dictionary<GDT.ContentMainType, GDT.ContentTopDisplayDataT>();
	public Dictionary<GDT.CurrencySubType, GDT.CurrencyInfoT> CurrencyInfoTable { get; private set; } = new Dictionary<GDT.CurrencySubType, GDT.CurrencyInfoT>();
	public Dictionary<GDT.CurrencySubType, GDT.CoinInfoT> CoinInfoTable { get; private set; } = new Dictionary<GDT.CurrencySubType, GDT.CoinInfoT>();
	public Dictionary<int, GDT.PurchaseDataT> PurchaseDataTable { get; private set; } = new Dictionary<int, GDT.PurchaseDataT>();
	public Dictionary<int, GDT.CharacterCustomizingInfoT> CharacterCustomizingInfoTable { get; private set; } = new Dictionary<int, GDT.CharacterCustomizingInfoT>();
	public Dictionary<int, List<GDT.CharacterCustomizingDataT>> CharacterCustomizingDataTable { get; private set; } = new Dictionary<int, List<GDT.CharacterCustomizingDataT>>();
	public Dictionary<short, GDT.CharacterCustomizingDetailT> CharacterCustomizingDetailTable { get; private set; } = new Dictionary<short, GDT.CharacterCustomizingDetailT>();
	public Dictionary<int, GDT.PresetT> PresetTable { get; private set; } = new Dictionary<int, GDT.PresetT>();
	public Dictionary<GDT.CharacterType, List<GDT.CharacterCustomizingBasicT>> CharacterCustomizingBasicTable { get; private set; } = new Dictionary<GDT.CharacterType, List<GDT.CharacterCustomizingBasicT>>();
	public List<GDT.CharacterCustomizingTypeIconT> CharacterCustomizingTypeIconTable { get; private set; } = new List<GDT.CharacterCustomizingTypeIconT>();
	public List<GDT.CharacterCustomizingDivideT> CharacterCustomizingDivideTable { get; private set; } = new List<GDT.CharacterCustomizingDivideT>();
	public Dictionary<int, GDT.EffectT> EffectTable { get; private set; } = new Dictionary<int, GDT.EffectT>();
	public Dictionary<int, GDT.EmotionInfoT> EmotionInfoTable { get; private set; } = new Dictionary<int, GDT.EmotionInfoT>();
	public Dictionary<int, GDT.EntertainContentInfoT> EntertainContentInfoTable { get; private set; } = new Dictionary<int, GDT.EntertainContentInfoT>();
	public Dictionary<int, GDT.EntertainContentHeadsAndTailsT> EntertainContentHeadsAndTailsTable { get; private set; } = new Dictionary<int, GDT.EntertainContentHeadsAndTailsT>();
	public Dictionary<int, GDT.EntertainContentDrawCardT> EntertainContentDrawCardTable { get; private set; } = new Dictionary<int, GDT.EntertainContentDrawCardT>();
	public Dictionary<int, GDT.EntertainContentBingoT> EntertainContentBingoTable { get; private set; } = new Dictionary<int, GDT.EntertainContentBingoT>();
	public Dictionary<int, List<GDT.EntertainContentDialogueT>> EntertainContentDialogueTable { get; private set; } = new Dictionary<int, List<GDT.EntertainContentDialogueT>>();
	public Dictionary<int, List<GDT.EntertainContentRewardT>> EntertainContentRewardTable { get; private set; } = new Dictionary<int, List<GDT.EntertainContentRewardT>>();
	public Dictionary<int, List<GDT.EntertainContentScheduleT>> EntertainContentScheduleTable { get; private set; } = new Dictionary<int, List<GDT.EntertainContentScheduleT>>();
	public Dictionary<int, GDT.EnvironmentInfoT> EnvironmentInfoTable { get; private set; } = new Dictionary<int, GDT.EnvironmentInfoT>();
	public Dictionary<int, List<GDT.EnvironmentNextEnvGroupT>> EnvironmentNextEnvGroupTable { get; private set; } = new Dictionary<int, List<GDT.EnvironmentNextEnvGroupT>>();
	public Dictionary<int, GDT.EventInfoT> EventInfoTable { get; private set; } = new Dictionary<int, GDT.EventInfoT>();
	public Dictionary<int, List<GDT.EventMessageT>> EventMessageTable { get; private set; } = new Dictionary<int, List<GDT.EventMessageT>>();
	public Dictionary<int, GDT.EventObjectT> EventObjectTable { get; private set; } = new Dictionary<int, GDT.EventObjectT>();
	public Dictionary<int, List<GDT.EventDropDataT>> EventDropDataTable { get; private set; } = new Dictionary<int, List<GDT.EventDropDataT>>();
	public Dictionary<int, List<GDT.EventDropPointDataT>> EventDropPointDataTable { get; private set; } = new Dictionary<int, List<GDT.EventDropPointDataT>>();
	public List<GDT.FriendT> FriendTable { get; private set; } = new List<GDT.FriendT>();
	public Dictionary<int, GDT.HoldemInfoT> HoldemInfoTable { get; private set; } = new Dictionary<int, GDT.HoldemInfoT>();
	public Dictionary<int, List<GDT.HoldemScheduleT>> HoldemScheduleTable { get; private set; } = new Dictionary<int, List<GDT.HoldemScheduleT>>();
	public Dictionary<GDT.CurrencySubType, GDT.InventoryInfoT> InventoryInfoTable { get; private set; } = new Dictionary<GDT.CurrencySubType, GDT.InventoryInfoT>();
	public Dictionary<GDT.CurrencySubType, List<GDT.InventoryCategoryT>> InventoryCategoryTable { get; private set; } = new Dictionary<GDT.CurrencySubType, List<GDT.InventoryCategoryT>>();
	public Dictionary<GDT.InventoryCategoryType, List<GDT.InventoryCategoryDetailT>> InventoryCategoryDetailTable { get; private set; } = new Dictionary<GDT.InventoryCategoryType, List<GDT.InventoryCategoryDetailT>>();
	public Dictionary<int, GDT.ItemInfoT> ItemInfoTable { get; private set; } = new Dictionary<int, GDT.ItemInfoT>();
	public Dictionary<GDT.ItemGradeType, GDT.ItemGradeT> ItemGradeTable { get; private set; } = new Dictionary<GDT.ItemGradeType, GDT.ItemGradeT>();
	public Dictionary<int, GDT.ItemEquipT> ItemEquipTable { get; private set; } = new Dictionary<int, GDT.ItemEquipT>();
	public Dictionary<int, List<GDT.ItemResourceT>> ItemResourceTable { get; private set; } = new Dictionary<int, List<GDT.ItemResourceT>>();
	public Dictionary<int, GDT.ItemUsingT> ItemUsingTable { get; private set; } = new Dictionary<int, GDT.ItemUsingT>();
	public Dictionary<GDT.ItemSubType, List<GDT.ItemGrowthInfoT>> ItemGrowthInfoTable { get; private set; } = new Dictionary<GDT.ItemSubType, List<GDT.ItemGrowthInfoT>>();
	public Dictionary<GDT.ItemSubType, List<GDT.ItemGrowthDataT>> ItemGrowthDataTable { get; private set; } = new Dictionary<GDT.ItemSubType, List<GDT.ItemGrowthDataT>>();
	public Dictionary<GDT.ItemSubType, List<GDT.ItemOptionDataT>> ItemOptionDataTable { get; private set; } = new Dictionary<GDT.ItemSubType, List<GDT.ItemOptionDataT>>();
	public Dictionary<string, GDT.LanguageUIT> LanguageUITable { get; private set; } = new Dictionary<string, GDT.LanguageUIT>();
	public Dictionary<string, GDT.LanguageItemT> LanguageItemTable { get; private set; } = new Dictionary<string, GDT.LanguageItemT>();
	public Dictionary<string, GDT.LanguageShopT> LanguageShopTable { get; private set; } = new Dictionary<string, GDT.LanguageShopT>();
	public Dictionary<string, GDT.LanguageQuestT> LanguageQuestTable { get; private set; } = new Dictionary<string, GDT.LanguageQuestT>();
	public Dictionary<string, GDT.LanguageSkillT> LanguageSkillTable { get; private set; } = new Dictionary<string, GDT.LanguageSkillT>();
	public Dictionary<int, GDT.NpcSpawnerT> NpcSpawnerTable { get; private set; } = new Dictionary<int, GDT.NpcSpawnerT>();
	public Dictionary<int, GDT.DrawCardT> DrawCardTable { get; private set; } = new Dictionary<int, GDT.DrawCardT>();
	public Dictionary<int, GDT.PortalT> PortalTable { get; private set; } = new Dictionary<int, GDT.PortalT>();
	public Dictionary<int, GDT.ContentOpenObjectT> ContentOpenObjectTable { get; private set; } = new Dictionary<int, GDT.ContentOpenObjectT>();
	public Dictionary<int, List<GDT.LoadingSceneInfoT>> LoadingSceneInfoTable { get; private set; } = new Dictionary<int, List<GDT.LoadingSceneInfoT>>();
	public Dictionary<int, List<GDT.LoadingSceneDataT>> LoadingSceneDataTable { get; private set; } = new Dictionary<int, List<GDT.LoadingSceneDataT>>();
	public Dictionary<int, GDT.MailT> MailTable { get; private set; } = new Dictionary<int, GDT.MailT>();
	public Dictionary<int, GDT.MakingInfoT> MakingInfoTable { get; private set; } = new Dictionary<int, GDT.MakingInfoT>();
	public Dictionary<int, GDT.MakingListDataT> MakingListDataTable { get; private set; } = new Dictionary<int, GDT.MakingListDataT>();
	public Dictionary<int, List<GDT.MakingMaterialDataT>> MakingMaterialDataTable { get; private set; } = new Dictionary<int, List<GDT.MakingMaterialDataT>>();
	public Dictionary<int, GDT.MapInfoT> MapInfoTable { get; private set; } = new Dictionary<int, GDT.MapInfoT>();
	public Dictionary<int, List<GDT.ArrivalSpawnGroupT>> ArrivalSpawnGroupTable { get; private set; } = new Dictionary<int, List<GDT.ArrivalSpawnGroupT>>();
	public Dictionary<int, GDT.WarpT> WarpTable { get; private set; } = new Dictionary<int, GDT.WarpT>();
	public Dictionary<int, GDT.QuestInfoT> QuestInfoTable { get; private set; } = new Dictionary<int, GDT.QuestInfoT>();
	public Dictionary<int, GDT.QuestCompleteT> QuestCompleteTable { get; private set; } = new Dictionary<int, GDT.QuestCompleteT>();
	public Dictionary<int, GDT.MoveEffectInfoT> MoveEffectInfoTable { get; private set; } = new Dictionary<int, GDT.MoveEffectInfoT>();
	public Dictionary<int, List<GDT.NpcAnimationT>> NpcAnimationTable { get; private set; } = new Dictionary<int, List<GDT.NpcAnimationT>>();
	public Dictionary<int, GDT.PetDataT> PetDataTable { get; private set; } = new Dictionary<int, GDT.PetDataT>();
	public Dictionary<int, GDT.PlatformGameInfoT> PlatformGameInfoTable { get; private set; } = new Dictionary<int, GDT.PlatformGameInfoT>();
	public Dictionary<int, List<GDT.PlatformGameStageGroupT>> PlatformGameStageGroupTable { get; private set; } = new Dictionary<int, List<GDT.PlatformGameStageGroupT>>();
	public Dictionary<int, GDT.PlatformGameStageT> PlatformGameStageTable { get; private set; } = new Dictionary<int, GDT.PlatformGameStageT>();
	public Dictionary<int, List<GDT.PlatformGameRewardT>> PlatformGameRewardTable { get; private set; } = new Dictionary<int, List<GDT.PlatformGameRewardT>>();
	public Dictionary<int, List<GDT.PlatformGameScheduleT>> PlatformGameScheduleTable { get; private set; } = new Dictionary<int, List<GDT.PlatformGameScheduleT>>();
	public Dictionary<int, GDT.PlatformGameSeasonT> PlatformGameSeasonTable { get; private set; } = new Dictionary<int, GDT.PlatformGameSeasonT>();
	public Dictionary<int, List<GDT.PlatformGameSeasonRewardT>> PlatformGameSeasonRewardTable { get; private set; } = new Dictionary<int, List<GDT.PlatformGameSeasonRewardT>>();
	public Dictionary<int, GDT.PlatformGamePoseT> PlatformGamePoseTable { get; private set; } = new Dictionary<int, GDT.PlatformGamePoseT>();
	public Dictionary<int, GDT.PlatformGameObjectT> PlatformGameObjectTable { get; private set; } = new Dictionary<int, GDT.PlatformGameObjectT>();
	public Dictionary<int, GDT.TriggerInfoT> TriggerInfoTable { get; private set; } = new Dictionary<int, GDT.TriggerInfoT>();
	public Dictionary<int, GDT.SpawnTriggerT> SpawnTriggerTable { get; private set; } = new Dictionary<int, GDT.SpawnTriggerT>();
	public Dictionary<int, GDT.AnimationTriggerT> AnimationTriggerTable { get; private set; } = new Dictionary<int, GDT.AnimationTriggerT>();
	public Dictionary<int, GDT.RespawnTriggerT> RespawnTriggerTable { get; private set; } = new Dictionary<int, GDT.RespawnTriggerT>();
	public Dictionary<int, GDT.SkillTriggerT> SkillTriggerTable { get; private set; } = new Dictionary<int, GDT.SkillTriggerT>();
	public Dictionary<int, GDT.TrackTriggerT> TrackTriggerTable { get; private set; } = new Dictionary<int, GDT.TrackTriggerT>();
	public Dictionary<int, GDT.DoorTriggerT> DoorTriggerTable { get; private set; } = new Dictionary<int, GDT.DoorTriggerT>();
	public Dictionary<int, GDT.StandbyPositionParentT> StandbyPositionParentTable { get; private set; } = new Dictionary<int, GDT.StandbyPositionParentT>();
	public Dictionary<int, List<GDT.StandbyPositionInfoT>> StandbyPositionInfoTable { get; private set; } = new Dictionary<int, List<GDT.StandbyPositionInfoT>>();
	public Dictionary<int, GDT.StagePositionInfoT> StagePositionInfoTable { get; private set; } = new Dictionary<int, GDT.StagePositionInfoT>();
	public Dictionary<int, GDT.PGObjectSpawnerT> PGObjectSpawnerTable { get; private set; } = new Dictionary<int, GDT.PGObjectSpawnerT>();
	public Dictionary<int, GDT.PGObjectRandomSpawnerT> PGObjectRandomSpawnerTable { get; private set; } = new Dictionary<int, GDT.PGObjectRandomSpawnerT>();
	public Dictionary<int, List<GDT.PGSpawnerPosGroupT>> PGSpawnerPosGroupTable { get; private set; } = new Dictionary<int, List<GDT.PGSpawnerPosGroupT>>();
	public Dictionary<int, GDT.PGPendulumT> PGPendulumTable { get; private set; } = new Dictionary<int, GDT.PGPendulumT>();
	public Dictionary<int, List<GDT.PGObstacleT>> PGObstacleTable { get; private set; } = new Dictionary<int, List<GDT.PGObstacleT>>();
	public Dictionary<int, GDT.QuestCameraT> QuestCameraTable { get; private set; } = new Dictionary<int, GDT.QuestCameraT>();
	public Dictionary<int, GDT.QuestGroupInfoT> QuestGroupInfoTable { get; private set; } = new Dictionary<int, GDT.QuestGroupInfoT>();
	public Dictionary<int, GDT.QuestTabInfoT> QuestTabInfoTable { get; private set; } = new Dictionary<int, GDT.QuestTabInfoT>();
	public Dictionary<GDT.ReddotMainType, List<GDT.RedDotPositionT>> RedDotPositionTable { get; private set; } = new Dictionary<GDT.ReddotMainType, List<GDT.RedDotPositionT>>();
	public Dictionary<int, List<GDT.RewardDataT>> RewardDataTable { get; private set; } = new Dictionary<int, List<GDT.RewardDataT>>();
	public Dictionary<int, GDT.ScenarioDialogT> ScenarioDialogTable { get; private set; } = new Dictionary<int, GDT.ScenarioDialogT>();
	public Dictionary<int, List<GDT.ScenarioSceneT>> ScenarioSceneTable { get; private set; } = new Dictionary<int, List<GDT.ScenarioSceneT>>();
	public Dictionary<int, GDT.SkillInfoT> SkillInfoTable { get; private set; } = new Dictionary<int, GDT.SkillInfoT>();
	public Dictionary<int, GDT.SkillAnimationDataT> SkillAnimationDataTable { get; private set; } = new Dictionary<int, GDT.SkillAnimationDataT>();
	public Dictionary<int, GDT.SkillEventDataT> SkillEventDataTable { get; private set; } = new Dictionary<int, GDT.SkillEventDataT>();
	public Dictionary<int, GDT.ProjectileT> ProjectileTable { get; private set; } = new Dictionary<int, GDT.ProjectileT>();
	public Dictionary<int, GDT.SkillGrowthGroupT> SkillGrowthGroupTable { get; private set; } = new Dictionary<int, GDT.SkillGrowthGroupT>();
	public Dictionary<int, GDT.BuffInfoT> BuffInfoTable { get; private set; } = new Dictionary<int, GDT.BuffInfoT>();
	public Dictionary<int, List<GDT.BuffDataT>> BuffDataTable { get; private set; } = new Dictionary<int, List<GDT.BuffDataT>>();
	public Dictionary<int, GDT.SlangT> SlangTable { get; private set; } = new Dictionary<int, GDT.SlangT>();
	public Dictionary<int, GDT.SoundT> SoundTable { get; private set; } = new Dictionary<int, GDT.SoundT>();
	public Dictionary<int, GDT.SwapCoinT> SwapCoinTable { get; private set; } = new Dictionary<int, GDT.SwapCoinT>();
	public Dictionary<GDT.CurrencySubType, GDT.SwapCurrencyT> SwapCurrencyTable { get; private set; } = new Dictionary<GDT.CurrencySubType, GDT.SwapCurrencyT>();
	public Dictionary<string, GDT.SystemMessageT> SystemMessageTable { get; private set; } = new Dictionary<string, GDT.SystemMessageT>();
	public Dictionary<GDT.TierType, List<GDT.TierT>> TierTable { get; private set; } = new Dictionary<GDT.TierType, List<GDT.TierT>>();
	public Dictionary<string, GDT.TokenAddressT> TokenAddressTable { get; private set; } = new Dictionary<string, GDT.TokenAddressT>();
	public Dictionary<int, GDT.DevTokenAddressT> DevTokenAddressTable { get; private set; } = new Dictionary<int, GDT.DevTokenAddressT>();
	public Dictionary<int, GDT.QATokenAddressT> QATokenAddressTable { get; private set; } = new Dictionary<int, GDT.QATokenAddressT>();
	public Dictionary<int, GDT.ProductionTokenAddressT> ProductionTokenAddressTable { get; private set; } = new Dictionary<int, GDT.ProductionTokenAddressT>();
	public Dictionary<int, GDT.TreasureLotteryInfoT> TreasureLotteryInfoTable { get; private set; } = new Dictionary<int, GDT.TreasureLotteryInfoT>();
	public Dictionary<int, GDT.TreasureLotteryPatternT> TreasureLotteryPatternTable { get; private set; } = new Dictionary<int, GDT.TreasureLotteryPatternT>();
	public Dictionary<int, GDT.TreasureLotteryItemT> TreasureLotteryItemTable { get; private set; } = new Dictionary<int, GDT.TreasureLotteryItemT>();
	public Dictionary<int, List<GDT.TreasureLotteryRewardT>> TreasureLotteryRewardTable { get; private set; } = new Dictionary<int, List<GDT.TreasureLotteryRewardT>>();
	public Dictionary<int, List<GDT.TreasureLotteryMultiplierT>> TreasureLotteryMultiplierTable { get; private set; } = new Dictionary<int, List<GDT.TreasureLotteryMultiplierT>>();
	public Dictionary<int, GDT.TreasureLotterySeasonT> TreasureLotterySeasonTable { get; private set; } = new Dictionary<int, GDT.TreasureLotterySeasonT>();
	public Dictionary<int, GDT.WorldPositionInfoT> WorldPositionInfoTable { get; private set; } = new Dictionary<int, GDT.WorldPositionInfoT>();
	public GDT.CommonT CommonTable { get; private set; }
	public GDT.EntertainProductionTimeT EntertainProductionTimeTable { get; private set; }
	public GDT.HoldemProductionTimeT HoldemProductionTimeTable { get; private set; }
	
	public void Init(byte[] bytes)
	{
		Dictionary<string, ByteBuffer> byteBufferList = new Dictionary<string, ByteBuffer>();
		{
			Int32 readOffset = 0;
			
			Int32 versionLength = BitConverter.ToInt32(bytes, readOffset);
			readOffset += sizeof(Int32);
			
			byte[] versionBytes = new byte[versionLength];
			Array.Copy(bytes, readOffset, versionBytes, 0, versionLength);
			
			string version = Encoding.Default.GetString(versionBytes);
			readOffset += versionLength;
			
			MajorVersion = Int32.Parse(version.Split('.')[0]);
			MinorVersion = Int32.Parse(version.Split('.')[1]);
			
			Int32 utcOffsetLength = BitConverter.ToInt32(bytes, readOffset);
			readOffset += sizeof(Int32);
			
			byte[] utcOffsetBytes = new byte[utcOffsetLength];
			Array.Copy(bytes, readOffset, utcOffsetBytes, 0, utcOffsetLength);
			
			string utcOffset = Encoding.Default.GetString(utcOffsetBytes);
			readOffset += utcOffsetLength;
			
			UtcOffset = Int32.Parse(utcOffset);
			
			while(readOffset < bytes.Length)
			{
				Int32 nameLength = BitConverter.ToInt32(bytes, readOffset);
				readOffset += sizeof(Int32);
				
				byte[] nameBytes = new byte[nameLength];
				Array.Copy(bytes, readOffset, nameBytes, 0, nameLength);
				
				string name = Encoding.Default.GetString(nameBytes);
				readOffset += nameLength;
				
				Int32 fileLength = BitConverter.ToInt32(bytes, readOffset);
				readOffset += sizeof(Int32);
				
				byte[] fileBytes = new byte[fileLength];
				Array.Copy(bytes, readOffset, fileBytes, 0, fileLength);
				readOffset += fileLength;
				
				ByteBuffer byteBuffer = new ByteBuffer(fileBytes);
				byteBufferList.Add(name, byteBuffer);
			}
		}
		
		{
			GDT.Common table = GDT.Common.GetRootAsCommon(byteBufferList["Common"]);
			CommonTable = table.UnPack();
		}
		{
			GDT.EntertainProductionTime table = GDT.EntertainProductionTime.GetRootAsEntertainProductionTime(byteBufferList["EntertainProductionTime"]);
			EntertainProductionTimeTable = table.UnPack();
		}
		{
			GDT.HoldemProductionTime table = GDT.HoldemProductionTime.GetRootAsHoldemProductionTime(byteBufferList["HoldemProductionTime"]);
			HoldemProductionTimeTable = table.UnPack();
		}
		if(byteBufferList.ContainsKey("AnimationInfo"))
		{
			GDT.AnimationInfoTable table = GDT.AnimationInfoTable.GetRootAsAnimationInfoTable(byteBufferList["AnimationInfo"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.AnimationInfoT tableData = table.Rows(i).Value.UnPack();
				if(false == AnimationInfoTable.ContainsKey(tableData.AnimationID))
				{
					List<GDT.AnimationInfoT> newList = new List<GDT.AnimationInfoT>();
					newList.Add(tableData);
					AnimationInfoTable.Add(tableData.AnimationID, newList);
				}
				else
				{
					AnimationInfoTable[tableData.AnimationID].Add(tableData);
				}
			}
		}
		if(byteBufferList.ContainsKey("CameraSetting"))
		{
			GDT.CameraSettingTable table = GDT.CameraSettingTable.GetRootAsCameraSettingTable(byteBufferList["CameraSetting"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.CameraSettingT tableData = table.Rows(i).Value.UnPack();
				if(false == CameraSettingTable.ContainsKey(tableData.CameraMainTypeID))
				{
					List<GDT.CameraSettingT> newList = new List<GDT.CameraSettingT>();
					newList.Add(tableData);
					CameraSettingTable.Add(tableData.CameraMainTypeID, newList);
				}
				else
				{
					CameraSettingTable[tableData.CameraMainTypeID].Add(tableData);
				}
			}
		}
		if(byteBufferList.ContainsKey("CashShopInfo"))
		{
			GDT.CashShopInfoTable table = GDT.CashShopInfoTable.GetRootAsCashShopInfoTable(byteBufferList["CashShopInfo"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.CashShopInfoT tableData = table.Rows(i).Value.UnPack();
				CashShopInfoTable.Add(tableData.Index, tableData);
			}
		}
		if(byteBufferList.ContainsKey("CashShopBase"))
		{
			GDT.CashShopBaseTable table = GDT.CashShopBaseTable.GetRootAsCashShopBaseTable(byteBufferList["CashShopBase"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.CashShopBaseT tableData = table.Rows(i).Value.UnPack();
				CashShopBaseTable.Add(tableData.Index, tableData);
			}
		}
		if(byteBufferList.ContainsKey("CashShopProduct"))
		{
			GDT.CashShopProductTable table = GDT.CashShopProductTable.GetRootAsCashShopProductTable(byteBufferList["CashShopProduct"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.CashShopProductT tableData = table.Rows(i).Value.UnPack();
				CashShopProductTable.Add(tableData.ProductID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("PeriodPaymentData"))
		{
			GDT.PeriodPaymentDataTable table = GDT.PeriodPaymentDataTable.GetRootAsPeriodPaymentDataTable(byteBufferList["PeriodPaymentData"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.PeriodPaymentDataT tableData = table.Rows(i).Value.UnPack();
				if(false == PeriodPaymentDataTable.ContainsKey(tableData.GroupID))
				{
					List<GDT.PeriodPaymentDataT> newList = new List<GDT.PeriodPaymentDataT>();
					newList.Add(tableData);
					PeriodPaymentDataTable.Add(tableData.GroupID, newList);
				}
				else
				{
					PeriodPaymentDataTable[tableData.GroupID].Add(tableData);
				}
			}
		}
		if(byteBufferList.ContainsKey("CharacterInfo"))
		{
			GDT.CharacterInfoTable table = GDT.CharacterInfoTable.GetRootAsCharacterInfoTable(byteBufferList["CharacterInfo"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.CharacterInfoT tableData = table.Rows(i).Value.UnPack();
				CharacterInfoTable.Add(tableData.CharacterID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("CharacterNpcFunction"))
		{
			GDT.CharacterNpcFunctionTable table = GDT.CharacterNpcFunctionTable.GetRootAsCharacterNpcFunctionTable(byteBufferList["CharacterNpcFunction"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.CharacterNpcFunctionT tableData = table.Rows(i).Value.UnPack();
				if(false == CharacterNpcFunctionTable.ContainsKey(tableData.CharacterID))
				{
					List<GDT.CharacterNpcFunctionT> newList = new List<GDT.CharacterNpcFunctionT>();
					newList.Add(tableData);
					CharacterNpcFunctionTable.Add(tableData.CharacterID, newList);
				}
				else
				{
					CharacterNpcFunctionTable[tableData.CharacterID].Add(tableData);
				}
			}
		}
		if(byteBufferList.ContainsKey("CharacterCountenance"))
		{
			GDT.CharacterCountenanceTable table = GDT.CharacterCountenanceTable.GetRootAsCharacterCountenanceTable(byteBufferList["CharacterCountenance"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.CharacterCountenanceT tableData = table.Rows(i).Value.UnPack();
				if(false == CharacterCountenanceTable.ContainsKey(tableData.CountenanceID))
				{
					List<GDT.CharacterCountenanceT> newList = new List<GDT.CharacterCountenanceT>();
					newList.Add(tableData);
					CharacterCountenanceTable.Add(tableData.CountenanceID, newList);
				}
				else
				{
					CharacterCountenanceTable[tableData.CountenanceID].Add(tableData);
				}
			}
		}
		if(byteBufferList.ContainsKey("CheatCommand"))
		{
			GDT.CheatCommandTable table = GDT.CheatCommandTable.GetRootAsCheatCommandTable(byteBufferList["CheatCommand"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.CheatCommandT tableData = table.Rows(i).Value.UnPack();
				CheatCommandTable.Add(tableData.CheatCommandID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("CheatGroup"))
		{
			GDT.CheatGroupTable table = GDT.CheatGroupTable.GetRootAsCheatGroupTable(byteBufferList["CheatGroup"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.CheatGroupT tableData = table.Rows(i).Value.UnPack();
				if(false == CheatGroupTable.ContainsKey(tableData.CheatGroupID))
				{
					List<GDT.CheatGroupT> newList = new List<GDT.CheatGroupT>();
					newList.Add(tableData);
					CheatGroupTable.Add(tableData.CheatGroupID, newList);
				}
				else
				{
					CheatGroupTable[tableData.CheatGroupID].Add(tableData);
				}
			}
		}
		if(byteBufferList.ContainsKey("ConnectWallet"))
		{
			GDT.ConnectWalletTable table = GDT.ConnectWalletTable.GetRootAsConnectWalletTable(byteBufferList["ConnectWallet"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.ConnectWalletT tableData = table.Rows(i).Value.UnPack();
				ConnectWalletTable.Add(tableData.WalletTypeID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("ContentGuide"))
		{
			GDT.ContentGuideTable table = GDT.ContentGuideTable.GetRootAsContentGuideTable(byteBufferList["ContentGuide"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.ContentGuideT tableData = table.Rows(i).Value.UnPack();
				if(false == ContentGuideTable.ContainsKey(tableData.ContentGuideID))
				{
					List<GDT.ContentGuideT> newList = new List<GDT.ContentGuideT>();
					newList.Add(tableData);
					ContentGuideTable.Add(tableData.ContentGuideID, newList);
				}
				else
				{
					ContentGuideTable[tableData.ContentGuideID].Add(tableData);
				}
			}
		}
		if(byteBufferList.ContainsKey("ContentManagerInfo"))
		{
			GDT.ContentManagerInfoTable table = GDT.ContentManagerInfoTable.GetRootAsContentManagerInfoTable(byteBufferList["ContentManagerInfo"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.ContentManagerInfoT tableData = table.Rows(i).Value.UnPack();
				ContentManagerInfoTable.Add(tableData.Index, tableData);
			}
		}
		if(byteBufferList.ContainsKey("ContentTopDisplayData"))
		{
			GDT.ContentTopDisplayDataTable table = GDT.ContentTopDisplayDataTable.GetRootAsContentTopDisplayDataTable(byteBufferList["ContentTopDisplayData"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.ContentTopDisplayDataT tableData = table.Rows(i).Value.UnPack();
				ContentTopDisplayDataTable.Add(tableData.ContentMainTypeID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("CurrencyInfo"))
		{
			GDT.CurrencyInfoTable table = GDT.CurrencyInfoTable.GetRootAsCurrencyInfoTable(byteBufferList["CurrencyInfo"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.CurrencyInfoT tableData = table.Rows(i).Value.UnPack();
				CurrencyInfoTable.Add(tableData.CurrencySubTypeID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("CoinInfo"))
		{
			GDT.CoinInfoTable table = GDT.CoinInfoTable.GetRootAsCoinInfoTable(byteBufferList["CoinInfo"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.CoinInfoT tableData = table.Rows(i).Value.UnPack();
				CoinInfoTable.Add(tableData.CurrencySubTypeID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("PurchaseData"))
		{
			GDT.PurchaseDataTable table = GDT.PurchaseDataTable.GetRootAsPurchaseDataTable(byteBufferList["PurchaseData"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.PurchaseDataT tableData = table.Rows(i).Value.UnPack();
				PurchaseDataTable.Add(tableData.Index, tableData);
			}
		}
		if(byteBufferList.ContainsKey("CharacterCustomizingInfo"))
		{
			GDT.CharacterCustomizingInfoTable table = GDT.CharacterCustomizingInfoTable.GetRootAsCharacterCustomizingInfoTable(byteBufferList["CharacterCustomizingInfo"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.CharacterCustomizingInfoT tableData = table.Rows(i).Value.UnPack();
				CharacterCustomizingInfoTable.Add(tableData.CharacterID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("CharacterCustomizingData"))
		{
			GDT.CharacterCustomizingDataTable table = GDT.CharacterCustomizingDataTable.GetRootAsCharacterCustomizingDataTable(byteBufferList["CharacterCustomizingData"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.CharacterCustomizingDataT tableData = table.Rows(i).Value.UnPack();
				if(false == CharacterCustomizingDataTable.ContainsKey(tableData.CustomizingMainTypeID))
				{
					List<GDT.CharacterCustomizingDataT> newList = new List<GDT.CharacterCustomizingDataT>();
					newList.Add(tableData);
					CharacterCustomizingDataTable.Add(tableData.CustomizingMainTypeID, newList);
				}
				else
				{
					CharacterCustomizingDataTable[tableData.CustomizingMainTypeID].Add(tableData);
				}
			}
		}
		if(byteBufferList.ContainsKey("CharacterCustomizingDetail"))
		{
			GDT.CharacterCustomizingDetailTable table = GDT.CharacterCustomizingDetailTable.GetRootAsCharacterCustomizingDetailTable(byteBufferList["CharacterCustomizingDetail"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.CharacterCustomizingDetailT tableData = table.Rows(i).Value.UnPack();
				CharacterCustomizingDetailTable.Add(tableData.CustomizingDetailIndex, tableData);
			}
		}
		if(byteBufferList.ContainsKey("Preset"))
		{
			GDT.PresetTable table = GDT.PresetTable.GetRootAsPresetTable(byteBufferList["Preset"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.PresetT tableData = table.Rows(i).Value.UnPack();
				PresetTable.Add(tableData.PresetIndex, tableData);
			}
		}
		if(byteBufferList.ContainsKey("CharacterCustomizingBasic"))
		{
			GDT.CharacterCustomizingBasicTable table = GDT.CharacterCustomizingBasicTable.GetRootAsCharacterCustomizingBasicTable(byteBufferList["CharacterCustomizingBasic"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.CharacterCustomizingBasicT tableData = table.Rows(i).Value.UnPack();
				if(false == CharacterCustomizingBasicTable.ContainsKey(tableData.CharacterType))
				{
					List<GDT.CharacterCustomizingBasicT> newList = new List<GDT.CharacterCustomizingBasicT>();
					newList.Add(tableData);
					CharacterCustomizingBasicTable.Add(tableData.CharacterType, newList);
				}
				else
				{
					CharacterCustomizingBasicTable[tableData.CharacterType].Add(tableData);
				}
			}
		}
		if(byteBufferList.ContainsKey("CharacterCustomizingTypeIcon"))
		{
			GDT.CharacterCustomizingTypeIconTable table = GDT.CharacterCustomizingTypeIconTable.GetRootAsCharacterCustomizingTypeIconTable(byteBufferList["CharacterCustomizingTypeIcon"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.CharacterCustomizingTypeIconT tableData = table.Rows(i).Value.UnPack();
				CharacterCustomizingTypeIconTable.Add(tableData);
			}
		}
		if(byteBufferList.ContainsKey("CharacterCustomizingDivide"))
		{
			GDT.CharacterCustomizingDivideTable table = GDT.CharacterCustomizingDivideTable.GetRootAsCharacterCustomizingDivideTable(byteBufferList["CharacterCustomizingDivide"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.CharacterCustomizingDivideT tableData = table.Rows(i).Value.UnPack();
				CharacterCustomizingDivideTable.Add(tableData);
			}
		}
		if(byteBufferList.ContainsKey("Effect"))
		{
			GDT.EffectTable table = GDT.EffectTable.GetRootAsEffectTable(byteBufferList["Effect"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.EffectT tableData = table.Rows(i).Value.UnPack();
				EffectTable.Add(tableData.EffectID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("EmotionInfo"))
		{
			GDT.EmotionInfoTable table = GDT.EmotionInfoTable.GetRootAsEmotionInfoTable(byteBufferList["EmotionInfo"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.EmotionInfoT tableData = table.Rows(i).Value.UnPack();
				EmotionInfoTable.Add(tableData.Index, tableData);
			}
		}
		if(byteBufferList.ContainsKey("EntertainContentInfo"))
		{
			GDT.EntertainContentInfoTable table = GDT.EntertainContentInfoTable.GetRootAsEntertainContentInfoTable(byteBufferList["EntertainContentInfo"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.EntertainContentInfoT tableData = table.Rows(i).Value.UnPack();
				EntertainContentInfoTable.Add(tableData.EntertainContentID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("EntertainContentHeadsAndTails"))
		{
			GDT.EntertainContentHeadsAndTailsTable table = GDT.EntertainContentHeadsAndTailsTable.GetRootAsEntertainContentHeadsAndTailsTable(byteBufferList["EntertainContentHeadsAndTails"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.EntertainContentHeadsAndTailsT tableData = table.Rows(i).Value.UnPack();
				EntertainContentHeadsAndTailsTable.Add(tableData.HeadsAndTailsID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("EntertainContentDrawCard"))
		{
			GDT.EntertainContentDrawCardTable table = GDT.EntertainContentDrawCardTable.GetRootAsEntertainContentDrawCardTable(byteBufferList["EntertainContentDrawCard"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.EntertainContentDrawCardT tableData = table.Rows(i).Value.UnPack();
				EntertainContentDrawCardTable.Add(tableData.DrawCardID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("EntertainContentBingo"))
		{
			GDT.EntertainContentBingoTable table = GDT.EntertainContentBingoTable.GetRootAsEntertainContentBingoTable(byteBufferList["EntertainContentBingo"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.EntertainContentBingoT tableData = table.Rows(i).Value.UnPack();
				EntertainContentBingoTable.Add(tableData.BingoID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("EntertainContentDialogue"))
		{
			GDT.EntertainContentDialogueTable table = GDT.EntertainContentDialogueTable.GetRootAsEntertainContentDialogueTable(byteBufferList["EntertainContentDialogue"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.EntertainContentDialogueT tableData = table.Rows(i).Value.UnPack();
				if(false == EntertainContentDialogueTable.ContainsKey(tableData.DialogueID))
				{
					List<GDT.EntertainContentDialogueT> newList = new List<GDT.EntertainContentDialogueT>();
					newList.Add(tableData);
					EntertainContentDialogueTable.Add(tableData.DialogueID, newList);
				}
				else
				{
					EntertainContentDialogueTable[tableData.DialogueID].Add(tableData);
				}
			}
		}
		if(byteBufferList.ContainsKey("EntertainContentReward"))
		{
			GDT.EntertainContentRewardTable table = GDT.EntertainContentRewardTable.GetRootAsEntertainContentRewardTable(byteBufferList["EntertainContentReward"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.EntertainContentRewardT tableData = table.Rows(i).Value.UnPack();
				if(false == EntertainContentRewardTable.ContainsKey(tableData.RewardID))
				{
					List<GDT.EntertainContentRewardT> newList = new List<GDT.EntertainContentRewardT>();
					newList.Add(tableData);
					EntertainContentRewardTable.Add(tableData.RewardID, newList);
				}
				else
				{
					EntertainContentRewardTable[tableData.RewardID].Add(tableData);
				}
			}
		}
		if(byteBufferList.ContainsKey("EntertainContentSchedule"))
		{
			GDT.EntertainContentScheduleTable table = GDT.EntertainContentScheduleTable.GetRootAsEntertainContentScheduleTable(byteBufferList["EntertainContentSchedule"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.EntertainContentScheduleT tableData = table.Rows(i).Value.UnPack();
				if(false == EntertainContentScheduleTable.ContainsKey(tableData.ScheduleID))
				{
					List<GDT.EntertainContentScheduleT> newList = new List<GDT.EntertainContentScheduleT>();
					newList.Add(tableData);
					EntertainContentScheduleTable.Add(tableData.ScheduleID, newList);
				}
				else
				{
					EntertainContentScheduleTable[tableData.ScheduleID].Add(tableData);
				}
			}
		}
		if(byteBufferList.ContainsKey("EnvironmentInfo"))
		{
			GDT.EnvironmentInfoTable table = GDT.EnvironmentInfoTable.GetRootAsEnvironmentInfoTable(byteBufferList["EnvironmentInfo"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.EnvironmentInfoT tableData = table.Rows(i).Value.UnPack();
				EnvironmentInfoTable.Add(tableData.EnvironmentID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("EnvironmentNextEnvGroup"))
		{
			GDT.EnvironmentNextEnvGroupTable table = GDT.EnvironmentNextEnvGroupTable.GetRootAsEnvironmentNextEnvGroupTable(byteBufferList["EnvironmentNextEnvGroup"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.EnvironmentNextEnvGroupT tableData = table.Rows(i).Value.UnPack();
				if(false == EnvironmentNextEnvGroupTable.ContainsKey(tableData.NextEnvGroupID))
				{
					List<GDT.EnvironmentNextEnvGroupT> newList = new List<GDT.EnvironmentNextEnvGroupT>();
					newList.Add(tableData);
					EnvironmentNextEnvGroupTable.Add(tableData.NextEnvGroupID, newList);
				}
				else
				{
					EnvironmentNextEnvGroupTable[tableData.NextEnvGroupID].Add(tableData);
				}
			}
		}
		if(byteBufferList.ContainsKey("EventInfo"))
		{
			GDT.EventInfoTable table = GDT.EventInfoTable.GetRootAsEventInfoTable(byteBufferList["EventInfo"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.EventInfoT tableData = table.Rows(i).Value.UnPack();
				EventInfoTable.Add(tableData.EventID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("EventMessage"))
		{
			GDT.EventMessageTable table = GDT.EventMessageTable.GetRootAsEventMessageTable(byteBufferList["EventMessage"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.EventMessageT tableData = table.Rows(i).Value.UnPack();
				if(false == EventMessageTable.ContainsKey(tableData.EventID))
				{
					List<GDT.EventMessageT> newList = new List<GDT.EventMessageT>();
					newList.Add(tableData);
					EventMessageTable.Add(tableData.EventID, newList);
				}
				else
				{
					EventMessageTable[tableData.EventID].Add(tableData);
				}
			}
		}
		if(byteBufferList.ContainsKey("EventObject"))
		{
			GDT.EventObjectTable table = GDT.EventObjectTable.GetRootAsEventObjectTable(byteBufferList["EventObject"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.EventObjectT tableData = table.Rows(i).Value.UnPack();
				EventObjectTable.Add(tableData.ObjectID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("EventDropData"))
		{
			GDT.EventDropDataTable table = GDT.EventDropDataTable.GetRootAsEventDropDataTable(byteBufferList["EventDropData"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.EventDropDataT tableData = table.Rows(i).Value.UnPack();
				if(false == EventDropDataTable.ContainsKey(tableData.EventID))
				{
					List<GDT.EventDropDataT> newList = new List<GDT.EventDropDataT>();
					newList.Add(tableData);
					EventDropDataTable.Add(tableData.EventID, newList);
				}
				else
				{
					EventDropDataTable[tableData.EventID].Add(tableData);
				}
			}
		}
		if(byteBufferList.ContainsKey("EventDropPointData"))
		{
			GDT.EventDropPointDataTable table = GDT.EventDropPointDataTable.GetRootAsEventDropPointDataTable(byteBufferList["EventDropPointData"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.EventDropPointDataT tableData = table.Rows(i).Value.UnPack();
				if(false == EventDropPointDataTable.ContainsKey(tableData.EventID))
				{
					List<GDT.EventDropPointDataT> newList = new List<GDT.EventDropPointDataT>();
					newList.Add(tableData);
					EventDropPointDataTable.Add(tableData.EventID, newList);
				}
				else
				{
					EventDropPointDataTable[tableData.EventID].Add(tableData);
				}
			}
		}
		if(byteBufferList.ContainsKey("Friend"))
		{
			GDT.FriendTable table = GDT.FriendTable.GetRootAsFriendTable(byteBufferList["Friend"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.FriendT tableData = table.Rows(i).Value.UnPack();
				FriendTable.Add(tableData);
			}
		}
		if(byteBufferList.ContainsKey("HoldemInfo"))
		{
			GDT.HoldemInfoTable table = GDT.HoldemInfoTable.GetRootAsHoldemInfoTable(byteBufferList["HoldemInfo"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.HoldemInfoT tableData = table.Rows(i).Value.UnPack();
				HoldemInfoTable.Add(tableData.ID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("HoldemSchedule"))
		{
			GDT.HoldemScheduleTable table = GDT.HoldemScheduleTable.GetRootAsHoldemScheduleTable(byteBufferList["HoldemSchedule"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.HoldemScheduleT tableData = table.Rows(i).Value.UnPack();
				if(false == HoldemScheduleTable.ContainsKey(tableData.ScheduleID))
				{
					List<GDT.HoldemScheduleT> newList = new List<GDT.HoldemScheduleT>();
					newList.Add(tableData);
					HoldemScheduleTable.Add(tableData.ScheduleID, newList);
				}
				else
				{
					HoldemScheduleTable[tableData.ScheduleID].Add(tableData);
				}
			}
		}
		if(byteBufferList.ContainsKey("InventoryInfo"))
		{
			GDT.InventoryInfoTable table = GDT.InventoryInfoTable.GetRootAsInventoryInfoTable(byteBufferList["InventoryInfo"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.InventoryInfoT tableData = table.Rows(i).Value.UnPack();
				InventoryInfoTable.Add(tableData.CurrencySubTypeID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("InventoryCategory"))
		{
			GDT.InventoryCategoryTable table = GDT.InventoryCategoryTable.GetRootAsInventoryCategoryTable(byteBufferList["InventoryCategory"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.InventoryCategoryT tableData = table.Rows(i).Value.UnPack();
				if(false == InventoryCategoryTable.ContainsKey(tableData.GroupID))
				{
					List<GDT.InventoryCategoryT> newList = new List<GDT.InventoryCategoryT>();
					newList.Add(tableData);
					InventoryCategoryTable.Add(tableData.GroupID, newList);
				}
				else
				{
					InventoryCategoryTable[tableData.GroupID].Add(tableData);
				}
			}
		}
		if(byteBufferList.ContainsKey("InventoryCategoryDetail"))
		{
			GDT.InventoryCategoryDetailTable table = GDT.InventoryCategoryDetailTable.GetRootAsInventoryCategoryDetailTable(byteBufferList["InventoryCategoryDetail"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.InventoryCategoryDetailT tableData = table.Rows(i).Value.UnPack();
				if(false == InventoryCategoryDetailTable.ContainsKey(tableData.InventoryCategoryType))
				{
					List<GDT.InventoryCategoryDetailT> newList = new List<GDT.InventoryCategoryDetailT>();
					newList.Add(tableData);
					InventoryCategoryDetailTable.Add(tableData.InventoryCategoryType, newList);
				}
				else
				{
					InventoryCategoryDetailTable[tableData.InventoryCategoryType].Add(tableData);
				}
			}
		}
		if(byteBufferList.ContainsKey("ItemInfo"))
		{
			GDT.ItemInfoTable table = GDT.ItemInfoTable.GetRootAsItemInfoTable(byteBufferList["ItemInfo"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.ItemInfoT tableData = table.Rows(i).Value.UnPack();
				ItemInfoTable.Add(tableData.ItemID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("ItemGrade"))
		{
			GDT.ItemGradeTable table = GDT.ItemGradeTable.GetRootAsItemGradeTable(byteBufferList["ItemGrade"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.ItemGradeT tableData = table.Rows(i).Value.UnPack();
				ItemGradeTable.Add(tableData.ItemGradeTypeID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("ItemEquip"))
		{
			GDT.ItemEquipTable table = GDT.ItemEquipTable.GetRootAsItemEquipTable(byteBufferList["ItemEquip"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.ItemEquipT tableData = table.Rows(i).Value.UnPack();
				ItemEquipTable.Add(tableData.ItemID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("ItemResource"))
		{
			GDT.ItemResourceTable table = GDT.ItemResourceTable.GetRootAsItemResourceTable(byteBufferList["ItemResource"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.ItemResourceT tableData = table.Rows(i).Value.UnPack();
				if(false == ItemResourceTable.ContainsKey(tableData.ItemID))
				{
					List<GDT.ItemResourceT> newList = new List<GDT.ItemResourceT>();
					newList.Add(tableData);
					ItemResourceTable.Add(tableData.ItemID, newList);
				}
				else
				{
					ItemResourceTable[tableData.ItemID].Add(tableData);
				}
			}
		}
		if(byteBufferList.ContainsKey("ItemUsing"))
		{
			GDT.ItemUsingTable table = GDT.ItemUsingTable.GetRootAsItemUsingTable(byteBufferList["ItemUsing"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.ItemUsingT tableData = table.Rows(i).Value.UnPack();
				ItemUsingTable.Add(tableData.ItemID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("ItemGrowthInfo"))
		{
			GDT.ItemGrowthInfoTable table = GDT.ItemGrowthInfoTable.GetRootAsItemGrowthInfoTable(byteBufferList["ItemGrowthInfo"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.ItemGrowthInfoT tableData = table.Rows(i).Value.UnPack();
				if(false == ItemGrowthInfoTable.ContainsKey(tableData.GroupID))
				{
					List<GDT.ItemGrowthInfoT> newList = new List<GDT.ItemGrowthInfoT>();
					newList.Add(tableData);
					ItemGrowthInfoTable.Add(tableData.GroupID, newList);
				}
				else
				{
					ItemGrowthInfoTable[tableData.GroupID].Add(tableData);
				}
			}
		}
		if(byteBufferList.ContainsKey("ItemGrowthData"))
		{
			GDT.ItemGrowthDataTable table = GDT.ItemGrowthDataTable.GetRootAsItemGrowthDataTable(byteBufferList["ItemGrowthData"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.ItemGrowthDataT tableData = table.Rows(i).Value.UnPack();
				if(false == ItemGrowthDataTable.ContainsKey(tableData.GroupID))
				{
					List<GDT.ItemGrowthDataT> newList = new List<GDT.ItemGrowthDataT>();
					newList.Add(tableData);
					ItemGrowthDataTable.Add(tableData.GroupID, newList);
				}
				else
				{
					ItemGrowthDataTable[tableData.GroupID].Add(tableData);
				}
			}
		}
		if(byteBufferList.ContainsKey("ItemOptionData"))
		{
			GDT.ItemOptionDataTable table = GDT.ItemOptionDataTable.GetRootAsItemOptionDataTable(byteBufferList["ItemOptionData"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.ItemOptionDataT tableData = table.Rows(i).Value.UnPack();
				if(false == ItemOptionDataTable.ContainsKey(tableData.GroupID))
				{
					List<GDT.ItemOptionDataT> newList = new List<GDT.ItemOptionDataT>();
					newList.Add(tableData);
					ItemOptionDataTable.Add(tableData.GroupID, newList);
				}
				else
				{
					ItemOptionDataTable[tableData.GroupID].Add(tableData);
				}
			}
		}
		if(byteBufferList.ContainsKey("LanguageUI"))
		{
			GDT.LanguageUITable table = GDT.LanguageUITable.GetRootAsLanguageUITable(byteBufferList["LanguageUI"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.LanguageUIT tableData = table.Rows(i).Value.UnPack();
				LanguageUITable.Add(tableData.StringKey, tableData);
			}
		}
		if(byteBufferList.ContainsKey("LanguageItem"))
		{
			GDT.LanguageItemTable table = GDT.LanguageItemTable.GetRootAsLanguageItemTable(byteBufferList["LanguageItem"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.LanguageItemT tableData = table.Rows(i).Value.UnPack();
				LanguageItemTable.Add(tableData.StringKey, tableData);
			}
		}
		if(byteBufferList.ContainsKey("LanguageShop"))
		{
			GDT.LanguageShopTable table = GDT.LanguageShopTable.GetRootAsLanguageShopTable(byteBufferList["LanguageShop"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.LanguageShopT tableData = table.Rows(i).Value.UnPack();
				LanguageShopTable.Add(tableData.StringKey, tableData);
			}
		}
		if(byteBufferList.ContainsKey("LanguageQuest"))
		{
			GDT.LanguageQuestTable table = GDT.LanguageQuestTable.GetRootAsLanguageQuestTable(byteBufferList["LanguageQuest"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.LanguageQuestT tableData = table.Rows(i).Value.UnPack();
				LanguageQuestTable.Add(tableData.StringKey, tableData);
			}
		}
		if(byteBufferList.ContainsKey("LanguageSkill"))
		{
			GDT.LanguageSkillTable table = GDT.LanguageSkillTable.GetRootAsLanguageSkillTable(byteBufferList["LanguageSkill"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.LanguageSkillT tableData = table.Rows(i).Value.UnPack();
				LanguageSkillTable.Add(tableData.StringKey, tableData);
			}
		}
		if(byteBufferList.ContainsKey("NpcSpawner"))
		{
			GDT.NpcSpawnerTable table = GDT.NpcSpawnerTable.GetRootAsNpcSpawnerTable(byteBufferList["NpcSpawner"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.NpcSpawnerT tableData = table.Rows(i).Value.UnPack();
				NpcSpawnerTable.Add(tableData.ObjectID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("DrawCard"))
		{
			GDT.DrawCardTable table = GDT.DrawCardTable.GetRootAsDrawCardTable(byteBufferList["DrawCard"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.DrawCardT tableData = table.Rows(i).Value.UnPack();
				DrawCardTable.Add(tableData.ObjectID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("Portal"))
		{
			GDT.PortalTable table = GDT.PortalTable.GetRootAsPortalTable(byteBufferList["Portal"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.PortalT tableData = table.Rows(i).Value.UnPack();
				PortalTable.Add(tableData.ObjectID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("ContentOpenObject"))
		{
			GDT.ContentOpenObjectTable table = GDT.ContentOpenObjectTable.GetRootAsContentOpenObjectTable(byteBufferList["ContentOpenObject"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.ContentOpenObjectT tableData = table.Rows(i).Value.UnPack();
				ContentOpenObjectTable.Add(tableData.ObjectID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("LoadingSceneInfo"))
		{
			GDT.LoadingSceneInfoTable table = GDT.LoadingSceneInfoTable.GetRootAsLoadingSceneInfoTable(byteBufferList["LoadingSceneInfo"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.LoadingSceneInfoT tableData = table.Rows(i).Value.UnPack();
				if(false == LoadingSceneInfoTable.ContainsKey(tableData.LoadingID))
				{
					List<GDT.LoadingSceneInfoT> newList = new List<GDT.LoadingSceneInfoT>();
					newList.Add(tableData);
					LoadingSceneInfoTable.Add(tableData.LoadingID, newList);
				}
				else
				{
					LoadingSceneInfoTable[tableData.LoadingID].Add(tableData);
				}
			}
		}
		if(byteBufferList.ContainsKey("LoadingSceneData"))
		{
			GDT.LoadingSceneDataTable table = GDT.LoadingSceneDataTable.GetRootAsLoadingSceneDataTable(byteBufferList["LoadingSceneData"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.LoadingSceneDataT tableData = table.Rows(i).Value.UnPack();
				if(false == LoadingSceneDataTable.ContainsKey(tableData.LoadingDataID))
				{
					List<GDT.LoadingSceneDataT> newList = new List<GDT.LoadingSceneDataT>();
					newList.Add(tableData);
					LoadingSceneDataTable.Add(tableData.LoadingDataID, newList);
				}
				else
				{
					LoadingSceneDataTable[tableData.LoadingDataID].Add(tableData);
				}
			}
		}
		if(byteBufferList.ContainsKey("Mail"))
		{
			GDT.MailTable table = GDT.MailTable.GetRootAsMailTable(byteBufferList["Mail"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.MailT tableData = table.Rows(i).Value.UnPack();
				MailTable.Add(tableData.Index, tableData);
			}
		}
		if(byteBufferList.ContainsKey("MakingInfo"))
		{
			GDT.MakingInfoTable table = GDT.MakingInfoTable.GetRootAsMakingInfoTable(byteBufferList["MakingInfo"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.MakingInfoT tableData = table.Rows(i).Value.UnPack();
				MakingInfoTable.Add(tableData.Index, tableData);
			}
		}
		if(byteBufferList.ContainsKey("MakingListData"))
		{
			GDT.MakingListDataTable table = GDT.MakingListDataTable.GetRootAsMakingListDataTable(byteBufferList["MakingListData"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.MakingListDataT tableData = table.Rows(i).Value.UnPack();
				MakingListDataTable.Add(tableData.MakingID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("MakingMaterialData"))
		{
			GDT.MakingMaterialDataTable table = GDT.MakingMaterialDataTable.GetRootAsMakingMaterialDataTable(byteBufferList["MakingMaterialData"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.MakingMaterialDataT tableData = table.Rows(i).Value.UnPack();
				if(false == MakingMaterialDataTable.ContainsKey(tableData.MakingID))
				{
					List<GDT.MakingMaterialDataT> newList = new List<GDT.MakingMaterialDataT>();
					newList.Add(tableData);
					MakingMaterialDataTable.Add(tableData.MakingID, newList);
				}
				else
				{
					MakingMaterialDataTable[tableData.MakingID].Add(tableData);
				}
			}
		}
		if(byteBufferList.ContainsKey("MapInfo"))
		{
			GDT.MapInfoTable table = GDT.MapInfoTable.GetRootAsMapInfoTable(byteBufferList["MapInfo"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.MapInfoT tableData = table.Rows(i).Value.UnPack();
				MapInfoTable.Add(tableData.MapID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("ArrivalSpawnGroup"))
		{
			GDT.ArrivalSpawnGroupTable table = GDT.ArrivalSpawnGroupTable.GetRootAsArrivalSpawnGroupTable(byteBufferList["ArrivalSpawnGroup"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.ArrivalSpawnGroupT tableData = table.Rows(i).Value.UnPack();
				if(false == ArrivalSpawnGroupTable.ContainsKey(tableData.SpawnGroupID))
				{
					List<GDT.ArrivalSpawnGroupT> newList = new List<GDT.ArrivalSpawnGroupT>();
					newList.Add(tableData);
					ArrivalSpawnGroupTable.Add(tableData.SpawnGroupID, newList);
				}
				else
				{
					ArrivalSpawnGroupTable[tableData.SpawnGroupID].Add(tableData);
				}
			}
		}
		if(byteBufferList.ContainsKey("Warp"))
		{
			GDT.WarpTable table = GDT.WarpTable.GetRootAsWarpTable(byteBufferList["Warp"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.WarpT tableData = table.Rows(i).Value.UnPack();
				WarpTable.Add(tableData.Index, tableData);
			}
		}
		if(byteBufferList.ContainsKey("QuestInfo"))
		{
			GDT.QuestInfoTable table = GDT.QuestInfoTable.GetRootAsQuestInfoTable(byteBufferList["QuestInfo"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.QuestInfoT tableData = table.Rows(i).Value.UnPack();
				QuestInfoTable.Add(tableData.QuestID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("QuestComplete"))
		{
			GDT.QuestCompleteTable table = GDT.QuestCompleteTable.GetRootAsQuestCompleteTable(byteBufferList["QuestComplete"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.QuestCompleteT tableData = table.Rows(i).Value.UnPack();
				QuestCompleteTable.Add(tableData.QuestCompleteID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("MoveEffectInfo"))
		{
			GDT.MoveEffectInfoTable table = GDT.MoveEffectInfoTable.GetRootAsMoveEffectInfoTable(byteBufferList["MoveEffectInfo"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.MoveEffectInfoT tableData = table.Rows(i).Value.UnPack();
				MoveEffectInfoTable.Add(tableData.Index, tableData);
			}
		}
		if(byteBufferList.ContainsKey("NpcAnimation"))
		{
			GDT.NpcAnimationTable table = GDT.NpcAnimationTable.GetRootAsNpcAnimationTable(byteBufferList["NpcAnimation"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.NpcAnimationT tableData = table.Rows(i).Value.UnPack();
				if(false == NpcAnimationTable.ContainsKey(tableData.NpcAnimationID))
				{
					List<GDT.NpcAnimationT> newList = new List<GDT.NpcAnimationT>();
					newList.Add(tableData);
					NpcAnimationTable.Add(tableData.NpcAnimationID, newList);
				}
				else
				{
					NpcAnimationTable[tableData.NpcAnimationID].Add(tableData);
				}
			}
		}
		if(byteBufferList.ContainsKey("PetData"))
		{
			GDT.PetDataTable table = GDT.PetDataTable.GetRootAsPetDataTable(byteBufferList["PetData"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.PetDataT tableData = table.Rows(i).Value.UnPack();
				PetDataTable.Add(tableData.CharacterID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("PlatformGameInfo"))
		{
			GDT.PlatformGameInfoTable table = GDT.PlatformGameInfoTable.GetRootAsPlatformGameInfoTable(byteBufferList["PlatformGameInfo"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.PlatformGameInfoT tableData = table.Rows(i).Value.UnPack();
				PlatformGameInfoTable.Add(tableData.PlatformGameID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("PlatformGameStageGroup"))
		{
			GDT.PlatformGameStageGroupTable table = GDT.PlatformGameStageGroupTable.GetRootAsPlatformGameStageGroupTable(byteBufferList["PlatformGameStageGroup"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.PlatformGameStageGroupT tableData = table.Rows(i).Value.UnPack();
				if(false == PlatformGameStageGroupTable.ContainsKey(tableData.StageGroupID))
				{
					List<GDT.PlatformGameStageGroupT> newList = new List<GDT.PlatformGameStageGroupT>();
					newList.Add(tableData);
					PlatformGameStageGroupTable.Add(tableData.StageGroupID, newList);
				}
				else
				{
					PlatformGameStageGroupTable[tableData.StageGroupID].Add(tableData);
				}
			}
		}
		if(byteBufferList.ContainsKey("PlatformGameStage"))
		{
			GDT.PlatformGameStageTable table = GDT.PlatformGameStageTable.GetRootAsPlatformGameStageTable(byteBufferList["PlatformGameStage"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.PlatformGameStageT tableData = table.Rows(i).Value.UnPack();
				PlatformGameStageTable.Add(tableData.StageID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("PlatformGameReward"))
		{
			GDT.PlatformGameRewardTable table = GDT.PlatformGameRewardTable.GetRootAsPlatformGameRewardTable(byteBufferList["PlatformGameReward"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.PlatformGameRewardT tableData = table.Rows(i).Value.UnPack();
				if(false == PlatformGameRewardTable.ContainsKey(tableData.PlatformGameID))
				{
					List<GDT.PlatformGameRewardT> newList = new List<GDT.PlatformGameRewardT>();
					newList.Add(tableData);
					PlatformGameRewardTable.Add(tableData.PlatformGameID, newList);
				}
				else
				{
					PlatformGameRewardTable[tableData.PlatformGameID].Add(tableData);
				}
			}
		}
		if(byteBufferList.ContainsKey("PlatformGameSchedule"))
		{
			GDT.PlatformGameScheduleTable table = GDT.PlatformGameScheduleTable.GetRootAsPlatformGameScheduleTable(byteBufferList["PlatformGameSchedule"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.PlatformGameScheduleT tableData = table.Rows(i).Value.UnPack();
				if(false == PlatformGameScheduleTable.ContainsKey(tableData.PlatformGameID))
				{
					List<GDT.PlatformGameScheduleT> newList = new List<GDT.PlatformGameScheduleT>();
					newList.Add(tableData);
					PlatformGameScheduleTable.Add(tableData.PlatformGameID, newList);
				}
				else
				{
					PlatformGameScheduleTable[tableData.PlatformGameID].Add(tableData);
				}
			}
		}
		if(byteBufferList.ContainsKey("PlatformGameSeason"))
		{
			GDT.PlatformGameSeasonTable table = GDT.PlatformGameSeasonTable.GetRootAsPlatformGameSeasonTable(byteBufferList["PlatformGameSeason"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.PlatformGameSeasonT tableData = table.Rows(i).Value.UnPack();
				PlatformGameSeasonTable.Add(tableData.PlatformGameSeasonID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("PlatformGameSeasonReward"))
		{
			GDT.PlatformGameSeasonRewardTable table = GDT.PlatformGameSeasonRewardTable.GetRootAsPlatformGameSeasonRewardTable(byteBufferList["PlatformGameSeasonReward"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.PlatformGameSeasonRewardT tableData = table.Rows(i).Value.UnPack();
				if(false == PlatformGameSeasonRewardTable.ContainsKey(tableData.PlatformGameSeasonID))
				{
					List<GDT.PlatformGameSeasonRewardT> newList = new List<GDT.PlatformGameSeasonRewardT>();
					newList.Add(tableData);
					PlatformGameSeasonRewardTable.Add(tableData.PlatformGameSeasonID, newList);
				}
				else
				{
					PlatformGameSeasonRewardTable[tableData.PlatformGameSeasonID].Add(tableData);
				}
			}
		}
		if(byteBufferList.ContainsKey("PlatformGamePose"))
		{
			GDT.PlatformGamePoseTable table = GDT.PlatformGamePoseTable.GetRootAsPlatformGamePoseTable(byteBufferList["PlatformGamePose"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.PlatformGamePoseT tableData = table.Rows(i).Value.UnPack();
				PlatformGamePoseTable.Add(tableData.Index, tableData);
			}
		}
		if(byteBufferList.ContainsKey("PlatformGameObject"))
		{
			GDT.PlatformGameObjectTable table = GDT.PlatformGameObjectTable.GetRootAsPlatformGameObjectTable(byteBufferList["PlatformGameObject"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.PlatformGameObjectT tableData = table.Rows(i).Value.UnPack();
				PlatformGameObjectTable.Add(tableData.CreateObjectID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("TriggerInfo"))
		{
			GDT.TriggerInfoTable table = GDT.TriggerInfoTable.GetRootAsTriggerInfoTable(byteBufferList["TriggerInfo"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.TriggerInfoT tableData = table.Rows(i).Value.UnPack();
				TriggerInfoTable.Add(tableData.TriggerID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("SpawnTrigger"))
		{
			GDT.SpawnTriggerTable table = GDT.SpawnTriggerTable.GetRootAsSpawnTriggerTable(byteBufferList["SpawnTrigger"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.SpawnTriggerT tableData = table.Rows(i).Value.UnPack();
				SpawnTriggerTable.Add(tableData.TriggerID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("AnimationTrigger"))
		{
			GDT.AnimationTriggerTable table = GDT.AnimationTriggerTable.GetRootAsAnimationTriggerTable(byteBufferList["AnimationTrigger"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.AnimationTriggerT tableData = table.Rows(i).Value.UnPack();
				AnimationTriggerTable.Add(tableData.TriggerID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("RespawnTrigger"))
		{
			GDT.RespawnTriggerTable table = GDT.RespawnTriggerTable.GetRootAsRespawnTriggerTable(byteBufferList["RespawnTrigger"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.RespawnTriggerT tableData = table.Rows(i).Value.UnPack();
				RespawnTriggerTable.Add(tableData.TriggerID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("SkillTrigger"))
		{
			GDT.SkillTriggerTable table = GDT.SkillTriggerTable.GetRootAsSkillTriggerTable(byteBufferList["SkillTrigger"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.SkillTriggerT tableData = table.Rows(i).Value.UnPack();
				SkillTriggerTable.Add(tableData.TriggerID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("TrackTrigger"))
		{
			GDT.TrackTriggerTable table = GDT.TrackTriggerTable.GetRootAsTrackTriggerTable(byteBufferList["TrackTrigger"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.TrackTriggerT tableData = table.Rows(i).Value.UnPack();
				TrackTriggerTable.Add(tableData.TriggerID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("DoorTrigger"))
		{
			GDT.DoorTriggerTable table = GDT.DoorTriggerTable.GetRootAsDoorTriggerTable(byteBufferList["DoorTrigger"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.DoorTriggerT tableData = table.Rows(i).Value.UnPack();
				DoorTriggerTable.Add(tableData.TriggerID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("StandbyPositionParent"))
		{
			GDT.StandbyPositionParentTable table = GDT.StandbyPositionParentTable.GetRootAsStandbyPositionParentTable(byteBufferList["StandbyPositionParent"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.StandbyPositionParentT tableData = table.Rows(i).Value.UnPack();
				StandbyPositionParentTable.Add(tableData.StageID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("StandbyPositionInfo"))
		{
			GDT.StandbyPositionInfoTable table = GDT.StandbyPositionInfoTable.GetRootAsStandbyPositionInfoTable(byteBufferList["StandbyPositionInfo"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.StandbyPositionInfoT tableData = table.Rows(i).Value.UnPack();
				if(false == StandbyPositionInfoTable.ContainsKey(tableData.StageID))
				{
					List<GDT.StandbyPositionInfoT> newList = new List<GDT.StandbyPositionInfoT>();
					newList.Add(tableData);
					StandbyPositionInfoTable.Add(tableData.StageID, newList);
				}
				else
				{
					StandbyPositionInfoTable[tableData.StageID].Add(tableData);
				}
			}
		}
		if(byteBufferList.ContainsKey("StagePositionInfo"))
		{
			GDT.StagePositionInfoTable table = GDT.StagePositionInfoTable.GetRootAsStagePositionInfoTable(byteBufferList["StagePositionInfo"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.StagePositionInfoT tableData = table.Rows(i).Value.UnPack();
				StagePositionInfoTable.Add(tableData.StageID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("PGObjectSpawner"))
		{
			GDT.PGObjectSpawnerTable table = GDT.PGObjectSpawnerTable.GetRootAsPGObjectSpawnerTable(byteBufferList["PGObjectSpawner"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.PGObjectSpawnerT tableData = table.Rows(i).Value.UnPack();
				PGObjectSpawnerTable.Add(tableData.ObjectSpawnerID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("PGObjectRandomSpawner"))
		{
			GDT.PGObjectRandomSpawnerTable table = GDT.PGObjectRandomSpawnerTable.GetRootAsPGObjectRandomSpawnerTable(byteBufferList["PGObjectRandomSpawner"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.PGObjectRandomSpawnerT tableData = table.Rows(i).Value.UnPack();
				PGObjectRandomSpawnerTable.Add(tableData.ObjectSpawnerID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("PGSpawnerPosGroup"))
		{
			GDT.PGSpawnerPosGroupTable table = GDT.PGSpawnerPosGroupTable.GetRootAsPGSpawnerPosGroupTable(byteBufferList["PGSpawnerPosGroup"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.PGSpawnerPosGroupT tableData = table.Rows(i).Value.UnPack();
				if(false == PGSpawnerPosGroupTable.ContainsKey(tableData.ObjectSpawnerID))
				{
					List<GDT.PGSpawnerPosGroupT> newList = new List<GDT.PGSpawnerPosGroupT>();
					newList.Add(tableData);
					PGSpawnerPosGroupTable.Add(tableData.ObjectSpawnerID, newList);
				}
				else
				{
					PGSpawnerPosGroupTable[tableData.ObjectSpawnerID].Add(tableData);
				}
			}
		}
		if(byteBufferList.ContainsKey("PGPendulum"))
		{
			GDT.PGPendulumTable table = GDT.PGPendulumTable.GetRootAsPGPendulumTable(byteBufferList["PGPendulum"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.PGPendulumT tableData = table.Rows(i).Value.UnPack();
				PGPendulumTable.Add(tableData.ObjectID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("PGObstacle"))
		{
			GDT.PGObstacleTable table = GDT.PGObstacleTable.GetRootAsPGObstacleTable(byteBufferList["PGObstacle"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.PGObstacleT tableData = table.Rows(i).Value.UnPack();
				if(false == PGObstacleTable.ContainsKey(tableData.StageID))
				{
					List<GDT.PGObstacleT> newList = new List<GDT.PGObstacleT>();
					newList.Add(tableData);
					PGObstacleTable.Add(tableData.StageID, newList);
				}
				else
				{
					PGObstacleTable[tableData.StageID].Add(tableData);
				}
			}
		}
		if(byteBufferList.ContainsKey("QuestCamera"))
		{
			GDT.QuestCameraTable table = GDT.QuestCameraTable.GetRootAsQuestCameraTable(byteBufferList["QuestCamera"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.QuestCameraT tableData = table.Rows(i).Value.UnPack();
				QuestCameraTable.Add(tableData.ID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("QuestGroupInfo"))
		{
			GDT.QuestGroupInfoTable table = GDT.QuestGroupInfoTable.GetRootAsQuestGroupInfoTable(byteBufferList["QuestGroupInfo"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.QuestGroupInfoT tableData = table.Rows(i).Value.UnPack();
				QuestGroupInfoTable.Add(tableData.QuestGroupID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("QuestTabInfo"))
		{
			GDT.QuestTabInfoTable table = GDT.QuestTabInfoTable.GetRootAsQuestTabInfoTable(byteBufferList["QuestTabInfo"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.QuestTabInfoT tableData = table.Rows(i).Value.UnPack();
				QuestTabInfoTable.Add(tableData.QuestTabID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("RedDotPosition"))
		{
			GDT.RedDotPositionTable table = GDT.RedDotPositionTable.GetRootAsRedDotPositionTable(byteBufferList["RedDotPosition"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.RedDotPositionT tableData = table.Rows(i).Value.UnPack();
				if(false == RedDotPositionTable.ContainsKey(tableData.ReddotMainTypeID))
				{
					List<GDT.RedDotPositionT> newList = new List<GDT.RedDotPositionT>();
					newList.Add(tableData);
					RedDotPositionTable.Add(tableData.ReddotMainTypeID, newList);
				}
				else
				{
					RedDotPositionTable[tableData.ReddotMainTypeID].Add(tableData);
				}
			}
		}
		if(byteBufferList.ContainsKey("RewardData"))
		{
			GDT.RewardDataTable table = GDT.RewardDataTable.GetRootAsRewardDataTable(byteBufferList["RewardData"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.RewardDataT tableData = table.Rows(i).Value.UnPack();
				if(false == RewardDataTable.ContainsKey(tableData.GroupID))
				{
					List<GDT.RewardDataT> newList = new List<GDT.RewardDataT>();
					newList.Add(tableData);
					RewardDataTable.Add(tableData.GroupID, newList);
				}
				else
				{
					RewardDataTable[tableData.GroupID].Add(tableData);
				}
			}
		}
		if(byteBufferList.ContainsKey("ScenarioDialog"))
		{
			GDT.ScenarioDialogTable table = GDT.ScenarioDialogTable.GetRootAsScenarioDialogTable(byteBufferList["ScenarioDialog"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.ScenarioDialogT tableData = table.Rows(i).Value.UnPack();
				ScenarioDialogTable.Add(tableData.ScenarioScriptID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("ScenarioScene"))
		{
			GDT.ScenarioSceneTable table = GDT.ScenarioSceneTable.GetRootAsScenarioSceneTable(byteBufferList["ScenarioScene"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.ScenarioSceneT tableData = table.Rows(i).Value.UnPack();
				if(false == ScenarioSceneTable.ContainsKey(tableData.QuestScriptID))
				{
					List<GDT.ScenarioSceneT> newList = new List<GDT.ScenarioSceneT>();
					newList.Add(tableData);
					ScenarioSceneTable.Add(tableData.QuestScriptID, newList);
				}
				else
				{
					ScenarioSceneTable[tableData.QuestScriptID].Add(tableData);
				}
			}
		}
		if(byteBufferList.ContainsKey("SkillInfo"))
		{
			GDT.SkillInfoTable table = GDT.SkillInfoTable.GetRootAsSkillInfoTable(byteBufferList["SkillInfo"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.SkillInfoT tableData = table.Rows(i).Value.UnPack();
				SkillInfoTable.Add(tableData.SkillID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("SkillAnimationData"))
		{
			GDT.SkillAnimationDataTable table = GDT.SkillAnimationDataTable.GetRootAsSkillAnimationDataTable(byteBufferList["SkillAnimationData"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.SkillAnimationDataT tableData = table.Rows(i).Value.UnPack();
				SkillAnimationDataTable.Add(tableData.SkillID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("SkillEventData"))
		{
			GDT.SkillEventDataTable table = GDT.SkillEventDataTable.GetRootAsSkillEventDataTable(byteBufferList["SkillEventData"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.SkillEventDataT tableData = table.Rows(i).Value.UnPack();
				SkillEventDataTable.Add(tableData.SkillEventID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("Projectile"))
		{
			GDT.ProjectileTable table = GDT.ProjectileTable.GetRootAsProjectileTable(byteBufferList["Projectile"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.ProjectileT tableData = table.Rows(i).Value.UnPack();
				ProjectileTable.Add(tableData.ProjectileID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("SkillGrowthGroup"))
		{
			GDT.SkillGrowthGroupTable table = GDT.SkillGrowthGroupTable.GetRootAsSkillGrowthGroupTable(byteBufferList["SkillGrowthGroup"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.SkillGrowthGroupT tableData = table.Rows(i).Value.UnPack();
				SkillGrowthGroupTable.Add(tableData.SkillGrowthGroupID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("BuffInfo"))
		{
			GDT.BuffInfoTable table = GDT.BuffInfoTable.GetRootAsBuffInfoTable(byteBufferList["BuffInfo"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.BuffInfoT tableData = table.Rows(i).Value.UnPack();
				BuffInfoTable.Add(tableData.BuffID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("BuffData"))
		{
			GDT.BuffDataTable table = GDT.BuffDataTable.GetRootAsBuffDataTable(byteBufferList["BuffData"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.BuffDataT tableData = table.Rows(i).Value.UnPack();
				if(false == BuffDataTable.ContainsKey(tableData.BuffID))
				{
					List<GDT.BuffDataT> newList = new List<GDT.BuffDataT>();
					newList.Add(tableData);
					BuffDataTable.Add(tableData.BuffID, newList);
				}
				else
				{
					BuffDataTable[tableData.BuffID].Add(tableData);
				}
			}
		}
		if(byteBufferList.ContainsKey("Slang"))
		{
			GDT.SlangTable table = GDT.SlangTable.GetRootAsSlangTable(byteBufferList["Slang"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.SlangT tableData = table.Rows(i).Value.UnPack();
				SlangTable.Add(tableData.Index, tableData);
			}
		}
		if(byteBufferList.ContainsKey("Sound"))
		{
			GDT.SoundTable table = GDT.SoundTable.GetRootAsSoundTable(byteBufferList["Sound"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.SoundT tableData = table.Rows(i).Value.UnPack();
				SoundTable.Add(tableData.SoundID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("SwapCoin"))
		{
			GDT.SwapCoinTable table = GDT.SwapCoinTable.GetRootAsSwapCoinTable(byteBufferList["SwapCoin"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.SwapCoinT tableData = table.Rows(i).Value.UnPack();
				SwapCoinTable.Add(tableData.CoinID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("SwapCurrency"))
		{
			GDT.SwapCurrencyTable table = GDT.SwapCurrencyTable.GetRootAsSwapCurrencyTable(byteBufferList["SwapCurrency"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.SwapCurrencyT tableData = table.Rows(i).Value.UnPack();
				SwapCurrencyTable.Add(tableData.CurrencyID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("SystemMessage"))
		{
			GDT.SystemMessageTable table = GDT.SystemMessageTable.GetRootAsSystemMessageTable(byteBufferList["SystemMessage"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.SystemMessageT tableData = table.Rows(i).Value.UnPack();
				SystemMessageTable.Add(tableData.SystemMsgText, tableData);
			}
		}
		if(byteBufferList.ContainsKey("Tier"))
		{
			GDT.TierTable table = GDT.TierTable.GetRootAsTierTable(byteBufferList["Tier"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.TierT tableData = table.Rows(i).Value.UnPack();
				if(false == TierTable.ContainsKey(tableData.TierTypeID))
				{
					List<GDT.TierT> newList = new List<GDT.TierT>();
					newList.Add(tableData);
					TierTable.Add(tableData.TierTypeID, newList);
				}
				else
				{
					TierTable[tableData.TierTypeID].Add(tableData);
				}
			}
		}
		if(byteBufferList.ContainsKey("TokenAddress"))
		{
			GDT.TokenAddressTable table = GDT.TokenAddressTable.GetRootAsTokenAddressTable(byteBufferList["TokenAddress"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.TokenAddressT tableData = table.Rows(i).Value.UnPack();
				TokenAddressTable.Add(tableData.TokenAddressID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("DevTokenAddress"))
		{
			GDT.DevTokenAddressTable table = GDT.DevTokenAddressTable.GetRootAsDevTokenAddressTable(byteBufferList["DevTokenAddress"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.DevTokenAddressT tableData = table.Rows(i).Value.UnPack();
				DevTokenAddressTable.Add(tableData.TokenID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("QATokenAddress"))
		{
			GDT.QATokenAddressTable table = GDT.QATokenAddressTable.GetRootAsQATokenAddressTable(byteBufferList["QATokenAddress"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.QATokenAddressT tableData = table.Rows(i).Value.UnPack();
				QATokenAddressTable.Add(tableData.TokenID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("ProductionTokenAddress"))
		{
			GDT.ProductionTokenAddressTable table = GDT.ProductionTokenAddressTable.GetRootAsProductionTokenAddressTable(byteBufferList["ProductionTokenAddress"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.ProductionTokenAddressT tableData = table.Rows(i).Value.UnPack();
				ProductionTokenAddressTable.Add(tableData.TokenID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("TreasureLotteryInfo"))
		{
			GDT.TreasureLotteryInfoTable table = GDT.TreasureLotteryInfoTable.GetRootAsTreasureLotteryInfoTable(byteBufferList["TreasureLotteryInfo"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.TreasureLotteryInfoT tableData = table.Rows(i).Value.UnPack();
				TreasureLotteryInfoTable.Add(tableData.TreasureLotteryID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("TreasureLotteryPattern"))
		{
			GDT.TreasureLotteryPatternTable table = GDT.TreasureLotteryPatternTable.GetRootAsTreasureLotteryPatternTable(byteBufferList["TreasureLotteryPattern"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.TreasureLotteryPatternT tableData = table.Rows(i).Value.UnPack();
				TreasureLotteryPatternTable.Add(tableData.PatternID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("TreasureLotteryItem"))
		{
			GDT.TreasureLotteryItemTable table = GDT.TreasureLotteryItemTable.GetRootAsTreasureLotteryItemTable(byteBufferList["TreasureLotteryItem"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.TreasureLotteryItemT tableData = table.Rows(i).Value.UnPack();
				TreasureLotteryItemTable.Add(tableData.SlotID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("TreasureLotteryReward"))
		{
			GDT.TreasureLotteryRewardTable table = GDT.TreasureLotteryRewardTable.GetRootAsTreasureLotteryRewardTable(byteBufferList["TreasureLotteryReward"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.TreasureLotteryRewardT tableData = table.Rows(i).Value.UnPack();
				if(false == TreasureLotteryRewardTable.ContainsKey(tableData.TreasureLotteryID))
				{
					List<GDT.TreasureLotteryRewardT> newList = new List<GDT.TreasureLotteryRewardT>();
					newList.Add(tableData);
					TreasureLotteryRewardTable.Add(tableData.TreasureLotteryID, newList);
				}
				else
				{
					TreasureLotteryRewardTable[tableData.TreasureLotteryID].Add(tableData);
				}
			}
		}
		if(byteBufferList.ContainsKey("TreasureLotteryMultiplier"))
		{
			GDT.TreasureLotteryMultiplierTable table = GDT.TreasureLotteryMultiplierTable.GetRootAsTreasureLotteryMultiplierTable(byteBufferList["TreasureLotteryMultiplier"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.TreasureLotteryMultiplierT tableData = table.Rows(i).Value.UnPack();
				if(false == TreasureLotteryMultiplierTable.ContainsKey(tableData.TreasureLotteryID))
				{
					List<GDT.TreasureLotteryMultiplierT> newList = new List<GDT.TreasureLotteryMultiplierT>();
					newList.Add(tableData);
					TreasureLotteryMultiplierTable.Add(tableData.TreasureLotteryID, newList);
				}
				else
				{
					TreasureLotteryMultiplierTable[tableData.TreasureLotteryID].Add(tableData);
				}
			}
		}
		if(byteBufferList.ContainsKey("TreasureLotterySeason"))
		{
			GDT.TreasureLotterySeasonTable table = GDT.TreasureLotterySeasonTable.GetRootAsTreasureLotterySeasonTable(byteBufferList["TreasureLotterySeason"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.TreasureLotterySeasonT tableData = table.Rows(i).Value.UnPack();
				TreasureLotterySeasonTable.Add(tableData.TreasureLotterySeasonID, tableData);
			}
		}
		if(byteBufferList.ContainsKey("WorldPositionInfo"))
		{
			GDT.WorldPositionInfoTable table = GDT.WorldPositionInfoTable.GetRootAsWorldPositionInfoTable(byteBufferList["WorldPositionInfo"]);
			for (int i = 0; i < table.RowsLength; i++)
			{
				GDT.WorldPositionInfoT tableData = table.Rows(i).Value.UnPack();
				WorldPositionInfoTable.Add(tableData.ID, tableData);
			}
		}
	}
	
	public List<GDT.AnimationInfoT> GetAnimationInfoList(int key)
	{
		if(AnimationInfoTable.ContainsKey(key))
		{
			return AnimationInfoTable[key];
		}
		return null;
	}
	
	public List<GDT.CameraSettingT> GetCameraSettingList(GDT.CameraMainType key)
	{
		if(CameraSettingTable.ContainsKey(key))
		{
			return CameraSettingTable[key];
		}
		return null;
	}
	
	public GDT.CashShopInfoT GetCashShopInfo(int key)
	{
		if(CashShopInfoTable.ContainsKey(key))
		{
			return CashShopInfoTable[key];
		}
		return null;
	}
	
	public GDT.CashShopBaseT GetCashShopBase(int key)
	{
		if(CashShopBaseTable.ContainsKey(key))
		{
			return CashShopBaseTable[key];
		}
		return null;
	}
	
	public GDT.CashShopProductT GetCashShopProduct(int key)
	{
		if(CashShopProductTable.ContainsKey(key))
		{
			return CashShopProductTable[key];
		}
		return null;
	}
	
	public List<GDT.PeriodPaymentDataT> GetPeriodPaymentDataList(int key)
	{
		if(PeriodPaymentDataTable.ContainsKey(key))
		{
			return PeriodPaymentDataTable[key];
		}
		return null;
	}
	
	public GDT.CharacterInfoT GetCharacterInfo(int key)
	{
		if(CharacterInfoTable.ContainsKey(key))
		{
			return CharacterInfoTable[key];
		}
		return null;
	}
	
	public List<GDT.CharacterNpcFunctionT> GetCharacterNpcFunctionList(int key)
	{
		if(CharacterNpcFunctionTable.ContainsKey(key))
		{
			return CharacterNpcFunctionTable[key];
		}
		return null;
	}
	
	public List<GDT.CharacterCountenanceT> GetCharacterCountenanceList(int key)
	{
		if(CharacterCountenanceTable.ContainsKey(key))
		{
			return CharacterCountenanceTable[key];
		}
		return null;
	}
	
	public GDT.CheatCommandT GetCheatCommand(string key)
	{
		if(CheatCommandTable.ContainsKey(key))
		{
			return CheatCommandTable[key];
		}
		return null;
	}
	
	public List<GDT.CheatGroupT> GetCheatGroupList(string key)
	{
		if(CheatGroupTable.ContainsKey(key))
		{
			return CheatGroupTable[key];
		}
		return null;
	}
	
	public GDT.ConnectWalletT GetConnectWallet(GDT.WalletType key)
	{
		if(ConnectWalletTable.ContainsKey(key))
		{
			return ConnectWalletTable[key];
		}
		return null;
	}
	
	public List<GDT.ContentGuideT> GetContentGuideList(int key)
	{
		if(ContentGuideTable.ContainsKey(key))
		{
			return ContentGuideTable[key];
		}
		return null;
	}
	
	public GDT.ContentManagerInfoT GetContentManagerInfo(int key)
	{
		if(ContentManagerInfoTable.ContainsKey(key))
		{
			return ContentManagerInfoTable[key];
		}
		return null;
	}
	
	public GDT.ContentTopDisplayDataT GetContentTopDisplayData(GDT.ContentMainType key)
	{
		if(ContentTopDisplayDataTable.ContainsKey(key))
		{
			return ContentTopDisplayDataTable[key];
		}
		return null;
	}
	
	public GDT.CurrencyInfoT GetCurrencyInfo(GDT.CurrencySubType key)
	{
		if(CurrencyInfoTable.ContainsKey(key))
		{
			return CurrencyInfoTable[key];
		}
		return null;
	}
	
	public GDT.CoinInfoT GetCoinInfo(GDT.CurrencySubType key)
	{
		if(CoinInfoTable.ContainsKey(key))
		{
			return CoinInfoTable[key];
		}
		return null;
	}
	
	public GDT.PurchaseDataT GetPurchaseData(int key)
	{
		if(PurchaseDataTable.ContainsKey(key))
		{
			return PurchaseDataTable[key];
		}
		return null;
	}
	
	public GDT.CharacterCustomizingInfoT GetCharacterCustomizingInfo(int key)
	{
		if(CharacterCustomizingInfoTable.ContainsKey(key))
		{
			return CharacterCustomizingInfoTable[key];
		}
		return null;
	}
	
	public List<GDT.CharacterCustomizingDataT> GetCharacterCustomizingDataList(int key)
	{
		if(CharacterCustomizingDataTable.ContainsKey(key))
		{
			return CharacterCustomizingDataTable[key];
		}
		return null;
	}
	
	public GDT.CharacterCustomizingDetailT GetCharacterCustomizingDetail(short key)
	{
		if(CharacterCustomizingDetailTable.ContainsKey(key))
		{
			return CharacterCustomizingDetailTable[key];
		}
		return null;
	}
	
	public GDT.PresetT GetPreset(int key)
	{
		if(PresetTable.ContainsKey(key))
		{
			return PresetTable[key];
		}
		return null;
	}
	
	public List<GDT.CharacterCustomizingBasicT> GetCharacterCustomizingBasicList(GDT.CharacterType key)
	{
		if(CharacterCustomizingBasicTable.ContainsKey(key))
		{
			return CharacterCustomizingBasicTable[key];
		}
		return null;
	}
	
	public GDT.EffectT GetEffect(int key)
	{
		if(EffectTable.ContainsKey(key))
		{
			return EffectTable[key];
		}
		return null;
	}
	
	public GDT.EmotionInfoT GetEmotionInfo(int key)
	{
		if(EmotionInfoTable.ContainsKey(key))
		{
			return EmotionInfoTable[key];
		}
		return null;
	}
	
	public GDT.EntertainContentInfoT GetEntertainContentInfo(int key)
	{
		if(EntertainContentInfoTable.ContainsKey(key))
		{
			return EntertainContentInfoTable[key];
		}
		return null;
	}
	
	public GDT.EntertainContentHeadsAndTailsT GetEntertainContentHeadsAndTails(int key)
	{
		if(EntertainContentHeadsAndTailsTable.ContainsKey(key))
		{
			return EntertainContentHeadsAndTailsTable[key];
		}
		return null;
	}
	
	public GDT.EntertainContentDrawCardT GetEntertainContentDrawCard(int key)
	{
		if(EntertainContentDrawCardTable.ContainsKey(key))
		{
			return EntertainContentDrawCardTable[key];
		}
		return null;
	}
	
	public GDT.EntertainContentBingoT GetEntertainContentBingo(int key)
	{
		if(EntertainContentBingoTable.ContainsKey(key))
		{
			return EntertainContentBingoTable[key];
		}
		return null;
	}
	
	public List<GDT.EntertainContentDialogueT> GetEntertainContentDialogueList(int key)
	{
		if(EntertainContentDialogueTable.ContainsKey(key))
		{
			return EntertainContentDialogueTable[key];
		}
		return null;
	}
	
	public List<GDT.EntertainContentRewardT> GetEntertainContentRewardList(int key)
	{
		if(EntertainContentRewardTable.ContainsKey(key))
		{
			return EntertainContentRewardTable[key];
		}
		return null;
	}
	
	public List<GDT.EntertainContentScheduleT> GetEntertainContentScheduleList(int key)
	{
		if(EntertainContentScheduleTable.ContainsKey(key))
		{
			return EntertainContentScheduleTable[key];
		}
		return null;
	}
	
	public GDT.EnvironmentInfoT GetEnvironmentInfo(int key)
	{
		if(EnvironmentInfoTable.ContainsKey(key))
		{
			return EnvironmentInfoTable[key];
		}
		return null;
	}
	
	public List<GDT.EnvironmentNextEnvGroupT> GetEnvironmentNextEnvGroupList(int key)
	{
		if(EnvironmentNextEnvGroupTable.ContainsKey(key))
		{
			return EnvironmentNextEnvGroupTable[key];
		}
		return null;
	}
	
	public GDT.EventInfoT GetEventInfo(int key)
	{
		if(EventInfoTable.ContainsKey(key))
		{
			return EventInfoTable[key];
		}
		return null;
	}
	
	public List<GDT.EventMessageT> GetEventMessageList(int key)
	{
		if(EventMessageTable.ContainsKey(key))
		{
			return EventMessageTable[key];
		}
		return null;
	}
	
	public GDT.EventObjectT GetEventObject(int key)
	{
		if(EventObjectTable.ContainsKey(key))
		{
			return EventObjectTable[key];
		}
		return null;
	}
	
	public List<GDT.EventDropDataT> GetEventDropDataList(int key)
	{
		if(EventDropDataTable.ContainsKey(key))
		{
			return EventDropDataTable[key];
		}
		return null;
	}
	
	public List<GDT.EventDropPointDataT> GetEventDropPointDataList(int key)
	{
		if(EventDropPointDataTable.ContainsKey(key))
		{
			return EventDropPointDataTable[key];
		}
		return null;
	}
	
	public GDT.HoldemInfoT GetHoldemInfo(int key)
	{
		if(HoldemInfoTable.ContainsKey(key))
		{
			return HoldemInfoTable[key];
		}
		return null;
	}
	
	public List<GDT.HoldemScheduleT> GetHoldemScheduleList(int key)
	{
		if(HoldemScheduleTable.ContainsKey(key))
		{
			return HoldemScheduleTable[key];
		}
		return null;
	}
	
	public GDT.InventoryInfoT GetInventoryInfo(GDT.CurrencySubType key)
	{
		if(InventoryInfoTable.ContainsKey(key))
		{
			return InventoryInfoTable[key];
		}
		return null;
	}
	
	public List<GDT.InventoryCategoryT> GetInventoryCategoryList(GDT.CurrencySubType key)
	{
		if(InventoryCategoryTable.ContainsKey(key))
		{
			return InventoryCategoryTable[key];
		}
		return null;
	}
	
	public List<GDT.InventoryCategoryDetailT> GetInventoryCategoryDetailList(GDT.InventoryCategoryType key)
	{
		if(InventoryCategoryDetailTable.ContainsKey(key))
		{
			return InventoryCategoryDetailTable[key];
		}
		return null;
	}
	
	public GDT.ItemInfoT GetItemInfo(int key)
	{
		if(ItemInfoTable.ContainsKey(key))
		{
			return ItemInfoTable[key];
		}
		return null;
	}
	
	public GDT.ItemGradeT GetItemGrade(GDT.ItemGradeType key)
	{
		if(ItemGradeTable.ContainsKey(key))
		{
			return ItemGradeTable[key];
		}
		return null;
	}
	
	public GDT.ItemEquipT GetItemEquip(int key)
	{
		if(ItemEquipTable.ContainsKey(key))
		{
			return ItemEquipTable[key];
		}
		return null;
	}
	
	public List<GDT.ItemResourceT> GetItemResourceList(int key)
	{
		if(ItemResourceTable.ContainsKey(key))
		{
			return ItemResourceTable[key];
		}
		return null;
	}
	
	public GDT.ItemUsingT GetItemUsing(int key)
	{
		if(ItemUsingTable.ContainsKey(key))
		{
			return ItemUsingTable[key];
		}
		return null;
	}
	
	public List<GDT.ItemGrowthInfoT> GetItemGrowthInfoList(GDT.ItemSubType key)
	{
		if(ItemGrowthInfoTable.ContainsKey(key))
		{
			return ItemGrowthInfoTable[key];
		}
		return null;
	}
	
	public List<GDT.ItemGrowthDataT> GetItemGrowthDataList(GDT.ItemSubType key)
	{
		if(ItemGrowthDataTable.ContainsKey(key))
		{
			return ItemGrowthDataTable[key];
		}
		return null;
	}
	
	public List<GDT.ItemOptionDataT> GetItemOptionDataList(GDT.ItemSubType key)
	{
		if(ItemOptionDataTable.ContainsKey(key))
		{
			return ItemOptionDataTable[key];
		}
		return null;
	}
	
	public GDT.LanguageUIT GetLanguageUI(string key)
	{
		if(LanguageUITable.ContainsKey(key))
		{
			return LanguageUITable[key];
		}
		return null;
	}
	
	public GDT.LanguageItemT GetLanguageItem(string key)
	{
		if(LanguageItemTable.ContainsKey(key))
		{
			return LanguageItemTable[key];
		}
		return null;
	}
	
	public GDT.LanguageShopT GetLanguageShop(string key)
	{
		if(LanguageShopTable.ContainsKey(key))
		{
			return LanguageShopTable[key];
		}
		return null;
	}
	
	public GDT.LanguageQuestT GetLanguageQuest(string key)
	{
		if(LanguageQuestTable.ContainsKey(key))
		{
			return LanguageQuestTable[key];
		}
		return null;
	}
	
	public GDT.LanguageSkillT GetLanguageSkill(string key)
	{
		if(LanguageSkillTable.ContainsKey(key))
		{
			return LanguageSkillTable[key];
		}
		return null;
	}
	
	public GDT.NpcSpawnerT GetNpcSpawner(int key)
	{
		if(NpcSpawnerTable.ContainsKey(key))
		{
			return NpcSpawnerTable[key];
		}
		return null;
	}
	
	public GDT.DrawCardT GetDrawCard(int key)
	{
		if(DrawCardTable.ContainsKey(key))
		{
			return DrawCardTable[key];
		}
		return null;
	}
	
	public GDT.PortalT GetPortal(int key)
	{
		if(PortalTable.ContainsKey(key))
		{
			return PortalTable[key];
		}
		return null;
	}
	
	public GDT.ContentOpenObjectT GetContentOpenObject(int key)
	{
		if(ContentOpenObjectTable.ContainsKey(key))
		{
			return ContentOpenObjectTable[key];
		}
		return null;
	}
	
	public List<GDT.LoadingSceneInfoT> GetLoadingSceneInfoList(int key)
	{
		if(LoadingSceneInfoTable.ContainsKey(key))
		{
			return LoadingSceneInfoTable[key];
		}
		return null;
	}
	
	public List<GDT.LoadingSceneDataT> GetLoadingSceneDataList(int key)
	{
		if(LoadingSceneDataTable.ContainsKey(key))
		{
			return LoadingSceneDataTable[key];
		}
		return null;
	}
	
	public GDT.MailT GetMail(int key)
	{
		if(MailTable.ContainsKey(key))
		{
			return MailTable[key];
		}
		return null;
	}
	
	public GDT.MakingInfoT GetMakingInfo(int key)
	{
		if(MakingInfoTable.ContainsKey(key))
		{
			return MakingInfoTable[key];
		}
		return null;
	}
	
	public GDT.MakingListDataT GetMakingListData(int key)
	{
		if(MakingListDataTable.ContainsKey(key))
		{
			return MakingListDataTable[key];
		}
		return null;
	}
	
	public List<GDT.MakingMaterialDataT> GetMakingMaterialDataList(int key)
	{
		if(MakingMaterialDataTable.ContainsKey(key))
		{
			return MakingMaterialDataTable[key];
		}
		return null;
	}
	
	public GDT.MapInfoT GetMapInfo(int key)
	{
		if(MapInfoTable.ContainsKey(key))
		{
			return MapInfoTable[key];
		}
		return null;
	}
	
	public List<GDT.ArrivalSpawnGroupT> GetArrivalSpawnGroupList(int key)
	{
		if(ArrivalSpawnGroupTable.ContainsKey(key))
		{
			return ArrivalSpawnGroupTable[key];
		}
		return null;
	}
	
	public GDT.WarpT GetWarp(int key)
	{
		if(WarpTable.ContainsKey(key))
		{
			return WarpTable[key];
		}
		return null;
	}
	
	public GDT.QuestInfoT GetQuestInfo(int key)
	{
		if(QuestInfoTable.ContainsKey(key))
		{
			return QuestInfoTable[key];
		}
		return null;
	}
	
	public GDT.QuestCompleteT GetQuestComplete(int key)
	{
		if(QuestCompleteTable.ContainsKey(key))
		{
			return QuestCompleteTable[key];
		}
		return null;
	}
	
	public GDT.MoveEffectInfoT GetMoveEffectInfo(int key)
	{
		if(MoveEffectInfoTable.ContainsKey(key))
		{
			return MoveEffectInfoTable[key];
		}
		return null;
	}
	
	public List<GDT.NpcAnimationT> GetNpcAnimationList(int key)
	{
		if(NpcAnimationTable.ContainsKey(key))
		{
			return NpcAnimationTable[key];
		}
		return null;
	}
	
	public GDT.PetDataT GetPetData(int key)
	{
		if(PetDataTable.ContainsKey(key))
		{
			return PetDataTable[key];
		}
		return null;
	}
	
	public GDT.PlatformGameInfoT GetPlatformGameInfo(int key)
	{
		if(PlatformGameInfoTable.ContainsKey(key))
		{
			return PlatformGameInfoTable[key];
		}
		return null;
	}
	
	public List<GDT.PlatformGameStageGroupT> GetPlatformGameStageGroupList(int key)
	{
		if(PlatformGameStageGroupTable.ContainsKey(key))
		{
			return PlatformGameStageGroupTable[key];
		}
		return null;
	}
	
	public GDT.PlatformGameStageT GetPlatformGameStage(int key)
	{
		if(PlatformGameStageTable.ContainsKey(key))
		{
			return PlatformGameStageTable[key];
		}
		return null;
	}
	
	public List<GDT.PlatformGameRewardT> GetPlatformGameRewardList(int key)
	{
		if(PlatformGameRewardTable.ContainsKey(key))
		{
			return PlatformGameRewardTable[key];
		}
		return null;
	}
	
	public List<GDT.PlatformGameScheduleT> GetPlatformGameScheduleList(int key)
	{
		if(PlatformGameScheduleTable.ContainsKey(key))
		{
			return PlatformGameScheduleTable[key];
		}
		return null;
	}
	
	public GDT.PlatformGameSeasonT GetPlatformGameSeason(int key)
	{
		if(PlatformGameSeasonTable.ContainsKey(key))
		{
			return PlatformGameSeasonTable[key];
		}
		return null;
	}
	
	public List<GDT.PlatformGameSeasonRewardT> GetPlatformGameSeasonRewardList(int key)
	{
		if(PlatformGameSeasonRewardTable.ContainsKey(key))
		{
			return PlatformGameSeasonRewardTable[key];
		}
		return null;
	}
	
	public GDT.PlatformGamePoseT GetPlatformGamePose(int key)
	{
		if(PlatformGamePoseTable.ContainsKey(key))
		{
			return PlatformGamePoseTable[key];
		}
		return null;
	}
	
	public GDT.PlatformGameObjectT GetPlatformGameObject(int key)
	{
		if(PlatformGameObjectTable.ContainsKey(key))
		{
			return PlatformGameObjectTable[key];
		}
		return null;
	}
	
	public GDT.TriggerInfoT GetTriggerInfo(int key)
	{
		if(TriggerInfoTable.ContainsKey(key))
		{
			return TriggerInfoTable[key];
		}
		return null;
	}
	
	public GDT.SpawnTriggerT GetSpawnTrigger(int key)
	{
		if(SpawnTriggerTable.ContainsKey(key))
		{
			return SpawnTriggerTable[key];
		}
		return null;
	}
	
	public GDT.AnimationTriggerT GetAnimationTrigger(int key)
	{
		if(AnimationTriggerTable.ContainsKey(key))
		{
			return AnimationTriggerTable[key];
		}
		return null;
	}
	
	public GDT.RespawnTriggerT GetRespawnTrigger(int key)
	{
		if(RespawnTriggerTable.ContainsKey(key))
		{
			return RespawnTriggerTable[key];
		}
		return null;
	}
	
	public GDT.SkillTriggerT GetSkillTrigger(int key)
	{
		if(SkillTriggerTable.ContainsKey(key))
		{
			return SkillTriggerTable[key];
		}
		return null;
	}
	
	public GDT.TrackTriggerT GetTrackTrigger(int key)
	{
		if(TrackTriggerTable.ContainsKey(key))
		{
			return TrackTriggerTable[key];
		}
		return null;
	}
	
	public GDT.DoorTriggerT GetDoorTrigger(int key)
	{
		if(DoorTriggerTable.ContainsKey(key))
		{
			return DoorTriggerTable[key];
		}
		return null;
	}
	
	public GDT.StandbyPositionParentT GetStandbyPositionParent(int key)
	{
		if(StandbyPositionParentTable.ContainsKey(key))
		{
			return StandbyPositionParentTable[key];
		}
		return null;
	}
	
	public List<GDT.StandbyPositionInfoT> GetStandbyPositionInfoList(int key)
	{
		if(StandbyPositionInfoTable.ContainsKey(key))
		{
			return StandbyPositionInfoTable[key];
		}
		return null;
	}
	
	public GDT.StagePositionInfoT GetStagePositionInfo(int key)
	{
		if(StagePositionInfoTable.ContainsKey(key))
		{
			return StagePositionInfoTable[key];
		}
		return null;
	}
	
	public GDT.PGObjectSpawnerT GetPGObjectSpawner(int key)
	{
		if(PGObjectSpawnerTable.ContainsKey(key))
		{
			return PGObjectSpawnerTable[key];
		}
		return null;
	}
	
	public GDT.PGObjectRandomSpawnerT GetPGObjectRandomSpawner(int key)
	{
		if(PGObjectRandomSpawnerTable.ContainsKey(key))
		{
			return PGObjectRandomSpawnerTable[key];
		}
		return null;
	}
	
	public List<GDT.PGSpawnerPosGroupT> GetPGSpawnerPosGroupList(int key)
	{
		if(PGSpawnerPosGroupTable.ContainsKey(key))
		{
			return PGSpawnerPosGroupTable[key];
		}
		return null;
	}
	
	public GDT.PGPendulumT GetPGPendulum(int key)
	{
		if(PGPendulumTable.ContainsKey(key))
		{
			return PGPendulumTable[key];
		}
		return null;
	}
	
	public List<GDT.PGObstacleT> GetPGObstacleList(int key)
	{
		if(PGObstacleTable.ContainsKey(key))
		{
			return PGObstacleTable[key];
		}
		return null;
	}
	
	public GDT.QuestCameraT GetQuestCamera(int key)
	{
		if(QuestCameraTable.ContainsKey(key))
		{
			return QuestCameraTable[key];
		}
		return null;
	}
	
	public GDT.QuestGroupInfoT GetQuestGroupInfo(int key)
	{
		if(QuestGroupInfoTable.ContainsKey(key))
		{
			return QuestGroupInfoTable[key];
		}
		return null;
	}
	
	public GDT.QuestTabInfoT GetQuestTabInfo(int key)
	{
		if(QuestTabInfoTable.ContainsKey(key))
		{
			return QuestTabInfoTable[key];
		}
		return null;
	}
	
	public List<GDT.RedDotPositionT> GetRedDotPositionList(GDT.ReddotMainType key)
	{
		if(RedDotPositionTable.ContainsKey(key))
		{
			return RedDotPositionTable[key];
		}
		return null;
	}
	
	public List<GDT.RewardDataT> GetRewardDataList(int key)
	{
		if(RewardDataTable.ContainsKey(key))
		{
			return RewardDataTable[key];
		}
		return null;
	}
	
	public GDT.ScenarioDialogT GetScenarioDialog(int key)
	{
		if(ScenarioDialogTable.ContainsKey(key))
		{
			return ScenarioDialogTable[key];
		}
		return null;
	}
	
	public List<GDT.ScenarioSceneT> GetScenarioSceneList(int key)
	{
		if(ScenarioSceneTable.ContainsKey(key))
		{
			return ScenarioSceneTable[key];
		}
		return null;
	}
	
	public GDT.SkillInfoT GetSkillInfo(int key)
	{
		if(SkillInfoTable.ContainsKey(key))
		{
			return SkillInfoTable[key];
		}
		return null;
	}
	
	public GDT.SkillAnimationDataT GetSkillAnimationData(int key)
	{
		if(SkillAnimationDataTable.ContainsKey(key))
		{
			return SkillAnimationDataTable[key];
		}
		return null;
	}
	
	public GDT.SkillEventDataT GetSkillEventData(int key)
	{
		if(SkillEventDataTable.ContainsKey(key))
		{
			return SkillEventDataTable[key];
		}
		return null;
	}
	
	public GDT.ProjectileT GetProjectile(int key)
	{
		if(ProjectileTable.ContainsKey(key))
		{
			return ProjectileTable[key];
		}
		return null;
	}
	
	public GDT.SkillGrowthGroupT GetSkillGrowthGroup(int key)
	{
		if(SkillGrowthGroupTable.ContainsKey(key))
		{
			return SkillGrowthGroupTable[key];
		}
		return null;
	}
	
	public GDT.BuffInfoT GetBuffInfo(int key)
	{
		if(BuffInfoTable.ContainsKey(key))
		{
			return BuffInfoTable[key];
		}
		return null;
	}
	
	public List<GDT.BuffDataT> GetBuffDataList(int key)
	{
		if(BuffDataTable.ContainsKey(key))
		{
			return BuffDataTable[key];
		}
		return null;
	}
	
	public GDT.SlangT GetSlang(int key)
	{
		if(SlangTable.ContainsKey(key))
		{
			return SlangTable[key];
		}
		return null;
	}
	
	public GDT.SoundT GetSound(int key)
	{
		if(SoundTable.ContainsKey(key))
		{
			return SoundTable[key];
		}
		return null;
	}
	
	public GDT.SwapCoinT GetSwapCoin(int key)
	{
		if(SwapCoinTable.ContainsKey(key))
		{
			return SwapCoinTable[key];
		}
		return null;
	}
	
	public GDT.SwapCurrencyT GetSwapCurrency(GDT.CurrencySubType key)
	{
		if(SwapCurrencyTable.ContainsKey(key))
		{
			return SwapCurrencyTable[key];
		}
		return null;
	}
	
	public GDT.SystemMessageT GetSystemMessage(string key)
	{
		if(SystemMessageTable.ContainsKey(key))
		{
			return SystemMessageTable[key];
		}
		return null;
	}
	
	public List<GDT.TierT> GetTierList(GDT.TierType key)
	{
		if(TierTable.ContainsKey(key))
		{
			return TierTable[key];
		}
		return null;
	}
	
	public GDT.TokenAddressT GetTokenAddress(string key)
	{
		if(TokenAddressTable.ContainsKey(key))
		{
			return TokenAddressTable[key];
		}
		return null;
	}
	
	public GDT.DevTokenAddressT GetDevTokenAddress(int key)
	{
		if(DevTokenAddressTable.ContainsKey(key))
		{
			return DevTokenAddressTable[key];
		}
		return null;
	}
	
	public GDT.QATokenAddressT GetQATokenAddress(int key)
	{
		if(QATokenAddressTable.ContainsKey(key))
		{
			return QATokenAddressTable[key];
		}
		return null;
	}
	
	public GDT.ProductionTokenAddressT GetProductionTokenAddress(int key)
	{
		if(ProductionTokenAddressTable.ContainsKey(key))
		{
			return ProductionTokenAddressTable[key];
		}
		return null;
	}
	
	public GDT.TreasureLotteryInfoT GetTreasureLotteryInfo(int key)
	{
		if(TreasureLotteryInfoTable.ContainsKey(key))
		{
			return TreasureLotteryInfoTable[key];
		}
		return null;
	}
	
	public GDT.TreasureLotteryPatternT GetTreasureLotteryPattern(int key)
	{
		if(TreasureLotteryPatternTable.ContainsKey(key))
		{
			return TreasureLotteryPatternTable[key];
		}
		return null;
	}
	
	public GDT.TreasureLotteryItemT GetTreasureLotteryItem(int key)
	{
		if(TreasureLotteryItemTable.ContainsKey(key))
		{
			return TreasureLotteryItemTable[key];
		}
		return null;
	}
	
	public List<GDT.TreasureLotteryRewardT> GetTreasureLotteryRewardList(int key)
	{
		if(TreasureLotteryRewardTable.ContainsKey(key))
		{
			return TreasureLotteryRewardTable[key];
		}
		return null;
	}
	
	public List<GDT.TreasureLotteryMultiplierT> GetTreasureLotteryMultiplierList(int key)
	{
		if(TreasureLotteryMultiplierTable.ContainsKey(key))
		{
			return TreasureLotteryMultiplierTable[key];
		}
		return null;
	}
	
	public GDT.TreasureLotterySeasonT GetTreasureLotterySeason(int key)
	{
		if(TreasureLotterySeasonTable.ContainsKey(key))
		{
			return TreasureLotterySeasonTable[key];
		}
		return null;
	}
	
	public GDT.WorldPositionInfoT GetWorldPositionInfo(int key)
	{
		if(WorldPositionInfoTable.ContainsKey(key))
		{
			return WorldPositionInfoTable[key];
		}
		return null;
	}
}
