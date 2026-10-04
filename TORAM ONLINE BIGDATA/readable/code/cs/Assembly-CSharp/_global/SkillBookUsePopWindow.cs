// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SkillBookUsePopWindow : PopUpMessageWindow // TypeDefIndex: 8828
{
	// Fields
	private UIIcon titleIcon; // 0x70
	private UILabel titleLabel; // 0x78
	private UILabel messageLabel; // 0x80
	private UIIcon skillIcon; // 0x88
	private UILabel attentionLabel; // 0x90
	private UILabel buttonLabel; // 0x98
	private UIImageButton imageButton; // 0xA0
	private short skill; // 0xA8
	private bool isFailure; // 0xAA
	private string itemDelayText; // 0xB0
	private string itemOkText; // 0xB8
	private PlayerDataManager playerDataManager; // 0xC0
	private bool isInit; // 0xC8
	private int waitFrame; // 0xCC
	private const int waitFrameCount = 1;
	private const int waitLabelFrameCount = 2;

	// Methods

	// RVA: 0x1E2984C Offset: 0x1E2584C VA: 0x1E2984C
	public void .ctor(string title, string delayText, string okText, short skill, bool isFailure) { }

	// RVA: 0x1E29938 Offset: 0x1E25938 VA: 0x1E29938 Slot: 4
	protected override void Initialize() { }

	// RVA: 0x1E29BAC Offset: 0x1E25BAC VA: 0x1E29BAC Slot: 5
	public override void Update() { }

	// RVA: 0x1E29D94 Offset: 0x1E25D94 VA: 0x1E29D94
	private void UpdateWindowLabelWithIcon() { }
}
