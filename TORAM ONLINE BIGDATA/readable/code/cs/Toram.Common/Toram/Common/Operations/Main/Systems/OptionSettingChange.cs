// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Systems
public class OptionSettingChange : OperationRequestBase // TypeDefIndex: 11939
{
	// Fields
	[CompilerGenerated]
	private byte <OptionCode>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <Flag>k__BackingField; // 0x21

	// Properties
	public byte OptionCode { get; set; }
	public bool Flag { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x376AB4C Offset: 0x3766B4C VA: 0x376AB4C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x376AB54 Offset: 0x3766B54 VA: 0x376AB54
	public byte get_OptionCode() { }

	[CompilerGenerated]
	// RVA: 0x376AB5C Offset: 0x3766B5C VA: 0x376AB5C
	public void set_OptionCode(byte value) { }

	[CompilerGenerated]
	// RVA: 0x376AB64 Offset: 0x3766B64 VA: 0x376AB64
	public bool get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x376AB6C Offset: 0x3766B6C VA: 0x376AB6C
	public void set_Flag(bool value) { }

	// RVA: 0x376AB78 Offset: 0x3766B78 VA: 0x376AB78 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x376AB80 Offset: 0x3766B80 VA: 0x376AB80 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x376AB88 Offset: 0x3766B88 VA: 0x376AB88 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x376AC64 Offset: 0x3766C64 VA: 0x376AC64 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
