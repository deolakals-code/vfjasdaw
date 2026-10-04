// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Status
public class DailyTrophyCheckReward : PacketBase // TypeDefIndex: 12075
{
	// Fields
	[CompilerGenerated]
	private int <TrophyId>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 163)]
	public int TrophyId { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3782580 Offset: 0x377E580 VA: 0x3782580
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3782588 Offset: 0x377E588 VA: 0x3782588
	public int get_TrophyId() { }

	[CompilerGenerated]
	// RVA: 0x3782590 Offset: 0x377E590 VA: 0x3782590
	public void set_TrophyId(int value) { }

	// RVA: 0x3782598 Offset: 0x377E598 VA: 0x3782598 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37825A0 Offset: 0x377E5A0 VA: 0x37825A0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37826C0 Offset: 0x377E6C0 VA: 0x37826C0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
