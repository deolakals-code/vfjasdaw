// Assembly: Assembly-CSharp.dll
// Namespace: 
public class DefenceSafeRoom : DefenceRoom // TypeDefIndex: 3881
{
	// Fields
	private GameObject crystalObj; // 0x38
	private DefenceCrystal crystal; // 0x40

	// Properties
	public int CrystalHP { get; }
	public int CrystalMaxHP { get; }
	public bool IsNoDamage { get; }
	public bool IsCrystalBreak { get; }

	// Methods

	// RVA: 0x2403B64 Offset: 0x23FFB64 VA: 0x2403B64
	public int get_CrystalHP() { }

	// RVA: 0x2403C0C Offset: 0x23FFC0C VA: 0x2403C0C
	public int get_CrystalMaxHP() { }

	// RVA: 0x2403AC8 Offset: 0x23FFAC8 VA: 0x2403AC8
	public bool get_IsNoDamage() { }

	// RVA: 0x2403A2C Offset: 0x23FFA2C VA: 0x2403A2C
	public bool get_IsCrystalBreak() { }

	// RVA: 0x240542C Offset: 0x240142C VA: 0x240542C
	private void Awake() { }

	// RVA: 0x24055FC Offset: 0x24015FC VA: 0x24055FC Slot: 4
	public override void SetInfo(int x, int y, byte gate, int roomId) { }

	// RVA: 0x2405658 Offset: 0x2401658 VA: 0x2405658 Slot: 5
	public override void Destroy() { }

	// RVA: 0x2405724 Offset: 0x2401724 VA: 0x2405724
	private void Update() { }

	// RVA: 0x2405728 Offset: 0x2401728 VA: 0x2405728
	public void Damage(int uniqueId, int hp) { }

	// RVA: 0x2405744 Offset: 0x2401744 VA: 0x2405744
	public void InitCrystalHp(int hp) { }

	// RVA: 0x2405760 Offset: 0x2401760 VA: 0x2405760
	public void .ctor() { }
}
