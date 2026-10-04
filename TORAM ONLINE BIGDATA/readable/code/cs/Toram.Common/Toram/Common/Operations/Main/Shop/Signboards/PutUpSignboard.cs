// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Shop.Signboards
public class PutUpSignboard : OperationRequestBase // TypeDefIndex: 11966
{
	// Fields
	[CompilerGenerated]
	private byte <SignboardType>k__BackingField; // 0x20
	[CompilerGenerated]
	private ItemSelectData[] <SelectItem>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <Gold>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <TargetNo>k__BackingField; // 0x34
	[CompilerGenerated]
	private int <RequiredItemId>k__BackingField; // 0x38

	// Properties
	public byte SignboardType { get; set; }
	public ItemSelectData[] SelectItem { get; set; }
	public int Gold { get; set; }
	public int TargetNo { get; set; }
	public int RequiredItemId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x376F25C Offset: 0x376B25C VA: 0x376F25C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x376F264 Offset: 0x376B264 VA: 0x376F264
	public byte get_SignboardType() { }

	[CompilerGenerated]
	// RVA: 0x376F26C Offset: 0x376B26C VA: 0x376F26C
	public void set_SignboardType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x376F274 Offset: 0x376B274 VA: 0x376F274
	public ItemSelectData[] get_SelectItem() { }

	[CompilerGenerated]
	// RVA: 0x376F27C Offset: 0x376B27C VA: 0x376F27C
	public void set_SelectItem(ItemSelectData[] value) { }

	[CompilerGenerated]
	// RVA: 0x376F284 Offset: 0x376B284 VA: 0x376F284
	public int get_Gold() { }

	[CompilerGenerated]
	// RVA: 0x376F28C Offset: 0x376B28C VA: 0x376F28C
	public void set_Gold(int value) { }

	[CompilerGenerated]
	// RVA: 0x376F294 Offset: 0x376B294 VA: 0x376F294
	public int get_TargetNo() { }

	[CompilerGenerated]
	// RVA: 0x376F29C Offset: 0x376B29C VA: 0x376F29C
	public void set_TargetNo(int value) { }

	[CompilerGenerated]
	// RVA: 0x376F2A4 Offset: 0x376B2A4 VA: 0x376F2A4
	public int get_RequiredItemId() { }

	[CompilerGenerated]
	// RVA: 0x376F2AC Offset: 0x376B2AC VA: 0x376F2AC
	public void set_RequiredItemId(int value) { }

	// RVA: 0x376F2B4 Offset: 0x376B2B4 VA: 0x376F2B4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x376F2BC Offset: 0x376B2BC VA: 0x376F2BC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x376F2C4 Offset: 0x376B2C4 VA: 0x376F2C4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x376F5DC Offset: 0x376B5DC VA: 0x376F5DC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
