// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Systems
public class OptionSettingChangeResponse : OperationResponseBase // TypeDefIndex: 11941
{
	// Fields
	[CompilerGenerated]
	private byte <VariableType>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <OptionValue>k__BackingField; // 0x24

	// Properties
	public byte VariableType { get; set; }
	public int OptionValue { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x376B118 Offset: 0x3767118 VA: 0x376B118
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x376B120 Offset: 0x3767120 VA: 0x376B120
	public byte get_VariableType() { }

	[CompilerGenerated]
	// RVA: 0x376B128 Offset: 0x3767128 VA: 0x376B128
	public void set_VariableType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x376B130 Offset: 0x3767130 VA: 0x376B130
	public int get_OptionValue() { }

	[CompilerGenerated]
	// RVA: 0x376B138 Offset: 0x3767138 VA: 0x376B138
	public void set_OptionValue(int value) { }

	// RVA: 0x376B140 Offset: 0x3767140 VA: 0x376B140 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x376B148 Offset: 0x3767148 VA: 0x376B148 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x376B150 Offset: 0x3767150 VA: 0x376B150 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x376B22C Offset: 0x376722C VA: 0x376B22C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
