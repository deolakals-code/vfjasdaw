// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Parameter
public class ParameterSaveActionSetting : OperationRequestBase // TypeDefIndex: 11984
{
	// Fields
	[CompilerGenerated]
	private byte <ParamId>k__BackingField; // 0x20
	[CompilerGenerated]
	private Dictionary<short, byte> <Skills>k__BackingField; // 0x28

	// Properties
	public byte ParamId { get; set; }
	public Dictionary<short, byte> Skills { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3772258 Offset: 0x376E258 VA: 0x3772258
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3772260 Offset: 0x376E260 VA: 0x3772260
	public byte get_ParamId() { }

	[CompilerGenerated]
	// RVA: 0x3772268 Offset: 0x376E268 VA: 0x3772268
	public void set_ParamId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3772270 Offset: 0x376E270 VA: 0x3772270
	public Dictionary<short, byte> get_Skills() { }

	[CompilerGenerated]
	// RVA: 0x3772278 Offset: 0x376E278 VA: 0x3772278
	public void set_Skills(Dictionary<short, byte> value) { }

	// RVA: 0x3772280 Offset: 0x376E280 VA: 0x3772280 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3772288 Offset: 0x376E288 VA: 0x3772288 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3772290 Offset: 0x376E290 VA: 0x3772290 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3772348 Offset: 0x376E348 VA: 0x3772348 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
