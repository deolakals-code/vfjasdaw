// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room.Defence
public class DefenceMoveMobEvent : EventSubBase // TypeDefIndex: 12773
{
	// Fields
	[CompilerGenerated]
	private MobData[] <MobList>k__BackingField; // 0x20

	// Properties
	[PacketClass(Code = 89, IsOptional = True)]
	public MobData[] MobList { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3655E8C Offset: 0x3651E8C VA: 0x3655E8C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3655E94 Offset: 0x3651E94 VA: 0x3655E94
	public MobData[] get_MobList() { }

	[CompilerGenerated]
	// RVA: 0x3655E9C Offset: 0x3651E9C VA: 0x3655E9C
	public void set_MobList(MobData[] value) { }

	// RVA: 0x3655EA4 Offset: 0x3651EA4 VA: 0x3655EA4
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3655FA4 Offset: 0x3651FA4 VA: 0x3655FA4
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3656030 Offset: 0x3652030 VA: 0x3656030 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3656038 Offset: 0x3652038 VA: 0x3656038 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3656040 Offset: 0x3652040 VA: 0x3656040 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36560D8 Offset: 0x36520D8 VA: 0x36560D8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
