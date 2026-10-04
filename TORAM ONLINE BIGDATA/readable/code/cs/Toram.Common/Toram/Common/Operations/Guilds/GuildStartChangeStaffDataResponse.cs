// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds
public class GuildStartChangeStaffDataResponse : OperationResponseBase // TypeDefIndex: 12369
{
	// Fields
	[CompilerGenerated]
	private int <MemberId>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 74)]
	public int MemberId { get; set; }
	public override byte SubCode { get; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x35FC2F8 Offset: 0x35F82F8 VA: 0x35FC2F8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35FC300 Offset: 0x35F8300 VA: 0x35FC300
	public int get_MemberId() { }

	[CompilerGenerated]
	// RVA: 0x35FC308 Offset: 0x35F8308 VA: 0x35FC308
	public void set_MemberId(int value) { }

	// RVA: 0x35FC310 Offset: 0x35F8310 VA: 0x35FC310 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35FC318 Offset: 0x35F8318 VA: 0x35FC318 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35FC320 Offset: 0x35F8320 VA: 0x35FC320 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x35FC3C0 Offset: 0x35F83C0 VA: 0x35FC3C0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
