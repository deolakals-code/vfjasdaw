// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Rooms.Dungeon
public class DungeonGroupSettingChange : PacketBase // TypeDefIndex: 11765
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x24
	[CompilerGenerated]
	private short <FloorDepth>k__BackingField; // 0x26

	// Properties
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 55)]
	public byte ArchetypeType { get; set; }
	[PacketClass(Code = 240)]
	public short FloorDepth { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3745BFC Offset: 0x3741BFC VA: 0x3745BFC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3745C04 Offset: 0x3741C04 VA: 0x3745C04
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x3745C0C Offset: 0x3741C0C VA: 0x3745C0C
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3745C14 Offset: 0x3741C14 VA: 0x3745C14
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x3745C1C Offset: 0x3741C1C VA: 0x3745C1C
	public void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3745C24 Offset: 0x3741C24 VA: 0x3745C24
	public short get_FloorDepth() { }

	[CompilerGenerated]
	// RVA: 0x3745C2C Offset: 0x3741C2C VA: 0x3745C2C
	public void set_FloorDepth(short value) { }

	// RVA: 0x3745C34 Offset: 0x3741C34 VA: 0x3745C34
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3745C38 Offset: 0x3741C38 VA: 0x3745C38
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3745C3C Offset: 0x3741C3C VA: 0x3745C3C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3745C44 Offset: 0x3741C44 VA: 0x3745C44 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3745E14 Offset: 0x3741E14 VA: 0x3745E14 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
