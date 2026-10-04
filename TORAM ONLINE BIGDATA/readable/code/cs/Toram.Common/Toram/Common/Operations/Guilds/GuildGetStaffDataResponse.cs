// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds
public class GuildGetStaffDataResponse : OperationResponseBase // TypeDefIndex: 12368
{
	// Fields
	[CompilerGenerated]
	private int <GuildId>k__BackingField; // 0x20
	[CompilerGenerated]
	private GuildStaffData <StaffData>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 219)]
	public int GuildId { get; set; }
	[PacketParameter(Code = 199)]
	public GuildStaffData StaffData { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35FC030 Offset: 0x35F8030 VA: 0x35FC030
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35FC038 Offset: 0x35F8038 VA: 0x35FC038
	public int get_GuildId() { }

	[CompilerGenerated]
	// RVA: 0x35FC040 Offset: 0x35F8040 VA: 0x35FC040
	public void set_GuildId(int value) { }

	[CompilerGenerated]
	// RVA: 0x35FC048 Offset: 0x35F8048 VA: 0x35FC048
	public GuildStaffData get_StaffData() { }

	[CompilerGenerated]
	// RVA: 0x35FC050 Offset: 0x35F8050 VA: 0x35FC050
	public void set_StaffData(GuildStaffData value) { }

	// RVA: 0x35FC058 Offset: 0x35F8058 VA: 0x35FC058 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35FC060 Offset: 0x35F8060 VA: 0x35FC060 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35FC068 Offset: 0x35F8068 VA: 0x35FC068 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35FC230 Offset: 0x35F8230 VA: 0x35FC230 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
