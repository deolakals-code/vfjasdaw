// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIScoreAttackCategoryResultManager : MonoBehaviour // TypeDefIndex: 6238
{
	// Fields
	[SerializeField]
	private UILabel categoryTitleLabel; // 0x20
	[SerializeField]
	private GameObject categoryScoreNewRecordLabel; // 0x28
	[SerializeField]
	private UISprite categoryIcon; // 0x30
	[SerializeField]
	private UILabel categoryNameLabel; // 0x38
	[SerializeField]
	private UILabel categoryScoreLabel; // 0x40
	[SerializeField]
	private UILabel categoryDamageScoreLabel; // 0x48
	private ScoreAttackRoomData roomData; // 0x50
	private PlayerDataManager pData; // 0x58
	private SystemTextManager sys; // 0x60
	private string[] categoryIconKeys; // 0x68

	// Methods

	// RVA: 0x18C66B4 Offset: 0x18C26B4 VA: 0x18C66B4
	public void Initialize(ScoreAttackRoomData roomData, UIScoreAttackResultManager.RollType mvpType) { }

	// RVA: 0x18C6ADC Offset: 0x18C2ADC VA: 0x18C6ADC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x18C6C18 Offset: 0x18C2C18 VA: 0x18C6C18
	private bool <Initialize>b__10_0(Tuple<ArchetypeUid, long> x) { }
}
