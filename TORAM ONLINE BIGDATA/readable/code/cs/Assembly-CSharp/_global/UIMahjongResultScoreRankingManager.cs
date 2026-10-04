// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMahjongResultScoreRankingManager : MonoBehaviour // TypeDefIndex: 5936
{
	// Fields
	[SerializeField]
	private UILabel rankLabel; // 0x20
	[SerializeField]
	private UILabel rank; // 0x28
	[SerializeField]
	private UILabel nameLabel; // 0x30
	[SerializeField]
	private UILabel scoreLabel; // 0x38
	[SerializeField]
	private UILabel gameScoreLabel; // 0x40
	[SerializeField]
	private GameObject autologousIcon; // 0x48
	[SerializeField]
	private Color[] rankColors; // 0x50
	[SerializeField]
	private Color[] gameScoreColors; // 0x58
	private SystemTextManager sys; // 0x60

	// Methods

	// RVA: 0x184D210 Offset: 0x1849210 VA: 0x184D210
	public void Initialize(byte rank, string name, int score, float gameScore, bool isMine) { }

	// RVA: 0x184D55C Offset: 0x184955C VA: 0x184D55C
	public void .ctor() { }
}
