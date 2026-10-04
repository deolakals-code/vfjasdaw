// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main
public class ViewPersonsChangeResponse : PacketBase // TypeDefIndex: 11905
{
	// Fields
	[CompilerGenerated]
	private int <ViewPersons>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 195, IsOptional = True)]
	public int ViewPersons { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3761F74 Offset: 0x375DF74 VA: 0x3761F74
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3761F7C Offset: 0x375DF7C VA: 0x3761F7C
	public int get_ViewPersons() { }

	[CompilerGenerated]
	// RVA: 0x3761F84 Offset: 0x375DF84 VA: 0x3761F84
	public void set_ViewPersons(int value) { }

	// RVA: 0x3761F8C Offset: 0x375DF8C VA: 0x3761F8C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3761F94 Offset: 0x375DF94 VA: 0x3761F94 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37620E0 Offset: 0x375E0E0 VA: 0x37620E0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
