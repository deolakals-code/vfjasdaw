// Assembly: Assembly-CSharp.dll
// Namespace: 
[Serializable]
private class BlackKnightMobObjectManager.EnemyData // TypeDefIndex: 4203
{
	// Fields
	[CompilerGenerated]
	private int <LocalId>k__BackingField; // 0x10
	[CompilerGenerated]
	private GameObject <Enemy>k__BackingField; // 0x18
	[CompilerGenerated]
	private BlackKnightMobManagerBase <Manager>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <IsFade>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <IsBoss>k__BackingField; // 0x29
	[CompilerGenerated]
	private bool <IsValid>k__BackingField; // 0x2A
	[CompilerGenerated]
	private bool <Destroyed>k__BackingField; // 0x2B

	// Properties
	public int LocalId { get; set; }
	public GameObject Enemy { get; set; }
	public BlackKnightMobManagerBase Manager { get; set; }
	public bool IsFade { get; set; }
	public bool IsBoss { get; set; }
	public bool IsValid { get; set; }
	public bool Destroyed { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x24AB2A0 Offset: 0x24A72A0 VA: 0x24AB2A0
	public int get_LocalId() { }

	[CompilerGenerated]
	// RVA: 0x24AB2A8 Offset: 0x24A72A8 VA: 0x24AB2A8
	private void set_LocalId(int value) { }

	[CompilerGenerated]
	// RVA: 0x24AB2B0 Offset: 0x24A72B0 VA: 0x24AB2B0
	public GameObject get_Enemy() { }

	[CompilerGenerated]
	// RVA: 0x24AB2B8 Offset: 0x24A72B8 VA: 0x24AB2B8
	private void set_Enemy(GameObject value) { }

	[CompilerGenerated]
	// RVA: 0x24AB2C0 Offset: 0x24A72C0 VA: 0x24AB2C0
	public BlackKnightMobManagerBase get_Manager() { }

	[CompilerGenerated]
	// RVA: 0x24AB2C8 Offset: 0x24A72C8 VA: 0x24AB2C8
	private void set_Manager(BlackKnightMobManagerBase value) { }

	[CompilerGenerated]
	// RVA: 0x24AB2D0 Offset: 0x24A72D0 VA: 0x24AB2D0
	public bool get_IsFade() { }

	[CompilerGenerated]
	// RVA: 0x24AB2D8 Offset: 0x24A72D8 VA: 0x24AB2D8
	private void set_IsFade(bool value) { }

	[CompilerGenerated]
	// RVA: 0x24AB2E4 Offset: 0x24A72E4 VA: 0x24AB2E4
	public bool get_IsBoss() { }

	[CompilerGenerated]
	// RVA: 0x24AB2EC Offset: 0x24A72EC VA: 0x24AB2EC
	private void set_IsBoss(bool value) { }

	[CompilerGenerated]
	// RVA: 0x24AB2F8 Offset: 0x24A72F8 VA: 0x24AB2F8
	public bool get_IsValid() { }

	[CompilerGenerated]
	// RVA: 0x24AB300 Offset: 0x24A7300 VA: 0x24AB300
	private void set_IsValid(bool value) { }

	[CompilerGenerated]
	// RVA: 0x24AB30C Offset: 0x24A730C VA: 0x24AB30C
	public bool get_Destroyed() { }

	[CompilerGenerated]
	// RVA: 0x24AB314 Offset: 0x24A7314 VA: 0x24AB314
	private void set_Destroyed(bool value) { }

	// RVA: 0x24AB320 Offset: 0x24A7320 VA: 0x24AB320
	public void .ctor(int localId, GameObject enemy, BlackKnightMobManagerBase mobActManager, bool fade) { }

	// RVA: 0x24AACFC Offset: 0x24A6CFC VA: 0x24AACFC
	public void .ctor(int localId, GameObject enemy, BlackKnightMobManagerBase mobActManager, bool fade, bool boss, bool roomMob) { }

	[IteratorStateMachine(typeof(BlackKnightMobObjectManager.EnemyData.<LoadEffectModel>d__30))]
	// RVA: 0x24AB330 Offset: 0x24A7330 VA: 0x24AB330
	public IEnumerator LoadEffectModel() { }

	// RVA: 0x24AB3C4 Offset: 0x24A73C4 VA: 0x24AB3C4
	public void Invalidation() { }

	// RVA: 0x24AA724 Offset: 0x24A6724 VA: 0x24AA724
	public void Destroy(bool immediately) { }

	// RVA: 0x24AB3CC Offset: 0x24A73CC VA: 0x24AB3CC
	private void innerDestroy() { }

	[CompilerGenerated]
	// RVA: 0x24AB470 Offset: 0x24A7470 VA: 0x24AB470
	private void <Destroy>b__32_0() { }
}
