// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Shop.Signboards.Bazaar
public class GetBazaarResponse : OperationResponseBase // TypeDefIndex: 11979
{
	// Fields
	[CompilerGenerated]
	private BazaarData <Bazaar>k__BackingField; // 0x20

	// Properties
	public BazaarData Bazaar { get; set; }
	public override byte SubCode { get; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x377131C Offset: 0x376D31C VA: 0x377131C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3771324 Offset: 0x376D324 VA: 0x3771324
	public BazaarData get_Bazaar() { }

	[CompilerGenerated]
	// RVA: 0x377132C Offset: 0x376D32C VA: 0x377132C
	public void set_Bazaar(BazaarData value) { }

	// RVA: 0x3771334 Offset: 0x376D334 VA: 0x3771334 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x377133C Offset: 0x376D33C VA: 0x377133C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3771344 Offset: 0x376D344 VA: 0x3771344 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x37713CC Offset: 0x376D3CC VA: 0x37713CC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
