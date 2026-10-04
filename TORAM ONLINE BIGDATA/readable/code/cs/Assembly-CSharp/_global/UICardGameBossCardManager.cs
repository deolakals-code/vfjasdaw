// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UICardGameBossCardManager : MonoBehaviour // TypeDefIndex: 5669
{
	// Fields
	[SerializeField]
	private UICardGameBossCard bossCard; // 0x20
	[SerializeField]
	private UISprite bossIcon; // 0x28
	private Dictionary<int, UICardGameBossCard> bossCardList; // 0x30
	[CompilerGenerated]
	private UICardGameBattlePanelManager <uiManager>k__BackingField; // 0x38
	private int BossNum; // 0x40

	// Properties
	private UICardGameBattlePanelManager uiManager { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x17C2F18 Offset: 0x17BEF18 VA: 0x17C2F18
	private UICardGameBattlePanelManager get_uiManager() { }

	[CompilerGenerated]
	// RVA: 0x17C2F20 Offset: 0x17BEF20 VA: 0x17C2F20
	private void set_uiManager(UICardGameBattlePanelManager value) { }

	// RVA: 0x17BA9B0 Offset: 0x17B69B0 VA: 0x17BA9B0
	public void Initialize(UICardGameBattlePanelManager manager) { }

	// RVA: 0x17BB8F4 Offset: 0x17B78F4 VA: 0x17BB8F4
	public void CreateBossDatas(bool inAnime, List<CardGameBossCard> cardData, float height) { }

	// RVA: 0x17C0D2C Offset: 0x17BCD2C VA: 0x17C0D2C
	public void CreateBossCard(CardGameBossCard card, float height, float animeTimer) { }

	// RVA: 0x17BD374 Offset: 0x17B9374 VA: 0x17BD374
	public void DeadBoss(int uniqueId) { }

	// RVA: 0x17BADF4 Offset: 0x17B6DF4 VA: 0x17BADF4
	public void DestroyBossCardAll() { }

	// RVA: 0x17BD53C Offset: 0x17B953C VA: 0x17BD53C
	public void SetActiveHpUI(int uniqueId) { }

	// RVA: 0x17BD5F0 Offset: 0x17B95F0 VA: 0x17BD5F0
	public void SetHpOtherPlayerAttack(int uniqueId) { }

	// RVA: 0x17BF51C Offset: 0x17BB51C VA: 0x17BF51C
	public void DisplayCard(float interval, float height, float time) { }

	// RVA: 0x17BEDA8 Offset: 0x17BADA8 VA: 0x17BEDA8
	public bool TryGetHitMob(Vector3 pos, out int id) { }

	// RVA: 0x17BD428 Offset: 0x17B9428 VA: 0x17BD428
	public void UpdateUI(int uniqueId, CardGameBossCard cardData, bool damage) { }

	// RVA: 0x17BD7C8 Offset: 0x17B97C8 VA: 0x17BD7C8
	public bool GetBossUi(int uniqueId, out UICardGameBossCard uiBoss) { }

	// RVA: 0x17BF33C Offset: 0x17BB33C VA: 0x17BF33C
	public void SetEnabled(bool enable) { }

	// RVA: 0x17C2F28 Offset: 0x17BEF28 VA: 0x17C2F28
	public void .ctor() { }
}
