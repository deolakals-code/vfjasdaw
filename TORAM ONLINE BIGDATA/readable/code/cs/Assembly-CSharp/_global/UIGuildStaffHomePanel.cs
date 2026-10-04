// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIGuildStaffHomePanel : MonoBehaviour, UIGuildStaffBasePanel // TypeDefIndex: 6681
{
	// Fields
	[SerializeField]
	private UILabel mainLabel; // 0x20
	[SerializeField]
	private GameObject[] topSelectEnterButton; // 0x28
	private UIGuildStaffMainManager manager; // 0x30
	private SystemTextManager systemTextManager; // 0x38
	private GuildManager guildManager; // 0x40

	// Methods

	// RVA: 0x19B8DFC Offset: 0x19B4DFC VA: 0x19B8DFC Slot: 4
	public void Initialize(UIGuildStaffMainManager manager, SystemTextManager systemTextManager) { }

	// RVA: 0x19B8E70 Offset: 0x19B4E70 VA: 0x19B8E70 Slot: 8
	public void FadeIn() { }

	[IteratorStateMachine(typeof(UIGuildStaffHomePanel.<FadeOut>d__7))]
	// RVA: 0x19B913C Offset: 0x19B513C VA: 0x19B913C Slot: 9
	public IEnumerator FadeOut() { }

	// RVA: 0x19B91D0 Offset: 0x19B51D0 VA: 0x19B91D0 Slot: 7
	public GameObject Panel() { }

	// RVA: 0x19B91D8 Offset: 0x19B51D8 VA: 0x19B91D8 Slot: 5
	public bool PushLeftTopButton() { }

	// RVA: 0x19B91FC Offset: 0x19B51FC VA: 0x19B91FC Slot: 6
	public bool PushRightTopButton() { }

	// RVA: 0x19B9204 Offset: 0x19B5204 VA: 0x19B9204
	public void OnClick_ChangeHome() { }

	// RVA: 0x19B9344 Offset: 0x19B5344 VA: 0x19B9344
	public void OnClick_CustomBuffer() { }

	// RVA: 0x19B93D0 Offset: 0x19B53D0 VA: 0x19B93D0
	public void .ctor() { }
}
