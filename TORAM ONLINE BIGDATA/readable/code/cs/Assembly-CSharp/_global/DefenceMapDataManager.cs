// Assembly: Assembly-CSharp.dll
// Namespace: 
public class DefenceMapDataManager : Singleton<DefenceMapDataManager> // TypeDefIndex: 3871
{
	// Fields
	private int mapWidth; // 0x20
	private int mapHeight; // 0x24
	private int mapSize; // 0x28
	private List<DefenceMapChip> mapList; // 0x30
	private List<GameObject> roomObjectList; // 0x38
	private DefenceStartRoom _startRoom; // 0x40
	private List<DefenceSafeRoom> _safeRoomList; // 0x48
	private List<DefenceMonsterRoom> _monsterRoomList; // 0x50

	// Properties
	public List<DefenceMapChip> MapList { get; }
	public DefenceStartRoom StartRoom { get; }
	public List<DefenceSafeRoom> SafeRoomList { get; }
	public List<DefenceMonsterRoom> MonsterRoomList { get; }
	public int CrystalCount { get; }
	public int NoDamageCrystalCount { get; }
	public int CrystalHP { get; }
	public int CrystalHP_percent { get; }

	// Methods

	// RVA: 0x24012FC Offset: 0x23FD2FC VA: 0x24012FC
	public List<DefenceMapChip> get_MapList() { }

	// RVA: 0x2401304 Offset: 0x23FD304 VA: 0x2401304
	public DefenceStartRoom get_StartRoom() { }

	// RVA: 0x2401450 Offset: 0x23FD450 VA: 0x2401450
	public List<DefenceSafeRoom> get_SafeRoomList() { }

	// RVA: 0x2401678 Offset: 0x23FD678 VA: 0x2401678
	public List<DefenceMonsterRoom> get_MonsterRoomList() { }

	// RVA: 0x24018A0 Offset: 0x23FD8A0 VA: 0x24018A0
	public int get_CrystalCount() { }

	// RVA: 0x24019D0 Offset: 0x23FD9D0 VA: 0x24019D0
	public int get_NoDamageCrystalCount() { }

	// RVA: 0x2401B00 Offset: 0x23FDB00 VA: 0x2401B00
	public int get_CrystalHP() { }

	// RVA: 0x2401C0C Offset: 0x23FDC0C VA: 0x2401C0C
	public int get_CrystalHP_percent() { }

	// RVA: 0x2401E14 Offset: 0x23FDE14 VA: 0x2401E14
	private void Awake() { }

	// RVA: 0x2401E28 Offset: 0x23FDE28 VA: 0x2401E28
	public void Create(List<DefenceMapChip> serverList) { }

	// RVA: 0x2401ECC Offset: 0x23FDECC VA: 0x2401ECC
	public void Clear() { }

	// RVA: 0x240285C Offset: 0x23FE85C VA: 0x240285C
	public void FadeoutMagicSquare() { }

	// RVA: 0x24029AC Offset: 0x23FE9AC VA: 0x24029AC
	public void GetMap(Vector3 position, out int x, out int y) { }

	// RVA: 0x2402B78 Offset: 0x23FEB78 VA: 0x2402B78
	public byte GetGuide(int x, int y, DefencePoint2 targetPoint) { }

	// RVA: 0x2402CC0 Offset: 0x23FECC0 VA: 0x2402CC0
	public byte GetGuide(int x, int y, int targetX, int targetY) { }

	// RVA: 0x2402CD4 Offset: 0x23FECD4 VA: 0x2402CD4
	public Vector3 GuideToDir(byte guide) { }

	// RVA: 0x2402E08 Offset: 0x23FEE08 VA: 0x2402E08
	public Vector3 GetGuideToDirection(int x, int y, DefencePoint2 targetPoint) { }

	// RVA: 0x2402E68 Offset: 0x23FEE68 VA: 0x2402E68
	public DefenceSafeRoom GetSafeRoom(int x, int y) { }

	// RVA: 0x2402F60 Offset: 0x23FEF60 VA: 0x2402F60
	public DefenceSafeRoom GetSafeRoom(Vector3 pos) { }

	// RVA: 0x2402F90 Offset: 0x23FEF90 VA: 0x2402F90
	public DefenceSafeRoom GetSafeRoom(int id) { }

	// RVA: 0x240307C Offset: 0x23FF07C VA: 0x240307C
	public bool IsRoom(int x, int y) { }

	// RVA: 0x240315C Offset: 0x23FF15C VA: 0x240315C
	public bool IsRoom(Vector3 pos) { }

	// RVA: 0x240318C Offset: 0x23FF18C VA: 0x240318C
	public DefenceSafeRoom GetNearSafeRoom(Vector3 pos) { }

	// RVA: 0x2402368 Offset: 0x23FE368 VA: 0x2402368
	private void CreateRoomObject() { }

	// RVA: 0x2403640 Offset: 0x23FF640 VA: 0x2403640
	public void .ctor() { }
}
