// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Global.Contents.Moba
public class MobaHealEvent : EventSubBase // TypeDefIndex: 12661
{
	// Fields
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <Hp>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <Mp>k__BackingField; // 0x2C
	[CompilerGenerated]
	private int <HpHeal>k__BackingField; // 0x30
	[CompilerGenerated]
	private short <MpHeal>k__BackingField; // 0x34
	[CompilerGenerated]
	private short <DuelAbilityType>k__BackingField; // 0x36

	// Properties
	public byte ArchetypeType { get; set; }
	public int ArchetypeId { get; set; }
	public int Hp { get; set; }
	public short Mp { get; set; }
	public int HpHeal { get; set; }
	public short MpHeal { get; set; }
	public short DuelAbilityType { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x363C428 Offset: 0x3638428 VA: 0x363C428
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x363C430 Offset: 0x3638430 VA: 0x363C430
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x363C438 Offset: 0x3638438 VA: 0x363C438
	public void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x363C440 Offset: 0x3638440 VA: 0x363C440
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x363C448 Offset: 0x3638448 VA: 0x363C448
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x363C450 Offset: 0x3638450 VA: 0x363C450
	public int get_Hp() { }

	[CompilerGenerated]
	// RVA: 0x363C458 Offset: 0x3638458 VA: 0x363C458
	public void set_Hp(int value) { }

	[CompilerGenerated]
	// RVA: 0x363C460 Offset: 0x3638460 VA: 0x363C460
	public short get_Mp() { }

	[CompilerGenerated]
	// RVA: 0x363C468 Offset: 0x3638468 VA: 0x363C468
	public void set_Mp(short value) { }

	[CompilerGenerated]
	// RVA: 0x363C470 Offset: 0x3638470 VA: 0x363C470
	public int get_HpHeal() { }

	[CompilerGenerated]
	// RVA: 0x363C478 Offset: 0x3638478 VA: 0x363C478
	public void set_HpHeal(int value) { }

	[CompilerGenerated]
	// RVA: 0x363C480 Offset: 0x3638480 VA: 0x363C480
	public short get_MpHeal() { }

	[CompilerGenerated]
	// RVA: 0x363C488 Offset: 0x3638488 VA: 0x363C488
	public void set_MpHeal(short value) { }

	[CompilerGenerated]
	// RVA: 0x363C490 Offset: 0x3638490 VA: 0x363C490
	public short get_DuelAbilityType() { }

	[CompilerGenerated]
	// RVA: 0x363C498 Offset: 0x3638498 VA: 0x363C498
	public void set_DuelAbilityType(short value) { }

	// RVA: 0x363C4A0 Offset: 0x36384A0 VA: 0x363C4A0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x363C4A8 Offset: 0x36384A8 VA: 0x363C4A8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x363C4B0 Offset: 0x36384B0 VA: 0x363C4B0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x363C66C Offset: 0x363866C VA: 0x363C66C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
