// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ExSkillEnchantedSpell : ExSkillDataBase // TypeDefIndex: 1819
{
	// Fields
	[CompilerGenerated]
	private EnchantedSpellConditionType <Trigger>k__BackingField; // 0x10
	[CompilerGenerated]
	private SkillId <UseSkillId>k__BackingField; // 0x14
	[CompilerGenerated]
	private byte <UseSkillLevel>k__BackingField; // 0x18

	// Properties
	public override SkillId SkillId { get; }
	public EnchantedSpellConditionType Trigger { get; set; }
	public SkillId UseSkillId { get; set; }
	public byte UseSkillLevel { get; set; }

	// Methods

	// RVA: 0x20E49E0 Offset: 0x20E09E0 VA: 0x20E49E0
	public void .ctor() { }

	// RVA: 0x20E49E8 Offset: 0x20E09E8 VA: 0x20E49E8
	public void .ctor(byte[] binary) { }

	// RVA: 0x20E4A1C Offset: 0x20E0A1C VA: 0x20E4A1C Slot: 4
	public override SkillId get_SkillId() { }

	[CompilerGenerated]
	// RVA: 0x20E4A24 Offset: 0x20E0A24 VA: 0x20E4A24
	public EnchantedSpellConditionType get_Trigger() { }

	[CompilerGenerated]
	// RVA: 0x20E4A2C Offset: 0x20E0A2C VA: 0x20E4A2C
	public void set_Trigger(EnchantedSpellConditionType value) { }

	[CompilerGenerated]
	// RVA: 0x20E4A34 Offset: 0x20E0A34 VA: 0x20E4A34
	public SkillId get_UseSkillId() { }

	[CompilerGenerated]
	// RVA: 0x20E4A3C Offset: 0x20E0A3C VA: 0x20E4A3C
	public void set_UseSkillId(SkillId value) { }

	[CompilerGenerated]
	// RVA: 0x20E4A44 Offset: 0x20E0A44 VA: 0x20E4A44
	public byte get_UseSkillLevel() { }

	[CompilerGenerated]
	// RVA: 0x20E4A4C Offset: 0x20E0A4C VA: 0x20E4A4C
	public void set_UseSkillLevel(byte value) { }

	// RVA: 0x20E4A54 Offset: 0x20E0A54 VA: 0x20E4A54 Slot: 6
	public override void SetValue(byte[] binary) { }

	// RVA: 0x20E4C18 Offset: 0x20E0C18 VA: 0x20E4C18 Slot: 5
	public override byte[] ToBinary() { }
}
