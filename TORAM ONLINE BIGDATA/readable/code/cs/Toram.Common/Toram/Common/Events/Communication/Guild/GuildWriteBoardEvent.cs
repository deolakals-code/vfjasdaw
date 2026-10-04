// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Guild
public class GuildWriteBoardEvent : PacketBase // TypeDefIndex: 12927
{
	// Fields
	[CompilerGenerated]
	private int <GuildId>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x24
	[CompilerGenerated]
	private string <UserName>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <BoardType>k__BackingField; // 0x30
	[CompilerGenerated]
	private long <BoardDate>k__BackingField; // 0x38

	// Properties
	[PacketParameter(Code = 219)]
	public int GuildId { get; set; }
	[PacketParameter(Code = 74)]
	public int ArchetypeId { get; set; }
	[PacketParameter(Code = 66)]
	public string UserName { get; set; }
	public byte BoardType { get; set; }
	public long BoardDate { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x367A3F4 Offset: 0x36763F4 VA: 0x367A3F4
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x367A3FC Offset: 0x36763FC VA: 0x367A3FC
	public int get_GuildId() { }

	[CompilerGenerated]
	// RVA: 0x367A404 Offset: 0x3676404 VA: 0x367A404
	public void set_GuildId(int value) { }

	[CompilerGenerated]
	// RVA: 0x367A40C Offset: 0x367640C VA: 0x367A40C
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x367A414 Offset: 0x3676414 VA: 0x367A414
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x367A41C Offset: 0x367641C VA: 0x367A41C
	public string get_UserName() { }

	[CompilerGenerated]
	// RVA: 0x367A424 Offset: 0x3676424 VA: 0x367A424
	public void set_UserName(string value) { }

	[CompilerGenerated]
	// RVA: 0x367A42C Offset: 0x367642C VA: 0x367A42C
	public byte get_BoardType() { }

	[CompilerGenerated]
	// RVA: 0x367A434 Offset: 0x3676434 VA: 0x367A434
	public void set_BoardType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x367A43C Offset: 0x367643C VA: 0x367A43C
	public long get_BoardDate() { }

	[CompilerGenerated]
	// RVA: 0x367A444 Offset: 0x3676444 VA: 0x367A444
	public void set_BoardDate(long value) { }

	// RVA: 0x367A44C Offset: 0x367644C VA: 0x367A44C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x367A454 Offset: 0x3676454 VA: 0x367A454 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x367A70C Offset: 0x367670C VA: 0x367A70C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
