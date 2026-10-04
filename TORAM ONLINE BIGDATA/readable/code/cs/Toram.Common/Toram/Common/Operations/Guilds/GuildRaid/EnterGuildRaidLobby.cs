// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds.GuildRaid
public class EnterGuildRaidLobby : PacketBase // TypeDefIndex: 12432
{
	// Fields
	[CompilerGenerated]
	private int <EnterGuildId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <Element>k__BackingField; // 0x24

	// Properties
	[PacketParameter(Code = 0)]
	public int EnterGuildId { get; set; }
	[PacketParameter(Code = 10)]
	public byte Element { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3606AAC Offset: 0x3602AAC VA: 0x3606AAC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3606AB4 Offset: 0x3602AB4 VA: 0x3606AB4
	public int get_EnterGuildId() { }

	[CompilerGenerated]
	// RVA: 0x3606ABC Offset: 0x3602ABC VA: 0x3606ABC
	public void set_EnterGuildId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3606AC4 Offset: 0x3602AC4 VA: 0x3606AC4
	public byte get_Element() { }

	[CompilerGenerated]
	// RVA: 0x3606ACC Offset: 0x3602ACC VA: 0x3606ACC
	public void set_Element(byte value) { }

	// RVA: 0x3606AD4 Offset: 0x3602AD4 VA: 0x3606AD4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3606ADC Offset: 0x3602ADC VA: 0x3606ADC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3606BF0 Offset: 0x3602BF0 VA: 0x3606BF0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
