// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Party.Lottery
public class LotteryJoinResponse : OperationResponseBase // TypeDefIndex: 11512
{
	// Fields
	[CompilerGenerated]
	private int <LotteryNum>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <OrganizerId>k__BackingField; // 0x24
	[CompilerGenerated]
	private string <OrganizerName>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <JoinPartyId>k__BackingField; // 0x30

	// Properties
	[PacketParameter(Code = 253)]
	public int LotteryNum { get; set; }
	[PacketParameter(Code = 200)]
	public int OrganizerId { get; set; }
	[PacketParameter(Code = 211)]
	public string OrganizerName { get; set; }
	[PacketParameter(Code = 94)]
	public int JoinPartyId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3715470 Offset: 0x3711470 VA: 0x3715470
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3715478 Offset: 0x3711478 VA: 0x3715478
	public int get_LotteryNum() { }

	[CompilerGenerated]
	// RVA: 0x3715480 Offset: 0x3711480 VA: 0x3715480
	public void set_LotteryNum(int value) { }

	[CompilerGenerated]
	// RVA: 0x3715488 Offset: 0x3711488 VA: 0x3715488
	public int get_OrganizerId() { }

	[CompilerGenerated]
	// RVA: 0x3715490 Offset: 0x3711490 VA: 0x3715490
	public void set_OrganizerId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3715498 Offset: 0x3711498 VA: 0x3715498
	public string get_OrganizerName() { }

	[CompilerGenerated]
	// RVA: 0x37154A0 Offset: 0x37114A0 VA: 0x37154A0
	public void set_OrganizerName(string value) { }

	[CompilerGenerated]
	// RVA: 0x37154A8 Offset: 0x37114A8 VA: 0x37154A8
	public int get_JoinPartyId() { }

	[CompilerGenerated]
	// RVA: 0x37154B0 Offset: 0x37114B0 VA: 0x37154B0
	public void set_JoinPartyId(int value) { }

	// RVA: 0x37154B8 Offset: 0x37114B8 VA: 0x37154B8
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x37154BC Offset: 0x37114BC VA: 0x37154BC
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x37154C0 Offset: 0x37114C0 VA: 0x37154C0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37154C8 Offset: 0x37114C8 VA: 0x37154C8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37154D0 Offset: 0x37114D0 VA: 0x37154D0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37156D8 Offset: 0x37116D8 VA: 0x37156D8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
