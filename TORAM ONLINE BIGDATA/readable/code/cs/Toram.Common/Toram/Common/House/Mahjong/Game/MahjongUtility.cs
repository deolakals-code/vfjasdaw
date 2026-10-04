// Assembly: Toram.Common.dll
// Namespace: Toram.Common.House.Mahjong.Game
public class MahjongUtility // TypeDefIndex: 12579
{
	// Fields
	private static readonly Dictionary<int, byte> windTiles; // 0x0
	private static int[] KokushimusoBit; // 0x8
	private static readonly List<int> GreenTiles; // 0x10
	public static readonly List<int> ThinkingTimeList; // 0x18

	// Methods

	// RVA: 0x3622BF4 Offset: 0x361EBF4 VA: 0x3622BF4
	private static void .cctor() { }

	// RVA: 0x3623220 Offset: 0x361F220 VA: 0x3623220
	public static byte GetWind(int id) { }

	// RVA: 0x36232F4 Offset: 0x361F2F4 VA: 0x36232F4
	public static int GetSuitNumber(int id) { }

	// RVA: 0x3623378 Offset: 0x361F378 VA: 0x3623378
	public static bool IsYaochu(int id) { }

	// RVA: 0x362336C Offset: 0x361F36C VA: 0x362336C
	public static bool IsHonour(int id) { }

	// RVA: 0x36233B0 Offset: 0x361F3B0 VA: 0x36233B0
	public static bool IsWind(int id) { }

	// RVA: 0x362342C Offset: 0x361F42C VA: 0x362342C
	public static bool IsSangen(int id) { }

	// RVA: 0x362343C Offset: 0x361F43C VA: 0x362343C
	public static bool IsManzu(int id) { }

	// RVA: 0x3623448 Offset: 0x361F448 VA: 0x3623448
	public static bool IsSozu(int id) { }

	// RVA: 0x3623458 Offset: 0x361F458 VA: 0x3623458
	public static bool IsPinzu(int id) { }

	// RVA: 0x3623468 Offset: 0x361F468 VA: 0x3623468
	public static bool IsGreen(int id) { }

	// RVA: 0x36234E8 Offset: 0x361F4E8 VA: 0x36234E8
	public static int GetDoraId(int id, MahjongMemberType type = 0) { }

	// RVA: 0x3623624 Offset: 0x361F624 VA: 0x3623624
	public static List<MahjongMentsuData> GetToitsuList(int[] tileCounts, List<MahjongTileData> tiles) { }

	// RVA: 0x3623950 Offset: 0x361F950 VA: 0x3623950
	public static List<MahjongMentsuData> SearchKotsuCandidate(int[] tileCounts, List<MahjongTileData> tiles) { }

	// RVA: 0x3623C64 Offset: 0x361FC64 VA: 0x3623C64
	public static List<MahjongMentsuData> SearchShuntsuCandidate(int[] tileCounts, List<MahjongTileData> tiles) { }

	// RVA: 0x3624384 Offset: 0x3620384 VA: 0x3624384
	public static bool IsRyanmen(MahjongMentsuData mentsu, MahjongTileData last) { }

	// RVA: 0x3624488 Offset: 0x3620488 VA: 0x3624488
	public static bool CheckCanPon(MahjongTileData[] tiles, MahjongTileData discard) { }

	// RVA: 0x3624578 Offset: 0x3620578 VA: 0x3624578
	public static bool CheckCanChii(MahjongTileData[] tiles, MahjongTileData discard) { }

	// RVA: 0x36249C0 Offset: 0x36209C0 VA: 0x36249C0
	public static bool CheckMinKan(MahjongTileData[] tiles, MahjongTileData discard) { }

	// RVA: 0x3624AB0 Offset: 0x3620AB0 VA: 0x3624AB0
	public static bool CheckAnkan(MahjongTileData[] tiles) { }

	// RVA: 0x3624BE0 Offset: 0x3620BE0 VA: 0x3624BE0
	public static bool CheckKakan(MahjongTileData[] tiles, MahjongMentsuData[] mentsuList) { }

	// RVA: 0x3624D48 Offset: 0x3620D48 VA: 0x3624D48
	public static bool CheckKokushimuso(int[] hands, int lastTileId, out bool isJusanmenmachi) { }

	// RVA: 0x3624EA4 Offset: 0x3620EA4 VA: 0x3624EA4
	public static List<MahjongHandMentsuData> CalcMentsu(MahjongTileData[] tiles, MahjongMentsuData[] mentsuList, MahjongTileData last) { }

	// RVA: 0x3624914 Offset: 0x3620914 VA: 0x3624914
	public static int[] ConvertTilesToTileCounts(MahjongTileData[] tiles) { }

	// RVA: 0x3625B38 Offset: 0x3621B38 VA: 0x3625B38
	public static bool CheckTenpai(MahjongTileData[] tiles, MahjongMentsuData[] mentsuList, out int[] winTileIds) { }
}
