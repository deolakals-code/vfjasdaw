// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds
public class GuildChangeTenantResponse : OperationResponseBase // TypeDefIndex: 12372
{
	// Fields
	[CompilerGenerated]
	private int <GuildId>k__BackingField; // 0x20
	[CompilerGenerated]
	private GuildVariableData <VariableData>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 219)]
	public int GuildId { get; set; }
	[PacketParameter(Code = 199)]
	public GuildVariableData VariableData { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35FC980 Offset: 0x35F8980 VA: 0x35FC980
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35FC988 Offset: 0x35F8988 VA: 0x35FC988
	public int get_GuildId() { }

	[CompilerGenerated]
	// RVA: 0x35FC990 Offset: 0x35F8990 VA: 0x35FC990
	public void set_GuildId(int value) { }

	[CompilerGenerated]
	// RVA: 0x35FC998 Offset: 0x35F8998 VA: 0x35FC998
	public GuildVariableData get_VariableData() { }

	[CompilerGenerated]
	// RVA: 0x35FC9A0 Offset: 0x35F89A0 VA: 0x35FC9A0
	public void set_VariableData(GuildVariableData value) { }

	// RVA: 0x35FC9A8 Offset: 0x35F89A8 VA: 0x35FC9A8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35FC9B0 Offset: 0x35F89B0 VA: 0x35FC9B0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35FC9B8 Offset: 0x35F89B8 VA: 0x35FC9B8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35FCB80 Offset: 0x35F8B80 VA: 0x35FCB80 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
