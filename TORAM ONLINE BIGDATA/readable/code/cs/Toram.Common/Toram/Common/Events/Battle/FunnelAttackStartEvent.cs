// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Battle
public class FunnelAttackStartEvent : PacketBase // TypeDefIndex: 12706
{
	// Fields
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x24
	[CompilerGenerated]
	private MobIdData <FunnelData>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <CommandId>k__BackingField; // 0x30

	// Properties
	[PacketParameter(Code = 55)]
	public byte ArchetypeType { get; set; }
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 76)]
	public MobIdData FunnelData { get; set; }
	[PacketParameter(Code = 130)]
	public short CommandId { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3645BC0 Offset: 0x3641BC0 VA: 0x3645BC0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3645BC8 Offset: 0x3641BC8 VA: 0x3645BC8
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x3645BD0 Offset: 0x3641BD0 VA: 0x3645BD0
	public void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3645BD8 Offset: 0x3641BD8 VA: 0x3645BD8
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x3645BE0 Offset: 0x3641BE0 VA: 0x3645BE0
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3645BE8 Offset: 0x3641BE8 VA: 0x3645BE8
	public MobIdData get_FunnelData() { }

	[CompilerGenerated]
	// RVA: 0x3645BF0 Offset: 0x3641BF0 VA: 0x3645BF0
	public void set_FunnelData(MobIdData value) { }

	[CompilerGenerated]
	// RVA: 0x3645BF8 Offset: 0x3641BF8 VA: 0x3645BF8
	public short get_CommandId() { }

	[CompilerGenerated]
	// RVA: 0x3645C00 Offset: 0x3641C00 VA: 0x3645C00
	public void set_CommandId(short value) { }

	// RVA: 0x3645C08 Offset: 0x3641C08 VA: 0x3645C08 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3645C10 Offset: 0x3641C10 VA: 0x3645C10 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3645E90 Offset: 0x3641E90 VA: 0x3645E90 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
