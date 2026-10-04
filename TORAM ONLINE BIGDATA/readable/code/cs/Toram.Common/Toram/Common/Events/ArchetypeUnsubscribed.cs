// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events
public class ArchetypeUnsubscribed : PacketBase // TypeDefIndex: 12619
{
	// Fields
	[CompilerGenerated]
	private byte <InterestAreaId>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x28

	// Properties
	public byte InterestAreaId { get; set; }
	public int AvatarUuid { get; set; }
	public byte ArchetypeType { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x363274C Offset: 0x362E74C VA: 0x363274C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3632754 Offset: 0x362E754 VA: 0x3632754
	public byte get_InterestAreaId() { }

	[CompilerGenerated]
	// RVA: 0x363275C Offset: 0x362E75C VA: 0x363275C
	public void set_InterestAreaId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3632764 Offset: 0x362E764 VA: 0x3632764
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x363276C Offset: 0x362E76C VA: 0x363276C
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3632774 Offset: 0x362E774 VA: 0x3632774
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x363277C Offset: 0x362E77C VA: 0x363277C
	public void set_ArchetypeType(byte value) { }

	// RVA: 0x3632784 Offset: 0x362E784 VA: 0x3632784 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x363278C Offset: 0x362E78C VA: 0x363278C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3632950 Offset: 0x362E950 VA: 0x3632950 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
