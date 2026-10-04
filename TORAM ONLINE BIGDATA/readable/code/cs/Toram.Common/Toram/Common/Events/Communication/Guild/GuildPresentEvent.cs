// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Guild
public class GuildPresentEvent : PacketBase // TypeDefIndex: 12922
{
	// Fields
	[CompilerGenerated]
	private int <Point>k__BackingField; // 0x20
	[CompilerGenerated]
	private DateTime <Time>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <UserName>k__BackingField; // 0x30

	// Properties
	public int Point { get; set; }
	public DateTime Time { get; set; }
	public string UserName { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3678E9C Offset: 0x3674E9C VA: 0x3678E9C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3678EA4 Offset: 0x3674EA4 VA: 0x3678EA4
	public int get_Point() { }

	[CompilerGenerated]
	// RVA: 0x3678EAC Offset: 0x3674EAC VA: 0x3678EAC
	public void set_Point(int value) { }

	[CompilerGenerated]
	// RVA: 0x3678EB4 Offset: 0x3674EB4 VA: 0x3678EB4
	public DateTime get_Time() { }

	[CompilerGenerated]
	// RVA: 0x3678EBC Offset: 0x3674EBC VA: 0x3678EBC
	public void set_Time(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x3678EC4 Offset: 0x3674EC4 VA: 0x3678EC4
	public string get_UserName() { }

	[CompilerGenerated]
	// RVA: 0x3678ECC Offset: 0x3674ECC VA: 0x3678ECC
	public void set_UserName(string value) { }

	// RVA: 0x3678ED4 Offset: 0x3674ED4 VA: 0x3678ED4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3678EDC Offset: 0x3674EDC VA: 0x3678EDC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36790CC Offset: 0x36750CC VA: 0x36790CC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
