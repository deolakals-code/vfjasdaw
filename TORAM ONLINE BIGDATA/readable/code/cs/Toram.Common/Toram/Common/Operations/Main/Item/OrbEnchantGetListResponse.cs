// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Item
public class OrbEnchantGetListResponse : OperationResponseBase // TypeDefIndex: 12134
{
	// Fields
	[CompilerGenerated]
	private OrbEnchantData[] <OldEnchantList>k__BackingField; // 0x20
	[CompilerGenerated]
	private OrbEnchantData[] <NewEnchantList>k__BackingField; // 0x28
	[CompilerGenerated]
	private Dictionary<byte, byte> <SlotLimits>k__BackingField; // 0x30

	// Properties
	public OrbEnchantData[] OldEnchantList { get; set; }
	public OrbEnchantData[] NewEnchantList { get; set; }
	public Dictionary<byte, byte> SlotLimits { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x378E48C Offset: 0x378A48C VA: 0x378E48C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x378E494 Offset: 0x378A494 VA: 0x378E494
	public OrbEnchantData[] get_OldEnchantList() { }

	[CompilerGenerated]
	// RVA: 0x378E49C Offset: 0x378A49C VA: 0x378E49C
	public void set_OldEnchantList(OrbEnchantData[] value) { }

	[CompilerGenerated]
	// RVA: 0x378E4A4 Offset: 0x378A4A4 VA: 0x378E4A4
	public OrbEnchantData[] get_NewEnchantList() { }

	[CompilerGenerated]
	// RVA: 0x378E4AC Offset: 0x378A4AC VA: 0x378E4AC
	public void set_NewEnchantList(OrbEnchantData[] value) { }

	[CompilerGenerated]
	// RVA: 0x378E4B4 Offset: 0x378A4B4 VA: 0x378E4B4
	public Dictionary<byte, byte> get_SlotLimits() { }

	[CompilerGenerated]
	// RVA: 0x378E4BC Offset: 0x378A4BC VA: 0x378E4BC
	public void set_SlotLimits(Dictionary<byte, byte> value) { }

	// RVA: 0x378E4C4 Offset: 0x378A4C4 VA: 0x378E4C4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x378E4CC Offset: 0x378A4CC VA: 0x378E4CC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x378E4D4 Offset: 0x378A4D4 VA: 0x378E4D4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x378E5B8 Offset: 0x378A5B8 VA: 0x378E5B8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
