// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room.Wave
public class WaveTargetAttackEvent : EventSubBase // TypeDefIndex: 12766
{
	// Fields
	[CompilerGenerated]
	private MobData <MobData>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <TargetId>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <TargetHp>k__BackingField; // 0x2C
	[CompilerGenerated]
	private ArchetypeUid <Archetype>k__BackingField; // 0x30

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }
	[PacketClass(Code = 76, IsOptional = True)]
	public MobData MobData { get; set; }
	[PacketParameter(Code = 96, IsOptional = True)]
	public short TargetId { get; set; }
	[PacketParameter(Code = 25, IsOptional = True)]
	public int TargetHp { get; set; }
	[PacketParameter(Code = 86, IsOptional = True)]
	public ArchetypeUid Archetype { get; set; }

	// Methods

	// RVA: 0x3654624 Offset: 0x3650624 VA: 0x3654624 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x365462C Offset: 0x365062C VA: 0x365462C Slot: 7
	public override byte get_SubCode() { }

	[CompilerGenerated]
	// RVA: 0x3654634 Offset: 0x3650634 VA: 0x3654634
	public MobData get_MobData() { }

	[CompilerGenerated]
	// RVA: 0x365463C Offset: 0x365063C VA: 0x365463C
	public void set_MobData(MobData value) { }

	[CompilerGenerated]
	// RVA: 0x3654644 Offset: 0x3650644 VA: 0x3654644
	public short get_TargetId() { }

	[CompilerGenerated]
	// RVA: 0x365464C Offset: 0x365064C VA: 0x365464C
	public void set_TargetId(short value) { }

	[CompilerGenerated]
	// RVA: 0x3654654 Offset: 0x3650654 VA: 0x3654654
	public int get_TargetHp() { }

	[CompilerGenerated]
	// RVA: 0x365465C Offset: 0x365065C VA: 0x365465C
	public void set_TargetHp(int value) { }

	[CompilerGenerated]
	// RVA: 0x3654664 Offset: 0x3650664 VA: 0x3654664
	public ArchetypeUid get_Archetype() { }

	[CompilerGenerated]
	// RVA: 0x365466C Offset: 0x365066C VA: 0x365466C
	public void set_Archetype(ArchetypeUid value) { }

	// RVA: 0x3654674 Offset: 0x3650674 VA: 0x3654674
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x365467C Offset: 0x365067C VA: 0x365467C
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3654804 Offset: 0x3650804 VA: 0x3654804
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x36548C0 Offset: 0x36508C0 VA: 0x36548C0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3654A48 Offset: 0x3650A48 VA: 0x3654A48 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
