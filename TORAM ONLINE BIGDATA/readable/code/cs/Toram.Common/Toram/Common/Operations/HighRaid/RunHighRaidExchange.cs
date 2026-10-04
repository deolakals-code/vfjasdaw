// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.HighRaid
public class RunHighRaidExchange : OperationRequestBase // TypeDefIndex: 11564
{
	// Fields
	[CompilerGenerated]
	private byte <HighRaidNo>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <ClientNowPoint>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <ClientRewardNo>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <ClientRewardCost>k__BackingField; // 0x2C

	// Properties
	[PacketParameter(Code = 210)]
	public byte HighRaidNo { get; set; }
	[PacketParameter(Code = 205)]
	public int ClientNowPoint { get; set; }
	[PacketParameter(Code = 153)]
	public byte ClientRewardNo { get; set; }
	[PacketParameter(Code = 149)]
	public int ClientRewardCost { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x371B094 Offset: 0x3717094 VA: 0x371B094
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x371B09C Offset: 0x371709C VA: 0x371B09C
	public byte get_HighRaidNo() { }

	[CompilerGenerated]
	// RVA: 0x371B0A4 Offset: 0x37170A4 VA: 0x371B0A4
	public void set_HighRaidNo(byte value) { }

	[CompilerGenerated]
	// RVA: 0x371B0AC Offset: 0x37170AC VA: 0x371B0AC
	public int get_ClientNowPoint() { }

	[CompilerGenerated]
	// RVA: 0x371B0B4 Offset: 0x37170B4 VA: 0x371B0B4
	public void set_ClientNowPoint(int value) { }

	[CompilerGenerated]
	// RVA: 0x371B0BC Offset: 0x37170BC VA: 0x371B0BC
	public byte get_ClientRewardNo() { }

	[CompilerGenerated]
	// RVA: 0x371B0C4 Offset: 0x37170C4 VA: 0x371B0C4
	public void set_ClientRewardNo(byte value) { }

	[CompilerGenerated]
	// RVA: 0x371B0CC Offset: 0x37170CC VA: 0x371B0CC
	public int get_ClientRewardCost() { }

	[CompilerGenerated]
	// RVA: 0x371B0D4 Offset: 0x37170D4 VA: 0x371B0D4
	public void set_ClientRewardCost(int value) { }

	// RVA: 0x371B0DC Offset: 0x37170DC VA: 0x371B0DC
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x371B0E0 Offset: 0x37170E0 VA: 0x371B0E0
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x371B0E4 Offset: 0x37170E4 VA: 0x371B0E4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x371B0EC Offset: 0x37170EC VA: 0x371B0EC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x371B0F4 Offset: 0x37170F4 VA: 0x371B0F4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x371B2FC Offset: 0x37172FC VA: 0x371B2FC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
