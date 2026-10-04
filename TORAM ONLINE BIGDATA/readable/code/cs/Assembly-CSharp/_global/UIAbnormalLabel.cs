// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIAbnormalLabel : MonoBehaviour // TypeDefIndex: 6469
{
	// Fields
	[SerializeField]
	private GameObject labelObject; // 0x20
	private IUILabel label; // 0x28
	[SerializeField]
	private GameObject backgroundObject; // 0x30
	private IUIWidget background; // 0x38
	private Vector3 targetPosition; // 0x40
	private const float DefaultScale = 1.4;
	private float correctScale; // 0x4C

	// Methods

	// RVA: 0x193CD90 Offset: 0x1938D90 VA: 0x193CD90
	public void AbnormalLabelCreate(string abnormalText, bool player, int skillId, Vector3 position, bool abnormalBreakthroughLimit, float size = 1) { }

	// RVA: 0x193E500 Offset: 0x193A500 VA: 0x193E500
	public void AbnormalLabelCreate(string abnormalText, bool player, ItemDBData.EquipType equipType, int mainWeaponType, int subWeaponType, Vector3 position, bool abnormalBreakthroughLimit, float size = 1) { }

	// RVA: 0x193D094 Offset: 0x1939094 VA: 0x193D094
	public void InitializePlayerToEnemy(string abnormalText, int skillId, Vector3 position, bool other) { }

	// RVA: 0x193D2A4 Offset: 0x19392A4 VA: 0x193D2A4
	public void InitializePlayerToEnemy(string abnormalText, ItemDBData.EquipType equipType, int mainWeaponType, int subWeaponType, Vector3 position, bool other) { }

	// RVA: 0x193D79C Offset: 0x193979C VA: 0x193D79C
	public void InitializeAbnormalLabelEnemyToPlayer(AbnormalType abnormal, string abnormalText, Vector3 position, bool abnormalBreakthroughLimit) { }

	// RVA: 0x193DB0C Offset: 0x1939B0C VA: 0x193DB0C
	public void InitializeRecoveryAbnormalLabelEnemyToPlayer(string text, bool isVaccine, AbnormalType abnormal, Vector3 position) { }

	// RVA: 0x193DF4C Offset: 0x1939F4C VA: 0x193DF4C
	public void InitializeAbnormalLabelPlayer(string abnormalText, int skillId, Vector3 position, bool abnormalBreakthroughLimit) { }

	// RVA: 0x193E164 Offset: 0x193A164 VA: 0x193E164
	public void AbnormalLabelCreate(string abnormalText, Vector3 position) { }

	// RVA: 0x193E81C Offset: 0x193A81C VA: 0x193E81C
	public void MobBuffLabelCreate(string mobBuffText, MobBuffId mobBuffId, Vector3 position) { }

	// RVA: 0x193F4E4 Offset: 0x193B4E4 VA: 0x193F4E4
	public void ItemLabelCreate(int itemId, string itemName, Vector3 position) { }

	// RVA: 0x193F72C Offset: 0x193B72C VA: 0x193F72C
	public void GemCartLabelCreate(Vector3 position, string itemName) { }

	// RVA: 0x193EAA4 Offset: 0x193AAA4 VA: 0x193EAA4
	public void AvoidGuardLabelCreate(string defenseText, bool player, bool avoid, Vector3 position) { }

	// RVA: 0x193F22C Offset: 0x193B22C VA: 0x193F22C
	public void BreakedPartsLabelCreate(string defenseText, Vector3 position) { }

	// RVA: 0x1947634 Offset: 0x1943634 VA: 0x1947634
	private void Initialize(string text, Color color, Vector3 position, string spriteName, float timer) { }

	// RVA: 0x1947368 Offset: 0x1943368 VA: 0x1947368
	private void Initialize(string text, Color color, Vector3 position, float timer, Color textColor) { }

	// RVA: 0x1947734 Offset: 0x1943734 VA: 0x1947734
	private void ScreenUpdate() { }

	// RVA: 0x19478C0 Offset: 0x19438C0 VA: 0x19478C0
	private void Update() { }

	// RVA: 0x1947AA8 Offset: 0x1943AA8 VA: 0x1947AA8
	public void .ctor() { }
}
