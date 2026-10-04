// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds
public class GuildHomeEnter : PacketBase // TypeDefIndex: 12355
{
	// Fields
	[CompilerGenerated]
	private int <EnterGuildId>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 0)]
	public int EnterGuildId { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x35F9B8C Offset: 0x35F5B8C VA: 0x35F9B8C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35F9B94 Offset: 0x35F5B94 VA: 0x35F9B94
	public int get_EnterGuildId() { }

	[CompilerGenerated]
	// RVA: 0x35F9B9C Offset: 0x35F5B9C VA: 0x35F9B9C
	public void set_EnterGuildId(int value) { }

	// RVA: 0x35F9BA4 Offset: 0x35F5BA4 VA: 0x35F9BA4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35F9BAC Offset: 0x35F5BAC VA: 0x35F9BAC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x35F9C7C Offset: 0x35F5C7C VA: 0x35F9C7C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
