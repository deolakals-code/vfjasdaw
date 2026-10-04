// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Command
[CLSCompliant(False)]
public static class RoomOperations // TypeDefIndex: 15142
{
	// Methods

	// RVA: 0x35A6FE4 Offset: 0x35A2FE4 VA: 0x35A6FE4
	public static void CheckBossSymbol(Game game, int fieldId, byte roomId, bool forcibly, byte detailFlag) { }

	// RVA: 0x35A7124 Offset: 0x35A3124 VA: 0x35A7124
	public static void CheckDefenceRoom(Game game, int fieldId, byte flag, short level) { }

	// RVA: 0x35A7250 Offset: 0x35A3250 VA: 0x35A7250
	public static void CheckWaveRoom(Game game, int fieldId, byte roomId, short level) { }

	// RVA: 0x35A737C Offset: 0x35A337C VA: 0x35A737C
	public static void RoomState(Game game, byte archetypeType, int archetypeId) { }

	// RVA: 0x35A7498 Offset: 0x35A3498 VA: 0x35A7498
	public static void RoomGroupSettingChange(Game game, bool isReinforce, short areaLevel) { }

	// RVA: 0x35A75F4 Offset: 0x35A35F4 VA: 0x35A75F4
	public static void RoomJoinCancel(Game game) { }

	// RVA: 0x35A7700 Offset: 0x35A3700 VA: 0x35A7700
	public static void RoomStartEntry(Game game, int fieldId, byte roomType, byte roomId, RoomGroupSetting groupSetting, short[] position, float rotation, EmergencyPositionData emergencyPosition, int[] supportItems, int[] supportOrbItems) { }

	// RVA: 0x35A78BC Offset: 0x35A38BC VA: 0x35A78BC
	public static void RoomJoinReady(Game game, int[] supportItems, int[] supportOrbItems) { }

	// RVA: 0x35A79F0 Offset: 0x35A39F0 VA: 0x35A79F0
	public static void RoomJoinReadyCancel(Game game) { }

	// RVA: 0x35A7AFC Offset: 0x35A3AFC VA: 0x35A7AFC
	public static void RoomBattleStart(Game game, short[] position, float rotation, EmergencyPositionData emergencyPosition, int[] supportItems, int[] supportOrbItems) { }

	// RVA: 0x35A7C7C Offset: 0x35A3C7C VA: 0x35A7C7C
	public static void RoomBattleJoin(Game game, short[] position, float rotation, EmergencyPositionData emergencyPosition) { }

	// RVA: 0x35A7DCC Offset: 0x35A3DCC VA: 0x35A7DCC
	public static void LeaveRoom(Game game, int fieldId, byte roomType, byte roomId, short[] position, float rotation) { }

	// RVA: 0x35A7F28 Offset: 0x35A3F28 VA: 0x35A7F28
	public static void LeaveRoom(Game game) { }

	// RVA: 0x35A803C Offset: 0x35A403C VA: 0x35A803C
	public static void RoomWarpPosition(Game game, short[] position) { }

	// RVA: 0x35A815C Offset: 0x35A415C VA: 0x35A815C
	public static void NpcAvatarJoin(Game game, byte archetypeType, int archetypeId, short[] position, float rotation) { }

	// RVA: 0x35A82B0 Offset: 0x35A42B0 VA: 0x35A82B0
	public static void NpcAvatarRejoin(Game game, byte archetypeType, int archetypeId, short[] position, float rotation) { }

	// RVA: 0x35A8404 Offset: 0x35A4404 VA: 0x35A8404
	public static void CheckDungeonRoom(Game game, byte archetypeType, int archetypeId, int fieldId, byte roomId, int guildId) { }

	// RVA: 0x35A8548 Offset: 0x35A4548 VA: 0x35A8548
	public static void DungeonGroupSettingChange(Game game, byte archetypeType, int archetypeId, short floorDepth) { }

	// RVA: 0x35A8674 Offset: 0x35A4674 VA: 0x35A8674
	public static void RoomRespawn(Game game) { }

	// RVA: 0x35A8780 Offset: 0x35A4780 VA: 0x35A8780
	public static void RoomRetire(Game game) { }

	// RVA: 0x35A888C Offset: 0x35A488C VA: 0x35A888C
	public static void WaveMobTargetAttack(Game game, short targetId, int mobUniqueId, int damage, bool isCombo) { }

	// RVA: 0x35A89C4 Offset: 0x35A49C4 VA: 0x35A89C4
	public static void CheckRaidBossSymbol(Game game, int fieldId, byte roomId, bool isForcibly, bool isDetail, bool isMatching, bool isSecondParty) { }

	// RVA: 0x35A8B40 Offset: 0x35A4B40 VA: 0x35A8B40
	public static void RoomLobbyState(Game game) { }

	// RVA: 0x35A8C08 Offset: 0x35A4C08 VA: 0x35A8C08
	public static void RoomLobbyLeave(Game game) { }

	// RVA: 0x35A8CD0 Offset: 0x35A4CD0 VA: 0x35A8CD0
	public static void RoomLobbySettingChange(Game game, short areaLevel, bool isMatching, bool isSecondParty) { }

	// RVA: 0x35A8E38 Offset: 0x35A4E38 VA: 0x35A8E38
	public static void RoomLobbyJoin(Game game) { }

	// RVA: 0x35A8F44 Offset: 0x35A4F44 VA: 0x35A8F44
	public static void RoomLobbyJoin(Game game, byte[] bonusList) { }

	// RVA: 0x35A9064 Offset: 0x35A5064 VA: 0x35A9064
	public static void RoomLobbyJoin(Game game, int[] supportItems, int[] supportOrbItems) { }

	// RVA: 0x35A9198 Offset: 0x35A5198 VA: 0x35A9198
	public static void RoomLobbyJoin_Plus(Game game, byte[] bonusList, int[] supportItems, int[] supportOrbItems) { }

	// RVA: 0x35A92E8 Offset: 0x35A52E8 VA: 0x35A92E8
	public static void RoomLobbyJoinCancel(Game game) { }

	// RVA: 0x35A93B0 Offset: 0x35A53B0 VA: 0x35A93B0
	public static void RoomLobbyBattleStart(Game game, short[] position, float rotation, EmergencyPositionData emergencyPosition) { }

	// RVA: 0x35A9500 Offset: 0x35A5500 VA: 0x35A9500
	public static void TreasureHuntRoomLobbyBattleStart(Game game, short[] position, float rotation, EmergencyPositionData emergencyPosition, byte[] bonusList) { }

	// RVA: 0x35A966C Offset: 0x35A566C VA: 0x35A966C
	public static void HighRaidRoomLobbyBattleStart(Game game, short[] position, float rotation, EmergencyPositionData emergencyPosition, int[] supportItems, int[] supportOrbItems) { }

	// RVA: 0x35A97EC Offset: 0x35A57EC VA: 0x35A97EC
	public static void TreasureHuntRoomLobbyBattleStart_Plus(Game game, short[] position, float rotation, EmergencyPositionData emergencyPosition, byte[] bonusList, int[] supportItems, int[] supportOrbItems) { }

	// RVA: 0x35A9988 Offset: 0x35A5988 VA: 0x35A9988
	public static void RoomLobbyBattleJoin(Game game, short[] position, float rotation, EmergencyPositionData emergencyPosition) { }

	// RVA: 0x35A9AD8 Offset: 0x35A5AD8 VA: 0x35A9AD8
	public static void RoomStart(Game game) { }

	// RVA: 0x35A9BA0 Offset: 0x35A5BA0 VA: 0x35A9BA0
	public static void RoomSecondPartyRegistry(Game game, int[] secondPartyNpcIds) { }

	// RVA: 0x35A9CC0 Offset: 0x35A5CC0 VA: 0x35A9CC0
	public static void RoomSecondPartyJoin(Game game, NpcJoinPositionData[] joinNpcs) { }

	// RVA: 0x35A9DE0 Offset: 0x35A5DE0 VA: 0x35A9DE0
	public static void CheckTreasureHuntRoom(Game game, int fieldId, byte roomId) { }

	// RVA: 0x35A9EFC Offset: 0x35A5EFC VA: 0x35A9EFC
	public static void AddHateMonster(Game game, int uniqueId) { }

	// RVA: 0x35AA010 Offset: 0x35A6010 VA: 0x35AA010
	public static void AcquireTreasure(Game game, TreasureHuntTreasureData treasure) { }

	// RVA: 0x35AA130 Offset: 0x35A6130 VA: 0x35AA130
	public static void CheckWaveRaidRoom(Game game, int fieldId, byte roomId) { }

	// RVA: 0x35AA27C Offset: 0x35A627C VA: 0x35AA27C
	public static void WaveRaidMobTargetAttack(Game game, short targetId, int mobUniqueId, int damage, bool isCombo) { }

	// RVA: 0x35AA284 Offset: 0x35A6284 VA: 0x35AA284
	public static void CheckNewWaveRoom(Game game, int fieldId, byte roomId, bool isForcibly, bool isMatching) { }

	// RVA: 0x35AA3D0 Offset: 0x35A63D0 VA: 0x35AA3D0
	public static void NewWaveMobTargetAttack(Game game, short targetId, int mobUniqueId, int damage, bool isCombo) { }

	// RVA: 0x35AA3D8 Offset: 0x35A63D8 VA: 0x35AA3D8
	public static void CheckHighRaidRoom(Game game, byte highRaidNo) { }

	// RVA: 0x35AA4EC Offset: 0x35A64EC VA: 0x35AA4EC
	public static void CheckGuildRaidRoom(Game game) { }

	// RVA: 0x35AA5B4 Offset: 0x35A65B4 VA: 0x35AA5B4
	public static void GuildRaidRoomLobbyJoin(Game game) { }

	// RVA: 0x35AA6AC Offset: 0x35A66AC VA: 0x35AA6AC
	public static void GuildRaidRoomLobbyJoinCancel(Game game) { }

	// RVA: 0x35AA774 Offset: 0x35A6774 VA: 0x35AA774
	public static void GuildRaidRoomLobbyBattleStart(Game game, short[] position, float rotation, EmergencyPositionData emergencyPosition) { }

	// RVA: 0x35AA8B0 Offset: 0x35A68B0 VA: 0x35AA8B0
	public static void GuildRaidRoomLobbyState(Game game) { }
}
