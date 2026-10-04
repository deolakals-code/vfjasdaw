// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UICardGameBossCard : MonoBehaviour // TypeDefIndex: 5668
{
	// Fields
	[SerializeField]
	private Transform shakeTrans; // 0x20
	[SerializeField]
	private BoxCollider collider; // 0x28
	[SerializeField]
	private UISprite bossCardBase; // 0x30
	[SerializeField]
	private UISprite bossIcon; // 0x38
	[SerializeField]
	private UISprite spinaIcon; // 0x40
	[SerializeField]
	private UILabel spinaLabel; // 0x48
	[SerializeField]
	private UISprite lifeIcon; // 0x50
	[SerializeField]
	private UISprite lifeDamageIcon; // 0x58
	[SerializeField]
	private UILabel lifeLabel; // 0x60
	private Vector3 position; // 0x68
	private float shakeTime; // 0x74
	private UICardGameBattlePanelManager uiManager; // 0x78
	private bool isDead; // 0x80
	private bool updateHpLabel; // 0x81
	[CompilerGenerated]
	private CardGameBossCard <Status>k__BackingField; // 0x88

	// Properties
	public CardGameBossCard Status { get; set; }
	public int CardHeight { get; }
	public bool IsEnabled { get; set; }
	public bool IsDead { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x17C2924 Offset: 0x17BE924 VA: 0x17C2924
	public CardGameBossCard get_Status() { }

	[CompilerGenerated]
	// RVA: 0x17C292C Offset: 0x17BE92C VA: 0x17C292C
	private void set_Status(CardGameBossCard value) { }

	// RVA: 0x17BD830 Offset: 0x17B9830 VA: 0x17BD830
	public int get_CardHeight() { }

	// RVA: 0x17C2934 Offset: 0x17BE934 VA: 0x17C2934
	public bool get_IsEnabled() { }

	// RVA: 0x17C2950 Offset: 0x17BE950 VA: 0x17C2950
	public void set_IsEnabled(bool value) { }

	// RVA: 0x17C2970 Offset: 0x17BE970 VA: 0x17C2970
	public bool get_IsDead() { }

	// RVA: 0x17C2978 Offset: 0x17BE978 VA: 0x17C2978
	private void Start() { }

	// RVA: 0x17C297C Offset: 0x17BE97C VA: 0x17C297C
	private void Update() { }

	// RVA: 0x17C2A48 Offset: 0x17BEA48 VA: 0x17C2A48
	public void Initialize(UICardGameBattlePanelManager manager, CardGameBossCard cardData) { }

	// RVA: 0x17C2BB4 Offset: 0x17BEBB4 VA: 0x17C2BB4
	public void SetSpinaLabel(int spina) { }

	// RVA: 0x17C2AE4 Offset: 0x17BEAE4 VA: 0x17C2AE4
	public void SetLifeLabel(int life) { }

	// RVA: 0x17C2B2C Offset: 0x17BEB2C VA: 0x17C2B2C
	public void SetActiveHp(bool active) { }

	// RVA: 0x17C2C98 Offset: 0x17BEC98 VA: 0x17C2C98
	public void SetActiveHpDamage() { }

	// RVA: 0x17C2D10 Offset: 0x17BED10 VA: 0x17C2D10
	public void StartShake() { }

	// RVA: 0x17C2D20 Offset: 0x17BED20 VA: 0x17C2D20
	public void OnPressBossCard() { }

	// RVA: 0x17C2D48 Offset: 0x17BED48 VA: 0x17C2D48
	public bool SelectCheck(Vector3 pos) { }

	// RVA: 0x17C2EB8 Offset: 0x17BEEB8 VA: 0x17C2EB8
	public void movePosition(Vector3 pos, float time) { }

	// RVA: 0x17C2BF4 Offset: 0x17BEBF4 VA: 0x17C2BF4
	public void Dead() { }

	// RVA: 0x17C2F10 Offset: 0x17BEF10 VA: 0x17C2F10
	public void .ctor() { }
}
