// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Lottery
public class HouseLotteryJoin : OperationRequestBase // TypeDefIndex: 11531
{
	// Fields
	[CompilerGenerated]
	private int <OrganizerId>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 200)]
	public int OrganizerId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3716BFC Offset: 0x3712BFC VA: 0x3716BFC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3716C04 Offset: 0x3712C04 VA: 0x3716C04
	public int get_OrganizerId() { }

	[CompilerGenerated]
	// RVA: 0x3716C0C Offset: 0x3712C0C VA: 0x3716C0C
	public void set_OrganizerId(int value) { }

	// RVA: 0x3716C14 Offset: 0x3712C14 VA: 0x3716C14 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3716C1C Offset: 0x3712C1C VA: 0x3716C1C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3716C24 Offset: 0x3712C24 VA: 0x3716C24 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3716D44 Offset: 0x3712D44 VA: 0x3716D44 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
