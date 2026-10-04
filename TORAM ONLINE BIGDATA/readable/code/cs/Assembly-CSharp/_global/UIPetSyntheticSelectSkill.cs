// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPetSyntheticSelectSkill : MonoBehaviour, IUIPetSynthetic // TypeDefIndex: 7766
{
	// Fields
	[SerializeField]
	private GameObject leftSkillPanel; // 0x20
	[SerializeField]
	private GameObject[] leftSkillObj; // 0x28
	[SerializeField]
	private GameObject rightSkillPanel; // 0x30
	[SerializeField]
	private GameObject[] rightSkillObj; // 0x38
	private Action<int[], int[]> getAction; // 0x40
	private int[] selectedSkill; // 0x48
	private int[] selectedSkillLv; // 0x50
	private PetSkillData[] leftSkillData; // 0x58
	private int leftSelectedId; // 0x60
	private int rightSelectedId; // 0x64
	private PetSkillData[] rightSkillData; // 0x68
	private SystemTextManager systemTextManager; // 0x70
	private SkillTextManager skillTextManager; // 0x78
	private SkillTextManagerData skillTextManagerData; // 0x80
	private UIImageButton mainButton; // 0x88
	private Coroutine endCoroutine; // 0x90

	// Methods

	// RVA: 0x1C099B0 Offset: 0x1C059B0 VA: 0x1C099B0
	public void Initialize(int leftSkillId, int rightSkillId, PetSkillData[] leftSkillData, PetSkillData[] rightSkillData, Action<int[], int[]> getAction) { }

	// RVA: 0x1C0A87C Offset: 0x1C0687C VA: 0x1C0A87C Slot: 4
	public void InitMainButton(UIImageButton mainButton) { }

	// RVA: 0x1C0A898 Offset: 0x1C06898 VA: 0x1C0A898
	private void SetMainButton() { }

	// RVA: 0x1C0A9A8 Offset: 0x1C069A8 VA: 0x1C0A9A8 Slot: 5
	public void ClosePanel() { }

	[IteratorStateMachine(typeof(UIPetSyntheticSelectSkill.<CloseAndDisnablePanel>d__20))]
	// RVA: 0x1C0A9D8 Offset: 0x1C069D8 VA: 0x1C0A9D8
	private IEnumerator CloseAndDisnablePanel() { }

	// RVA: 0x1C0AA6C Offset: 0x1C06A6C VA: 0x1C0AA6C Slot: 6
	public void ResetElementPos() { }

	// RVA: 0x1C0AAD4 Offset: 0x1C06AD4 VA: 0x1C0AAD4
	private void onLeftSkill(int param) { }

	// RVA: 0x1C0AC20 Offset: 0x1C06C20 VA: 0x1C0AC20
	private void onRightSkill(int param) { }

	// RVA: 0x1C0AD74 Offset: 0x1C06D74 VA: 0x1C0AD74
	private void onNext() { }

	// RVA: 0x1C09C98 Offset: 0x1C05C98 VA: 0x1C09C98
	private void SetLeftSkillPanel() { }

	// RVA: 0x1C0A288 Offset: 0x1C06288 VA: 0x1C0A288
	private void SetRightSkillPanel() { }

	// RVA: 0x1C0AD9C Offset: 0x1C06D9C VA: 0x1C0AD9C
	public void .ctor() { }
}
