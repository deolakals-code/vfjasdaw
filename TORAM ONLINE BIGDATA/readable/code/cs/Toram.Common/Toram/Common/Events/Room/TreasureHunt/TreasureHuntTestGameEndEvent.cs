// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room.TreasureHunt
public class TreasureHuntTestGameEndEvent : EventSubBase // TypeDefIndex: 12797
{
	// Fields
	[CompilerGenerated]
	private byte <GameEndCode>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <ScriptRetval>k__BackingField; // 0x22
	[CompilerGenerated]
	private byte[] <acquiredTreasureNums>k__BackingField; // 0x28
	[CompilerGenerated]
	private TreasureHuntResultBonusData[] <ResultBonusDatas>k__BackingField; // 0x30
	[CompilerGenerated]
	private Dictionary<byte, byte> <RewardList>k__BackingField; // 0x38
	[CompilerGenerated]
	private int <Point>k__BackingField; // 0x40

	// Properties
	[PacketClass(Code = 141)]
	public byte GameEndCode { get; set; }
	[PacketClass(Code = 195)]
	public short ScriptRetval { get; set; }
	[PacketClass(Code = 253, IsOptional = True)]
	public byte[] acquiredTreasureNums { get; set; }
	[PacketClass(Code = 206, IsOptional = True)]
	public TreasureHuntResultBonusData[] ResultBonusDatas { get; set; }
	[PacketClass(Code = 213, IsOptional = True)]
	public Dictionary<byte, byte> RewardList { get; set; }
	[PacketClass(Code = 205, IsOptional = True)]
	public int Point { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x365B0B8 Offset: 0x36570B8 VA: 0x365B0B8
	public void .ctor() { }

	// RVA: 0x365B0C0 Offset: 0x36570C0 VA: 0x365B0C0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x365B0C8 Offset: 0x36570C8 VA: 0x365B0C8
	public byte get_GameEndCode() { }

	[CompilerGenerated]
	// RVA: 0x365B0D0 Offset: 0x36570D0 VA: 0x365B0D0
	public void set_GameEndCode(byte value) { }

	[CompilerGenerated]
	// RVA: 0x365B0D8 Offset: 0x36570D8 VA: 0x365B0D8
	public short get_ScriptRetval() { }

	[CompilerGenerated]
	// RVA: 0x365B0E0 Offset: 0x36570E0 VA: 0x365B0E0
	public void set_ScriptRetval(short value) { }

	[CompilerGenerated]
	// RVA: 0x365B0E8 Offset: 0x36570E8 VA: 0x365B0E8
	public byte[] get_acquiredTreasureNums() { }

	[CompilerGenerated]
	// RVA: 0x365B0F0 Offset: 0x36570F0 VA: 0x365B0F0
	public void set_acquiredTreasureNums(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x365B0F8 Offset: 0x36570F8 VA: 0x365B0F8
	public TreasureHuntResultBonusData[] get_ResultBonusDatas() { }

	[CompilerGenerated]
	// RVA: 0x365B100 Offset: 0x3657100 VA: 0x365B100
	public void set_ResultBonusDatas(TreasureHuntResultBonusData[] value) { }

	[CompilerGenerated]
	// RVA: 0x365B108 Offset: 0x3657108 VA: 0x365B108
	public Dictionary<byte, byte> get_RewardList() { }

	[CompilerGenerated]
	// RVA: 0x365B110 Offset: 0x3657110 VA: 0x365B110
	public void set_RewardList(Dictionary<byte, byte> value) { }

	[CompilerGenerated]
	// RVA: 0x365B118 Offset: 0x3657118 VA: 0x365B118
	public int get_Point() { }

	[CompilerGenerated]
	// RVA: 0x365B120 Offset: 0x3657120 VA: 0x365B120
	public void set_Point(int value) { }

	// RVA: 0x365B128 Offset: 0x3657128 VA: 0x365B128 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x365B130 Offset: 0x3657130 VA: 0x365B130 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x365B138 Offset: 0x3657138 VA: 0x365B138 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x365B4F0 Offset: 0x36574F0 VA: 0x365B4F0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
