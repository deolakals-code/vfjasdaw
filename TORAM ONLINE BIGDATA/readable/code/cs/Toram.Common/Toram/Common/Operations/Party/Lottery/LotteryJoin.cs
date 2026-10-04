// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Party.Lottery
public class LotteryJoin : OperationRequestBase // TypeDefIndex: 11511
{
	// Fields
	[CompilerGenerated]
	private int <OrganizerId>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <JoinPartyId>k__BackingField; // 0x24

	// Properties
	[PacketParameter(Code = 200)]
	public int OrganizerId { get; set; }
	[PacketParameter(Code = 94)]
	public int JoinPartyId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3715204 Offset: 0x3711204 VA: 0x3715204
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x371520C Offset: 0x371120C VA: 0x371520C
	public int get_OrganizerId() { }

	[CompilerGenerated]
	// RVA: 0x3715214 Offset: 0x3711214 VA: 0x3715214
	public void set_OrganizerId(int value) { }

	[CompilerGenerated]
	// RVA: 0x371521C Offset: 0x371121C VA: 0x371521C
	public int get_JoinPartyId() { }

	[CompilerGenerated]
	// RVA: 0x3715224 Offset: 0x3711224 VA: 0x3715224
	public void set_JoinPartyId(int value) { }

	// RVA: 0x371522C Offset: 0x371122C VA: 0x371522C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3715234 Offset: 0x3711234 VA: 0x3715234 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x371523C Offset: 0x371123C VA: 0x371523C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37153A8 Offset: 0x37113A8 VA: 0x37153A8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
