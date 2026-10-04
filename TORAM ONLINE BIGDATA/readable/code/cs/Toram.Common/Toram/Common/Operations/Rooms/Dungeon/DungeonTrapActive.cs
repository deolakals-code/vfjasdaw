// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Rooms.Dungeon
public class DungeonTrapActive : PacketBase // TypeDefIndex: 11771
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <TrapId>k__BackingField; // 0x24
	[CompilerGenerated]
	private int[] <HateMobId>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 153)]
	public byte TrapId { get; set; }
	[PacketParameter(Code = 89, IsOptional = True)]
	public int[] HateMobId { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x37470C8 Offset: 0x37430C8 VA: 0x37470C8
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x37470D0 Offset: 0x37430D0 VA: 0x37470D0
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x37470D8 Offset: 0x37430D8 VA: 0x37470D8
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x37470E0 Offset: 0x37430E0 VA: 0x37470E0
	public byte get_TrapId() { }

	[CompilerGenerated]
	// RVA: 0x37470E8 Offset: 0x37430E8 VA: 0x37470E8
	public void set_TrapId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x37470F0 Offset: 0x37430F0 VA: 0x37470F0
	public int[] get_HateMobId() { }

	[CompilerGenerated]
	// RVA: 0x37470F8 Offset: 0x37430F8 VA: 0x37470F8
	public void set_HateMobId(int[] value) { }

	// RVA: 0x3747100 Offset: 0x3743100 VA: 0x3747100 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3747108 Offset: 0x3743108 VA: 0x3747108 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3747310 Offset: 0x3743310 VA: 0x3747310 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
