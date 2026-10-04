// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIGuildStaffSupportPanel : MonoBehaviour, UIGuildStaffBasePanel // TypeDefIndex: 6712
{
	// Fields
	[SerializeField]
	private GameObject settingPanel; // 0x20
	[SerializeField]
	private GameObject buyPanel; // 0x28
	[SerializeField]
	private UILabel limitLabel; // 0x30
	[SerializeField]
	private GameObject requestButtonObj; // 0x38
	[SerializeField]
	private GameObject leadButtonObj; // 0x40
	[SerializeField]
	private UIToggle leadToggle; // 0x48
	[SerializeField]
	private UIImageButton buyImageButton; // 0x50
	[SerializeField]
	private UIButtonColor buyColorButton; // 0x58
	private UIGuildStaffMainManager manager; // 0x60
	private SystemTextManager systemTextManager; // 0x68
	private bool isSaveFlag; // 0x70

	// Methods

	// RVA: 0x19C3C34 Offset: 0x19BFC34 VA: 0x19C3C34 Slot: 4
	public void Initialize(UIGuildStaffMainManager manager, SystemTextManager systemTextManager) { }

	// RVA: 0x19C3CC0 Offset: 0x19BFCC0 VA: 0x19C3CC0 Slot: 5
	public bool PushLeftTopButton() { }

	// RVA: 0x19C3D40 Offset: 0x19BFD40 VA: 0x19C3D40 Slot: 6
	public bool PushRightTopButton() { }

	// RVA: 0x19C3D48 Offset: 0x19BFD48 VA: 0x19C3D48 Slot: 7
	public GameObject Panel() { }

	// RVA: 0x19C3D50 Offset: 0x19BFD50 VA: 0x19C3D50 Slot: 8
	public void FadeIn() { }

	[IteratorStateMachine(typeof(UIGuildStaffSupportPanel.<FadeOut>d__16))]
	// RVA: 0x19C40D8 Offset: 0x19C00D8 VA: 0x19C40D8 Slot: 9
	public IEnumerator FadeOut() { }

	// RVA: 0x19C416C Offset: 0x19C016C VA: 0x19C416C
	private void OnDestroy() { }

	// RVA: 0x19C41C8 Offset: 0x19C01C8 VA: 0x19C41C8
	public void OnClick_SupportStaff() { }

	// RVA: 0x19C4454 Offset: 0x19C0454 VA: 0x19C4454
	public void OnClick_Request() { }

	// RVA: 0x19C45E0 Offset: 0x19C05E0 VA: 0x19C45E0
	private void ActiveBuyPanel() { }

	// RVA: 0x19C4790 Offset: 0x19C0790 VA: 0x19C4790
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x19C4798 Offset: 0x19C0798 VA: 0x19C4798
	private void <OnClick_SupportStaff>b__18_1() { }
}
