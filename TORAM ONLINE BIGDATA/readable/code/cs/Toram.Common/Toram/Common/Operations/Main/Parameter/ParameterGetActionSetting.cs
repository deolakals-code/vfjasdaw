// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Parameter
public class ParameterGetActionSetting : OperationRequestBase // TypeDefIndex: 11982
{
	// Fields
	[CompilerGenerated]
	private byte <ParamId>k__BackingField; // 0x20

	// Properties
	public byte ParamId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3771B40 Offset: 0x376DB40 VA: 0x3771B40
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3771B48 Offset: 0x376DB48 VA: 0x3771B48
	public byte get_ParamId() { }

	[CompilerGenerated]
	// RVA: 0x3771B50 Offset: 0x376DB50 VA: 0x3771B50
	public void set_ParamId(byte value) { }

	// RVA: 0x3771B58 Offset: 0x376DB58 VA: 0x3771B58 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3771B60 Offset: 0x376DB60 VA: 0x3771B60 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3771B68 Offset: 0x376DB68 VA: 0x3771B68 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3771C08 Offset: 0x376DC08 VA: 0x3771C08 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
