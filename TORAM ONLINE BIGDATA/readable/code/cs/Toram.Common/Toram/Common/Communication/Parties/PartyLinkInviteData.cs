// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Communication.Parties
public class PartyLinkInviteData : UnityHashBase // TypeDefIndex: 13002
{
	// Fields
	[CompilerGenerated]
	private int <PartyLinkId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private string <LeaderName>k__BackingField; // 0x20
	[CompilerGenerated]
	private long <Time>k__BackingField; // 0x28

	// Properties
	public int PartyLinkId { get; set; }
	public string LeaderName { get; set; }
	public long Time { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x368B448 Offset: 0x3687448 VA: 0x368B448
	public void .ctor() { }

	// RVA: 0x368B450 Offset: 0x3687450 VA: 0x368B450
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x368B458 Offset: 0x3687458 VA: 0x368B458
	public int get_PartyLinkId() { }

	[CompilerGenerated]
	// RVA: 0x368B460 Offset: 0x3687460 VA: 0x368B460
	public void set_PartyLinkId(int value) { }

	[CompilerGenerated]
	// RVA: 0x368B468 Offset: 0x3687468 VA: 0x368B468
	public string get_LeaderName() { }

	[CompilerGenerated]
	// RVA: 0x368B470 Offset: 0x3687470 VA: 0x368B470
	public void set_LeaderName(string value) { }

	[CompilerGenerated]
	// RVA: 0x368B478 Offset: 0x3687478 VA: 0x368B478
	public long get_Time() { }

	[CompilerGenerated]
	// RVA: 0x368B480 Offset: 0x3687480 VA: 0x368B480
	public void set_Time(long value) { }

	// RVA: 0x368B488 Offset: 0x3687488 VA: 0x368B488 Slot: 3
	public override string ToString() { }

	// RVA: 0x368B548 Offset: 0x3687548 VA: 0x368B548 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x368B550 Offset: 0x3687550 VA: 0x368B550 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x368B788 Offset: 0x3687788 VA: 0x368B788 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
