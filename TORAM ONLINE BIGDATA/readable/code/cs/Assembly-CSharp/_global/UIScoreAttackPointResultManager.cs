// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIScoreAttackPointResultManager : MonoBehaviour // TypeDefIndex: 6253
{
	// Fields
	[SerializeField]
	private UILabel damageDealtLabel; // 0x20
	[SerializeField]
	private UILabel conditionBonusTitleLabel; // 0x28
	[SerializeField]
	private UISprite conditionBonusTitleLine; // 0x30
	[SerializeField]
	private UILabel[] bonusTitleLabels; // 0x38
	[SerializeField]
	private UILabel[] bonusRatioLabels; // 0x40
	[SerializeField]
	private UILabel[] bonusValueLabels; // 0x48
	[SerializeField]
	private UILabel[] damageScoreLabels; // 0x50
	[SerializeField]
	private UILabel[] damageScoreScoreLabels; // 0x58
	[SerializeField]
	private GameObject totalDamageNewRecordLabel; // 0x60
	[SerializeField]
	private UILabel totalDamageLabel; // 0x68
	private ScoreAttackRoomData roomData; // 0x70
	private SystemTextManager sys; // 0x78
	private readonly byte[] RatioValues; // 0x80

	// Methods

	// RVA: 0x18CFD30 Offset: 0x18CBD30 VA: 0x18CFD30
	public void Initialize(ScoreAttackRoomData roomData) { }

	// RVA: 0x18D06A0 Offset: 0x18CC6A0 VA: 0x18D06A0
	public void .ctor() { }
}
