// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds.Quest
public class GuildMedalUpdateResponse : OperationResponseBase // TypeDefIndex: 12424
{
	// Fields
	[CompilerGenerated]
	private GuildVariableData[] <Data>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 199)]
	public GuildVariableData[] Data { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x36052D4 Offset: 0x36012D4 VA: 0x36052D4
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36052DC Offset: 0x36012DC VA: 0x36052DC
	public GuildVariableData[] get_Data() { }

	[CompilerGenerated]
	// RVA: 0x36052E4 Offset: 0x36012E4 VA: 0x36052E4
	public void set_Data(GuildVariableData[] value) { }

	// RVA: 0x36052EC Offset: 0x36012EC VA: 0x36052EC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36052F4 Offset: 0x36012F4 VA: 0x36052F4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x36052FC Offset: 0x36012FC VA: 0x36052FC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3605390 Offset: 0x3601390 VA: 0x3605390 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
