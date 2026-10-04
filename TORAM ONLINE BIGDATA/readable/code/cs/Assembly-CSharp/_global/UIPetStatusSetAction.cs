// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPetStatusSetAction : MonoBehaviour // TypeDefIndex: 7875
{
	// Fields
	private UIPetStatusSetAction.UseOperation useOpe; // 0x20
	[SerializeField]
	private GameObject[] setActionPanelObject; // 0x28
	[SerializeField]
	private GameObject setActionElementObj; // 0x30
	private List<GameObject> NowActionList; // 0x38
	[SerializeField]
	private GameObject[] setActionMainElements; // 0x40
	[SerializeField]
	private UIScrollWindow fullscreenWindow; // 0x48
	[SerializeField]
	private GameObject scrollCameraObj; // 0x50
	[SerializeField]
	private UIImageButton setSkillButton; // 0x58
	private List<PetSkillData> haveSkillList; // 0x60
	private UIPetStatusSetAction.Panel panelState; // 0x68
	private SystemTextManager systemTextManager; // 0x70
	private SkillTextManager skillTextManager; // 0x78
	private SkillTextManagerData textData; // 0x80
	private UIPetStatusManager statusManager; // 0x88
	private PetAttackPatternData petAttackPatternData; // 0x90
	private List<PetAttackPatternData.PatternData> patternList; // 0x98
	private Vector3 cameraPos; // 0xA0
	private ItemType weaponType; // 0xAC
	private bool isCalm; // 0xAE
	private bool isTimid; // 0xAF
	private const int elementMax = 6;
	private const float elementX = 910;

	// Methods

	// RVA: 0x1C48F9C Offset: 0x1C44F9C VA: 0x1C48F9C
	public static bool IsNearAtk(ItemType weaponType) { }

	// RVA: 0x1C48FC4 Offset: 0x1C44FC4 VA: 0x1C48FC4
	public static bool IsPhysicalAttack(SkillId id) { }

	// RVA: 0x1C48FEC Offset: 0x1C44FEC VA: 0x1C48FEC
	public static bool IsMagicAttack(SkillId id) { }

	// RVA: 0x1C49014 Offset: 0x1C45014 VA: 0x1C49014
	public static bool IsSpecialAttack(SkillId id) { }

	// RVA: 0x1C4902C Offset: 0x1C4502C VA: 0x1C4902C
	public static bool IsPassive(SkillId id) { }

	// RVA: 0x1C49054 Offset: 0x1C45054 VA: 0x1C49054
	private bool IsBuff(SkillId id) { }

	// RVA: 0x1C41298 Offset: 0x1C3D298 VA: 0x1C41298
	public static bool IsSupport(SkillId id) { }

	// RVA: 0x1C4907C Offset: 0x1C4507C VA: 0x1C4907C
	public static bool IsOverEight(SkillId id, ItemType weaponType) { }

	// RVA: 0x1C490F8 Offset: 0x1C450F8 VA: 0x1C490F8
	public static bool IsDependEquip(SkillId id) { }

	// RVA: 0x1C49134 Offset: 0x1C45134 VA: 0x1C49134
	private bool IsAttackSkill(SkillId id) { }

	// RVA: 0x1C4675C Offset: 0x1C4275C VA: 0x1C4675C
	public void Initialize(UIPetStatusManager manager) { }

	// RVA: 0x1C49170 Offset: 0x1C45170 VA: 0x1C49170
	private void InitNowAction(int id, PetSkillData data, bool on) { }

	// RVA: 0x1C47B40 Offset: 0x1C43B40 VA: 0x1C47B40
	public void ClearMenu() { }

	// RVA: 0x1C47030 Offset: 0x1C43030 VA: 0x1C47030
	public void CreateSetActionScroll(int state) { }

	// RVA: 0x1C49B80 Offset: 0x1C45B80 VA: 0x1C49B80
	private void CreateFirstExp(float height) { }

	// RVA: 0x1C4A7E0 Offset: 0x1C467E0 VA: 0x1C4A7E0
	private void CreateCantSetSkill(float height, int personaType) { }

	// RVA: 0x1C4AF70 Offset: 0x1C46F70 VA: 0x1C4AF70
	private void CreateSetCanMessage(float height) { }

	// RVA: 0x1C49FCC Offset: 0x1C45FCC VA: 0x1C49FCC
	private void CreateNormalAtk(float height, int param, PetSkillData data) { }

	// RVA: 0x1C4A9D4 Offset: 0x1C469D4 VA: 0x1C4A9D4
	private void CreateSetSkill(float height, int param, int skillId, bool onFlag, bool calmAttack, bool timidAttack) { }

	// RVA: 0x1C4B1A0 Offset: 0x1C471A0 VA: 0x1C4B1A0
	private void CreateSetPattern(float height, int param, int index, PetSkillData skillData, bool normalMagicAtk, int actionNum) { }

	// RVA: 0x1C4BBE8 Offset: 0x1C47BE8 VA: 0x1C4BBE8
	private void onSelectAction(int param) { }

	// RVA: 0x1C4BDE4 Offset: 0x1C47DE4 VA: 0x1C4BDE4
	private void onSelectPattern(int param) { }

	[IteratorStateMachine(typeof(UIPetStatusSetAction.<PetSkillSet>d__48))]
	// RVA: 0x1C4BD50 Offset: 0x1C47D50 VA: 0x1C4BD50
	private IEnumerator PetSkillSet(byte no, int id, byte motion) { }

	// RVA: 0x1C4C094 Offset: 0x1C48094 VA: 0x1C4C094
	public void .ctor() { }
}
