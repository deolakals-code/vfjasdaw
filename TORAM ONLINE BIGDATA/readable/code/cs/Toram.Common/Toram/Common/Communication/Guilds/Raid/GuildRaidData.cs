// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Communication.Guilds.Raid
public class GuildRaidData : BinaryBase // TypeDefIndex: 13033
{
	// Fields
	[CompilerGenerated]
	private byte <Element>k__BackingField; // 0x19
	[CompilerGenerated]
	private int <RaidId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private byte <CurrentHpCount>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Damage>k__BackingField; // 0x24
	[CompilerGenerated]
	private AbnormalHitData[] <AbnormalHitList>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <IsPractice>k__BackingField; // 0x30

	// Properties
	public byte Element { get; set; }
	public int RaidId { get; set; }
	public byte CurrentHpCount { get; set; }
	public int Damage { get; set; }
	public AbnormalHitData[] AbnormalHitList { get; set; }
	public bool IsPractice { get; set; }

	// Methods

	// RVA: 0x368F540 Offset: 0x368B540 VA: 0x368F540
	public void .ctor(byte[] binary) { }

	[CompilerGenerated]
	// RVA: 0x3692BD0 Offset: 0x368EBD0 VA: 0x3692BD0
	public byte get_Element() { }

	[CompilerGenerated]
	// RVA: 0x3692BD8 Offset: 0x368EBD8 VA: 0x3692BD8
	public void set_Element(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3692BE0 Offset: 0x368EBE0 VA: 0x3692BE0
	public int get_RaidId() { }

	[CompilerGenerated]
	// RVA: 0x3692BE8 Offset: 0x368EBE8 VA: 0x3692BE8
	public void set_RaidId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3692BF0 Offset: 0x368EBF0 VA: 0x3692BF0
	public byte get_CurrentHpCount() { }

	[CompilerGenerated]
	// RVA: 0x3692BF8 Offset: 0x368EBF8 VA: 0x3692BF8
	public void set_CurrentHpCount(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3692C00 Offset: 0x368EC00 VA: 0x3692C00
	public int get_Damage() { }

	[CompilerGenerated]
	// RVA: 0x3692C08 Offset: 0x368EC08 VA: 0x3692C08
	public void set_Damage(int value) { }

	[CompilerGenerated]
	// RVA: 0x3692C10 Offset: 0x368EC10 VA: 0x3692C10
	public AbnormalHitData[] get_AbnormalHitList() { }

	[CompilerGenerated]
	// RVA: 0x3692C18 Offset: 0x368EC18 VA: 0x3692C18
	public void set_AbnormalHitList(AbnormalHitData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3692C20 Offset: 0x368EC20 VA: 0x3692C20
	public bool get_IsPractice() { }

	[CompilerGenerated]
	// RVA: 0x3692C28 Offset: 0x368EC28 VA: 0x3692C28
	public void set_IsPractice(bool value) { }

	// RVA: 0x3692C34 Offset: 0x368EC34 VA: 0x3692C34 Slot: 3
	public override string ToString() { }

	// RVA: 0x3692E84 Offset: 0x368EE84 VA: 0x3692E84 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x3692FB4 Offset: 0x368EFB4 VA: 0x3692FB4 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }
}
