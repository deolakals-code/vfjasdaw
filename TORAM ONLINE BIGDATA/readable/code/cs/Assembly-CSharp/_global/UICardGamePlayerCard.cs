// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UICardGamePlayerCard : UICardGameCardBase // TypeDefIndex: 5702
{
	// Fields
	[SerializeField]
	private UISprite cardBase; // 0x58
	[SerializeField]
	private UISprite cardFrame; // 0x60
	[SerializeField]
	private GameObject backSide; // 0x68
	[SerializeField]
	private UITexture backTex; // 0x70
	[SerializeField]
	private UILabel nameLabel; // 0x78
	[SerializeField]
	private UISprite recycle; // 0x80
	[SerializeField]
	private UISprite recycleFrame; // 0x88
	[SerializeField]
	private UISprite attackIcon; // 0x90
	[SerializeField]
	private UILabel attackLabel; // 0x98
	[SerializeField]
	private UISprite speedIcon; // 0xA0
	[SerializeField]
	private UILabel speedLabel; // 0xA8
	[SerializeField]
	private UISprite spinaIcon; // 0xB0
	[SerializeField]
	private UISprite targetLine; // 0xB8
	[SerializeField]
	private TweenPosition tweenPosition; // 0xC0
	[SerializeField]
	private UISprite targetEffect; // 0xC8
	[SerializeField]
	private UITexture cardTexture; // 0xD0
	private List<UISprite> spinaIconList; // 0xD8
	private int targetBossId; // 0xE0
	private bool activeLineQuick; // 0xE4
	private bool activeLineMoveAfter; // 0xE5
	private UICardGameBattlePanelManager uiManager; // 0xE8
	private const float maxHeight = 280;
	private const float minHeight = 150;
	[CompilerGenerated]
	private bool <IsDrawing>k__BackingField; // 0xF0

	// Properties
	public bool IsDrawing { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x17CA37C Offset: 0x17C637C VA: 0x17CA37C
	public bool get_IsDrawing() { }

	[CompilerGenerated]
	// RVA: 0x17CA384 Offset: 0x17C6384 VA: 0x17CA384
	private void set_IsDrawing(bool value) { }

	// RVA: 0x17CA390 Offset: 0x17C6390 VA: 0x17CA390
	private void Update() { }

	// RVA: 0x17CA5A0 Offset: 0x17C65A0 VA: 0x17CA5A0 Slot: 5
	public override void OnPressCard() { }

	// RVA: 0x17CA884 Offset: 0x17C6884 VA: 0x17CA884 Slot: 6
	public override void OnReleaseCard() { }

	// RVA: 0x17CAAE4 Offset: 0x17C6AE4 VA: 0x17CAAE4
	public void Initialize(UICardGameBattlePanelManager manager, CardGamePlayerCard cardData, string name) { }

	// RVA: 0x17CB1A0 Offset: 0x17C71A0 VA: 0x17CB1A0
	public void SetActiveTargetLine(bool active) { }

	// RVA: 0x17CB4F4 Offset: 0x17C74F4 VA: 0x17CB4F4
	public void SetTarget(int bossId, bool active) { }

	// RVA: 0x17CA848 Offset: 0x17C6848 VA: 0x17CA848
	public void CancelTarget() { }

	// RVA: 0x17CB574 Offset: 0x17C7574 VA: 0x17CB574
	public void ResizeCloseVersion(float duration) { }

	// RVA: 0x17CB678 Offset: 0x17C7678 VA: 0x17CB678
	public void ResizeNormalVersion(float duration) { }

	[IteratorStateMachine(typeof(UICardGamePlayerCard.<Draw>d__36))]
	// RVA: 0x17C104C Offset: 0x17BD04C VA: 0x17C104C
	public IEnumerator Draw() { }

	// RVA: 0x17CB778 Offset: 0x17C7778 VA: 0x17CB778
	private void MoveDraw() { }

	// RVA: 0x17CB888 Offset: 0x17C7888 VA: 0x17CB888
	public void AllHandDraw(Vector3 pos) { }

	[IteratorStateMachine(typeof(UICardGamePlayerCard.<DrawThread>d__39))]
	// RVA: 0x17CB8A8 Offset: 0x17C78A8 VA: 0x17CB8A8
	private IEnumerator DrawThread(Vector3 pos) { }

	// RVA: 0x17CAF0C Offset: 0x17C6F0C VA: 0x17CAF0C
	private void SetNameLabel(string name) { }

	// RVA: 0x17CAFA4 Offset: 0x17C6FA4 VA: 0x17CAFA4
	private void SetRecycle(bool recycle) { }

	// RVA: 0x17CB068 Offset: 0x17C7068 VA: 0x17CB068
	private void SetAttackLabel(int value) { }

	// RVA: 0x17CB104 Offset: 0x17C7104 VA: 0x17CB104
	private void SetSpeedLabel(int value) { }

	// RVA: 0x17CB20C Offset: 0x17C720C VA: 0x17CB20C
	private bool InitTargetLine() { }

	// RVA: 0x17CA440 Offset: 0x17C6440 VA: 0x17CA440
	private void SetTargetLine() { }

	// RVA: 0x17CA484 Offset: 0x17C6484 VA: 0x17CA484
	private void UpdateTargetLine() { }

	// RVA: 0x17CB940 Offset: 0x17C7940 VA: 0x17CB940
	private Vector3 Division(Vector3 vec1, Vector3 vec2) { }

	// RVA: 0x17CB950 Offset: 0x17C7950 VA: 0x17CB950
	public void .ctor() { }
}
