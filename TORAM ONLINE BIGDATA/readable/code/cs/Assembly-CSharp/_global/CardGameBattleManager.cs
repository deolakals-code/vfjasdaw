// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CardGameBattleManager // TypeDefIndex: 4251
{
	// Fields
	private List<CardGameTakeBase> currentTakeList; // 0x10
	private List<CardGameTakeBase> afterTakeList; // 0x18
	private List<CardGameTakeBase> removeTakeList; // 0x20
	private Dictionary<int, List<CardGameManager.CardGameAttackCardData>> attackList; // 0x28
	private CardGameBattleCameraManager cameraManager; // 0x30
	private int nowAttackSpeed; // 0x38
	private int targetBoss; // 0x3C
	private bool isStart; // 0x40
	private float startTimer; // 0x44
	private float endTimer; // 0x48

	// Methods

	// RVA: 0x24B5B28 Offset: 0x24B1B28 VA: 0x24B5B28
	public void InitGameStart() { }

	// RVA: 0x24B5B9C Offset: 0x24B1B9C VA: 0x24B5B9C
	public void ReserveTakeList(Dictionary<int, List<CardGameManager.CardGameAttackCardData>> speed, float start) { }

	// RVA: 0x24B6270 Offset: 0x24B2270 VA: 0x24B6270
	public void Update() { }

	// RVA: 0x24B7A94 Offset: 0x24B3A94 VA: 0x24B7A94
	public void TakeEnd(CardGameTakeBase take) { }

	// RVA: 0x24B7BA4 Offset: 0x24B3BA4 VA: 0x24B7BA4
	public void TakeFinish(CardGameTakeBase take) { }

	// RVA: 0x24B5ED4 Offset: 0x24B1ED4 VA: 0x24B5ED4
	private void Start() { }

	// RVA: 0x24B6DE0 Offset: 0x24B2DE0 VA: 0x24B6DE0
	private void End() { }

	// RVA: 0x24B7514 Offset: 0x24B3514 VA: 0x24B7514
	private CardGameTakeBase CreateTake(CardGameManager.CardGameAttackCardData data, bool last) { }

	// RVA: 0x24B7738 Offset: 0x24B3738 VA: 0x24B7738
	private void ReserveTake(CardGameTakeBase take) { }

	// RVA: 0x24B7D3C Offset: 0x24B3D3C VA: 0x24B7D3C
	private static int GetLastAttackTake(ItemDBData.ItemType mainWeaponType, ItemDBData.ItemType subWeaponType, ref int eventId, ref float castTime) { }

	// RVA: 0x24B8560 Offset: 0x24B4560 VA: 0x24B8560
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x24B866C Offset: 0x24B466C VA: 0x24B866C
	private bool <Update>b__12_0(KeyValuePair<int, List<CardGameManager.CardGameAttackCardData>> x) { }
}
