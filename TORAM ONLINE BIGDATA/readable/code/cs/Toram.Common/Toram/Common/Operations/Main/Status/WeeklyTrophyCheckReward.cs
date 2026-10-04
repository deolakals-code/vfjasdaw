// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Status
public class WeeklyTrophyCheckReward : PacketBase // TypeDefIndex: 12093
{
	// Fields
	[CompilerGenerated]
	private int <TrophyId>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 163)]
	public int TrophyId { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3785E8C Offset: 0x3781E8C VA: 0x3785E8C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3785E94 Offset: 0x3781E94 VA: 0x3785E94
	public int get_TrophyId() { }

	[CompilerGenerated]
	// RVA: 0x3785E9C Offset: 0x3781E9C VA: 0x3785E9C
	public void set_TrophyId(int value) { }

	// RVA: 0x3785EA4 Offset: 0x3781EA4 VA: 0x3785EA4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3785EAC Offset: 0x3781EAC VA: 0x3785EAC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3785FCC Offset: 0x3781FCC VA: 0x3785FCC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
