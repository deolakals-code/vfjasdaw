// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Guild.GuildStaff
public class GuildStaffStartRunningErrandEvent : EventSubBase // TypeDefIndex: 12929
{
	// Fields
	[CompilerGenerated]
	private byte <Flag>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <ErrandLeftTime>k__BackingField; // 0x24

	// Properties
	[PacketParameter(Code = 20)]
	public byte Flag { get; set; }
	[PacketParameter(Code = 42)]
	public int ErrandLeftTime { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x367A8C4 Offset: 0x36768C4 VA: 0x367A8C4
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x367A8CC Offset: 0x36768CC VA: 0x367A8CC
	public byte get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x367A8D4 Offset: 0x36768D4 VA: 0x367A8D4
	public void set_Flag(byte value) { }

	[CompilerGenerated]
	// RVA: 0x367A8DC Offset: 0x36768DC VA: 0x367A8DC
	public int get_ErrandLeftTime() { }

	[CompilerGenerated]
	// RVA: 0x367A8E4 Offset: 0x36768E4 VA: 0x367A8E4
	public void set_ErrandLeftTime(int value) { }

	// RVA: 0x367A8EC Offset: 0x36768EC VA: 0x367A8EC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x367A8F4 Offset: 0x36768F4 VA: 0x367A8F4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x367A8FC Offset: 0x36768FC VA: 0x367A8FC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x367A9D8 Offset: 0x36769D8 VA: 0x367A9D8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
