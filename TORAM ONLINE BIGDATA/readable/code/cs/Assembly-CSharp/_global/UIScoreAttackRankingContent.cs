// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIScoreAttackRankingContent : MonoBehaviour // TypeDefIndex: 6254
{
	// Fields
	[SerializeField]
	private UISprite rankColorBase; // 0x20
	[SerializeField]
	private UILabel rankLabel; // 0x28
	[Header("Solo")]
	[SerializeField]
	private GameObject soloPlayerObjectParent; // 0x30
	[SerializeField]
	private UISprite sWeaponIcon; // 0x38
	[SerializeField]
	private UISprite sSubWeaponIcon; // 0x40
	[SerializeField]
	private UILabel sLevelLabel; // 0x48
	[SerializeField]
	private UILabel sPlayerNameLabel; // 0x50
	[SerializeField]
	[Header("Party")]
	private GameObject partyPlayerObjectParent; // 0x58
	[SerializeField]
	private GameObject[] partyPlayerObjects; // 0x60
	[SerializeField]
	private UISprite[] pWeaponIcon; // 0x68
	[SerializeField]
	private UISprite[] pSubWeaponIcon; // 0x70
	[SerializeField]
	private UILabel[] pLevelLabel; // 0x78
	[SerializeField]
	private UILabel[] pPlayerNameLabel; // 0x80
	[SerializeField]
	[Space(20)]
	private GameObject rollScoreObject; // 0x88
	[SerializeField]
	private UILabel rollNameLabel; // 0x90
	[SerializeField]
	private UILabel rollScoreLabel; // 0x98
	[SerializeField]
	private UILabel damageScoreLabel; // 0xA0
	private readonly Color32 firstColor; // 0xA8
	private readonly Color32 secondColor; // 0xAC
	private readonly Color32 thirdColor; // 0xB0
	private readonly Color32 otherRankColor; // 0xB4
	private SystemTextManager sys; // 0xB8

	// Methods

	// RVA: 0x18D0784 Offset: 0x18CC784 VA: 0x18D0784
	public void Initialize_Roll(int rank, ScoreAttackRankingSendData_Roll userData, ScoreAttackRankingType rankingType) { }

	// RVA: 0x18D0C64 Offset: 0x18CCC64 VA: 0x18D0C64
	public void Initialize_MyRoll(ScoreAttackMyRankData_Roll myData, ScoreAttackRankingType rankingType) { }

	// RVA: 0x18D0D3C Offset: 0x18CCD3C VA: 0x18D0D3C
	public void Initialize_Solo(int rank, ScoreAttackRankingSendData_Solo userDatas, ScoreAttackRankingType rankingType) { }

	// RVA: 0x18D1490 Offset: 0x18CD490 VA: 0x18D1490
	public void Initialize_MySolo(ScoreAttackMyRankData_Solo myData, ScoreAttackRankingType rankingType) { }

	// RVA: 0x18D1568 Offset: 0x18CD568 VA: 0x18D1568
	public void .ctor() { }
}
