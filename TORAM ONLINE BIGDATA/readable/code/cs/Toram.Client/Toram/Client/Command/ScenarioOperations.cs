// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Command
[CLSCompliant(False)]
public static class ScenarioOperations // TypeDefIndex: 15143
{
	// Methods

	// RVA: 0x35AA978 Offset: 0x35A6978 VA: 0x35AA978
	public static void MissionGetData(Game game, int avatarUuid, int missionId) { }

	// RVA: 0x35AAA7C Offset: 0x35A6A7C VA: 0x35AAA7C
	public static void MissionStart(Game game, int avatarUuid, int missionId) { }

	// RVA: 0x35AAAFC Offset: 0x35A6AFC VA: 0x35AAAFC
	public static void MissionSetKey(Game game, int avatarUuid, int missionId, MissionKeyCommon missionKey) { }

	// RVA: 0x35AAB98 Offset: 0x35A6B98 VA: 0x35AAB98
	public static void MissionViewChange(Game game, int avatarUuid, int missionId, byte changeFlag, short keySetting, short itemSetting, short mobSetting, byte missionInfoNo) { }

	// RVA: 0x35AAC58 Offset: 0x35A6C58 VA: 0x35AAC58
	public static void MissionReward(Game game, int avatarUuid, int missionId, byte rewardId) { }

	// RVA: 0x35AACE8 Offset: 0x35A6CE8 VA: 0x35AACE8
	public static void MissionAbandonment(Game game, int avatarUuid) { }

	// RVA: 0x35AAD64 Offset: 0x35A6D64 VA: 0x35AAD64
	public static void MissionEnd(Game game, int avatarUuid, int missionId) { }

	// RVA: 0x35AADE4 Offset: 0x35A6DE4 VA: 0x35AADE4
	public static void QuestGetData(Game game, int avatarUuid, int questId) { }

	// RVA: 0x35AAEE8 Offset: 0x35A6EE8 VA: 0x35AAEE8
	public static void QuestAbandonment(Game game, int avatarUuid, int questId) { }

	// RVA: 0x35AAF68 Offset: 0x35A6F68 VA: 0x35AAF68
	public static void QuestStart(Game game, int avatarUuid, int questId) { }

	// RVA: 0x35AAFE8 Offset: 0x35A6FE8 VA: 0x35AAFE8
	public static void QuestSetKey(Game game, int avatarUuid, int questId, QuestKeyCommon questKey) { }

	// RVA: 0x35AB084 Offset: 0x35A7084 VA: 0x35AB084
	public static void QuestViewChange(Game game, int avatarUuid, int questId, byte changeFlag, short keySetting, short itemSetting, short mobSetting, byte questInfoNo) { }

	// RVA: 0x35AB144 Offset: 0x35A7144 VA: 0x35AB144
	public static void QuestReward(Game game, int avatarUuid, int questId, byte rewardId) { }

	// RVA: 0x35AB1D4 Offset: 0x35A71D4 VA: 0x35AB1D4
	public static void QuestContinuousReward(Game game, int questId, byte rewardId, byte count, bool isStopMaxExp) { }

	// RVA: 0x35AB274 Offset: 0x35A7274 VA: 0x35AB274
	public static void QuestEnd(Game game, int avatarUuid, int questId) { }
}
