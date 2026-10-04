// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GashaponEffectPlayer : MonoBehaviour // TypeDefIndex: 283
{
	// Fields
	[SerializeField]
	private GameObject TapEffect; // 0x20
	private static readonly Color lightNormalColor; // 0x0
	private static readonly Color lightRareColor; // 0x10
	private static readonly Color lightSuperRareColor; // 0x20
	private static readonly Color lightUltraRareColor; // 0x30
	private readonly Dictionary<GashaponEffectPlayer.RankType, Color> lightColors; // 0x28
	private Dictionary<GashaponEffectPlayer.RankType, int> rankCount; // 0x30
	private List<GashaponEffectPlayer.RankType> currentRankList; // 0x38
	private GashaponEffectPlayer.RankType defaultRank; // 0x40
	private GashaponEffectPlayer.RankType finallyRank; // 0x44
	private int upgradeCount; // 0x48
	private List<GameObject> boxObjectList; // 0x50
	private List<GameObject> lightObjectList; // 0x58
	private GameObject lightObjectOriginal; // 0x60
	private GameObject npcObject; // 0x68
	private bool isTapped; // 0x70
	private readonly float skipTime; // 0x74
	private float skipTimeStart; // 0x78
	[CompilerGenerated]
	private GashaponEffectPlayer.EventStep <Step>k__BackingField; // 0x7C
	private bool isOpenSkip; // 0x80

	// Properties
	public GashaponEffectPlayer.EventStep Step { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x22AF344 Offset: 0x22AB344 VA: 0x22AF344
	public GashaponEffectPlayer.EventStep get_Step() { }

	[CompilerGenerated]
	// RVA: 0x22AF34C Offset: 0x22AB34C VA: 0x22AF34C
	private void set_Step(GashaponEffectPlayer.EventStep value) { }

	// RVA: 0x22AF354 Offset: 0x22AB354 VA: 0x22AF354
	public static GashaponEffectPlayer Play(Transform parent, int[] rarelist) { }

	// RVA: 0x22AF544 Offset: 0x22AB544 VA: 0x22AF544
	private void Awake() { }

	// RVA: 0x22AF5C8 Offset: 0x22AB5C8 VA: 0x22AF5C8
	private void Update() { }

	// RVA: 0x22AF680 Offset: 0x22AB680 VA: 0x22AF680
	private void OnDestroy() { }

	[IteratorStateMachine(typeof(GashaponEffectPlayer.<Initialize>d__28))]
	// RVA: 0x22AF4BC Offset: 0x22AB4BC VA: 0x22AF4BC
	public IEnumerator Initialize(List<int> rarelist) { }

	// RVA: 0x22AF708 Offset: 0x22AB708 VA: 0x22AF708
	private void initializeRankList(List<int> rarelist) { }

	[IteratorStateMachine(typeof(GashaponEffectPlayer.<loadResources>d__30))]
	// RVA: 0x22B01BC Offset: 0x22AC1BC VA: 0x22B01BC
	private IEnumerator loadResources() { }

	[IteratorStateMachine(typeof(GashaponEffectPlayer.<loadNPC>d__31))]
	// RVA: 0x22B0250 Offset: 0x22AC250 VA: 0x22B0250
	private IEnumerator loadNPC() { }

	[IteratorStateMachine(typeof(GashaponEffectPlayer.<playGashaponAnimation>d__32))]
	// RVA: 0x22B02E4 Offset: 0x22AC2E4 VA: 0x22B02E4
	private IEnumerator playGashaponAnimation() { }

	[IteratorStateMachine(typeof(GashaponEffectPlayer.<playOneBox>d__33))]
	// RVA: 0x22B0378 Offset: 0x22AC378 VA: 0x22B0378
	private IEnumerator playOneBox(int boxesIndex, Action kickoutCallback, Action lastOpenCallback, Action npcCallback) { }

	[IteratorStateMachine(typeof(GashaponEffectPlayer.<playTreasureEffect>d__34))]
	// RVA: 0x22B0460 Offset: 0x22AC460 VA: 0x22B0460
	private IEnumerator playTreasureEffect() { }

	// RVA: 0x22B04F4 Offset: 0x22AC4F4 VA: 0x22B04F4
	private void npcCallback() { }

	[IteratorStateMachine(typeof(GashaponEffectPlayer.<npcCoroutine>d__36))]
	// RVA: 0x22B0514 Offset: 0x22AC514 VA: 0x22B0514
	private IEnumerator npcCoroutine() { }

	[IteratorStateMachine(typeof(GashaponEffectPlayer.<Initialize>d__38))]
	// RVA: 0x22B05A8 Offset: 0x22AC5A8 VA: 0x22B05A8
	public IEnumerator Initialize(int[] ranks) { }

	// RVA: 0x22B0658 Offset: 0x22AC658 VA: 0x22B0658
	public void AnimationSkip() { }

	[IteratorStateMachine(typeof(GashaponEffectPlayer.<PlayBoxAnimation>d__40))]
	// RVA: 0x22B0664 Offset: 0x22AC664 VA: 0x22B0664
	public IEnumerator PlayBoxAnimation(int rank) { }

	[IteratorStateMachine(typeof(GashaponEffectPlayer.<PlayBoxAnimation>d__41))]
	// RVA: 0x22B0708 Offset: 0x22AC708 VA: 0x22B0708
	private IEnumerator PlayBoxAnimation(int rank, Action lastOpenCallback) { }

	// RVA: 0x22B07C0 Offset: 0x22AC7C0 VA: 0x22B07C0
	private void SetRankList(int[] ranks) { }

	// RVA: 0x22B09DC Offset: 0x22AC9DC VA: 0x22B09DC
	private void OnTap() { }

	// RVA: 0x22B018C Offset: 0x22AC18C VA: 0x22B018C
	private GashaponEffectPlayer.RankType getRareRank(int rare) { }

	// RVA: 0x22B0A6C Offset: 0x22ACA6C VA: 0x22B0A6C
	private GashaponEffectPlayer.RankType getRareRankDebug(int itemId) { }

	// RVA: 0x22B09B8 Offset: 0x22AC9B8 VA: 0x22B09B8
	private GashaponEffectPlayer.RankType GetTreasureHuntRank(int rank) { }

	// RVA: 0x22AF608 Offset: 0x22AB608 VA: 0x22AF608
	public void Destroy() { }

	// RVA: 0x22B0AA8 Offset: 0x22ACAA8 VA: 0x22B0AA8
	public void .ctor() { }

	// RVA: 0x22B0D74 Offset: 0x22ACD74 VA: 0x22B0D74
	private static void .cctor() { }
}
