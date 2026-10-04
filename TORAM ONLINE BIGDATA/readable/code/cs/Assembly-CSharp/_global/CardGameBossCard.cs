// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CardGameBossCard // TypeDefIndex: 4260
{
	// Fields
	private int damage; // 0x10
	[CompilerGenerated]
	private int <UniqueId>k__BackingField; // 0x14
	[CompilerGenerated]
	private int <PopId>k__BackingField; // 0x18
	[CompilerGenerated]
	private int <Hp>k__BackingField; // 0x1C
	[CompilerGenerated]
	private int <Spina>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <IsDead>k__BackingField; // 0x24

	// Properties
	public int UniqueId { get; set; }
	public int PopId { get; set; }
	public int Hp { get; set; }
	public int Spina { get; set; }
	public bool IsDead { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x24BA0B8 Offset: 0x24B60B8 VA: 0x24BA0B8
	public int get_UniqueId() { }

	[CompilerGenerated]
	// RVA: 0x24BA0C0 Offset: 0x24B60C0 VA: 0x24BA0C0
	private void set_UniqueId(int value) { }

	[CompilerGenerated]
	// RVA: 0x24BA0C8 Offset: 0x24B60C8 VA: 0x24BA0C8
	public int get_PopId() { }

	[CompilerGenerated]
	// RVA: 0x24BA0D0 Offset: 0x24B60D0 VA: 0x24BA0D0
	private void set_PopId(int value) { }

	[CompilerGenerated]
	// RVA: 0x24BA0D8 Offset: 0x24B60D8 VA: 0x24BA0D8
	public int get_Hp() { }

	[CompilerGenerated]
	// RVA: 0x24BA0E0 Offset: 0x24B60E0 VA: 0x24BA0E0
	private void set_Hp(int value) { }

	[CompilerGenerated]
	// RVA: 0x24BA0E8 Offset: 0x24B60E8 VA: 0x24BA0E8
	public int get_Spina() { }

	[CompilerGenerated]
	// RVA: 0x24BA0F0 Offset: 0x24B60F0 VA: 0x24BA0F0
	private void set_Spina(int value) { }

	[CompilerGenerated]
	// RVA: 0x24BA0F8 Offset: 0x24B60F8 VA: 0x24BA0F8
	public bool get_IsDead() { }

	[CompilerGenerated]
	// RVA: 0x24BA100 Offset: 0x24B6100 VA: 0x24BA100
	private void set_IsDead(bool value) { }

	// RVA: 0x24BA10C Offset: 0x24B610C VA: 0x24BA10C
	public void .ctor() { }

	// RVA: 0x24BA12C Offset: 0x24B612C VA: 0x24BA12C
	public void Initialize(int uniqueId, int hp) { }

	// RVA: 0x24BA144 Offset: 0x24B6144 VA: 0x24BA144
	public void Damaged(int damage, int spina, bool isSpecial) { }

	// RVA: 0x24BA18C Offset: 0x24B618C VA: 0x24BA18C
	public void ResetDamage() { }

	// RVA: 0x24BA218 Offset: 0x24B6218 VA: 0x24BA218
	public void UpdateHP(int hp) { }

	// RVA: 0x24BA234 Offset: 0x24B6234 VA: 0x24BA234
	public void UpdateSpina(int spina) { }

	// RVA: 0x24BA23C Offset: 0x24B623C VA: 0x24BA23C
	public void ExPop(int hp, int popId) { }
}
