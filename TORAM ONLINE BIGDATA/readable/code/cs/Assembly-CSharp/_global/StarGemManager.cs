// Assembly: Assembly-CSharp.dll
// Namespace: 
public class StarGemManager // TypeDefIndex: 3784
{
	// Fields
	public const int STARJEM_MAX_COST = 10;
	private StarGemBag _bag; // 0x10
	private StarGemSkillManager _skill; // 0x18
	[CompilerGenerated]
	private bool <IsStarGemLock>k__BackingField; // 0x20

	// Properties
	public StarGemBag Bag { get; }
	public StarGemSkillManager Skill { get; }
	public bool IsActionLock { get; }
	public bool IsStarGemLock { get; set; }

	// Methods

	// RVA: 0x23E6378 Offset: 0x23E2378 VA: 0x23E6378
	public StarGemBag get_Bag() { }

	// RVA: 0x23E6380 Offset: 0x23E2380 VA: 0x23E6380
	public StarGemSkillManager get_Skill() { }

	// RVA: 0x23E6388 Offset: 0x23E2388 VA: 0x23E6388
	public bool get_IsActionLock() { }

	[CompilerGenerated]
	// RVA: 0x23E6418 Offset: 0x23E2418 VA: 0x23E6418
	public bool get_IsStarGemLock() { }

	[CompilerGenerated]
	// RVA: 0x23E6420 Offset: 0x23E2420 VA: 0x23E6420
	private void set_IsStarGemLock(bool value) { }

	// RVA: 0x23E642C Offset: 0x23E242C VA: 0x23E642C
	public void .ctor() { }

	// RVA: 0x23E6588 Offset: 0x23E2588 VA: 0x23E6588
	public void InitializeEquip(StarGemEquipData[] equips) { }

	// RVA: 0x23E687C Offset: 0x23E287C VA: 0x23E687C
	public void Equip(StarGemData[] gems, StarGemEquipData[] equips) { }

	// RVA: 0x23E6C40 Offset: 0x23E2C40 VA: 0x23E6C40
	public bool GetSendData(out Dictionary<byte, long> updateEquips, out int cost) { }

	// RVA: 0x23E6EF4 Offset: 0x23E2EF4 VA: 0x23E6EF4
	public void Reinforce(StarGemData deleteGem, StarGemData updateGem) { }

	// RVA: 0x23E7058 Offset: 0x23E3058 VA: 0x23E7058
	public void Evolution(StarGemData starGem) { }

	// RVA: 0x23E7294 Offset: 0x23E3294 VA: 0x23E7294
	public bool CheckStarGemLock() { }
}
