// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class ResultData : PacketBase // TypeDefIndex: 13192
{
	// Fields
	[CompilerGenerated]
	private byte <ExpType>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Exp>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <Gold>k__BackingField; // 0x28
	[CompilerGenerated]
	private ItemDatav2[] <BagItem>k__BackingField; // 0x30
	[CompilerGenerated]
	private WarrantyItemDatav2[] <WarrantyItem>k__BackingField; // 0x38
	[CompilerGenerated]
	private byte <IsBagFull>k__BackingField; // 0x40
	[CompilerGenerated]
	private DropData[] <DropList>k__BackingField; // 0x48
	[CompilerGenerated]
	private short <Level>k__BackingField; // 0x50
	[CompilerGenerated]
	private int <TotalExpI>k__BackingField; // 0x54
	[CompilerGenerated]
	private long <TotalExpL>k__BackingField; // 0x58
	[CompilerGenerated]
	private int <TrainingCount>k__BackingField; // 0x60
	[CompilerGenerated]
	private short <AreaBonusGage>k__BackingField; // 0x64
	[CompilerGenerated]
	private int[] <Points>k__BackingField; // 0x68

	// Properties
	public byte ExpType { get; set; }
	public int Exp { get; set; }
	public int Gold { get; set; }
	public ItemDatav2[] BagItem { get; set; }
	public WarrantyItemDatav2[] WarrantyItem { get; set; }
	public byte IsBagFull { get; set; }
	public DropData[] DropList { get; set; }
	public short Level { get; set; }
	public int TotalExpI { get; set; }
	public long TotalExpL { get; set; }
	public long TotalExp { get; }
	public int TrainingCount { get; set; }
	public short AreaBonusGage { get; set; }
	public int[] Points { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36B29D8 Offset: 0x36AE9D8 VA: 0x36B29D8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36C45E4 Offset: 0x36C05E4 VA: 0x36C45E4
	public byte get_ExpType() { }

	[CompilerGenerated]
	// RVA: 0x36C45EC Offset: 0x36C05EC VA: 0x36C45EC
	public void set_ExpType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36C45F4 Offset: 0x36C05F4 VA: 0x36C45F4
	public int get_Exp() { }

	[CompilerGenerated]
	// RVA: 0x36C45FC Offset: 0x36C05FC VA: 0x36C45FC
	public void set_Exp(int value) { }

	[CompilerGenerated]
	// RVA: 0x36C4604 Offset: 0x36C0604 VA: 0x36C4604
	public int get_Gold() { }

	[CompilerGenerated]
	// RVA: 0x36C460C Offset: 0x36C060C VA: 0x36C460C
	public void set_Gold(int value) { }

	[CompilerGenerated]
	// RVA: 0x36C4614 Offset: 0x36C0614 VA: 0x36C4614
	public ItemDatav2[] get_BagItem() { }

	[CompilerGenerated]
	// RVA: 0x36C461C Offset: 0x36C061C VA: 0x36C461C
	public void set_BagItem(ItemDatav2[] value) { }

	[CompilerGenerated]
	// RVA: 0x36C4624 Offset: 0x36C0624 VA: 0x36C4624
	public WarrantyItemDatav2[] get_WarrantyItem() { }

	[CompilerGenerated]
	// RVA: 0x36C462C Offset: 0x36C062C VA: 0x36C462C
	public void set_WarrantyItem(WarrantyItemDatav2[] value) { }

	[CompilerGenerated]
	// RVA: 0x36C4634 Offset: 0x36C0634 VA: 0x36C4634
	public byte get_IsBagFull() { }

	[CompilerGenerated]
	// RVA: 0x36C463C Offset: 0x36C063C VA: 0x36C463C
	public void set_IsBagFull(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36C4644 Offset: 0x36C0644 VA: 0x36C4644
	public DropData[] get_DropList() { }

	[CompilerGenerated]
	// RVA: 0x36C464C Offset: 0x36C064C VA: 0x36C464C
	public void set_DropList(DropData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36C4654 Offset: 0x36C0654 VA: 0x36C4654
	public short get_Level() { }

	[CompilerGenerated]
	// RVA: 0x36C465C Offset: 0x36C065C VA: 0x36C465C
	public void set_Level(short value) { }

	[CompilerGenerated]
	// RVA: 0x36C4664 Offset: 0x36C0664 VA: 0x36C4664
	public int get_TotalExpI() { }

	[CompilerGenerated]
	// RVA: 0x36C466C Offset: 0x36C066C VA: 0x36C466C
	public void set_TotalExpI(int value) { }

	[CompilerGenerated]
	// RVA: 0x36C4674 Offset: 0x36C0674 VA: 0x36C4674
	public long get_TotalExpL() { }

	[CompilerGenerated]
	// RVA: 0x36C467C Offset: 0x36C067C VA: 0x36C467C
	public void set_TotalExpL(long value) { }

	// RVA: 0x36C4684 Offset: 0x36C0684 VA: 0x36C4684
	public long get_TotalExp() { }

	[CompilerGenerated]
	// RVA: 0x36C468C Offset: 0x36C068C VA: 0x36C468C
	public int get_TrainingCount() { }

	[CompilerGenerated]
	// RVA: 0x36C4694 Offset: 0x36C0694 VA: 0x36C4694
	public void set_TrainingCount(int value) { }

	[CompilerGenerated]
	// RVA: 0x36C469C Offset: 0x36C069C VA: 0x36C469C
	public short get_AreaBonusGage() { }

	[CompilerGenerated]
	// RVA: 0x36C46A4 Offset: 0x36C06A4 VA: 0x36C46A4
	public void set_AreaBonusGage(short value) { }

	[CompilerGenerated]
	// RVA: 0x36C46AC Offset: 0x36C06AC VA: 0x36C46AC
	public int[] get_Points() { }

	[CompilerGenerated]
	// RVA: 0x36C46B4 Offset: 0x36C06B4 VA: 0x36C46B4
	public void set_Points(int[] value) { }

	// RVA: 0x36C46BC Offset: 0x36C06BC VA: 0x36C46BC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36C46C4 Offset: 0x36C06C4 VA: 0x36C46C4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36C4D84 Offset: 0x36C0D84 VA: 0x36C4D84 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
