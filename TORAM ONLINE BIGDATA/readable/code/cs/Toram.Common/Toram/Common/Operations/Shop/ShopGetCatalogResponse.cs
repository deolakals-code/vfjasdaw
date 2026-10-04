// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Shop
public class ShopGetCatalogResponse : OperationResponseBase // TypeDefIndex: 11717
{
	// Fields
	[CompilerGenerated]
	private int <ShopId>k__BackingField; // 0x20
	[CompilerGenerated]
	private CatalogData[] <ShopCatalog>k__BackingField; // 0x28

	// Properties
	public int ShopId { get; set; }
	public CatalogData[] ShopCatalog { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3739F60 Offset: 0x3735F60 VA: 0x3739F60
	public void .ctor() { }

	// RVA: 0x3739F68 Offset: 0x3735F68 VA: 0x3739F68
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3739F70 Offset: 0x3735F70 VA: 0x3739F70
	public int get_ShopId() { }

	[CompilerGenerated]
	// RVA: 0x3739F78 Offset: 0x3735F78 VA: 0x3739F78
	public void set_ShopId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3739F80 Offset: 0x3735F80 VA: 0x3739F80
	public CatalogData[] get_ShopCatalog() { }

	[CompilerGenerated]
	// RVA: 0x3739F88 Offset: 0x3735F88 VA: 0x3739F88
	public void set_ShopCatalog(CatalogData[] value) { }

	// RVA: 0x3739F90 Offset: 0x3735F90 VA: 0x3739F90 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3739F98 Offset: 0x3735F98 VA: 0x3739F98 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3739FA0 Offset: 0x3735FA0 VA: 0x3739FA0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x373A078 Offset: 0x3736078 VA: 0x373A078 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
