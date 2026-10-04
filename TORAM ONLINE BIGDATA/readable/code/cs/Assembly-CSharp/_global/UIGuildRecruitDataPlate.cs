// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIGuildRecruitDataPlate : MonoBehaviour // TypeDefIndex: 7158
{
	// Fields
	[SerializeField]
	private UIImageButton joinButton; // 0x20
	[SerializeField]
	private UILabel GuildNameLabel; // 0x28
	[SerializeField]
	private UILabel GuildMasterNameLabel; // 0x30
	[SerializeField]
	private UILabel JoinNumLabel; // 0x38
	[SerializeField]
	private UILabel CommentLabel; // 0x40
	[SerializeField]
	private UILabel ConditionLabel; // 0x48
	private int GuildId; // 0x50
	private byte JoinType; // 0x54
	private Action<int, string, string, byte> ButtonPushAction; // 0x58

	// Methods

	// RVA: 0x1AAE59C Offset: 0x1AAA59C VA: 0x1AAE59C
	private void Start() { }

	// RVA: 0x1AAE5A0 Offset: 0x1AAA5A0 VA: 0x1AAE5A0
	public void Initialize(int id, string guildName, string guildMasterName, string memberNum, string comment, string condition, byte joinType, Action<int, string, string, byte> action) { }

	// RVA: 0x1AAE678 Offset: 0x1AAA678 VA: 0x1AAE678
	private void OnPushButton() { }

	// RVA: 0x1AAE6C8 Offset: 0x1AAA6C8 VA: 0x1AAE6C8
	public void .ctor() { }
}
