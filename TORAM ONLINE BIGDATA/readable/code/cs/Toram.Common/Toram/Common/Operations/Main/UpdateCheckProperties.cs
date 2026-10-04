// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main
public class UpdateCheckProperties : PacketBase // TypeDefIndex: 11904
{
	// Fields
	[CompilerGenerated]
	private int <PropertiesRevision>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 56)]
	public int PropertiesRevision { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3761D60 Offset: 0x375DD60 VA: 0x3761D60
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3761D68 Offset: 0x375DD68 VA: 0x3761D68
	public int get_PropertiesRevision() { }

	[CompilerGenerated]
	// RVA: 0x3761D70 Offset: 0x375DD70 VA: 0x3761D70
	public void set_PropertiesRevision(int value) { }

	// RVA: 0x3761D78 Offset: 0x375DD78 VA: 0x3761D78 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3761D80 Offset: 0x375DD80 VA: 0x3761D80 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3761EA0 Offset: 0x375DEA0 VA: 0x3761EA0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
