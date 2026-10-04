// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.GameEvents.Summer
public class SummerGameEndEvent : EventSubBase // TypeDefIndex: 12691
{
	// Fields
	[CompilerGenerated]
	private SummerBossData <BossData>k__BackingField; // 0x20

	// Properties
	public SummerBossData BossData { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x364319C Offset: 0x363F19C VA: 0x364319C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36431A4 Offset: 0x363F1A4 VA: 0x36431A4
	public SummerBossData get_BossData() { }

	[CompilerGenerated]
	// RVA: 0x36431AC Offset: 0x363F1AC VA: 0x36431AC
	public void set_BossData(SummerBossData value) { }

	// RVA: 0x36431B4 Offset: 0x363F1B4 VA: 0x36431B4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36431BC Offset: 0x363F1BC VA: 0x36431BC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x36431C4 Offset: 0x363F1C4 VA: 0x36431C4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3643360 Offset: 0x363F360 VA: 0x3643360 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
