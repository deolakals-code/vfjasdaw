// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Item
public class OrbEnchantSaveResponse : OperationResponseBase // TypeDefIndex: 12136
{
	// Fields
	[CompilerGenerated]
	private OrbEnchantData <Enchant>k__BackingField; // 0x20

	// Properties
	public OrbEnchantData Enchant { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x378EB70 Offset: 0x378AB70 VA: 0x378EB70
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x378EB78 Offset: 0x378AB78 VA: 0x378EB78
	public OrbEnchantData get_Enchant() { }

	[CompilerGenerated]
	// RVA: 0x378EB80 Offset: 0x378AB80 VA: 0x378EB80
	public void set_Enchant(OrbEnchantData value) { }

	// RVA: 0x378EB88 Offset: 0x378AB88 VA: 0x378EB88 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x378EB90 Offset: 0x378AB90 VA: 0x378EB90 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x378EB98 Offset: 0x378AB98 VA: 0x378EB98 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x378EC20 Offset: 0x378AC20 VA: 0x378EC20 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
