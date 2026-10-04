// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMahjongResultPlayerScoreManager : MonoBehaviour // TypeDefIndex: 5935
{
	// Fields
	[SerializeField]
	private UILabel nameLabel; // 0x20
	[SerializeField]
	private UILabel rankingLabel; // 0x28
	[SerializeField]
	private UILabel ranking; // 0x30
	[SerializeField]
	private UILabel scoreLabel; // 0x38
	[SerializeField]
	private UILabel changeValueLabel; // 0x40
	[SerializeField]
	private Color[] scoreColors; // 0x48
	[SerializeField]
	private Color[] rankColors; // 0x50
	private int changeValue; // 0x58
	private int targetScore; // 0x5C
	private int beforeScore; // 0x60
	private Coroutine changeScoreCoroutine; // 0x68
	private Action countDownCompleteCallBack; // 0x70
	private float reductionRate; // 0x78
	private const float duration = 3;
	private SystemTextManager sys; // 0x80
	private bool isFinished; // 0x88

	// Properties
	public bool IsChangeFinished { get; }

	// Methods

	// RVA: 0x184CA58 Offset: 0x1848A58 VA: 0x184CA58
	public bool get_IsChangeFinished() { }

	// RVA: 0x184CA60 Offset: 0x1848A60 VA: 0x184CA60
	private void Update() { }

	// RVA: 0x184CC50 Offset: 0x1848C50 VA: 0x184CC50
	public void Initialize(string name, byte rank, int score, int changeValue, Action callBack) { }

	[IteratorStateMachine(typeof(UIMahjongResultPlayerScoreManager.<ChangeScore>d__20))]
	// RVA: 0x184D010 Offset: 0x1849010 VA: 0x184D010
	private IEnumerator ChangeScore(int changeValue) { }

	// RVA: 0x184CA08 Offset: 0x1848A08 VA: 0x184CA08
	public void ResetFinishedFlag() { }

	// RVA: 0x184D0B4 Offset: 0x18490B4 VA: 0x184D0B4
	public void .ctor() { }
}
