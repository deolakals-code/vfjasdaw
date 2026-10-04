// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIEquipRepairAbilityPanel : MonoBehaviour // TypeDefIndex: 7009
{
	// Fields
	[SerializeField]
	private GameObject basePanel; // 0x20
	[SerializeField]
	private GameObject mainPanel; // 0x28
	[SerializeField]
	private GameObject expPanel; // 0x30
	[SerializeField]
	private GameObject listPanel; // 0x38
	[SerializeField]
	private GameObject loadPanel; // 0x40
	[SerializeField]
	private GameObject resultPanel; // 0x48
	[SerializeField]
	private GameObject titleObj; // 0x50
	private UILabel titleLabel; // 0x58
	private UISprite titleIcon; // 0x60
	[SerializeField]
	private UIImageButton imageButton; // 0x68
	private UIButtonMessage buttonMessage; // 0x70
	private UILabel buttonLabel; // 0x78
	private UIIcon buttonItemIcon; // 0x80
	private UIButtonColor buttonColor; // 0x88
	[SerializeField]
	private UILabel isUseLabel; // 0x90
	[SerializeField]
	private UISlider loadSlider; // 0x98
	[SerializeField]
	private UILabel loadLabel; // 0xA0
	[SerializeField]
	private GameObject scrollWindowObject; // 0xA8
	private UIScrollWindow scrollWindow; // 0xB0
	[SerializeField]
	private GameObject scrollCameraObj; // 0xB8
	[SerializeField]
	private UILabel scrollLabel; // 0xC0
	[SerializeField]
	private GameObject[] abilityElement; // 0xC8
	private UIQuestBoradPopLabel[] abilityPopLabel; // 0xD0
	private TweenAlpha[] abilityAlpha; // 0xD8
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; // 0xE0
	[CompilerGenerated]
	private bool <IsOpenList>k__BackingField; // 0xE1
	private UIEquipEnchantPanel enchantPanel; // 0xE8
	private ItemData selectItem; // 0xF0
	private ItemDBData.EquipType selectEquipType; // 0xF8
	private OrbManager orbManager; // 0x100
	private bool orbInitConnect; // 0x108
	private int orbItemNum; // 0x10C
	private int orbNum; // 0x110
	private const int buyOrbNum = 2;
	private PlayerDataManager playerDataManager; // 0x118
	private SystemTextManager systemTextManager; // 0x120
	private ItemTextManager itemTextManager; // 0x128
	private bool inputLock; // 0x130
	private float loadingTimer; // 0x134
	private GameObject loadingObject; // 0x138
	private Coroutine loadCoroutine; // 0x140
	private Action resultAction; // 0x148
	private Action buyAction; // 0x150

	// Properties
	public bool IsOpen { get; set; }
	public bool IsOpenList { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1A71418 Offset: 0x1A6D418 VA: 0x1A71418
	public bool get_IsOpen() { }

	[CompilerGenerated]
	// RVA: 0x1A71420 Offset: 0x1A6D420 VA: 0x1A71420
	private void set_IsOpen(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1A7142C Offset: 0x1A6D42C VA: 0x1A7142C
	public bool get_IsOpenList() { }

	[CompilerGenerated]
	// RVA: 0x1A71434 Offset: 0x1A6D434 VA: 0x1A71434
	private void set_IsOpenList(bool value) { }

	// RVA: 0x1A71440 Offset: 0x1A6D440 VA: 0x1A71440
	private void Start() { }

	// RVA: 0x1A718D4 Offset: 0x1A6D8D4 VA: 0x1A718D4
	public void Initialize(UIEquipEnchantPanel panel, ItemData selectItem, ItemDBData.EquipType selectEquipType, int haveOrbItem, int haveOrb, Action resultAction, Action buyAction) { }

	// RVA: 0x1A71F38 Offset: 0x1A6DF38 VA: 0x1A71F38
	public void WindowClose() { }

	// RVA: 0x1A72064 Offset: 0x1A6E064 VA: 0x1A72064
	private void onCheck() { }

	// RVA: 0x1A72288 Offset: 0x1A6E288 VA: 0x1A72288
	private void onStartRepair() { }

	// RVA: 0x1A72688 Offset: 0x1A6E688 VA: 0x1A72688
	private void EndRepair() { }

	// RVA: 0x1A726B8 Offset: 0x1A6E6B8 VA: 0x1A726B8
	private void onClose() { }

	// RVA: 0x1A71E00 Offset: 0x1A6DE00 VA: 0x1A71E00
	private void SetButton(bool color, bool icon, string text, string functionName) { }

	[IteratorStateMachine(typeof(UIEquipRepairAbilityPanel.<ActiveFalsePanel>d__57))]
	// RVA: 0x1A71FF8 Offset: 0x1A6DFF8 VA: 0x1A71FF8
	private IEnumerator ActiveFalsePanel() { }

	[IteratorStateMachine(typeof(UIEquipRepairAbilityPanel.<WaitRepair>d__58))]
	// RVA: 0x1A7261C Offset: 0x1A6E61C VA: 0x1A7261C
	private IEnumerator WaitRepair() { }

	[IteratorStateMachine(typeof(UIEquipRepairAbilityPanel.<ConnectRepair>d__59))]
	// RVA: 0x1A72780 Offset: 0x1A6E780 VA: 0x1A72780
	private IEnumerator ConnectRepair() { }

	[IteratorStateMachine(typeof(UIEquipRepairAbilityPanel.<ConnectServiceBuyFairySewingTools>d__60))]
	// RVA: 0x1A725B0 Offset: 0x1A6E5B0 VA: 0x1A725B0
	private IEnumerator ConnectServiceBuyFairySewingTools() { }

	// RVA: 0x1A7283C Offset: 0x1A6E83C VA: 0x1A7283C
	public void .ctor() { }
}
