// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Lottery
public class HouseLotteryStartResponse : OperationResponseBase // TypeDefIndex: 11542
{
	// Fields
	[CompilerGenerated]
	private int <WinnerAvatarId>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <WinnerName>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <IsAnchored>k__BackingField; // 0x30

	// Properties
	[PacketParameter(Code = 200)]
	public int WinnerAvatarId { get; set; }
	[PacketParameter(Code = 211)]
	public string WinnerName { get; set; }
	[PacketParameter(Code = 43)]
	public bool IsAnchored { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x37175A8 Offset: 0x37135A8 VA: 0x37175A8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x37175B0 Offset: 0x37135B0 VA: 0x37175B0
	public int get_WinnerAvatarId() { }

	[CompilerGenerated]
	// RVA: 0x37175B8 Offset: 0x37135B8 VA: 0x37175B8
	public void set_WinnerAvatarId(int value) { }

	[CompilerGenerated]
	// RVA: 0x37175C0 Offset: 0x37135C0 VA: 0x37175C0
	public string get_WinnerName() { }

	[CompilerGenerated]
	// RVA: 0x37175C8 Offset: 0x37135C8 VA: 0x37175C8
	public void set_WinnerName(string value) { }

	[CompilerGenerated]
	// RVA: 0x37175D0 Offset: 0x37135D0 VA: 0x37175D0
	public bool get_IsAnchored() { }

	[CompilerGenerated]
	// RVA: 0x37175D8 Offset: 0x37135D8 VA: 0x37175D8
	public void set_IsAnchored(bool value) { }

	// RVA: 0x37175E4 Offset: 0x37135E4 VA: 0x37175E4
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x37176CC Offset: 0x37136CC VA: 0x37176CC
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3717760 Offset: 0x3713760 VA: 0x3717760 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3717768 Offset: 0x3713768 VA: 0x3717768 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3717770 Offset: 0x3713770 VA: 0x3717770 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37178F8 Offset: 0x37138F8 VA: 0x37178F8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
