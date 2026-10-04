// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UISkillStatusWindow : MonoBehaviour // TypeDefIndex: 6878
{
	// Fields
	[SerializeField]
	private GameObject viewCamera; // 0x20
	private UIIruna2Viewport viewport; // 0x28
	[SerializeField]
	private UILabel skillNameLabel; // 0x30
	[SerializeField]
	private UILabel skillTextLabel; // 0x38
	private UIIcon skillIcon; // 0x40
	[SerializeField]
	private GameObject skillButton; // 0x48
	private UIButtonSendMessage sendMessage; // 0x50
	private SkillTextManager skillTextManager; // 0x58

	// Methods

	// RVA: 0x1A30BCC Offset: 0x1A2CBCC VA: 0x1A30BCC
	private void Awake() { }

	// RVA: 0x1A30D48 Offset: 0x1A2CD48 VA: 0x1A30D48
	public void StatusSlideIn(int skillId) { }

	// RVA: 0x1A30F98 Offset: 0x1A2CF98 VA: 0x1A30F98
	public void StatusSlideOut() { }

	// RVA: 0x1A30FF0 Offset: 0x1A2CFF0 VA: 0x1A30FF0
	private void OnPress(bool pressed) { }

	// RVA: 0x1A30FFC Offset: 0x1A2CFFC VA: 0x1A30FFC
	private void OnSelect(bool selected) { }

	// RVA: 0x1A31008 Offset: 0x1A2D008 VA: 0x1A31008
	private void OnDrag(Vector2 delta) { }

	// RVA: 0x1A3100C Offset: 0x1A2D00C VA: 0x1A3100C
	public void .ctor() { }
}
