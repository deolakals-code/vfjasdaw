// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Scenario.Quests
public class QuestAbandonmentResponse : OperationBase // TypeDefIndex: 11431
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <QuestId>k__BackingField; // 0x28

	// Properties
	public override byte Code { get; }
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 77)]
	public int QuestId { get; set; }

	// Methods

	// RVA: 0x3708188 Offset: 0x3704188 VA: 0x3708188
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x3708190 Offset: 0x3704190 VA: 0x3708190 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x3708198 Offset: 0x3704198 VA: 0x3708198
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x37081A0 Offset: 0x37041A0 VA: 0x37081A0
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x37081A8 Offset: 0x37041A8 VA: 0x37081A8
	public int get_QuestId() { }

	[CompilerGenerated]
	// RVA: 0x37081B0 Offset: 0x37041B0 VA: 0x37081B0
	public void set_QuestId(int value) { }

	// RVA: 0x37081B8 Offset: 0x37041B8 VA: 0x37081B8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3708338 Offset: 0x3704338 VA: 0x3708338 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
