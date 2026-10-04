// Assembly: Assembly-CSharp.dll
// Namespace: 
[Serializable]
private class MobObjectManager.SymbolData : IComparable<MobObjectManager.SymbolData> // TypeDefIndex: 967
{
	// Fields
	[CompilerGenerated]
	private MobPopPoint <PopData>k__BackingField; // 0x10
	[CompilerGenerated]
	private GameObject <Symbol>k__BackingField; // 0x18
	[CompilerGenerated]
	private EnemyMobActionManagerBase <ActionManager>k__BackingField; // 0x20
	[CompilerGenerated]
	private Transform <Transform>k__BackingField; // 0x28
	[CompilerGenerated]
	private float <DistHeight>k__BackingField; // 0x30
	[CompilerGenerated]
	private bool <IsActive>k__BackingField; // 0x34
	[CompilerGenerated]
	private bool <IsScriptPop>k__BackingField; // 0x35
	[CompilerGenerated]
	private bool <IsFade>k__BackingField; // 0x36
	[CompilerGenerated]
	private bool <Disposed>k__BackingField; // 0x37

	// Properties
	public MobPopPoint PopData { get; set; }
	public GameObject Symbol { get; set; }
	public EnemyMobActionManagerBase ActionManager { get; set; }
	public Transform Transform { get; set; }
	public float Dist { get; }
	public float DistHeight { get; set; }
	public bool IsActive { get; set; }
	public bool IsScriptPop { get; set; }
	public bool IsFade { get; set; }
	public bool Disposed { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1F30304 Offset: 0x1F2C304 VA: 0x1F30304
	public MobPopPoint get_PopData() { }

	[CompilerGenerated]
	// RVA: 0x1F3030C Offset: 0x1F2C30C VA: 0x1F3030C
	private void set_PopData(MobPopPoint value) { }

	[CompilerGenerated]
	// RVA: 0x1F30314 Offset: 0x1F2C314 VA: 0x1F30314
	public GameObject get_Symbol() { }

	[CompilerGenerated]
	// RVA: 0x1F3031C Offset: 0x1F2C31C VA: 0x1F3031C
	private void set_Symbol(GameObject value) { }

	[CompilerGenerated]
	// RVA: 0x1F30324 Offset: 0x1F2C324 VA: 0x1F30324
	public EnemyMobActionManagerBase get_ActionManager() { }

	[CompilerGenerated]
	// RVA: 0x1F3032C Offset: 0x1F2C32C VA: 0x1F3032C
	private void set_ActionManager(EnemyMobActionManagerBase value) { }

	[CompilerGenerated]
	// RVA: 0x1F30334 Offset: 0x1F2C334 VA: 0x1F30334
	public Transform get_Transform() { }

	[CompilerGenerated]
	// RVA: 0x1F3033C Offset: 0x1F2C33C VA: 0x1F3033C
	private void set_Transform(Transform value) { }

	// RVA: 0x1F30344 Offset: 0x1F2C344 VA: 0x1F30344
	public float get_Dist() { }

	[CompilerGenerated]
	// RVA: 0x1F30360 Offset: 0x1F2C360 VA: 0x1F30360
	public float get_DistHeight() { }

	[CompilerGenerated]
	// RVA: 0x1F30368 Offset: 0x1F2C368 VA: 0x1F30368
	public void set_DistHeight(float value) { }

	[CompilerGenerated]
	// RVA: 0x1F30370 Offset: 0x1F2C370 VA: 0x1F30370
	public bool get_IsActive() { }

	[CompilerGenerated]
	// RVA: 0x1F30378 Offset: 0x1F2C378 VA: 0x1F30378
	private void set_IsActive(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1F30384 Offset: 0x1F2C384 VA: 0x1F30384
	public bool get_IsScriptPop() { }

	[CompilerGenerated]
	// RVA: 0x1F3038C Offset: 0x1F2C38C VA: 0x1F3038C
	private void set_IsScriptPop(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1F30398 Offset: 0x1F2C398 VA: 0x1F30398
	public bool get_IsFade() { }

	[CompilerGenerated]
	// RVA: 0x1F303A0 Offset: 0x1F2C3A0 VA: 0x1F303A0
	private void set_IsFade(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1F303AC Offset: 0x1F2C3AC VA: 0x1F303AC
	public bool get_Disposed() { }

	[CompilerGenerated]
	// RVA: 0x1F303B4 Offset: 0x1F2C3B4 VA: 0x1F303B4
	private void set_Disposed(bool value) { }

	// RVA: 0x1F303C0 Offset: 0x1F2C3C0 VA: 0x1F303C0
	public void .ctor(MobPopPoint popData, GameObject symbol, EnemyMobActionManagerBase action, bool fade, bool script, bool active) { }

	// RVA: 0x1F30478 Offset: 0x1F2C478 VA: 0x1F30478
	public void UpdateDist(Vector3 pos) { }

	// RVA: 0x1F30534 Offset: 0x1F2C534 VA: 0x1F30534
	public void Dispose() { }

	// RVA: 0x1F30584 Offset: 0x1F2C584 VA: 0x1F30584
	public int Compare(MobObjectManager.SymbolData x, MobObjectManager.SymbolData y) { }

	// RVA: 0x1F305F4 Offset: 0x1F2C5F4 VA: 0x1F305F4
	public int Compare(object x, object y) { }

	// RVA: 0x1F3073C Offset: 0x1F2C73C VA: 0x1F3073C Slot: 4
	public int CompareTo(MobObjectManager.SymbolData other) { }

	// RVA: 0x1F30780 Offset: 0x1F2C780 VA: 0x1F30780
	public void Activating() { }

	// RVA: 0x1F3078C Offset: 0x1F2C78C VA: 0x1F3078C
	public void UnActivating() { }
}
