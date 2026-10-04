// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Battle
public class RespawnLatencyEvent : PacketBase // TypeDefIndex: 12723
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x24
	[CompilerGenerated]
	private short <RespawnTime>k__BackingField; // 0x26
	[CompilerGenerated]
	private short <YellsTime>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <Failure>k__BackingField; // 0x2A

	// Properties
	public override byte Code { get; }
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 55)]
	public byte ArchetypeType { get; set; }
	[PacketParameter(Code = 119, IsOptional = True)]
	public short RespawnTime { get; set; }
	[PacketParameter(Code = 120, IsOptional = True)]
	public short YellsTime { get; set; }
	[PacketParameter(Code = 78, IsOptional = True)]
	public bool Failure { get; set; }

	// Methods

	// RVA: 0x364AB7C Offset: 0x3646B7C VA: 0x364AB7C
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x364AB84 Offset: 0x3646B84 VA: 0x364AB84 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x364AB8C Offset: 0x3646B8C VA: 0x364AB8C
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x364AB94 Offset: 0x3646B94 VA: 0x364AB94
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x364AB9C Offset: 0x3646B9C VA: 0x364AB9C
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x364ABA4 Offset: 0x3646BA4 VA: 0x364ABA4
	public void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x364ABAC Offset: 0x3646BAC VA: 0x364ABAC
	public short get_RespawnTime() { }

	[CompilerGenerated]
	// RVA: 0x364ABB4 Offset: 0x3646BB4 VA: 0x364ABB4
	public void set_RespawnTime(short value) { }

	[CompilerGenerated]
	// RVA: 0x364ABBC Offset: 0x3646BBC VA: 0x364ABBC
	public short get_YellsTime() { }

	[CompilerGenerated]
	// RVA: 0x364ABC4 Offset: 0x3646BC4 VA: 0x364ABC4
	public void set_YellsTime(short value) { }

	[CompilerGenerated]
	// RVA: 0x364ABCC Offset: 0x3646BCC VA: 0x364ABCC
	public bool get_Failure() { }

	[CompilerGenerated]
	// RVA: 0x364ABD4 Offset: 0x3646BD4 VA: 0x364ABD4
	public void set_Failure(bool value) { }

	// RVA: 0x364ABE0 Offset: 0x3646BE0 VA: 0x364ABE0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x364AED0 Offset: 0x3646ED0 VA: 0x364AED0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
