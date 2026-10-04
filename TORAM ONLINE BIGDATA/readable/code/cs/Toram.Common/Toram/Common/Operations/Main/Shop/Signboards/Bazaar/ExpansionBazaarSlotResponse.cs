// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Shop.Signboards.Bazaar
public class ExpansionBazaarSlotResponse : OperationResponseBase // TypeDefIndex: 11977
{
	// Fields
	[CompilerGenerated]
	private byte <Slot>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Gold>k__BackingField; // 0x24

	// Properties
	public byte Slot { get; set; }
	public int Gold { get; set; }
	public override byte SubCode { get; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3770EA8 Offset: 0x376CEA8 VA: 0x3770EA8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3770EB0 Offset: 0x376CEB0 VA: 0x3770EB0
	public byte get_Slot() { }

	[CompilerGenerated]
	// RVA: 0x3770EB8 Offset: 0x376CEB8 VA: 0x3770EB8
	public void set_Slot(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3770EC0 Offset: 0x376CEC0 VA: 0x3770EC0
	public int get_Gold() { }

	[CompilerGenerated]
	// RVA: 0x3770EC8 Offset: 0x376CEC8 VA: 0x3770EC8
	public void set_Gold(int value) { }

	// RVA: 0x3770ED0 Offset: 0x376CED0 VA: 0x3770ED0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3770ED8 Offset: 0x376CED8 VA: 0x3770ED8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3770EE0 Offset: 0x376CEE0 VA: 0x3770EE0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3770FBC Offset: 0x376CFBC VA: 0x3770FBC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
