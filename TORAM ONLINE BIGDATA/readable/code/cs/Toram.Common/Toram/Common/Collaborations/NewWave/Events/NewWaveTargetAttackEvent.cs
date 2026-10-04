// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Collaborations.NewWave.Events
public class NewWaveTargetAttackEvent : EventSubBase // TypeDefIndex: 13055
{
	// Fields
	[CompilerGenerated]
	private MobData <MobData>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <TargetHp>k__BackingField; // 0x28
	[CompilerGenerated]
	private ArchetypeUid <Archetype>k__BackingField; // 0x30

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }
	[PacketClass(Code = 76, IsOptional = True)]
	public MobData MobData { get; set; }
	[PacketParameter(Code = 25, IsOptional = True)]
	public int TargetHp { get; set; }
	[PacketParameter(Code = 86, IsOptional = True)]
	public ArchetypeUid Archetype { get; set; }

	// Methods

	// RVA: 0x3698DD0 Offset: 0x3694DD0 VA: 0x3698DD0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3698DD8 Offset: 0x3694DD8 VA: 0x3698DD8 Slot: 7
	public override byte get_SubCode() { }

	[CompilerGenerated]
	// RVA: 0x3698DE0 Offset: 0x3694DE0 VA: 0x3698DE0
	public MobData get_MobData() { }

	[CompilerGenerated]
	// RVA: 0x3698DE8 Offset: 0x3694DE8 VA: 0x3698DE8
	public void set_MobData(MobData value) { }

	[CompilerGenerated]
	// RVA: 0x3698DF0 Offset: 0x3694DF0 VA: 0x3698DF0
	public int get_TargetHp() { }

	[CompilerGenerated]
	// RVA: 0x3698DF8 Offset: 0x3694DF8 VA: 0x3698DF8
	public void set_TargetHp(int value) { }

	[CompilerGenerated]
	// RVA: 0x3698E00 Offset: 0x3694E00 VA: 0x3698E00
	public ArchetypeUid get_Archetype() { }

	[CompilerGenerated]
	// RVA: 0x3698E08 Offset: 0x3694E08 VA: 0x3698E08
	public void set_Archetype(ArchetypeUid value) { }

	// RVA: 0x3698E10 Offset: 0x3694E10 VA: 0x3698E10
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x3698E18 Offset: 0x3694E18 VA: 0x3698E18
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3698FA0 Offset: 0x3694FA0 VA: 0x3698FA0
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x369905C Offset: 0x369505C VA: 0x369905C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x369918C Offset: 0x369518C VA: 0x369918C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
