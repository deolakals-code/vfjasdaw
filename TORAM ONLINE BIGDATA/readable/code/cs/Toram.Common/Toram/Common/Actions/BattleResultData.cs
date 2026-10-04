// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class BattleResultData : PacketBase // TypeDefIndex: 13148
{
	// Fields
	[CompilerGenerated]
	private ItemDatav2[] <BagItem>k__BackingField; // 0x20
	[CompilerGenerated]
	private WarrantyItemDatav2[] <WarrantyItem>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <IsBagFull>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <TrainingCount>k__BackingField; // 0x34
	[CompilerGenerated]
	private short <Level>k__BackingField; // 0x38
	[CompilerGenerated]
	private int <TotalExpI>k__BackingField; // 0x3C
	[CompilerGenerated]
	private long <TotalExpL>k__BackingField; // 0x40
	[CompilerGenerated]
	private short <AreaBonusGage>k__BackingField; // 0x48

	// Properties
	public ItemDatav2[] BagItem { get; set; }
	public WarrantyItemDatav2[] WarrantyItem { get; set; }
	public byte IsBagFull { get; set; }
	public int TrainingCount { get; set; }
	public short Level { get; set; }
	public int TotalExpI { get; set; }
	public long TotalExpL { get; set; }
	public long TotalExp { get; }
	public short AreaBonusGage { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36B3B14 Offset: 0x36AFB14 VA: 0x36B3B14
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36B3B1C Offset: 0x36AFB1C VA: 0x36B3B1C
	public ItemDatav2[] get_BagItem() { }

	[CompilerGenerated]
	// RVA: 0x36B3B24 Offset: 0x36AFB24 VA: 0x36B3B24
	public void set_BagItem(ItemDatav2[] value) { }

	[CompilerGenerated]
	// RVA: 0x36B3B2C Offset: 0x36AFB2C VA: 0x36B3B2C
	public WarrantyItemDatav2[] get_WarrantyItem() { }

	[CompilerGenerated]
	// RVA: 0x36B3B34 Offset: 0x36AFB34 VA: 0x36B3B34
	public void set_WarrantyItem(WarrantyItemDatav2[] value) { }

	[CompilerGenerated]
	// RVA: 0x36B3B3C Offset: 0x36AFB3C VA: 0x36B3B3C
	public byte get_IsBagFull() { }

	[CompilerGenerated]
	// RVA: 0x36B3B44 Offset: 0x36AFB44 VA: 0x36B3B44
	public void set_IsBagFull(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36B3B4C Offset: 0x36AFB4C VA: 0x36B3B4C
	public int get_TrainingCount() { }

	[CompilerGenerated]
	// RVA: 0x36B3B54 Offset: 0x36AFB54 VA: 0x36B3B54
	public void set_TrainingCount(int value) { }

	[CompilerGenerated]
	// RVA: 0x36B3B5C Offset: 0x36AFB5C VA: 0x36B3B5C
	public short get_Level() { }

	[CompilerGenerated]
	// RVA: 0x36B3B64 Offset: 0x36AFB64 VA: 0x36B3B64
	public void set_Level(short value) { }

	[CompilerGenerated]
	// RVA: 0x36B3B6C Offset: 0x36AFB6C VA: 0x36B3B6C
	public int get_TotalExpI() { }

	[CompilerGenerated]
	// RVA: 0x36B3B74 Offset: 0x36AFB74 VA: 0x36B3B74
	public void set_TotalExpI(int value) { }

	[CompilerGenerated]
	// RVA: 0x36B3B7C Offset: 0x36AFB7C VA: 0x36B3B7C
	public long get_TotalExpL() { }

	[CompilerGenerated]
	// RVA: 0x36B3B84 Offset: 0x36AFB84 VA: 0x36B3B84
	public void set_TotalExpL(long value) { }

	// RVA: 0x36B3B8C Offset: 0x36AFB8C VA: 0x36B3B8C
	public long get_TotalExp() { }

	[CompilerGenerated]
	// RVA: 0x36B3B94 Offset: 0x36AFB94 VA: 0x36B3B94
	public short get_AreaBonusGage() { }

	[CompilerGenerated]
	// RVA: 0x36B3B9C Offset: 0x36AFB9C VA: 0x36B3B9C
	public void set_AreaBonusGage(short value) { }

	// RVA: 0x36B3BA4 Offset: 0x36AFBA4 VA: 0x36B3BA4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36B3BAC Offset: 0x36AFBAC VA: 0x36B3BAC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36B408C Offset: 0x36B008C VA: 0x36B408C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
