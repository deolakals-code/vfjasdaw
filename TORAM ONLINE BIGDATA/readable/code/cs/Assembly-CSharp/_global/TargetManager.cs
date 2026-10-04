// Assembly: Assembly-CSharp.dll
// Namespace: 
public class TargetManager : Singleton<TargetManager>, ISceneChangeManager // TypeDefIndex: 4654
{
	// Fields
	private TargetSymbol targetSymbol; // 0x20
	private GameObject targetObject; // 0x28
	private MobManager mobManager; // 0x30
	private EventAreaManager eventAreaManager; // 0x38
	private CameraManager cameraManager; // 0x40
	private CharacterActionManagerBase actionManager; // 0x48
	[CompilerGenerated]
	private TargetManager.TargetType <TargetObjectType>k__BackingField; // 0x50
	[CompilerGenerated]
	private bool <HasLeftMob>k__BackingField; // 0x54
	[CompilerGenerated]
	private bool <HasRightMob>k__BackingField; // 0x55

	// Properties
	public TargetManager.TargetType TargetObjectType { get; set; }
	public GameObject TargetObject { get; }
	public EventAreaManager EventAreaManager { get; }
	public bool HasLeftMob { get; set; }
	public bool HasRightMob { get; set; }
	public CharacterActionManagerBase ActionManager { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2585630 Offset: 0x2581630 VA: 0x2585630
	public TargetManager.TargetType get_TargetObjectType() { }

	[CompilerGenerated]
	// RVA: 0x2585638 Offset: 0x2581638 VA: 0x2585638
	private void set_TargetObjectType(TargetManager.TargetType value) { }

	// RVA: 0x2585640 Offset: 0x2581640 VA: 0x2585640
	public GameObject get_TargetObject() { }

	// RVA: 0x2585648 Offset: 0x2581648 VA: 0x2585648
	public EventAreaManager get_EventAreaManager() { }

	[CompilerGenerated]
	// RVA: 0x2585650 Offset: 0x2581650 VA: 0x2585650
	public bool get_HasLeftMob() { }

	[CompilerGenerated]
	// RVA: 0x2585658 Offset: 0x2581658 VA: 0x2585658
	private void set_HasLeftMob(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2585664 Offset: 0x2581664 VA: 0x2585664
	public bool get_HasRightMob() { }

	[CompilerGenerated]
	// RVA: 0x258566C Offset: 0x258166C VA: 0x258566C
	private void set_HasRightMob(bool value) { }

	// RVA: 0x2585678 Offset: 0x2581678 VA: 0x2585678
	public CharacterActionManagerBase get_ActionManager() { }

	// RVA: 0x2585680 Offset: 0x2581680 VA: 0x2585680
	private void Awake() { }

	// RVA: 0x2585768 Offset: 0x2581768 VA: 0x2585768 Slot: 4
	public void OnEnter() { }

	// RVA: 0x2585998 Offset: 0x2581998 VA: 0x2585998 Slot: 5
	public void OnLeave() { }

	// RVA: 0x2585A98 Offset: 0x2581A98 VA: 0x2585A98
	public void Clear() { }

	// RVA: 0x2585880 Offset: 0x2581880 VA: 0x2585880
	public void ClearTarget() { }

	// RVA: 0x2585A9C Offset: 0x2581A9C VA: 0x2585A9C
	public bool SearchNearCharacterTarget(Vector3 pos, float rad, float height, GameObject exclusions) { }

	// RVA: 0x25861E8 Offset: 0x25821E8 VA: 0x25861E8
	public bool SearchNearEventTarget(Vector3 pos, float rad, float height) { }

	// RVA: 0x25862CC Offset: 0x25822CC VA: 0x25862CC
	public void SearchInsideEventArea() { }

	// RVA: 0x25863A0 Offset: 0x25823A0 VA: 0x25863A0
	public bool SearchNearMobTarget(Vector3 pos, float rad, float height) { }

	// RVA: 0x2586484 Offset: 0x2582484 VA: 0x2586484
	public bool SearchNearHateMobTarget(Vector3 pos, float rad, float height) { }

	// RVA: 0x2586560 Offset: 0x2582560 VA: 0x2586560
	public bool SearchFarCharacterTarget(Vector3 pos, float rad, float height, GameObject exclusions) { }

	// RVA: 0x2586820 Offset: 0x2582820 VA: 0x2586820
	public bool SearchFarMobTarget(Vector3 pos, float rad, float height) { }

	// RVA: 0x2586904 Offset: 0x2582904 VA: 0x2586904
	public bool SearchFarHateMobTarget(Vector3 pos, float rad, float height) { }

	// RVA: 0x25869E0 Offset: 0x25829E0 VA: 0x25869E0
	public void CheckSideMobTarget(GameObject baseMob, Vector3 pos, float rad, float height) { }

	// RVA: 0x2586CAC Offset: 0x2582CAC VA: 0x2586CAC
	public bool SearchSideMobTarget(GameObject baseMob, bool right, Vector3 pos, float rad, float height) { }

	// RVA: 0x258717C Offset: 0x258317C VA: 0x258717C
	public bool TargetCheck(GameObject target) { }

	// RVA: 0x2585D78 Offset: 0x2581D78 VA: 0x2585D78
	public void SelectTarget(GameObject target, TargetManager.TargetType type, bool lookTarget) { }

	// RVA: 0x2587398 Offset: 0x2583398 VA: 0x2587398
	public void TargetLookCamera(Transform transform, float second) { }

	// RVA: 0x25873B4 Offset: 0x25833B4 VA: 0x25873B4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x25873FC Offset: 0x25833FC VA: 0x25873FC
	private void <OnEnter>b__26_0(bool s, GameObject symbol) { }
}
