// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room.WaveRaid
public class WaveRaidTargetAttackEvent : EventSubBase // TypeDefIndex: 12787
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

	// RVA: 0x3658D28 Offset: 0x3654D28 VA: 0x3658D28 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3658D30 Offset: 0x3654D30 VA: 0x3658D30 Slot: 7
	public override byte get_SubCode() { }

	[CompilerGenerated]
	// RVA: 0x3658D38 Offset: 0x3654D38 VA: 0x3658D38
	public MobData get_MobData() { }

	[CompilerGenerated]
	// RVA: 0x3658D40 Offset: 0x3654D40 VA: 0x3658D40
	public void set_MobData(MobData value) { }

	[CompilerGenerated]
	// RVA: 0x3658D48 Offset: 0x3654D48 VA: 0x3658D48
	public short get_TargetId() { }

	[CompilerGenerated]
	// RVA: 0x3658D50 Offset: 0x3654D50 VA: 0x3658D50
	public void set_TargetId(short value) { }

	[CompilerGenerated]
	// RVA: 0x3658D58 Offset: 0x3654D58 VA: 0x3658D58
	public int get_TargetHp() { }

	[CompilerGenerated]
	// RVA: 0x3658D60 Offset: 0x3654D60 VA: 0x3658D60
	public void set_TargetHp(int value) { }

	[CompilerGenerated]
	// RVA: 0x3658D68 Offset: 0x3654D68 VA: 0x3658D68
	public ArchetypeUid get_Archetype() { }

	[CompilerGenerated]
	// RVA: 0x3658D70 Offset: 0x3654D70 VA: 0x3658D70
	public void set_Archetype(ArchetypeUid value) { }

	// RVA: 0x3658D78 Offset: 0x3654D78 VA: 0x3658D78
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x3658D80 Offset: 0x3654D80 VA: 0x3658D80
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3658F08 Offset: 0x3654F08 VA: 0x3658F08
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3658FC4 Offset: 0x3654FC4 VA: 0x3658FC4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x365914C Offset: 0x365514C VA: 0x365914C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
