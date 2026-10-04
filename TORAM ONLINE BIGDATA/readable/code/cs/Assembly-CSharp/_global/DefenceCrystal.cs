// Assembly: Assembly-CSharp.dll
// Namespace: 
public class DefenceCrystal : MonoBehaviour // TypeDefIndex: 3862
{
	// Fields
	private GameObject crystalObject; // 0x20
	private Animation crystalAnimation; // 0x28
	private Motion crystalMotion; // 0x30
	private int animationNo; // 0x38
	private TransformShake shake; // 0x40
	private float shakeTime; // 0x48
	private int hp; // 0x4C
	private readonly int hpMax; // 0x50
	private int id; // 0x54
	private bool isDamage; // 0x58
	private GameObject defenceBattlePanel; // 0x60
	private DefenceRoomData defenceRoomData; // 0x68
	private SystemTextManager systemTextManager; // 0x70
	private float height; // 0x78

	// Properties
	public int HP { get; }
	public int HPMAX { get; }
	public bool IsBreak { get; }

	// Methods

	// RVA: 0x23FDA28 Offset: 0x23F9A28 VA: 0x23FDA28
	public int get_HP() { }

	// RVA: 0x23FDA30 Offset: 0x23F9A30 VA: 0x23FDA30
	public int get_HPMAX() { }

	// RVA: 0x23FDA38 Offset: 0x23F9A38 VA: 0x23FDA38
	public bool get_IsBreak() { }

	// RVA: 0x23FDA48 Offset: 0x23F9A48 VA: 0x23FDA48
	private void Awake() { }

	// RVA: 0x23FDD34 Offset: 0x23F9D34 VA: 0x23FDD34
	private void Update() { }

	// RVA: 0x23FE174 Offset: 0x23FA174 VA: 0x23FE174
	public void Damage(int hp) { }

	// RVA: 0x23FDC44 Offset: 0x23F9C44 VA: 0x23FDC44
	public void InitStatus() { }

	// RVA: 0x23FE268 Offset: 0x23FA268 VA: 0x23FE268
	private void UIDisplay() { }

	// RVA: 0x23FE4C4 Offset: 0x23FA4C4 VA: 0x23FE4C4
	public void SetStatus(int hp, int id) { }

	// RVA: 0x23FE564 Offset: 0x23FA564 VA: 0x23FE564
	public void SetHeight(float height) { }

	// RVA: 0x23FDC54 Offset: 0x23F9C54 VA: 0x23FDC54
	private void Load() { }

	// RVA: 0x23FE654 Offset: 0x23FA654 VA: 0x23FE654
	private void SetModel(GameObject modelObject) { }

	// RVA: 0x23FDE20 Offset: 0x23F9E20 VA: 0x23FDE20
	private void UpdateAnimation() { }

	// RVA: 0x23FEE90 Offset: 0x23FAE90 VA: 0x23FEE90
	private void SetCrystalSurfaceColor(float r, float g, float b) { }

	// RVA: 0x23FED14 Offset: 0x23FAD14 VA: 0x23FED14
	private void SetCrystalInsideColor(float r, float g, float b) { }

	// RVA: 0x23FF00C Offset: 0x23FB00C VA: 0x23FF00C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x23FF01C Offset: 0x23FB01C VA: 0x23FF01C
	private void <Load>b__27_0(bool b, GameObject x) { }
}
