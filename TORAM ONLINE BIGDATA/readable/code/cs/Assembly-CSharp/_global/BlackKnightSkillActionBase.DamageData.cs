// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BlackKnightSkillActionBase.DamageData // TypeDefIndex: 4224
{
	// Fields
	[CompilerGenerated]
	private BlackKnightCharacterManagerBase <Target>k__BackingField; // 0x10
	[CompilerGenerated]
	private int <TotalDamage>k__BackingField; // 0x18
	[CompilerGenerated]
	private SkillHitType <HitType>k__BackingField; // 0x1C
	[CompilerGenerated]
	private SkillDamageData <CurrentSkillDamage>k__BackingField; // 0x20

	// Properties
	public BlackKnightCharacterManagerBase Target { get; set; }
	public int TotalDamage { get; set; }
	public SkillHitType HitType { get; set; }
	public SkillDamageData CurrentSkillDamage { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x24AF2C8 Offset: 0x24AB2C8 VA: 0x24AF2C8
	public BlackKnightCharacterManagerBase get_Target() { }

	[CompilerGenerated]
	// RVA: 0x24AF2D0 Offset: 0x24AB2D0 VA: 0x24AF2D0
	private void set_Target(BlackKnightCharacterManagerBase value) { }

	[CompilerGenerated]
	// RVA: 0x24AF2D8 Offset: 0x24AB2D8 VA: 0x24AF2D8
	public int get_TotalDamage() { }

	[CompilerGenerated]
	// RVA: 0x24AF2E0 Offset: 0x24AB2E0 VA: 0x24AF2E0
	public void set_TotalDamage(int value) { }

	[CompilerGenerated]
	// RVA: 0x24AF2E8 Offset: 0x24AB2E8 VA: 0x24AF2E8
	public SkillHitType get_HitType() { }

	[CompilerGenerated]
	// RVA: 0x24AF2F0 Offset: 0x24AB2F0 VA: 0x24AF2F0
	public void set_HitType(SkillHitType value) { }

	[CompilerGenerated]
	// RVA: 0x24AF2F8 Offset: 0x24AB2F8 VA: 0x24AF2F8
	public SkillDamageData get_CurrentSkillDamage() { }

	[CompilerGenerated]
	// RVA: 0x24AF300 Offset: 0x24AB300 VA: 0x24AF300
	public void set_CurrentSkillDamage(SkillDamageData value) { }

	// RVA: 0x24A2CC4 Offset: 0x249ECC4 VA: 0x24A2CC4
	public void .ctor(BlackKnightCharacterManagerBase target) { }

	// RVA: 0x24A2E14 Offset: 0x249EE14 VA: 0x24A2E14
	public SkillDamageData createDamageData(int damage) { }

	// RVA: 0x24AF308 Offset: 0x24AB308 VA: 0x24AF308
	public void OnDamaged() { }
}
