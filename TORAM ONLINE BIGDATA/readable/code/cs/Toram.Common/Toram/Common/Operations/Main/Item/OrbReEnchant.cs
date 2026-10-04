// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Item
public class OrbReEnchant : OperationRequestBase // TypeDefIndex: 12137
{
	// Fields
	[CompilerGenerated]
	private int <TargetItemUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <TargetType>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <EnchantIndex>k__BackingField; // 0x25

	// Properties
	public int TargetItemUuid { get; set; }
	public byte TargetType { get; set; }
	public byte EnchantIndex { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x378EDB4 Offset: 0x378ADB4 VA: 0x378EDB4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x378EDBC Offset: 0x378ADBC VA: 0x378EDBC
	public int get_TargetItemUuid() { }

	[CompilerGenerated]
	// RVA: 0x378EDC4 Offset: 0x378ADC4 VA: 0x378EDC4
	public void set_TargetItemUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x378EDCC Offset: 0x378ADCC VA: 0x378EDCC
	public byte get_TargetType() { }

	[CompilerGenerated]
	// RVA: 0x378EDD4 Offset: 0x378ADD4 VA: 0x378EDD4
	public void set_TargetType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x378EDDC Offset: 0x378ADDC VA: 0x378EDDC
	public byte get_EnchantIndex() { }

	[CompilerGenerated]
	// RVA: 0x378EDE4 Offset: 0x378ADE4 VA: 0x378EDE4
	public void set_EnchantIndex(byte value) { }

	// RVA: 0x378EDEC Offset: 0x378ADEC VA: 0x378EDEC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x378EDF4 Offset: 0x378ADF4 VA: 0x378EDF4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x378EDFC Offset: 0x378ADFC VA: 0x378EDFC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x378EF08 Offset: 0x378AF08 VA: 0x378EF08 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
