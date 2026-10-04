// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMinstrelExSkillElement : MonoBehaviour // TypeDefIndex: 6740
{
	// Fields
	[SerializeField]
	private GameObject toggleObj; // 0x20
	[SerializeField]
	private UISprite toggleSprite; // 0x28
	[SerializeField]
	private UISprite toggleBaseSprite; // 0x30
	[SerializeField]
	private UILabel toggleLabel; // 0x38
	[SerializeField]
	private UILabel songCountLabel; // 0x40
	[SerializeField]
	private UISprite skillIcon; // 0x48
	[SerializeField]
	private UILabel skillNameLabel; // 0x50
	[SerializeField]
	private UIImageButton button; // 0x58
	[SerializeField]
	private GameObject arrowButton; // 0x60
	[SerializeField]
	private AnimationCurve moveMaxCurve; // 0x68
	[SerializeField]
	private AnimationCurve moveMinCurve; // 0x70
	private SystemTextManager sys; // 0x78
	private SkillTextManager skill; // 0x80
	private int skillIndex; // 0x88
	private int setSkillId; // 0x8C
	private bool toggleFlag; // 0x90
	private UIMinstrelExSkillManager manager; // 0x98
	private Action<int> toggleCallBack; // 0xA0
	private Action<int> changeSkill; // 0xA8
	private Action<int> changeOrder; // 0xB0
	private UIWidget[] wigets; // 0xB8
	private bool isMove; // 0xC0
	private bool isUp; // 0xC1
	private float moveTime; // 0xC4
	private const float moveCompleateTime = 1;
	private Vector2 targetPos; // 0xC8
	private const int moveDistance = 80;

	// Properties
	public bool IsSetSkill { get; }
	public bool IsMove { get; }

	// Methods

	// RVA: 0x19D2FF8 Offset: 0x19CEFF8 VA: 0x19D2FF8
	public bool get_IsSetSkill() { }

	// RVA: 0x19D3008 Offset: 0x19CF008 VA: 0x19D3008
	public bool get_IsMove() { }

	// RVA: 0x19D3010 Offset: 0x19CF010 VA: 0x19D3010
	private void Start() { }

	// RVA: 0x19D3094 Offset: 0x19CF094 VA: 0x19D3094
	private void Update() { }

	// RVA: 0x19D3310 Offset: 0x19CF310 VA: 0x19D3310
	public void Initialize(int index, int skillId, bool toggleFlag, UIMinstrelExSkillManager manager, Action<int> toggleCallBack, Action<int> changeSkill, Action<int> changeOrder) { }

	// RVA: 0x19D3888 Offset: 0x19CF888 VA: 0x19D3888
	public void ChangeOrder(int index, int skillId, bool toggleFlag, bool isUp) { }

	// RVA: 0x19D39A4 Offset: 0x19CF9A4 VA: 0x19D39A4
	public void OnClickToggle() { }

	// RVA: 0x19D3A24 Offset: 0x19CFA24 VA: 0x19D3A24
	public void OnClickChangeSkill() { }

	// RVA: 0x19D3A68 Offset: 0x19CFA68 VA: 0x19D3A68
	public void OnClickChangeOrder() { }

	// RVA: 0x19D3AAC Offset: 0x19CFAAC VA: 0x19D3AAC
	public void ChangeButtonEnable(bool flag) { }

	// RVA: 0x19D329C Offset: 0x19CF29C VA: 0x19D329C
	private void ChangeUIDepth(bool flag) { }

	// RVA: 0x19D3ACC Offset: 0x19CFACC VA: 0x19D3ACC
	public void .ctor() { }
}
