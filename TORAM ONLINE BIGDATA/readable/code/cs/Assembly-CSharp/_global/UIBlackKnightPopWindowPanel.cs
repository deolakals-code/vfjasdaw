// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIBlackKnightPopWindowPanel : MonoBehaviour // TypeDefIndex: 5848
{
	// Fields
	[SerializeField]
	private GameObject mainPanel; // 0x20
	[SerializeField]
	private UILabel[] labels; // 0x28
	[SerializeField]
	private UILabel[] buttonLabels; // 0x30
	[SerializeField]
	private UIImageButton[] imageButtons; // 0x38
	private BlackKnightRoomData roomData; // 0x40
	private SystemTextManager systemTextManager; // 0x48

	// Properties
	public bool IsEnable { get; }

	// Methods

	// RVA: 0x180907C Offset: 0x180507C VA: 0x180907C
	public bool get_IsEnable() { }

	// RVA: 0x1809098 Offset: 0x1805098 VA: 0x1809098
	private void Awake() { }

	// RVA: 0x1808CB8 Offset: 0x1804CB8 VA: 0x1808CB8
	public void Initialize(BlackKnightRoomData roomData) { }

	// RVA: 0x1809608 Offset: 0x1805608 VA: 0x1809608
	public void SetEnable(bool isEnable) { }

	// RVA: 0x1809728 Offset: 0x1805728 VA: 0x1809728
	public void ForceClose() { }

	[IteratorStateMachine(typeof(UIBlackKnightPopWindowPanel.<CloseTweenScalePanel>d__12))]
	// RVA: 0x18096BC Offset: 0x18056BC VA: 0x18096BC
	private IEnumerator CloseTweenScalePanel() { }

	// RVA: 0x18091F0 Offset: 0x18051F0 VA: 0x18091F0
	private void UpdateButton() { }

	// RVA: 0x1809770 Offset: 0x1805770 VA: 0x1809770
	public void OnClick(int param) { }

	// RVA: 0x1809830 Offset: 0x1805830 VA: 0x1809830
	public void .ctor() { }
}
