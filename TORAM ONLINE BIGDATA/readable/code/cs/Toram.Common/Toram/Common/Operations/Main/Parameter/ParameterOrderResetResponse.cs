// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Parameter
public class ParameterOrderResetResponse : OperationResponseBase // TypeDefIndex: 11999
{
	// Fields
	[CompilerGenerated]
	private byte <ParameterSlot>k__BackingField; // 0x20
	[CompilerGenerated]
	private ParameterData[] <ParameterList>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte[] <ParameterOrder>k__BackingField; // 0x30

	// Properties
	public byte ParameterSlot { get; set; }
	public ParameterData[] ParameterList { get; set; }
	public byte[] ParameterOrder { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x37742A0 Offset: 0x37702A0 VA: 0x37742A0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x37742A8 Offset: 0x37702A8 VA: 0x37742A8
	public byte get_ParameterSlot() { }

	[CompilerGenerated]
	// RVA: 0x37742B0 Offset: 0x37702B0 VA: 0x37742B0
	public void set_ParameterSlot(byte value) { }

	[CompilerGenerated]
	// RVA: 0x37742B8 Offset: 0x37702B8 VA: 0x37742B8
	public ParameterData[] get_ParameterList() { }

	[CompilerGenerated]
	// RVA: 0x37742C0 Offset: 0x37702C0 VA: 0x37742C0
	public void set_ParameterList(ParameterData[] value) { }

	[CompilerGenerated]
	// RVA: 0x37742C8 Offset: 0x37702C8 VA: 0x37742C8
	public byte[] get_ParameterOrder() { }

	[CompilerGenerated]
	// RVA: 0x37742D0 Offset: 0x37702D0 VA: 0x37742D0
	public void set_ParameterOrder(byte[] value) { }

	// RVA: 0x37742D8 Offset: 0x37702D8 VA: 0x37742D8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37742E0 Offset: 0x37702E0 VA: 0x37742E0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37742E8 Offset: 0x37702E8 VA: 0x37742E8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3774544 Offset: 0x3770544 VA: 0x3774544 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
