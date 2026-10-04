// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIBufferIcon : MonoBehaviour // TypeDefIndex: 6482
{
	// Fields
	[SerializeField]
	private GameObject supportBufferIcon; // 0x20
	private Dictionary<SkillId, GameObject> skillBuffer; // 0x28
	private SkillBufferManager skillBufferManager; // 0x30
	private Dictionary<SkillId, UISupportBufferIcon> skillBuffLimitLabel; // 0x38
	private Dictionary<SkillComboType, GameObject> skillComboBuffer; // 0x40
	private Dictionary<SkillComboType, UISupportBufferIcon> skillComboBuffLimitLabel; // 0x48
	private Dictionary<BonusType, GameObject> bonusBuffer; // 0x50
	private BonusManager bonusManager; // 0x58
	private Dictionary<BonusType, UISupportBufferIcon> bonusBuffLimitLabel; // 0x60
	private Dictionary<BonusType, GameObject> bonusDebuff; // 0x68
	private Dictionary<BonusType, UISupportBufferIcon> bonusDebuffLimitLabel; // 0x70
	private Dictionary<AbnormalType, GameObject> abnormalBuffer; // 0x78
	private AbnormalStateManager abnormalStateManager; // 0x80
	private Dictionary<AbnormalType, UISupportBufferIcon> abnormalBuffLimitLabel; // 0x88
	private UIBufferIcon.IconManager<BonusType, GameObject> equipBuffer; // 0x90
	private EquipBuffManager equipBuffManager; // 0x98
	private Dictionary<ItemDBData.EquipType, GameObject> randomPropertyBuffer; // 0xA0
	private ItemRandomPropertyManager itemRandomPropertyManager; // 0xA8
	private Dictionary<ItemDBData.EquipType, UISupportBufferIcon> randomPropertyLimitLabel; // 0xB0
	private GameObject gemBonus; // 0xB8
	private int gemBuffNum; // 0xC0
	private const int iconPrintMax = 11;
	private int nextViewIconIndex; // 0xC4
	private float changeViewIconTimer; // 0xC8
	private PlayerDataManager playerDataManager; // 0xD0
	private SystemTextManager systemTextManager; // 0xD8
	private const int LimitPrintMaxSeconds = 356400;
	private List<SkillId> checkSkillList; // 0xE0
	private readonly SkillId[] nonPrintSkillList; // 0xE8
	private List<SkillId> nonTimePrintSkillList; // 0xF0
	private List<UISupportBufferIcon> bufferIconList; // 0xF8
	private int lastFieldId; // 0x100
	private bool isIconUpdate; // 0x104
	private byte optionFlag; // 0x105
	[SerializeField]
	private float iconInterval; // 0x108
	[SerializeField]
	private bool isCenter; // 0x10C

	// Methods

	// RVA: 0x194DAD0 Offset: 0x1949AD0 VA: 0x194DAD0
	public void Initialize(BonusManager bonus, SkillBufferManager skillBuffer, AbnormalStateManager abnormalState, EquipBuffManager equipBuffManager) { }

	// RVA: 0x194DCEC Offset: 0x1949CEC VA: 0x194DCEC
	private void Update() { }

	// RVA: 0x1953350 Offset: 0x194F350 VA: 0x1953350
	private UISupportBufferIcon AddBufferIcon(Vector3 pos) { }

	// RVA: 0x1955270 Offset: 0x1951270 VA: 0x1955270
	private UISupportBufferIcon AddComboIcon(Vector3 pos) { }

	// RVA: 0x19556F0 Offset: 0x19516F0 VA: 0x19556F0
	private void RemoveIcon(GameObject bufferIconObject) { }

	// RVA: 0x19537A4 Offset: 0x194F7A4 VA: 0x19537A4
	private string BuffLimitText(int seconds) { }

	// RVA: 0x195391C Offset: 0x194F91C VA: 0x195391C
	private void SetSkillBufferType(SkillBufferDataBase data, UISupportBufferIcon icon) { }

	// RVA: 0x1953ABC Offset: 0x194FABC VA: 0x1953ABC
	private void SetSkillBufferText(SkillBufferDataBase data, UISupportBufferIcon icon) { }

	// RVA: 0x195305C Offset: 0x194F05C VA: 0x195305C
	private void BufferIconRemove() { }

	// RVA: 0x19544F4 Offset: 0x19504F4 VA: 0x19544F4
	private void IconPositionSort() { }

	// RVA: 0x195423C Offset: 0x195023C VA: 0x195423C
	private bool IsIconPositionDuplication() { }

	// RVA: 0x19557E0 Offset: 0x19517E0 VA: 0x19557E0
	public void .ctor() { }
}
