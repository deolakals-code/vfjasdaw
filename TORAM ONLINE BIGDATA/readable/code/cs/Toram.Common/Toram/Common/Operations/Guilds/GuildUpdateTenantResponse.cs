// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds
public class GuildUpdateTenantResponse : OperationResponseBase // TypeDefIndex: 12370
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
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35FC4E0 Offset: 0x35F84E0 VA: 0x35FC4E0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35FC4E8 Offset: 0x35F84E8 VA: 0x35FC4E8
	public int get_GuildId() { }

	[CompilerGenerated]
	// RVA: 0x35FC4F0 Offset: 0x35F84F0 VA: 0x35FC4F0
	public void set_GuildId(int value) { }

	[CompilerGenerated]
	// RVA: 0x35FC4F8 Offset: 0x35F84F8 VA: 0x35FC4F8
	public GuildVariableData[] get_Data() { }

	[CompilerGenerated]
	// RVA: 0x35FC500 Offset: 0x35F8500 VA: 0x35FC500
	public void set_Data(GuildVariableData[] value) { }

	// RVA: 0x35FC508 Offset: 0x35F8508 VA: 0x35FC508 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35FC510 Offset: 0x35F8510 VA: 0x35FC510 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35FC518 Offset: 0x35F8518 VA: 0x35FC518 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35FC6C4 Offset: 0x35F86C4 VA: 0x35FC6C4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
