// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIGuildStaffBankViewPanel : MonoBehaviour, UIGuildStaffBasePanel // TypeDefIndex: 6669
{
	// Fields
	[SerializeField]
	private UILabel mainLabel; // 0x20
	[SerializeField]
	private UILabel backSpinaLabel; // 0x28
	[SerializeField]
	private UILabel backMedalLabel; // 0x30
	private UIGuildStaffMainManager manager; // 0x38
	private SystemTextManager systemTextManager; // 0x40
	private GuildManager guildManager; // 0x48

	// Methods

	// RVA: 0x19AEF78 Offset: 0x19AAF78 VA: 0x19AEF78 Slot: 4
	public void Initialize(UIGuildStaffMainManager manager, SystemTextManager systemTextManager) { }

	// RVA: 0x19AEFEC Offset: 0x19AAFEC VA: 0x19AEFEC Slot: 8
	public void FadeIn() { }

	[IteratorStateMachine(typeof(UIGuildStaffBankViewPanel.<FadeOut>d__8))]
	// RVA: 0x19AF338 Offset: 0x19AB338 VA: 0x19AF338 Slot: 9
	public IEnumerator FadeOut() { }

	// RVA: 0x19AF3CC Offset: 0x19AB3CC VA: 0x19AF3CC Slot: 7
	public GameObject Panel() { }

	// RVA: 0x19AF3D4 Offset: 0x19AB3D4 VA: 0x19AF3D4 Slot: 5
	public bool PushLeftTopButton() { }

	// RVA: 0x19AF598 Offset: 0x19AB598 VA: 0x19AF598 Slot: 6
	public bool PushRightTopButton() { }

	// RVA: 0x19AF5A0 Offset: 0x19AB5A0 VA: 0x19AF5A0
	public void .ctor() { }
}
