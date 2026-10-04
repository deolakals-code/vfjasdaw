// Assembly: Assembly-CSharp.dll
// Namespace: 
private class CrazyDaggerBuf.EffectManager.EffectData // TypeDefIndex: 3110
{
	// Fields
	[CompilerGenerated]
	private readonly int <Uid>k__BackingField; // 0x10
	[CompilerGenerated]
	private GameObject <Obj>k__BackingField; // 0x18
	[CompilerGenerated]
	private bool <IsUpdatePosition>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <IsHit>k__BackingField; // 0x21
	[CompilerGenerated]
	private CrazyDaggerBuf.EffectManager.KnifeDataMode <Mode>k__BackingField; // 0x24
	[CompilerGenerated]
	private GameObject <SkillTarget>k__BackingField; // 0x28
	private readonly List<Vector3> activeFollowPosList; // 0x30
	private readonly List<Vector3> inactiveFollowPosList; // 0x38
	private readonly float followSpeed; // 0x40
	private CrazyDaggerBuf.EffectManager manager; // 0x48
	private CrazyDaggerBuf.EffectManager.KnifeMove knifeMove; // 0x50
	private GameObject playerObj; // 0x58
	private PlayerActionManagerBase playerAction; // 0x60
	private Dictionary<TakeParameterType, int> takeAppendParam; // 0x68
	private bool isBattle; // 0x70

	// Properties
	public int Uid { get; }
	public GameObject Obj { get; set; }
	public bool IsUpdatePosition { get; set; }
	public bool IsHit { get; set; }
	public CrazyDaggerBuf.EffectManager.KnifeDataMode Mode { get; set; }
	public GameObject SkillTarget { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2327BD4 Offset: 0x2323BD4 VA: 0x2327BD4
	public int get_Uid() { }

	[CompilerGenerated]
	// RVA: 0x2327BDC Offset: 0x2323BDC VA: 0x2327BDC
	public GameObject get_Obj() { }

	[CompilerGenerated]
	// RVA: 0x2327BE4 Offset: 0x2323BE4 VA: 0x2327BE4
	private void set_Obj(GameObject value) { }

	[CompilerGenerated]
	// RVA: 0x2327BEC Offset: 0x2323BEC VA: 0x2327BEC
	public bool get_IsUpdatePosition() { }

	[CompilerGenerated]
	// RVA: 0x2327BF4 Offset: 0x2323BF4 VA: 0x2327BF4
	public void set_IsUpdatePosition(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2327C00 Offset: 0x2323C00 VA: 0x2327C00
	public bool get_IsHit() { }

	[CompilerGenerated]
	// RVA: 0x2327C08 Offset: 0x2323C08 VA: 0x2327C08
	private void set_IsHit(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2327C14 Offset: 0x2323C14 VA: 0x2327C14
	public CrazyDaggerBuf.EffectManager.KnifeDataMode get_Mode() { }

	[CompilerGenerated]
	// RVA: 0x2327C1C Offset: 0x2323C1C VA: 0x2327C1C
	private void set_Mode(CrazyDaggerBuf.EffectManager.KnifeDataMode value) { }

	[CompilerGenerated]
	// RVA: 0x2327C24 Offset: 0x2323C24 VA: 0x2327C24
	public GameObject get_SkillTarget() { }

	[CompilerGenerated]
	// RVA: 0x2327C2C Offset: 0x2323C2C VA: 0x2327C2C
	private void set_SkillTarget(GameObject value) { }

	// RVA: 0x2325EEC Offset: 0x2321EEC VA: 0x2325EEC
	public void .ctor(int uid, CrazyDaggerBuf.EffectManager manager, PlayerActionManagerBase playerAction) { }

	// RVA: 0x2327460 Offset: 0x2323460 VA: 0x2327460
	public void SetEffectObj(GameObject obj, bool hit) { }

	// RVA: 0x2326E3C Offset: 0x2322E3C VA: 0x2326E3C
	public void ResetAttackData() { }

	// RVA: 0x23257DC Offset: 0x23217DC VA: 0x23257DC
	public void SkillStartEvent(int index, int maxIndex, int motionSpeed) { }

	// RVA: 0x23258F4 Offset: 0x23218F4 VA: 0x23258F4
	public void SkillAttackEvent(MobActionManagerBase mobAction) { }

	// RVA: 0x2325EB4 Offset: 0x2321EB4 VA: 0x2325EB4
	public void SkillEndEvent() { }

	// RVA: 0x2326AD8 Offset: 0x2322AD8 VA: 0x2326AD8
	public void ChangeMode(CrazyDaggerBuf.EffectManager.KnifeDataMode start) { }

	// RVA: 0x2326A0C Offset: 0x2322A0C VA: 0x2326A0C
	public bool IsReturnFollowPos(int index, int maxIndex) { }

	// RVA: 0x2326E44 Offset: 0x2322E44 VA: 0x2326E44
	public void MoveUpdate(int index, int maxIndex) { }

	// RVA: 0x2327E64 Offset: 0x2323E64 VA: 0x2327E64
	private void UpdateFollow(int index, int maxIndex) { }

	// RVA: 0x2328034 Offset: 0x2324034 VA: 0x2328034
	private void UpdateAttackStart() { }

	// RVA: 0x23284F4 Offset: 0x23244F4 VA: 0x23284F4
	private void UpdateAttack() { }

	// RVA: 0x23287D4 Offset: 0x23247D4 VA: 0x23287D4
	private void UpdateSkillStart() { }

	// RVA: 0x2327C34 Offset: 0x2323C34 VA: 0x2327C34
	private Vector3 GetFollowPos(int index, int maxIndex) { }
}
