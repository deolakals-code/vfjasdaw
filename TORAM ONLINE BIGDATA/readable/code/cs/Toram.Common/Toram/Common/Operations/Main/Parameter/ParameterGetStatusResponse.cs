// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Parameter
public class ParameterGetStatusResponse : PacketBase // TypeDefIndex: 11992
{
	// Fields
	[CompilerGenerated]
	private ParameterStatus <ParameterStatus>k__BackingField; // 0x20

	// Properties
	public ParameterStatus ParameterStatus { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x37736CC Offset: 0x376F6CC VA: 0x37736CC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x37736D4 Offset: 0x376F6D4 VA: 0x37736D4
	public ParameterStatus get_ParameterStatus() { }

	[CompilerGenerated]
	// RVA: 0x37736DC Offset: 0x376F6DC VA: 0x37736DC
	public void set_ParameterStatus(ParameterStatus value) { }

	// RVA: 0x37736E4 Offset: 0x376F6E4 VA: 0x37736E4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37736EC Offset: 0x376F6EC VA: 0x37736EC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3773888 Offset: 0x376F888 VA: 0x3773888 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
