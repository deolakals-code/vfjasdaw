// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main
public class ArchetypeActionLight : PacketBase // TypeDefIndex: 11893
{
	// Fields
	[CompilerGenerated]
	private byte <ActionCode>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x21
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte[] <ActionBinary>k__BackingField; // 0x28

	// Properties
	public byte ActionCode { get; set; }
	public byte ArchetypeType { get; set; }
	public int ArchetypeId { get; set; }
	public byte[] ActionBinary { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x375FB20 Offset: 0x375BB20 VA: 0x375FB20
	public void .ctor(byte actionCode, byte[] binary) { }

	[CompilerGenerated]
	// RVA: 0x375FB58 Offset: 0x375BB58 VA: 0x375FB58
	public byte get_ActionCode() { }

	[CompilerGenerated]
	// RVA: 0x375FB60 Offset: 0x375BB60 VA: 0x375FB60
	public void set_ActionCode(byte value) { }

	[CompilerGenerated]
	// RVA: 0x375FB68 Offset: 0x375BB68 VA: 0x375FB68
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x375FB70 Offset: 0x375BB70 VA: 0x375FB70
	public void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x375FB78 Offset: 0x375BB78 VA: 0x375FB78
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x375FB80 Offset: 0x375BB80 VA: 0x375FB80
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x375FB88 Offset: 0x375BB88 VA: 0x375FB88
	public byte[] get_ActionBinary() { }

	[CompilerGenerated]
	// RVA: 0x375FB90 Offset: 0x375BB90 VA: 0x375FB90
	public void set_ActionBinary(byte[] value) { }

	// RVA: 0x375FB98 Offset: 0x375BB98 VA: 0x375FB98 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x375FBA0 Offset: 0x375BBA0 VA: 0x375FBA0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x375FCF4 Offset: 0x375BCF4 VA: 0x375FCF4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
