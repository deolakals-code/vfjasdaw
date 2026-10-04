// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Guild
public class GuildRaidInvalidRandomPropertyEvent : EventSubBase // TypeDefIndex: 12905
{
	// Fields
	[CompilerGenerated]
	private int <GuildId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <Index>k__BackingField; // 0x24
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 0)]
	public int GuildId { get; set; }
	[PacketParameter(Code = 10)]
	public byte Index { get; set; }
	[PacketParameter(Code = 6)]
	public string Name { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3673A50 Offset: 0x366FA50 VA: 0x3673A50
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3673A58 Offset: 0x366FA58 VA: 0x3673A58
	public int get_GuildId() { }

	[CompilerGenerated]
	// RVA: 0x3673A60 Offset: 0x366FA60 VA: 0x3673A60
	public void set_GuildId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3673A68 Offset: 0x366FA68 VA: 0x3673A68
	public byte get_Index() { }

	[CompilerGenerated]
	// RVA: 0x3673A70 Offset: 0x366FA70 VA: 0x3673A70
	public void set_Index(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3673A78 Offset: 0x366FA78 VA: 0x3673A78
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x3673A80 Offset: 0x366FA80 VA: 0x3673A80
	public void set_Name(string value) { }

	// RVA: 0x3673A88 Offset: 0x366FA88 VA: 0x3673A88 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3673A90 Offset: 0x366FA90 VA: 0x3673A90 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3673A98 Offset: 0x366FA98 VA: 0x3673A98 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3673B88 Offset: 0x366FB88 VA: 0x3673B88 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
