// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Collaborations.NewWave.Events
public class NewWaveMoveMobEvent : EventSubBase // TypeDefIndex: 13052
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

	[CompilerGenerated]
	// RVA: 0x3698528 Offset: 0x3694528 VA: 0x3698528
	public MobData[] get_MobList() { }

	[CompilerGenerated]
	// RVA: 0x3698530 Offset: 0x3694530 VA: 0x3698530
	public void set_MobList(MobData[] value) { }

	// RVA: 0x3698538 Offset: 0x3694538 VA: 0x3698538 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3698540 Offset: 0x3694540 VA: 0x3698540 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3698548 Offset: 0x3694548 VA: 0x3698548
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x3698550 Offset: 0x3694550 VA: 0x3698550 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36986E8 Offset: 0x36946E8 VA: 0x36986E8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x36985E8 Offset: 0x36945E8 VA: 0x36985E8
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x369871C Offset: 0x369471C VA: 0x369871C
	private void GetClass(Dictionary<byte, object> parameters) { }
}
