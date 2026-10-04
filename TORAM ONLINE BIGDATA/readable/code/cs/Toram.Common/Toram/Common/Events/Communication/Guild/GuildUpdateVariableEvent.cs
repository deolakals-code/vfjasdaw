// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Guild
public class GuildUpdateVariableEvent : PacketBase // TypeDefIndex: 12910
{
	// Fields
	[CompilerGenerated]
	private int <GuildId>k__BackingField; // 0x20
	[CompilerGenerated]
	private GuildVariableData[] <Data>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 219)]
	public int GuildId { get; set; }
	[PacketParameter(Code = 199)]
	public GuildVariableData[] Data { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3675728 Offset: 0x3671728 VA: 0x3675728
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3675730 Offset: 0x3671730 VA: 0x3675730
	public int get_GuildId() { }

	[CompilerGenerated]
	// RVA: 0x3675738 Offset: 0x3671738 VA: 0x3675738
	public void set_GuildId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3675740 Offset: 0x3671740 VA: 0x3675740
	public GuildVariableData[] get_Data() { }

	[CompilerGenerated]
	// RVA: 0x3675748 Offset: 0x3671748 VA: 0x3675748
	public void set_Data(GuildVariableData[] value) { }

	// RVA: 0x3675750 Offset: 0x3671750 VA: 0x3675750 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3675758 Offset: 0x3671758 VA: 0x3675758 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3675904 Offset: 0x3671904 VA: 0x3675904 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
