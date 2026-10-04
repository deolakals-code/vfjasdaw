// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BlackKnightManager : MonoBehaviour // TypeDefIndex: 4154
{
	// Fields
	private BlackKnightPlayerManager playerManager; // 0x20
	private BlackKnightMobObjectManager mobObjectManager; // 0x28
	private BlackKnightHitCheckManager hitCheckManager; // 0x30
	[CompilerGenerated]
	private bool <IsInit>k__BackingField; // 0x38
	private GuideRail guideRail; // 0x40
	private GameObject playerDataManagerObject; // 0x48
	private GameObject effectAnchor; // 0x50
	private MotionAnimation effectMotion; // 0x58
	private Material fadeEffectMaterial; // 0x60
	private float damageEffect; // 0x68
	private float currentDamageEffect; // 0x6C
	private float damageEffetTimer; // 0x70
	private BlackKnightAvatarType avatarType; // 0x74
	private int playerHp; // 0x78

	// Properties
	public bool IsInit { get; set; }
	public BlackKnightPlayerManager PlayerManager { get; }
	public GuideRail GuideRail { get; }
	public BlackKnightMobObjectManager MobObjectManager { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x24950F8 Offset: 0x24910F8 VA: 0x24950F8
	public bool get_IsInit() { }

	[CompilerGenerated]
	// RVA: 0x2495100 Offset: 0x2491100 VA: 0x2495100
	private void set_IsInit(bool value) { }

	// RVA: 0x249510C Offset: 0x249110C VA: 0x249510C
	public BlackKnightPlayerManager get_PlayerManager() { }

	// RVA: 0x2495114 Offset: 0x2491114 VA: 0x2495114
	public GuideRail get_GuideRail() { }

	// RVA: 0x249511C Offset: 0x249111C VA: 0x249511C
	public BlackKnightMobObjectManager get_MobObjectManager() { }

	// RVA: 0x2495124 Offset: 0x2491124 VA: 0x2495124
	public void Awake() { }

	[IteratorStateMachine(typeof(BlackKnightManager.<Start>d__24))]
	// RVA: 0x2495198 Offset: 0x2491198 VA: 0x2495198
	private IEnumerator Start() { }

	// RVA: 0x249522C Offset: 0x249122C VA: 0x249522C
	public void Initialize() { }

	// RVA: 0x24953C4 Offset: 0x24913C4 VA: 0x24953C4
	public void Update() { }

	// RVA: 0x24957A4 Offset: 0x24917A4 VA: 0x24957A4
	public void LateUpdate() { }

	// RVA: 0x2495B40 Offset: 0x2491B40 VA: 0x2495B40
	public void SetPlayerStartHp(int hp) { }

	// RVA: 0x2495B48 Offset: 0x2491B48 VA: 0x2495B48
	public void Dispose() { }

	// RVA: 0x2495458 Offset: 0x2491458 VA: 0x2495458
	private void UpdateHitCheck() { }

	// RVA: 0x2495AC0 Offset: 0x2491AC0 VA: 0x2495AC0
	public void CheckContactCharaToChara() { }

	// RVA: 0x24962A8 Offset: 0x24922A8 VA: 0x24962A8
	public void EnterBossRoom() { }

	[IteratorStateMachine(typeof(BlackKnightManager.<EnterBossRoomCoroutine>d__33))]
	// RVA: 0x24962C8 Offset: 0x24922C8 VA: 0x24962C8
	public IEnumerator EnterBossRoomCoroutine() { }

	// RVA: 0x249635C Offset: 0x249235C VA: 0x249635C
	public void ReinforcePlayerAtk() { }

	// RVA: 0x2496398 Offset: 0x2492398 VA: 0x2496398
	public void ReinforcePlayerDef() { }

	// RVA: 0x2496410 Offset: 0x2492410 VA: 0x2496410
	public void ReinforcePlayerHeart() { }

	// RVA: 0x2496488 Offset: 0x2492488 VA: 0x2496488
	public void ReinforcePlayerMAtk() { }

	// RVA: 0x24964C4 Offset: 0x24924C4 VA: 0x24964C4
	public float GetReinforcePriceRate(BlackKnightRoomData.ReinforceType type) { }

	// RVA: 0x2496728 Offset: 0x2492728 VA: 0x2496728
	public bool CheckEquipInvalidScoreCrista() { }

	// RVA: 0x2496824 Offset: 0x2492824 VA: 0x2496824
	public int GetEquipDoubleScoreCristaNum() { }

	// RVA: 0x2496878 Offset: 0x2492878 VA: 0x2496878
	public void SetAvatarType(BlackKnightAvatarType avatarType) { }

	// RVA: 0x2496880 Offset: 0x2492880 VA: 0x2496880
	public void .ctor() { }
}
