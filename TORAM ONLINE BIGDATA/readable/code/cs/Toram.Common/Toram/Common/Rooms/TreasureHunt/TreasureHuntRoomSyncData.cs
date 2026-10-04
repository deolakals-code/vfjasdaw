// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Rooms.TreasureHunt
public class TreasureHuntRoomSyncData : RoomSyncDataBase // TypeDefIndex: 11336
{
	// Fields
	[CompilerGenerated]
	private bool <EntreeStagingFlag>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <GameState>k__BackingField; // 0x29
	[CompilerGenerated]
	private byte <GameEnd>k__BackingField; // 0x2A
	[CompilerGenerated]
	private int <TimeLeft>k__BackingField; // 0x2C
	[CompilerGenerated]
	private TreasureHuntMobData[] <MobList>k__BackingField; // 0x30
	[CompilerGenerated]
	private TreasureHuntTreasureData[] <TreasureList>k__BackingField; // 0x38
	[CompilerGenerated]
	private byte[] <AcquireTreasureList>k__BackingField; // 0x40
	[CompilerGenerated]
	private short <RetVal>k__BackingField; // 0x48
	[CompilerGenerated]
	private short[] <StartCoordinate>k__BackingField; // 0x50
	[CompilerGenerated]
	private short <StartRotation>k__BackingField; // 0x58

	// Properties
	[UnityHash(Code = 161)]
	public bool EntreeStagingFlag { get; set; }
	[UnityHash(Code = 70)]
	public byte GameState { get; set; }
	[UnityHash(Code = 141)]
	public byte GameEnd { get; set; }
	[UnityHash(Code = 172)]
	public int TimeLeft { get; set; }
	[UnityHash(Code = 89, IsOptional = True)]
	public TreasureHuntMobData[] MobList { get; set; }
	[UnityHash(Code = 213, IsOptional = True)]
	public TreasureHuntTreasureData[] TreasureList { get; set; }
	[UnityHash(Code = 199)]
	public byte[] AcquireTreasureList { get; set; }
	[UnityHash(Code = 195, IsOptional = True)]
	public short RetVal { get; set; }
	[UnityHash(Code = 54)]
	public short[] StartCoordinate { get; set; }
	[UnityHash(Code = 65)]
	public short StartRotation { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36ECC90 Offset: 0x36E8C90 VA: 0x36ECC90
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36ECC98 Offset: 0x36E8C98 VA: 0x36ECC98
	public bool get_EntreeStagingFlag() { }

	[CompilerGenerated]
	// RVA: 0x36ECCA0 Offset: 0x36E8CA0 VA: 0x36ECCA0
	public void set_EntreeStagingFlag(bool value) { }

	[CompilerGenerated]
	// RVA: 0x36ECCAC Offset: 0x36E8CAC VA: 0x36ECCAC
	public byte get_GameState() { }

	[CompilerGenerated]
	// RVA: 0x36ECCB4 Offset: 0x36E8CB4 VA: 0x36ECCB4
	public void set_GameState(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36ECCBC Offset: 0x36E8CBC VA: 0x36ECCBC
	public byte get_GameEnd() { }

	[CompilerGenerated]
	// RVA: 0x36ECCC4 Offset: 0x36E8CC4 VA: 0x36ECCC4
	public void set_GameEnd(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36ECCCC Offset: 0x36E8CCC VA: 0x36ECCCC
	public int get_TimeLeft() { }

	[CompilerGenerated]
	// RVA: 0x36ECCD4 Offset: 0x36E8CD4 VA: 0x36ECCD4
	public void set_TimeLeft(int value) { }

	[CompilerGenerated]
	// RVA: 0x36ECCDC Offset: 0x36E8CDC VA: 0x36ECCDC
	public TreasureHuntMobData[] get_MobList() { }

	[CompilerGenerated]
	// RVA: 0x36ECCE4 Offset: 0x36E8CE4 VA: 0x36ECCE4
	public void set_MobList(TreasureHuntMobData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36ECCEC Offset: 0x36E8CEC VA: 0x36ECCEC
	public TreasureHuntTreasureData[] get_TreasureList() { }

	[CompilerGenerated]
	// RVA: 0x36ECCF4 Offset: 0x36E8CF4 VA: 0x36ECCF4
	public void set_TreasureList(TreasureHuntTreasureData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36ECCFC Offset: 0x36E8CFC VA: 0x36ECCFC
	public byte[] get_AcquireTreasureList() { }

	[CompilerGenerated]
	// RVA: 0x36ECD04 Offset: 0x36E8D04 VA: 0x36ECD04
	public void set_AcquireTreasureList(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x36ECD0C Offset: 0x36E8D0C VA: 0x36ECD0C
	public short get_RetVal() { }

	[CompilerGenerated]
	// RVA: 0x36ECD14 Offset: 0x36E8D14 VA: 0x36ECD14
	public void set_RetVal(short value) { }

	[CompilerGenerated]
	// RVA: 0x36ECD1C Offset: 0x36E8D1C VA: 0x36ECD1C
	public short[] get_StartCoordinate() { }

	[CompilerGenerated]
	// RVA: 0x36ECD24 Offset: 0x36E8D24 VA: 0x36ECD24
	public void set_StartCoordinate(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x36ECD2C Offset: 0x36E8D2C VA: 0x36ECD2C
	public short get_StartRotation() { }

	[CompilerGenerated]
	// RVA: 0x36ECD34 Offset: 0x36E8D34 VA: 0x36ECD34
	public void set_StartRotation(short value) { }

	// RVA: 0x36ECD3C Offset: 0x36E8D3C VA: 0x36ECD3C
	private void SetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x36ECF34 Offset: 0x36E8F34 VA: 0x36ECF34
	private void GetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x36ED058 Offset: 0x36E9058 VA: 0x36ED058 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36ED060 Offset: 0x36E9060 VA: 0x36ED060 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36ED544 Offset: 0x36E9544 VA: 0x36ED544 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
