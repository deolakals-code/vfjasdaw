// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPetStatusEducation : MonoBehaviour // TypeDefIndex: 7857
{
	// Fields
	private UIPetStatusEducation.Training training; // 0x20
	[SerializeField]
	private GameObject menuPanel; // 0x28
	[SerializeField]
	private GameObject trainingMenuObj; // 0x30
	[SerializeField]
	private GameObject executionPanel; // 0x38
	private GameObject loadObj; // 0x40
	private GameObject resultObj; // 0x48
	[SerializeField]
	private UILabel trainingLabel; // 0x50
	[SerializeField]
	private GameObject difficultyPanel; // 0x58
	private UILabel difficultyLabel; // 0x60
	[SerializeField]
	private UIImageButton treeCheckButton; // 0x68
	[SerializeField]
	private GameObject rateStudyObj; // 0x70
	[SerializeField]
	private UILabel[] contentLabel; // 0x78
	[SerializeField]
	private UIImageButton teachButton; // 0x80
	[SerializeField]
	private UIImageButton orbTeachButton; // 0x88
	[SerializeField]
	private UILabel[] selectedTrainingLabel; // 0x90
	[SerializeField]
	private GameObject selectedSkillObj; // 0x98
	[SerializeField]
	private UISlider loadSlider; // 0xA0
	private Coroutine loadCoroutine; // 0xA8
	[SerializeField]
	private UILabel loadLabel; // 0xB0
	[SerializeField]
	private UILabel resultLabel; // 0xB8
	[SerializeField]
	private GameObject resultSkillLabel; // 0xC0
	[SerializeField]
	private UISprite[] healthIcon; // 0xC8
	[SerializeField]
	private GameObject useOrbObj; // 0xD0
	[SerializeField]
	private GameObject finishTeachPanel; // 0xD8
	[SerializeField]
	private UIIruna2Anchor orbPanel; // 0xE0
	[SerializeField]
	private UILabel orbLabel; // 0xE8
	[CompilerGenerated]
	private bool <IsLoad>k__BackingField; // 0xF0
	private PetTrainingType selectTrainingType; // 0xF4
	private PetTrainingType trainingDifficulty; // 0xF8
	private int orbNum; // 0xFC
	private SystemTextManager systemTextManager; // 0x100
	private SkillTextManager skillTextManager; // 0x108
	private float loadingTimer; // 0x110
	private GameObject loadingObject; // 0x118
	private int petId; // 0x120
	private UIPetStatusManager statusManager; // 0x128
	private string[] trainigContent; // 0x130
	private bool trainingFinishFlag; // 0x138
	private readonly int rateEasy; // 0x13C
	private readonly int rateHard; // 0x140
	private readonly int ratePremium; // 0x144
	private static readonly int[] petSkills; // 0x0

	// Properties
	public bool IsLoad { get; set; }
	public bool IsExecution { get; }
	public PetTrainingType SelectTrainingType { get; }

	// Methods

	// RVA: 0x1C3CA20 Offset: 0x1C38A20 VA: 0x1C3CA20
	private void UseOrbButtonEnableToTrue() { }

	[CompilerGenerated]
	// RVA: 0x1C3CA40 Offset: 0x1C38A40 VA: 0x1C3CA40
	public bool get_IsLoad() { }

	[CompilerGenerated]
	// RVA: 0x1C3CA48 Offset: 0x1C38A48 VA: 0x1C3CA48
	private void set_IsLoad(bool value) { }

	// RVA: 0x1C3CA54 Offset: 0x1C38A54 VA: 0x1C3CA54
	public bool get_IsExecution() { }

	// RVA: 0x1C3CA70 Offset: 0x1C38A70 VA: 0x1C3CA70
	public PetTrainingType get_SelectTrainingType() { }

	// RVA: 0x1C3CA78 Offset: 0x1C38A78 VA: 0x1C3CA78
	public void UpdateTrainingContent() { }

	// RVA: 0x1C3D740 Offset: 0x1C39740 VA: 0x1C3D740
	public void MoveOrbPanel(bool flag) { }

	// RVA: 0x1C3D780 Offset: 0x1C39780 VA: 0x1C3D780
	public void Initialize(UIPetStatusManager manager, int petId) { }

	// RVA: 0x1C3D9A4 Offset: 0x1C399A4 VA: 0x1C3D9A4
	private void UIinit() { }

	// RVA: 0x1C3DB84 Offset: 0x1C39B84 VA: 0x1C3DB84
	private void NowTrainingMenu() { }

	// RVA: 0x1C3DD10 Offset: 0x1C39D10 VA: 0x1C3DD10
	private void NowDifficulty() { }

	// RVA: 0x1C3CA7C Offset: 0x1C38A7C VA: 0x1C3CA7C
	private void TrainingContent() { }

	// RVA: 0x1C3E078 Offset: 0x1C3A078 VA: 0x1C3E078
	private int CanSkillTrainingLevel() { }

	// RVA: 0x1C3E108 Offset: 0x1C3A108 VA: 0x1C3E108
	private bool CheckCanSkillTraining() { }

	// RVA: 0x1C3E724 Offset: 0x1C3A724 VA: 0x1C3E724
	private void onTrainingRight() { }

	// RVA: 0x1C3E764 Offset: 0x1C3A764 VA: 0x1C3E764
	private void onTrainingLeft() { }

	// RVA: 0x1C3E7B0 Offset: 0x1C3A7B0 VA: 0x1C3E7B0
	private void onDifficultyRight() { }

	// RVA: 0x1C3E7DC Offset: 0x1C3A7DC VA: 0x1C3E7DC
	private void onDifficultyLeft() { }

	// RVA: 0x1C3E80C Offset: 0x1C3A80C VA: 0x1C3E80C
	private void onTeach() { }

	// RVA: 0x1C3E9E4 Offset: 0x1C3A9E4 VA: 0x1C3E9E4
	public void StartTeach() { }

	// RVA: 0x1C3ED8C Offset: 0x1C3AD8C VA: 0x1C3ED8C
	public void onCancel() { }

	// RVA: 0x1C3EE1C Offset: 0x1C3AE1C VA: 0x1C3EE1C
	private void onOk() { }

	[IteratorStateMachine(typeof(UIPetStatusEducation.<TrainingLoadBar>d__68))]
	// RVA: 0x1C3ED08 Offset: 0x1C3AD08 VA: 0x1C3ED08
	private IEnumerator TrainingLoadBar(float seconds) { }

	[IteratorStateMachine(typeof(UIPetStatusEducation.<TrainingPet>d__69))]
	// RVA: 0x1C3EFD0 Offset: 0x1C3AFD0 VA: 0x1C3EFD0
	private IEnumerator TrainingPet() { }

	[IteratorStateMachine(typeof(UIPetStatusEducation.<ConnectWait>d__70))]
	// RVA: 0x1C3F044 Offset: 0x1C3B044 VA: 0x1C3F044
	private IEnumerator ConnectWait(OrbManager.ConnectFlag connectFlag) { }

	[IteratorStateMachine(typeof(UIPetStatusEducation.<PetSkillSet>d__71))]
	// RVA: 0x1C3F0C8 Offset: 0x1C3B0C8 VA: 0x1C3F0C8
	private IEnumerator PetSkillSet(byte no, int id, byte motion) { }

	// RVA: 0x1C3F164 Offset: 0x1C3B164 VA: 0x1C3F164
	public void .ctor() { }

	// RVA: 0x1C3F270 Offset: 0x1C3B270 VA: 0x1C3F270
	private static void .cctor() { }
}
