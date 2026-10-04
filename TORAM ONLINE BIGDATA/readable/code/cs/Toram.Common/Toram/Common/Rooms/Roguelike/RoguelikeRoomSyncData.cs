// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Rooms.Roguelike
public class RoguelikeRoomSyncData : RoomSyncDataBase // TypeDefIndex: 11351
{
	// Fields
	[CompilerGenerated]
	private byte <Phase>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <StageIndex>k__BackingField; // 0x29
	[CompilerGenerated]
	private int <LeftTimeSec>k__BackingField; // 0x2C
	[CompilerGenerated]
	private short <PartyBonusRate>k__BackingField; // 0x30
	[CompilerGenerated]
	private RoguelikeBuffData[] <OwnBuffs>k__BackingField; // 0x38
	[CompilerGenerated]
	private Dictionary<int, short[]> <OtherBuffs>k__BackingField; // 0x40
	[CompilerGenerated]
	private Tuple<short, short>[] <BuffOptions>k__BackingField; // 0x48
	[CompilerGenerated]
	private BossSymbolData <BossSymbolData>k__BackingField; // 0x50
	[CompilerGenerated]
	private RoomMemberData[] <Members>k__BackingField; // 0x58

	// Properties
	[UnityHash(Code = 10)]
	public byte Phase { get; set; }
	[UnityHash(Code = 11)]
	public byte StageIndex { get; set; }
	[UnityHash(Code = 12)]
	public int LeftTimeSec { get; set; }
	[UnityHash(Code = 13)]
	public short PartyBonusRate { get; set; }
	[UnityHash(Code = 15)]
	public RoguelikeBuffData[] OwnBuffs { get; set; }
	[UnityHash(Code = 16)]
	public Dictionary<int, short[]> OtherBuffs { get; set; }
	[UnityHash(Code = 17)]
	public Tuple<short, short>[] BuffOptions { get; set; }
	[UnityHash(Code = 29)]
	public BossSymbolData BossSymbolData { get; set; }
	[UnityHash(Code = 5, IsOptional = True)]
	public RoomMemberData[] Members { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36F0C90 Offset: 0x36ECC90 VA: 0x36F0C90
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36F0C98 Offset: 0x36ECC98 VA: 0x36F0C98
	public byte get_Phase() { }

	[CompilerGenerated]
	// RVA: 0x36F0CA0 Offset: 0x36ECCA0 VA: 0x36F0CA0
	public void set_Phase(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36F0CA8 Offset: 0x36ECCA8 VA: 0x36F0CA8
	public byte get_StageIndex() { }

	[CompilerGenerated]
	// RVA: 0x36F0CB0 Offset: 0x36ECCB0 VA: 0x36F0CB0
	public void set_StageIndex(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36F0CB8 Offset: 0x36ECCB8 VA: 0x36F0CB8
	public int get_LeftTimeSec() { }

	[CompilerGenerated]
	// RVA: 0x36F0CC0 Offset: 0x36ECCC0 VA: 0x36F0CC0
	public void set_LeftTimeSec(int value) { }

	[CompilerGenerated]
	// RVA: 0x36F0CC8 Offset: 0x36ECCC8 VA: 0x36F0CC8
	public short get_PartyBonusRate() { }

	[CompilerGenerated]
	// RVA: 0x36F0CD0 Offset: 0x36ECCD0 VA: 0x36F0CD0
	public void set_PartyBonusRate(short value) { }

	[CompilerGenerated]
	// RVA: 0x36F0CD8 Offset: 0x36ECCD8 VA: 0x36F0CD8
	public RoguelikeBuffData[] get_OwnBuffs() { }

	[CompilerGenerated]
	// RVA: 0x36F0CE0 Offset: 0x36ECCE0 VA: 0x36F0CE0
	public void set_OwnBuffs(RoguelikeBuffData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36F0CE8 Offset: 0x36ECCE8 VA: 0x36F0CE8
	public Dictionary<int, short[]> get_OtherBuffs() { }

	[CompilerGenerated]
	// RVA: 0x36F0CF0 Offset: 0x36ECCF0 VA: 0x36F0CF0
	public void set_OtherBuffs(Dictionary<int, short[]> value) { }

	[CompilerGenerated]
	// RVA: 0x36F0CF8 Offset: 0x36ECCF8 VA: 0x36F0CF8
	public Tuple<short, short>[] get_BuffOptions() { }

	[CompilerGenerated]
	// RVA: 0x36F0D00 Offset: 0x36ECD00 VA: 0x36F0D00
	public void set_BuffOptions(Tuple<short, short>[] value) { }

	[CompilerGenerated]
	// RVA: 0x36F0D08 Offset: 0x36ECD08 VA: 0x36F0D08
	public BossSymbolData get_BossSymbolData() { }

	[CompilerGenerated]
	// RVA: 0x36F0D10 Offset: 0x36ECD10 VA: 0x36F0D10
	public void set_BossSymbolData(BossSymbolData value) { }

	[CompilerGenerated]
	// RVA: 0x36F0D18 Offset: 0x36ECD18 VA: 0x36F0D18
	public RoomMemberData[] get_Members() { }

	[CompilerGenerated]
	// RVA: 0x36F0D20 Offset: 0x36ECD20 VA: 0x36F0D20
	public void set_Members(RoomMemberData[] value) { }

	// RVA: 0x36F0D28 Offset: 0x36ECD28 VA: 0x36F0D28 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36F0D30 Offset: 0x36ECD30 VA: 0x36F0D30 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36F1864 Offset: 0x36ED864 VA: 0x36F1864 Slot: 6
	public override Dictionary<object, object> GetValue() { }

	// RVA: 0x36F1D34 Offset: 0x36EDD34 VA: 0x36F1D34
	private static byte[] SerializeOtherBuffs(Dictionary<int, short[]> otherBuffs) { }

	// RVA: 0x36F1570 Offset: 0x36ED570 VA: 0x36F1570
	private static Dictionary<int, short[]> DeserializeOtherBuffs(byte[] binary) { }
}
