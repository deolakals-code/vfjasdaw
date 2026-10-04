// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ExSkillSummonDemonic : ExSkillDataBase // TypeDefIndex: 1826
{
	// Fields
	[CompilerGenerated]
	private int <TotalPoint>k__BackingField; // 0x10
	private static Dictionary<int, byte> abilityPoint; // 0x0
	private Dictionary<int, bool> abilityList; // 0x18
	private PlayerDataManager playerDataManager; // 0x20

	// Properties
	public override SkillId SkillId { get; }
	public int TotalPoint { get; set; }
	public Dictionary<int, bool> AbilityList { get; }
	private int MaxPoint { get; }

	// Methods

	// RVA: 0x20E7B58 Offset: 0x20E3B58 VA: 0x20E7B58 Slot: 4
	public override SkillId get_SkillId() { }

	[CompilerGenerated]
	// RVA: 0x20E7B60 Offset: 0x20E3B60 VA: 0x20E7B60
	public int get_TotalPoint() { }

	[CompilerGenerated]
	// RVA: 0x20E7B68 Offset: 0x20E3B68 VA: 0x20E7B68
	private void set_TotalPoint(int value) { }

	// RVA: 0x20E7B70 Offset: 0x20E3B70 VA: 0x20E7B70
	public Dictionary<int, bool> get_AbilityList() { }

	// RVA: 0x20E7B78 Offset: 0x20E3B78 VA: 0x20E7B78
	private int get_MaxPoint() { }

	// RVA: 0x20E7C64 Offset: 0x20E3C64 VA: 0x20E7C64
	public void .ctor() { }

	// RVA: 0x20E5454 Offset: 0x20E1454 VA: 0x20E5454
	public void .ctor(byte[] binary) { }

	// RVA: 0x20E7DE0 Offset: 0x20E3DE0 VA: 0x20E7DE0 Slot: 6
	public override void SetValue(byte[] binary) { }

	// RVA: 0x20E8054 Offset: 0x20E4054 VA: 0x20E8054 Slot: 5
	public override byte[] ToBinary() { }

	// RVA: 0x20E8410 Offset: 0x20E4410 VA: 0x20E8410
	public int CalcAllPoint() { }

	// RVA: 0x20E85A4 Offset: 0x20E45A4 VA: 0x20E85A4
	public bool CheckAbility(ExSkillSummonDemonic.DemonicAbility ability) { }

	// RVA: 0x20E8604 Offset: 0x20E4604 VA: 0x20E8604
	public void SetAbility(int ability, bool flag) { }

	// RVA: 0x20E86A8 Offset: 0x20E46A8 VA: 0x20E86A8
	public int GetAbilityPoint(int ability) { }

	// RVA: 0x20E7C80 Offset: 0x20E3C80 VA: 0x20E7C80
	private void InitAbilityList() { }

	// RVA: 0x20E877C Offset: 0x20E477C VA: 0x20E877C
	private static void .cctor() { }
}
