// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIGuildAllianceInvitationElement : MonoBehaviour // TypeDefIndex: 6610
{
	// Fields
	[SerializeField]
	private UILabel guildNameLabel; // 0x20
	[SerializeField]
	private UILabel guildMasterLabel; // 0x28
	[SerializeField]
	private UILabel timeLabel; // 0x30
	[SerializeField]
	private UILabel cancelButtonLabel; // 0x38
	[SerializeField]
	private UILabel appleButtonLabel; // 0x40
	[SerializeField]
	private UIImageButton appleButton; // 0x48
	private UIGuildAllianceInvitationManager manager; // 0x50
	private int id; // 0x58
	private float countTimer; // 0x5C
	private int viewTime; // 0x60
	private string secondKey; // 0x68
	private string minuteKey; // 0x70

	// Methods

	// RVA: 0x199AA64 Offset: 0x1996A64 VA: 0x199AA64
	public void Initialize(UIGuildAllianceInvitationManager manager, int allianceId, string guildName, string masterName, float time, string minuteKey, string secondKey) { }

	// RVA: 0x199AB0C Offset: 0x1996B0C VA: 0x199AB0C
	public void SetButtonKey(bool isActiveApply, string applyButtonText, string cancelButtonText) { }

	// RVA: 0x199AB68 Offset: 0x1996B68 VA: 0x199AB68
	private void Update() { }

	// RVA: 0x199AC60 Offset: 0x1996C60 VA: 0x199AC60
	public void OnClick_CancelInvitation() { }

	// RVA: 0x199AF84 Offset: 0x1996F84 VA: 0x199AF84
	public void OnClick_Apple() { }

	// RVA: 0x199B1E0 Offset: 0x19971E0 VA: 0x199B1E0
	public void .ctor() { }
}
