// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events
public class WarpPositionEvent : PacketBase // TypeDefIndex: 12612
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x24
	[CompilerGenerated]
	private short[] <Position>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <Rotation>k__BackingField; // 0x30

	// Properties
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 55)]
	public byte ArchetypeType { get; }
	[PacketParameter(Code = 54, IsOptional = True)]
	public short[] Position { get; set; }
	[PacketParameter(Code = 65, IsOptional = True)]
	public short Rotation { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x363033C Offset: 0x362C33C VA: 0x363033C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3630344 Offset: 0x362C344 VA: 0x3630344
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x363034C Offset: 0x362C34C VA: 0x363034C
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3630354 Offset: 0x362C354 VA: 0x3630354
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x363035C Offset: 0x362C35C VA: 0x363035C
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x3630364 Offset: 0x362C364 VA: 0x3630364
	public void set_Position(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x363036C Offset: 0x362C36C VA: 0x363036C
	public short get_Rotation() { }

	[CompilerGenerated]
	// RVA: 0x3630374 Offset: 0x362C374 VA: 0x3630374
	public void set_Rotation(short value) { }

	// RVA: 0x363037C Offset: 0x362C37C VA: 0x363037C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3630384 Offset: 0x362C384 VA: 0x3630384 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36305B4 Offset: 0x362C5B4 VA: 0x36305B4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
