// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MobPopManager : MonoBehaviour // TypeDefIndex: 1018
{
	// Fields
	[CompilerGenerated]
	private MobObjectManager <MobObjectManager>k__BackingField; // 0x20
	private List<MobPopManager.MobPop> mobPopList; // 0x28
	private MobPopManager.MobPop lastPopPoint; // 0x30
	private Transform targetTransform; // 0x38
	private float popCounter; // 0x40
	private readonly float popInterval; // 0x44
	private int popLimitCounter; // 0x48
	private MonsterPopManager popManager; // 0x50

	// Properties
	private MobObjectManager MobObjectManager { get; set; }
	public int PopPointCount { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1F33F3C Offset: 0x1F2FF3C VA: 0x1F33F3C
	private MobObjectManager get_MobObjectManager() { }

	[CompilerGenerated]
	// RVA: 0x1F33F44 Offset: 0x1F2FF44 VA: 0x1F33F44
	public void set_MobObjectManager(MobObjectManager value) { }

	// RVA: 0x1F33F4C Offset: 0x1F2FF4C VA: 0x1F33F4C
	public int get_PopPointCount() { }

	// RVA: 0x1F33F94 Offset: 0x1F2FF94 VA: 0x1F33F94
	private void Awake() { }

	// RVA: 0x1F33FC8 Offset: 0x1F2FFC8 VA: 0x1F33FC8
	private void Start() { }

	// RVA: 0x1F33FCC Offset: 0x1F2FFCC VA: 0x1F33FCC
	public void PopDataDestroy(bool immediately) { }

	// RVA: 0x1F340C8 Offset: 0x1F300C8 VA: 0x1F340C8
	public void PopDataClear() { }

	// RVA: 0x1F34138 Offset: 0x1F30138 VA: 0x1F34138
	public void Update() { }

	// RVA: 0x1F342BC Offset: 0x1F302BC VA: 0x1F342BC
	public void PopSymbol(int popLocalId) { }

	// RVA: 0x1F3499C Offset: 0x1F3099C VA: 0x1F3499C
	public void AddPopData(MobPopPoint popdata) { }

	// RVA: 0x1F34BC4 Offset: 0x1F30BC4 VA: 0x1F34BC4
	public void SetObjectManager(MobObjectManager objectManager) { }

	// RVA: 0x1F34BCC Offset: 0x1F30BCC VA: 0x1F34BCC
	public void ResetPopData() { }

	// RVA: 0x1F34FB8 Offset: 0x1F30FB8 VA: 0x1F34FB8
	public bool TryGetPopUniqueId(out int popLocalId) { }

	// RVA: 0x1F34FD4 Offset: 0x1F30FD4 VA: 0x1F34FD4
	public void InitializePopManager() { }

	// RVA: 0x1F34FF0 Offset: 0x1F30FF0 VA: 0x1F34FF0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1F350B8 Offset: 0x1F310B8 VA: 0x1F350B8
	private void <Update>b__18_0(MobPopManager.MobPop data) { }
}
