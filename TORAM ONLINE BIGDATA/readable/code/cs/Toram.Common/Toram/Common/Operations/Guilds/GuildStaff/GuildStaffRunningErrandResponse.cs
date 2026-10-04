// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds.GuildStaff
public class GuildStaffRunningErrandResponse : OperationResponseBase // TypeDefIndex: 12415
{
	// Fields
	[CompilerGenerated]
	private int <ErrandLeftTime>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 172)]
	public int ErrandLeftTime { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3603CBC Offset: 0x35FFCBC VA: 0x3603CBC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3603CC4 Offset: 0x35FFCC4 VA: 0x3603CC4
	public int get_ErrandLeftTime() { }

	[CompilerGenerated]
	// RVA: 0x3603CCC Offset: 0x35FFCCC VA: 0x3603CCC
	public void set_ErrandLeftTime(int value) { }

	// RVA: 0x3603CD4 Offset: 0x35FFCD4 VA: 0x3603CD4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3603CDC Offset: 0x35FFCDC VA: 0x3603CDC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3603CE4 Offset: 0x35FFCE4 VA: 0x3603CE4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3603D84 Offset: 0x35FFD84 VA: 0x3603D84 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
