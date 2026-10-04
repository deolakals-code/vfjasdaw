// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIRhythmNotesManager : MonoBehaviour // TypeDefIndex: 6237
{
	// Fields
	[SerializeField]
	private GameObject notesBaseObj; // 0x20
	[SerializeField]
	private GameObject notesObj; // 0x28
	[SerializeField]
	private GameObject notesEffObj; // 0x30
	[SerializeField]
	private GameObject skillIconObj; // 0x38
	[SerializeField]
	private GameObject arrowObj; // 0x40
	[SerializeField]
	private GameObject buttonEffectObj; // 0x48
	[SerializeField]
	private GameObject moveNotesObj; // 0x50
	private UIRhythmNotesManager.NotesState notesState; // 0x58
	private Camera uiCamera; // 0x60
	private float bgmPosition; // 0x68
	private float dspTimeBGM; // 0x6C
	private float playPauseTime; // 0x70
	private float pauseDspTime; // 0x74
	private List<RhythmNotesData> notesDataList; // 0x78
	private const float WaitTime = 4;
	private float startWaitTime; // 0x80
	private float initStartTime; // 0x84
	private float initWaitTime; // 0x88
	private Action missAction; // 0x90
	private Action playAction; // 0x98
	private Action startAction; // 0xA0
	private Action endAction; // 0xA8
	private Action readyAction; // 0xB0
	private bool isStart; // 0xB8
	private bool isFadeOut; // 0xB9
	private const float arrowMoveMaxPos = 5;
	private RhythmMusicData musicData; // 0xC0
	private RhythmGameManager manager; // 0xC8
	private Action<int, int> tapAction; // 0xD0
	private UIAtlas notesAtlas; // 0xD8
	private Material notesBaseMaterial; // 0xE0
	private Material notesEffMaterial; // 0xE8
	private Material arrowMaterial; // 0xF0
	private Material skillIconMaterial; // 0xF8
	private Material buttonEffMaterial; // 0x100
	private Material moveNotesMaterial; // 0x108
	private Rect[] notesUV; // 0x110
	private Rect notesBaseUV; // 0x118
	private Rect notesEffUV; // 0x128
	private Rect skillIconUV; // 0x138
	private Rect arrowUV; // 0x148
	private Rect buttonEffUV; // 0x158
	private Rect moveNoteUV; // 0x168
	private List<RhythmButtonEffectData> notesEffectDataList; // 0x178
	private List<RhythmButtonEffectData> buttonEffDataList; // 0x180
	private List<Material> notesMaterialList; // 0x188
	private float[] notesScale; // 0x190
	private RhythmArrowStatusData[] arrowStatus; // 0x198
	private Vector3[] buttonPos; // 0x1A0
	private Vector3 buttonScale; // 0x1A8
	private float baseButtonAlpha; // 0x1B4
	private const float buttonMaxSize = 98;
	private const float effectMinSize = 100;
	private List<UIGLLabel> glLabelList; // 0x1B8

	// Properties
	public bool IsPause { get; }
	public bool IsCanTap { get; }
	public bool IsPlay { get; }

	// Methods

	// RVA: 0x18C2654 Offset: 0x18BE654 VA: 0x18C2654
	public bool get_IsPause() { }

	// RVA: 0x18C2664 Offset: 0x18BE664 VA: 0x18C2664
	public bool get_IsCanTap() { }

	// RVA: 0x18C2678 Offset: 0x18BE678 VA: 0x18C2678
	public bool get_IsPlay() { }

	// RVA: 0x18C2688 Offset: 0x18BE688 VA: 0x18C2688
	private void Start() { }

	// RVA: 0x18C26DC Offset: 0x18BE6DC VA: 0x18C26DC
	private void Update() { }

	// RVA: 0x18C3288 Offset: 0x18BF288 VA: 0x18C3288
	private void OnRenderObject() { }

	// RVA: 0x18C4244 Offset: 0x18C0244 VA: 0x18C4244
	private void OnDestroy() { }

	// RVA: 0x18C4248 Offset: 0x18C0248 VA: 0x18C4248
	private void OnApplicationPause(bool pauseStatus) { }

	// RVA: 0x18C43D4 Offset: 0x18C03D4 VA: 0x18C43D4
	public void Initialize(Vector3 buttonScale, Vector3[] buttonPos, Action missAction, Action readyAction, Action playAction, Action startAction, Action endAction) { }

	// RVA: 0x18C452C Offset: 0x18C052C VA: 0x18C452C Slot: 4
	public virtual bool HitCheck(int lane, RhythmNotesData.NotesType note, out RhythmNotesData.RankType type, out bool isSynchro) { }

	// RVA: 0x18C4728 Offset: 0x18C0728 VA: 0x18C4728
	public bool CheckNearFlickNotes(int lane, out RhythmNotesData.NotesType type) { }

	// RVA: 0x18C4828 Offset: 0x18C0828 VA: 0x18C4828
	public void ShakeFlickArrow(int lane, RhythmNotesData.NotesType type) { }

	// RVA: 0x18C49EC Offset: 0x18C09EC VA: 0x18C49EC
	public void StopShakeFlickArrow(int lane) { }

	// RVA: 0x18C4A68 Offset: 0x18C0A68 VA: 0x18C4A68
	public bool PopButtonEffect(int buttonId, Color color, RhythmNotesData.NotesType type) { }

	// RVA: 0x18C4B84 Offset: 0x18C0B84 VA: 0x18C4B84
	public void PlayPause() { }

	// RVA: 0x18C4BA8 Offset: 0x18C0BA8 VA: 0x18C4BA8
	public void AddGLLabel(UIGLLabel glLabel) { }

	// RVA: 0x18C4260 Offset: 0x18C0260 VA: 0x18C4260
	private void ChangeNotesState(UIRhythmNotesManager.NotesState nextState) { }

	[IteratorStateMachine(typeof(UIRhythmNotesManager.<InitCoroutine>d__75))]
	// RVA: 0x18C4C8C Offset: 0x18C0C8C VA: 0x18C4C8C
	private IEnumerator InitCoroutine() { }

	[IteratorStateMachine(typeof(UIRhythmNotesManager.<ChangeButtonAlpha>d__76))]
	// RVA: 0x18C4D20 Offset: 0x18C0D20 VA: 0x18C4D20
	private IEnumerator ChangeButtonAlpha(float startAlpha, float endAlpha, float time) { }

	// RVA: 0x18C4DD8 Offset: 0x18C0DD8 VA: 0x18C4DD8
	private void InitNotes() { }

	// RVA: 0x18C50C0 Offset: 0x18C10C0 VA: 0x18C50C0
	private void InitMaterial() { }

	// RVA: 0x18C2710 Offset: 0x18BE710 VA: 0x18C2710
	private bool UpdateNotesState() { }

	// RVA: 0x18C2934 Offset: 0x18BE934 VA: 0x18C2934
	private void UpdateNotes() { }

	// RVA: 0x18C2D84 Offset: 0x18BED84 VA: 0x18C2D84
	private void UpdateNotesEffect() { }

	// RVA: 0x18C2F08 Offset: 0x18BEF08 VA: 0x18C2F08
	private void UpdateButtonEffect() { }

	// RVA: 0x18C410C Offset: 0x18C010C VA: 0x18C410C
	private Rect GetNotesUV(RhythmNotesData.NotesType type) { }

	// RVA: 0x18C5DC4 Offset: 0x18C1DC4 VA: 0x18C5DC4
	private Color GetNotesEffectColor(RhythmNotesData.NotesType type) { }

	// RVA: 0x18C5DF4 Offset: 0x18C1DF4 VA: 0x18C5DF4 Slot: 5
	protected virtual Vector3 GetArrowVector3(int id, RhythmNotesData.NotesType type, Vector3 pos, float size, int lane) { }

	// RVA: 0x18C5EF4 Offset: 0x18C1EF4 VA: 0x18C5EF4
	private Vector3 GetArrowRotation(RhythmNotesData.NotesType type) { }

	// RVA: 0x18C5F6C Offset: 0x18C1F6C VA: 0x18C5F6C Slot: 6
	protected virtual Color GetArrowColor(RhythmNotesData.NotesType type, int lane) { }

	// RVA: 0x18C4868 Offset: 0x18C0868 VA: 0x18C4868
	private Vector3 GetArrowShakePos(int lane) { }

	// RVA: 0x18C5FA8 Offset: 0x18C1FA8 VA: 0x18C5FA8
	public void .ctor() { }
}
