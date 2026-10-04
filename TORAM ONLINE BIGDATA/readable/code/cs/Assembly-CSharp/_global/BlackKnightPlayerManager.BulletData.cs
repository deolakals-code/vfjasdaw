// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BlackKnightPlayerManager.BulletData // TypeDefIndex: 4159
{
	// Fields
	private BlackKnightPlayerSkillBase skill; // 0x10
	private GameObject bullet; // 0x18
	private int takeUid; // 0x20
	private int shotTakeUid; // 0x24
	private int localId; // 0x28

	// Properties
	public BlackKnightPlayerSkillBase Skill { get; }
	public GameObject Bullet { get; }
	public int TakeUid { get; }
	public int ShotTakeUid { get; }
	public int LocalId { get; }
	public bool IsCreatedEffect { get; }

	// Methods

	// RVA: 0x249ED20 Offset: 0x249AD20 VA: 0x249ED20
	public BlackKnightPlayerSkillBase get_Skill() { }

	// RVA: 0x249ED28 Offset: 0x249AD28 VA: 0x249ED28
	public GameObject get_Bullet() { }

	// RVA: 0x249ED30 Offset: 0x249AD30 VA: 0x249ED30
	public int get_TakeUid() { }

	// RVA: 0x249ED38 Offset: 0x249AD38 VA: 0x249ED38
	public int get_ShotTakeUid() { }

	// RVA: 0x249ED40 Offset: 0x249AD40 VA: 0x249ED40
	public int get_LocalId() { }

	// RVA: 0x249B22C Offset: 0x249722C VA: 0x249B22C
	public bool get_IsCreatedEffect() { }

	// RVA: 0x249E0DC Offset: 0x249A0DC VA: 0x249E0DC
	public void .ctor(BlackKnightPlayerSkillBase skill, int id, int uid, int shotId) { }

	// RVA: 0x249ED48 Offset: 0x249AD48 VA: 0x249ED48
	public void SetEffect(GameObject obj) { }
}
