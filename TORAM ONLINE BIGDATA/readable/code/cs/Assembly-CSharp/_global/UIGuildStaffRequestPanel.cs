// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIGuildStaffRequestPanel : MonoBehaviour, UIGuildStaffBasePanel // TypeDefIndex: 6709
{
	// Fields
	[SerializeField]
	private UIInput inputPanel; // 0x20
	[SerializeField]
	private UILabel inputPanelLabel; // 0x28
	[SerializeField]
	private UILabel[] updateUserNameLabel; // 0x30
	private UIGuildStaffMainManager manager; // 0x38
	private SystemTextManager systemTextManager; // 0x40
	private GuildManager guildManager; // 0x48

	// Methods

	// RVA: 0x19C21C0 Offset: 0x19BE1C0 VA: 0x19C21C0 Slot: 4
	public void Initialize(UIGuildStaffMainManager manager, SystemTextManager systemTextManager) { }

	// RVA: 0x19C2430 Offset: 0x19BE430 VA: 0x19C2430 Slot: 8
	public void FadeIn() { }

	[IteratorStateMachine(typeof(UIGuildStaffRequestPanel.<FadeOut>d__8))]
	// RVA: 0x19C263C Offset: 0x19BE63C VA: 0x19C263C Slot: 9
	public IEnumerator FadeOut() { }

	// RVA: 0x19C26B0 Offset: 0x19BE6B0 VA: 0x19C26B0 Slot: 7
	public GameObject Panel() { }

	// RVA: 0x19C26B8 Offset: 0x19BE6B8 VA: 0x19C26B8 Slot: 5
	public bool PushLeftTopButton() { }

	// RVA: 0x19C26DC Offset: 0x19BE6DC VA: 0x19C26DC Slot: 6
	public bool PushRightTopButton() { }

	// RVA: 0x19C26E4 Offset: 0x19BE6E4 VA: 0x19C26E4
	public void OnClickChangeName() { }

	[IteratorStateMachine(typeof(UIGuildStaffRequestPanel.<InputNameThread>d__13))]
	// RVA: 0x19C28E8 Offset: 0x19BE8E8 VA: 0x19C28E8
	private IEnumerator InputNameThread() { }

	// RVA: 0x19C295C Offset: 0x19BE95C VA: 0x19C295C
	private void OnClickChangeAppearance() { }

	// RVA: 0x19C2B60 Offset: 0x19BEB60 VA: 0x19C2B60
	private void OnClickChangeCostume() { }

	// RVA: 0x19C2D64 Offset: 0x19BED64 VA: 0x19C2D64
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x19C2DC8 Offset: 0x19BEDC8 VA: 0x19C2DC8
	private void <OnClickChangeName>b__12_1() { }

	[CompilerGenerated]
	// RVA: 0x19C2F5C Offset: 0x19BEF5C VA: 0x19C2F5C
	private void <InputNameThread>b__13_1() { }

	[CompilerGenerated]
	// RVA: 0x19C3120 Offset: 0x19BF120 VA: 0x19C3120
	private void <OnClickChangeAppearance>b__14_1() { }

	[CompilerGenerated]
	// RVA: 0x19C32E0 Offset: 0x19BF2E0 VA: 0x19C32E0
	private void <OnClickChangeCostume>b__15_1() { }
}
