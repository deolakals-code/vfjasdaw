// Assembly: Assembly-CSharp.dll
// Namespace: 
public class EffectBreakPartsTap : MonoBehaviour // TypeDefIndex: 228
{
	// Fields
	private GameObject model; // 0x20
	private SkinBreakParts skinBreakParts; // 0x28
	private EnemyMobActionManagerBase mobActionManager; // 0x30
	private MobHyperModeManager hyperModeManager; // 0x38
	private IBossParts parts; // 0x40
	private IPlayerControl playerControl; // 0x48
	private int breakPartsId; // 0x50
	private float waitPartsTime; // 0x54
	private BoxCollider tapCollider; // 0x58
	private int motionId; // 0x60
	private AnimationBase animationSimple; // 0x68
	private bool breakedCheck; // 0x70
	private UILabel breakPartsTimer; // 0x78
	private SkinnedMeshRenderer skinnedMeshRenderer; // 0x80
	private float fadeOutTimer; // 0x88
	private Vector3 lastPosition; // 0x8C
	private bool initFlag; // 0x98

	// Properties
	protected virtual int playMotion { get; }

	// Methods

	// RVA: 0x21C8FDC Offset: 0x21C4FDC VA: 0x21C8FDC Slot: 4
	protected virtual int get_playMotion() { }

	// RVA: 0x21C8FE4 Offset: 0x21C4FE4 VA: 0x21C8FE4 Slot: 5
	public virtual void Initialize(GameObject enemy) { }

	// RVA: 0x21C9B60 Offset: 0x21C5B60 VA: 0x21C9B60
	private void Start() { }

	// RVA: 0x21C9BC8 Offset: 0x21C5BC8 VA: 0x21C9BC8 Slot: 6
	public virtual void Update() { }

	// RVA: 0x21CA458 Offset: 0x21C6458 VA: 0x21CA458 Slot: 7
	protected virtual void OnClick() { }

	// RVA: 0x21CA604 Offset: 0x21C6604 VA: 0x21CA604
	public void UpdateParts(MobStatusMaster status) { }

	// RVA: 0x21CA744 Offset: 0x21C6744 VA: 0x21CA744
	public void .ctor() { }
}
