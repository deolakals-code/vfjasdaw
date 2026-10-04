// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CardGameBossCardManager // TypeDefIndex: 4262
{
	// Fields
	private Dictionary<int, CardGameBossCard> bossCard; // 0x10
	private UICardGameManager uiManager; // 0x18
	[SerializeField]
	private const int maxBossNum = 4;
	[SerializeField]
	private const int bossTotalHp = 50;
	[SerializeField]
	private const int minHpLimit = 1;

	// Properties
	public List<CardGameBossCard> FieldBossCardList { get; }
	public List<CardGameBossCard> BossCardList { get; }
	public int BossNum { get; }
	public int ActiveBossNum { get; }

	// Methods

	// RVA: 0x24BA25C Offset: 0x24B625C VA: 0x24BA25C
	public List<CardGameBossCard> get_FieldBossCardList() { }

	// RVA: 0x24BA4A0 Offset: 0x24B64A0 VA: 0x24BA4A0
	public List<CardGameBossCard> get_BossCardList() { }

	// RVA: 0x24BA540 Offset: 0x24B6540 VA: 0x24BA540
	public int get_BossNum() { }

	// RVA: 0x24BA548 Offset: 0x24B6548 VA: 0x24BA548
	public int get_ActiveBossNum() { }

	// RVA: 0x24BA674 Offset: 0x24B6674 VA: 0x24BA674
	public void Initialize(UICardGameManager uiManager) { }

	// RVA: 0x24BA67C Offset: 0x24B667C VA: 0x24BA67C
	public void CreateBossCard(List<int> bossHp) { }

	// RVA: 0x24BA900 Offset: 0x24B6900 VA: 0x24BA900
	public void DestroyAllCard() { }

	// RVA: 0x24BA950 Offset: 0x24B6950 VA: 0x24BA950
	public void Damaged(int uniqueId, int attack, int spina, bool isSpecial) { }

	// RVA: 0x24BAA80 Offset: 0x24B6A80 VA: 0x24BAA80
	public void ResetDamage() { }

	// RVA: 0x24BAC08 Offset: 0x24B6C08 VA: 0x24BAC08
	public void ResetDamage(int uniqueId) { }

	// RVA: 0x24BAC9C Offset: 0x24B6C9C VA: 0x24BAC9C
	public int GetBossSpina(int uniqueId) { }

	// RVA: 0x24BA884 Offset: 0x24B6884 VA: 0x24BA884
	public void DeadBoss(int uniqueId) { }

	// RVA: 0x24B6E38 Offset: 0x24B2E38 VA: 0x24B6E38
	public bool IsDeadBoss(int uniqueId) { }

	// RVA: 0x24BAD34 Offset: 0x24B6D34 VA: 0x24BAD34
	public bool IsDeadBossAll() { }

	// RVA: 0x24BAEA4 Offset: 0x24B6EA4 VA: 0x24BAEA4
	public void UpdateBossHp(int id, byte hp, short spina) { }

	// RVA: 0x24BAF4C Offset: 0x24B6F4C VA: 0x24BAF4C
	public CardGameBossCard GetData(int id) { }

	// RVA: 0x24BAFC4 Offset: 0x24B6FC4 VA: 0x24BAFC4
	public void .ctor() { }
}
