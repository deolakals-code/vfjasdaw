// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Lottery
public class HouseLotteryJoinResponse : OperationResponseBase // TypeDefIndex: 11532
{
	// Fields
	[CompilerGenerated]
	private int <LotteryNo>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <OrganizerId>k__BackingField; // 0x24
	[CompilerGenerated]
	private string <OrganizerName>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 210)]
	public int LotteryNo { get; set; }
	[PacketParameter(Code = 200)]
	public int OrganizerId { get; set; }
	[PacketParameter(Code = 211)]
	public string OrganizerName { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3716DE4 Offset: 0x3712DE4 VA: 0x3716DE4
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3716DEC Offset: 0x3712DEC VA: 0x3716DEC
	public int get_LotteryNo() { }

	[CompilerGenerated]
	// RVA: 0x3716DF4 Offset: 0x3712DF4 VA: 0x3716DF4
	public void set_LotteryNo(int value) { }

	[CompilerGenerated]
	// RVA: 0x3716DFC Offset: 0x3712DFC VA: 0x3716DFC
	public int get_OrganizerId() { }

	[CompilerGenerated]
	// RVA: 0x3716E04 Offset: 0x3712E04 VA: 0x3716E04
	public void set_OrganizerId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3716E0C Offset: 0x3712E0C VA: 0x3716E0C
	public string get_OrganizerName() { }

	[CompilerGenerated]
	// RVA: 0x3716E14 Offset: 0x3712E14 VA: 0x3716E14
	public void set_OrganizerName(string value) { }

	// RVA: 0x3716E1C Offset: 0x3712E1C VA: 0x3716E1C
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3716E20 Offset: 0x3712E20 VA: 0x3716E20
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3716E24 Offset: 0x3712E24 VA: 0x3716E24 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3716E2C Offset: 0x3712E2C VA: 0x3716E2C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3716E34 Offset: 0x3712E34 VA: 0x3716E34 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3716FF8 Offset: 0x3712FF8 VA: 0x3716FF8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
