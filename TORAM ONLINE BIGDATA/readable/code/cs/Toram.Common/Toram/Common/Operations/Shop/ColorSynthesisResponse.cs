// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Shop
public class ColorSynthesisResponse : OperationResponseBase // TypeDefIndex: 11726
{
	// Fields
	[CompilerGenerated]
	private bool <IsSuccess>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <UpdateGold>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <Gold>k__BackingField; // 0x28
	[CompilerGenerated]
	private ItemDatav2 <ColoringItem>k__BackingField; // 0x30
	[CompilerGenerated]
	private Tuple<int, short>[] <Shards>k__BackingField; // 0x38
	[CompilerGenerated]
	private bool <IsCreatePhilosophersStone>k__BackingField; // 0x40
	[CompilerGenerated]
	private ItemDatav2[] <UpdateItems>k__BackingField; // 0x48
	[CompilerGenerated]
	private MaterialData[] <UpdateMaterials>k__BackingField; // 0x50

	// Properties
	public bool IsSuccess { get; set; }
	public int UpdateGold { get; set; }
	public int Gold { get; set; }
	public ItemDatav2 ColoringItem { get; set; }
	public Tuple<int, short>[] Shards { get; set; }
	public bool IsCreatePhilosophersStone { get; set; }
	public ItemDatav2[] UpdateItems { get; set; }
	public MaterialData[] UpdateMaterials { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x373C6B8 Offset: 0x37386B8 VA: 0x373C6B8
	public void .ctor() { }

	// RVA: 0x373C6C0 Offset: 0x37386C0 VA: 0x373C6C0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x373C6C8 Offset: 0x37386C8 VA: 0x373C6C8
	public bool get_IsSuccess() { }

	[CompilerGenerated]
	// RVA: 0x373C6D0 Offset: 0x37386D0 VA: 0x373C6D0
	public void set_IsSuccess(bool value) { }

	[CompilerGenerated]
	// RVA: 0x373C6DC Offset: 0x37386DC VA: 0x373C6DC
	public int get_UpdateGold() { }

	[CompilerGenerated]
	// RVA: 0x373C6E4 Offset: 0x37386E4 VA: 0x373C6E4
	public void set_UpdateGold(int value) { }

	[CompilerGenerated]
	// RVA: 0x373C6EC Offset: 0x37386EC VA: 0x373C6EC
	public int get_Gold() { }

	[CompilerGenerated]
	// RVA: 0x373C6F4 Offset: 0x37386F4 VA: 0x373C6F4
	public void set_Gold(int value) { }

	[CompilerGenerated]
	// RVA: 0x373C6FC Offset: 0x37386FC VA: 0x373C6FC
	public ItemDatav2 get_ColoringItem() { }

	[CompilerGenerated]
	// RVA: 0x373C704 Offset: 0x3738704 VA: 0x373C704
	public void set_ColoringItem(ItemDatav2 value) { }

	[CompilerGenerated]
	// RVA: 0x373C70C Offset: 0x373870C VA: 0x373C70C
	public Tuple<int, short>[] get_Shards() { }

	[CompilerGenerated]
	// RVA: 0x373C714 Offset: 0x3738714 VA: 0x373C714
	public void set_Shards(Tuple<int, short>[] value) { }

	[CompilerGenerated]
	// RVA: 0x373C71C Offset: 0x373871C VA: 0x373C71C
	public bool get_IsCreatePhilosophersStone() { }

	[CompilerGenerated]
	// RVA: 0x373C724 Offset: 0x3738724 VA: 0x373C724
	public void set_IsCreatePhilosophersStone(bool value) { }

	[CompilerGenerated]
	// RVA: 0x373C730 Offset: 0x3738730 VA: 0x373C730
	public ItemDatav2[] get_UpdateItems() { }

	[CompilerGenerated]
	// RVA: 0x373C738 Offset: 0x3738738 VA: 0x373C738
	public void set_UpdateItems(ItemDatav2[] value) { }

	[CompilerGenerated]
	// RVA: 0x373C740 Offset: 0x3738740 VA: 0x373C740
	public MaterialData[] get_UpdateMaterials() { }

	[CompilerGenerated]
	// RVA: 0x373C748 Offset: 0x3738748 VA: 0x373C748
	public void set_UpdateMaterials(MaterialData[] value) { }

	// RVA: 0x373C750 Offset: 0x3738750 VA: 0x373C750 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x373C758 Offset: 0x3738758 VA: 0x373C758 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x373C760 Offset: 0x3738760 VA: 0x373C760 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x373CBB0 Offset: 0x3738BB0 VA: 0x373CBB0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
