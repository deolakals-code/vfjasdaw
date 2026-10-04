// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIFriendListElement : MonoBehaviour // TypeDefIndex: 7084
{
	// Fields
	[SerializeField]
	protected GameObject actionButton; // 0x20
	[SerializeField]
	protected UILabel nameLabel; // 0x28
	[SerializeField]
	protected UILabel levelLabel; // 0x30
	[SerializeField]
	private UILabel timeLabel; // 0x38
	[SerializeField]
	protected UISprite selectedSprite; // 0x40
	[SerializeField]
	protected UISprite connectIcon; // 0x48
	[SerializeField]
	protected UILabel fieldNameLabel; // 0x50
	protected UILabel actionLabel; // 0x58
	protected UISprite actionBackground; // 0x60
	protected BoxCollider actionCollider; // 0x68
	[CompilerGenerated]
	private Action<int> SelectedCallback; // 0x70
	protected int index; // 0x78
	protected SystemTextManager systemTextManager; // 0x80
	protected PlayerDataManager playerDataManager; // 0x88
	private FieldTextManager fieldTextManager; // 0x90
	protected BoxCollider boxCollider; // 0x98

	// Methods

	[CompilerGenerated]
	// RVA: 0x1A8FC4C Offset: 0x1A8BC4C VA: 0x1A8FC4C
	public void add_SelectedCallback(Action<int> value) { }

	[CompilerGenerated]
	// RVA: 0x1A8FCFC Offset: 0x1A8BCFC VA: 0x1A8FCFC
	public void remove_SelectedCallback(Action<int> value) { }

	// RVA: 0x1A8FDAC Offset: 0x1A8BDAC VA: 0x1A8FDAC
	protected void Awake() { }

	// RVA: 0x1A90030 Offset: 0x1A8C030 VA: 0x1A90030
	public void SetIndex(int index) { }

	// RVA: 0x1A90038 Offset: 0x1A8C038 VA: 0x1A90038
	public void SetLabel(string name, int lv, string time) { }

	// RVA: 0x1A90214 Offset: 0x1A8C214 VA: 0x1A90214
	public void SetAction(string actionLocalizeKey, bool isButton, int id, int loginDay, int fieldId, byte roomType) { }

	// RVA: 0x1A90A94 Offset: 0x1A8CA94 VA: 0x1A90A94 Slot: 4
	public virtual void SetSelected(bool isSelected) { }

	// RVA: 0x1A90AB4 Offset: 0x1A8CAB4 VA: 0x1A90AB4
	private void OnClick() { }

	// RVA: 0x1A90ADC Offset: 0x1A8CADC VA: 0x1A90ADC Slot: 5
	public virtual void SetMenuState(bool isMenu) { }

	// RVA: 0x1A9095C Offset: 0x1A8C95C VA: 0x1A9095C
	private string LoginDay(string actionLocalizeKey, int loginDay) { }

	// RVA: 0x1A90C24 Offset: 0x1A8CC24 VA: 0x1A90C24
	public void .ctor() { }
}
