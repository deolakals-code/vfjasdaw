// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIBlackKnightActionButtonPanel : MonoBehaviour // TypeDefIndex: 5824
{
	// Fields
	[SerializeField]
	private UISprite abilityIconBase; // 0x20
	[SerializeField]
	private Transform abilityPanelTrans; // 0x28
	[SerializeField]
	private UISprite skillButtonBase; // 0x30
	[SerializeField]
	private UISprite skillButtonIcon; // 0x38
	private BlackKnightRoomData roomData; // 0x40
	private BlackKnightPlayerManager playerManager; // 0x48
	private bool isDashPress; // 0x50
	private List<UISprite> abilityIconList; // 0x58
	private int nowMp; // 0x60
	private BlackKnightPlayerManager.StateFlag lastActType; // 0x64

	// Methods

	// RVA: 0x17FD3D0 Offset: 0x17F93D0 VA: 0x17FD3D0
	private void Update() { }

	// RVA: 0x17FD6D8 Offset: 0x17F96D8 VA: 0x17FD6D8
	public void Initialize(BlackKnightRoomData roomData) { }

	// RVA: 0x17FD9D8 Offset: 0x17F99D8 VA: 0x17FD9D8
	public void OnClick(int param) { }

	// RVA: 0x17FDA14 Offset: 0x17F9A14 VA: 0x17FDA14
	public void OnPress(bool isPress) { }

	// RVA: 0x17FD668 Offset: 0x17F9668 VA: 0x17FD668
	private string GetMpSpriteName(int id) { }

	// RVA: 0x17FD5E0 Offset: 0x17F95E0 VA: 0x17FD5E0
	private string GetSkillIconName() { }

	// RVA: 0x17FDA20 Offset: 0x17F9A20 VA: 0x17FDA20
	public void .ctor() { }
}
