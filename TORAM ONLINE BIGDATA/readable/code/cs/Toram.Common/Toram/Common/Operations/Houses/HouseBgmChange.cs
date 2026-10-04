// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses
public class HouseBgmChange : OperationRequestBase // TypeDefIndex: 12159
{
	// Fields
	[CompilerGenerated]
	private int <BgmItemId>k__BackingField; // 0x20

	// Properties
	public int BgmItemId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3792FB4 Offset: 0x378EFB4 VA: 0x3792FB4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3792FBC Offset: 0x378EFBC VA: 0x3792FBC
	public int get_BgmItemId() { }

	[CompilerGenerated]
	// RVA: 0x3792FC4 Offset: 0x378EFC4 VA: 0x3792FC4
	public void set_BgmItemId(int value) { }

	// RVA: 0x3792FCC Offset: 0x378EFCC VA: 0x3792FCC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3792FD4 Offset: 0x378EFD4 VA: 0x3792FD4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3792FDC Offset: 0x378EFDC VA: 0x3792FDC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37930FC Offset: 0x378F0FC VA: 0x37930FC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
