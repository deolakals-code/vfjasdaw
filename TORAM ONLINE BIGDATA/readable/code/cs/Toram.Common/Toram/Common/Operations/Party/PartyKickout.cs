// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Party
public class PartyKickout : PacketBase // TypeDefIndex: 11470
{
	// Fields
	[CompilerGenerated]
	private int <TargetId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <TargetType>k__BackingField; // 0x24

	// Properties
	[PacketParameter(Code = 96)]
	public int TargetId { get; set; }
	[PacketParameter(Code = 164, IsOptional = True)]
	public byte TargetType { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x370F590 Offset: 0x370B590 VA: 0x370F590
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x370F598 Offset: 0x370B598 VA: 0x370F598
	public int get_TargetId() { }

	[CompilerGenerated]
	// RVA: 0x370F5A0 Offset: 0x370B5A0 VA: 0x370F5A0
	public void set_TargetId(int value) { }

	[CompilerGenerated]
	// RVA: 0x370F5A8 Offset: 0x370B5A8 VA: 0x370F5A8
	public byte get_TargetType() { }

	[CompilerGenerated]
	// RVA: 0x370F5B0 Offset: 0x370B5B0 VA: 0x370F5B0
	public void set_TargetType(byte value) { }

	// RVA: 0x370F5B8 Offset: 0x370B5B8 VA: 0x370F5B8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x370F5C0 Offset: 0x370B5C0 VA: 0x370F5C0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x370F764 Offset: 0x370B764 VA: 0x370F764 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
