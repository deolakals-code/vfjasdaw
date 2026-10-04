// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Status
public class TrophyCheckReward : PacketBase // TypeDefIndex: 12091
{
	// Fields
	[CompilerGenerated]
	private int <TrophyId>k__BackingField; // 0x20

	// Properties
	public override byte Code { get; }
	[PacketParameter(Code = 163)]
	public int TrophyId { get; set; }

	// Methods

	// RVA: 0x3785958 Offset: 0x3781958 VA: 0x3785958
	public void .ctor() { }

	// RVA: 0x3785960 Offset: 0x3781960 VA: 0x3785960 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x3785968 Offset: 0x3781968 VA: 0x3785968
	public int get_TrophyId() { }

	[CompilerGenerated]
	// RVA: 0x3785970 Offset: 0x3781970 VA: 0x3785970
	public void set_TrophyId(int value) { }

	// RVA: 0x3785978 Offset: 0x3781978 VA: 0x3785978 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3785A98 Offset: 0x3781A98 VA: 0x3785A98 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
