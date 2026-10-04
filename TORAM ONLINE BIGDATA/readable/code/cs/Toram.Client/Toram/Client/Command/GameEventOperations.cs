// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Command
[CLSCompliant(False)]
public class GameEventOperations // TypeDefIndex: 15133
{
	// Methods

	// RVA: 0x3592068 Offset: 0x358E068 VA: 0x3592068
	public static void SetEvent(Game game, GameEventType type, Dictionary<byte, object> parameters) { }

	// RVA: 0x359217C Offset: 0x358E17C VA: 0x359217C
	public static void GetEvent(Game game, GameEventType type, Dictionary<byte, object> parameters) { }

	// RVA: 0x3592290 Offset: 0x358E290 VA: 0x3592290
	public static void EventSetFlag(Game game, byte eventType, int version, byte flagId, byte value) { }

	// RVA: 0x35923B0 Offset: 0x358E3B0 VA: 0x35923B0
	public static void EventGetFlag(Game game, byte eventType, int version, byte flagId) { }

	// RVA: 0x35924C8 Offset: 0x358E4C8 VA: 0x35924C8
	public static void EventGetScenario(Game game, byte eventType, int version) { }

	// RVA: 0x35925D0 Offset: 0x358E5D0 VA: 0x35925D0
	public static void EventLogin(Game game, byte eventType) { }

	// RVA: 0x35926D0 Offset: 0x358E6D0 VA: 0x35926D0
	public static void EventChangeField(Game game, byte eventType, short[] clientPosition, float clientRotation, float cameraRotation, Dictionary<byte, object> parameters) { }

	// RVA: 0x359285C Offset: 0x358E85C VA: 0x359285C
	public static void EventResult(Game game, byte eventType) { }

	// RVA: 0x359295C Offset: 0x358E95C VA: 0x359295C
	public static void SummerGetPoint(Game game) { }

	// RVA: 0x3592B00 Offset: 0x358EB00 VA: 0x3592B00
	public static void SummerFreeDiving(Game game, short[] clientPosition, float clientRotation, float camaraRotation) { }

	// RVA: 0x3592CFC Offset: 0x358ECFC VA: 0x3592CFC
	public static void SummerEnterDiving(Game game, int enterLobbyId, int[] useSeaItemIds, short[] clientPosition, float clientRotation, float camaraRotation) { }

	// RVA: 0x3592F54 Offset: 0x358EF54 VA: 0x3592F54
	public static void SummerCreateDiving(Game game, SummerRecruitType recruitType, int[] useSeaItemIds, short[] clientPosition, float clientRotation, float camaraRotation) { }

	// RVA: 0x3593198 Offset: 0x358F198 VA: 0x3593198
	public static void SummerRuleChange(Game game, SummerRecruitType recruitType) { }

	// RVA: 0x3593374 Offset: 0x358F374 VA: 0x3593374
	public static void SummerStartGame(Game game) { }

	// RVA: 0x3593518 Offset: 0x358F518 VA: 0x3593518
	public static void SummerPlayerRevive(Game game, int reviveId, short[] position) { }

	// RVA: 0x359371C Offset: 0x358F71C VA: 0x359371C
	public static void SummerGiveUp(Game game) { }
}
