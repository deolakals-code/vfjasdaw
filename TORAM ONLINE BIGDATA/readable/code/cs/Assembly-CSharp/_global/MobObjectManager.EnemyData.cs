// Assembly: Assembly-CSharp.dll
// Namespace: 
[Serializable]
public class MobObjectManager.EnemyData // TypeDefIndex: 968
{
	// Fields
	private MobObjectManager.IListener Listener; // 0x10
	[CompilerGenerated]
	private GameObject <Enemy>k__BackingField; // 0x18
	[CompilerGenerated]
	private Transform <Transform>k__BackingField; // 0x20
	[CompilerGenerated]
	private EnemyMobActionManagerBase <ActionManager>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <IsScriptPop>k__BackingField; // 0x30
	[CompilerGenerated]
	private bool <IsFade>k__BackingField; // 0x31
	[CompilerGenerated]
	private bool <IsBoss>k__BackingField; // 0x32
	[CompilerGenerated]
	private bool <IsRoomMob>k__BackingField; // 0x33
	[CompilerGenerated]
	private bool <IsValid>k__BackingField; // 0x34
	[CompilerGenerated]
	private bool <Destroyed>k__BackingField; // 0x35
	private float deadTime; // 0x38

	// Properties
	public GameObject Enemy { get; set; }
	public Transform Transform { get; set; }
	public EnemyMobActionManagerBase ActionManager { get; set; }
	public bool IsScriptPop { get; set; }
	public bool IsFade { get; set; }
	public bool IsBoss { get; set; }
	public bool IsRoomMob { get; set; }
	public bool IsValid { get; set; }
	public bool Destroyed { get; set; }
	public IMobIdData MobIdData { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1F30794 Offset: 0x1F2C794 VA: 0x1F30794
	public GameObject get_Enemy() { }

	[CompilerGenerated]
	// RVA: 0x1F3079C Offset: 0x1F2C79C VA: 0x1F3079C
	private void set_Enemy(GameObject value) { }

	[CompilerGenerated]
	// RVA: 0x1F307A4 Offset: 0x1F2C7A4 VA: 0x1F307A4
	public Transform get_Transform() { }

	[CompilerGenerated]
	// RVA: 0x1F307AC Offset: 0x1F2C7AC VA: 0x1F307AC
	private void set_Transform(Transform value) { }

	[CompilerGenerated]
	// RVA: 0x1F307B4 Offset: 0x1F2C7B4 VA: 0x1F307B4
	public EnemyMobActionManagerBase get_ActionManager() { }

	[CompilerGenerated]
	// RVA: 0x1F307BC Offset: 0x1F2C7BC VA: 0x1F307BC
	private void set_ActionManager(EnemyMobActionManagerBase value) { }

	[CompilerGenerated]
	// RVA: 0x1F307C4 Offset: 0x1F2C7C4 VA: 0x1F307C4
	public bool get_IsScriptPop() { }

	[CompilerGenerated]
	// RVA: 0x1F307CC Offset: 0x1F2C7CC VA: 0x1F307CC
	private void set_IsScriptPop(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1F307D8 Offset: 0x1F2C7D8 VA: 0x1F307D8
	public bool get_IsFade() { }

	[CompilerGenerated]
	// RVA: 0x1F307E0 Offset: 0x1F2C7E0 VA: 0x1F307E0
	private void set_IsFade(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1F307EC Offset: 0x1F2C7EC VA: 0x1F307EC
	public bool get_IsBoss() { }

	[CompilerGenerated]
	// RVA: 0x1F307F4 Offset: 0x1F2C7F4 VA: 0x1F307F4
	private void set_IsBoss(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1F30800 Offset: 0x1F2C800 VA: 0x1F30800
	public bool get_IsRoomMob() { }

	[CompilerGenerated]
	// RVA: 0x1F30808 Offset: 0x1F2C808 VA: 0x1F30808
	private void set_IsRoomMob(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1F30814 Offset: 0x1F2C814 VA: 0x1F30814
	public bool get_IsValid() { }

	[CompilerGenerated]
	// RVA: 0x1F3081C Offset: 0x1F2C81C VA: 0x1F3081C
	private void set_IsValid(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1F30828 Offset: 0x1F2C828 VA: 0x1F30828
	public bool get_Destroyed() { }

	[CompilerGenerated]
	// RVA: 0x1F30830 Offset: 0x1F2C830 VA: 0x1F30830
	private void set_Destroyed(bool value) { }

	// RVA: 0x1F3083C Offset: 0x1F2C83C VA: 0x1F3083C
	public void .ctor(GameObject enemy, EnemyMobActionManagerBase mobActManager, bool scriptPop, bool fade, MobObjectManager.IListener Listener) { }

	// RVA: 0x1F30868 Offset: 0x1F2C868 VA: 0x1F30868
	public void .ctor(GameObject enemy, EnemyMobActionManagerBase mobActManager, bool scriptPop, bool fade, bool boss, bool roomMob, MobObjectManager.IListener Listener) { }

	// RVA: 0x1F30934 Offset: 0x1F2C934 VA: 0x1F30934
	public bool IsValidMatch(IMobIdData mobId) { }

	// RVA: 0x1F309E0 Offset: 0x1F2C9E0 VA: 0x1F309E0
	public bool IsValidFuzzyMatch(IMobIdData mobId) { }

	// RVA: 0x1F30B48 Offset: 0x1F2CB48 VA: 0x1F30B48
	public bool DeadCheck() { }

	// RVA: 0x1F30C60 Offset: 0x1F2CC60 VA: 0x1F30C60
	public void Invalidation() { }

	// RVA: 0x1F30C68 Offset: 0x1F2CC68 VA: 0x1F30C68
	public void Destroy(bool immediately) { }

	// RVA: 0x1F30DA0 Offset: 0x1F2CDA0 VA: 0x1F30DA0
	private void innerDestroy() { }

	// RVA: 0x1F30ED4 Offset: 0x1F2CED4 VA: 0x1F30ED4
	public IMobIdData get_MobIdData() { }

	[CompilerGenerated]
	// RVA: 0x1F30EF0 Offset: 0x1F2CEF0 VA: 0x1F30EF0
	private void <Destroy>b__44_0() { }
}
