// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Parameter
public class ParameterOrderChange : OperationRequestBase // TypeDefIndex: 11996
{
	// Fields
	[CompilerGenerated]
	private byte[] <ParameterOrder>k__BackingField; // 0x20

	// Properties
	public byte[] ParameterOrder { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3773E90 Offset: 0x376FE90 VA: 0x3773E90
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3773E98 Offset: 0x376FE98 VA: 0x3773E98
	public byte[] get_ParameterOrder() { }

	[CompilerGenerated]
	// RVA: 0x3773EA0 Offset: 0x376FEA0 VA: 0x3773EA0
	public void set_ParameterOrder(byte[] value) { }

	// RVA: 0x3773EA8 Offset: 0x376FEA8 VA: 0x3773EA8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3773EB0 Offset: 0x376FEB0 VA: 0x3773EB0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3773EB8 Offset: 0x376FEB8 VA: 0x3773EB8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3774010 Offset: 0x3770010 VA: 0x3774010 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
