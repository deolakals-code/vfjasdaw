// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Shop
public class TransferRandomProperty : OperationRequestBase // TypeDefIndex: 11722
{
	// Fields
	private static readonly int[] SupportIdOrders; // 0x0
	[CompilerGenerated]
	private int <ShopId>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <TargetItemUuid>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <MaterialItemUuid>k__BackingField; // 0x28
	[CompilerGenerated]
	private short[] <UseSuuportList>k__BackingField; // 0x30

	// Properties
	public int ShopId { get; set; }
	public int TargetItemUuid { get; set; }
	public int MaterialItemUuid { get; set; }
	public short[] UseSuuportList { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x373B720 Offset: 0x3737720 VA: 0x373B720
	private static void .cctor() { }

	// RVA: 0x373B7C0 Offset: 0x37377C0 VA: 0x373B7C0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x373B7C8 Offset: 0x37377C8 VA: 0x373B7C8
	public int get_ShopId() { }

	[CompilerGenerated]
	// RVA: 0x373B7D0 Offset: 0x37377D0 VA: 0x373B7D0
	public void set_ShopId(int value) { }

	[CompilerGenerated]
	// RVA: 0x373B7D8 Offset: 0x37377D8 VA: 0x373B7D8
	public int get_TargetItemUuid() { }

	[CompilerGenerated]
	// RVA: 0x373B7E0 Offset: 0x37377E0 VA: 0x373B7E0
	public void set_TargetItemUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x373B7E8 Offset: 0x37377E8 VA: 0x373B7E8
	public int get_MaterialItemUuid() { }

	[CompilerGenerated]
	// RVA: 0x373B7F0 Offset: 0x37377F0 VA: 0x373B7F0
	public void set_MaterialItemUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x373B7F8 Offset: 0x37377F8 VA: 0x373B7F8
	public short[] get_UseSuuportList() { }

	[CompilerGenerated]
	// RVA: 0x373B800 Offset: 0x3737800 VA: 0x373B800
	public void set_UseSuuportList(short[] value) { }

	// RVA: 0x373B808 Offset: 0x3737808 VA: 0x373B808 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x373B810 Offset: 0x3737810 VA: 0x373B810 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x373B818 Offset: 0x3737818 VA: 0x373B818 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x373B92C Offset: 0x373792C VA: 0x373B92C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
