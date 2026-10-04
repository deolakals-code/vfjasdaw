// Assembly: Assembly-CSharp.dll
// Namespace: 
public class EventAreaManager : TargetableListManagerBase<EventAreaManager>, ISceneChangeManager // TypeDefIndex: 3819
{
	// Fields
	private const int EscapeId = -1;
	private List<EventArea> eventAreaList; // 0x28
	private List<EventArea> autoEventAreaList; // 0x30
	private Dictionary<int, EventArea> dynamicEventArea; // 0x38
	private Dictionary<int, EventAreaManager.TimeEventArea> timeEventAreaList; // 0x40
	private List<EventArea> listupEventList; // 0x48
	private EventArea lastExecAutoEventArea; // 0x50
	private EventArea insideEventArea; // 0x58
	private EventArea targetEventArea; // 0x60
	private PlayerDataManager playerDataManager; // 0x68
	private Transform playerTransform; // 0x70
	protected CharacterMove playerMove; // 0x78
	private bool autoPopLabel; // 0x80
	private bool checkPopLabel; // 0x81
	private GuardActionManager guardManager; // 0x88
	[CompilerGenerated]
	private CompanionEventAreaManager <CompanionEventAreaManager>k__BackingField; // 0x90

	// Properties
	public GameObject InsidePlayerEventArea { get; }
	public EventArea.MiniMapType InsideEventAreaContent { get; }
	public bool AutoPopLabel { get; set; }
	public CompanionEventAreaManager CompanionEventAreaManager { get; set; }

	// Methods

	// RVA: 0x23EDE0C Offset: 0x23E9E0C VA: 0x23EDE0C
	public GameObject get_InsidePlayerEventArea() { }

	// RVA: 0x23EDE94 Offset: 0x23E9E94 VA: 0x23EDE94
	public EventArea.MiniMapType get_InsideEventAreaContent() { }

	// RVA: 0x23EDF28 Offset: 0x23E9F28 VA: 0x23EDF28
	public bool get_AutoPopLabel() { }

	// RVA: 0x23EDF30 Offset: 0x23E9F30 VA: 0x23EDF30
	public void set_AutoPopLabel(bool value) { }

	[CompilerGenerated]
	// RVA: 0x23EDF48 Offset: 0x23E9F48 VA: 0x23EDF48
	public CompanionEventAreaManager get_CompanionEventAreaManager() { }

	[CompilerGenerated]
	// RVA: 0x23EDF50 Offset: 0x23E9F50 VA: 0x23EDF50
	private void set_CompanionEventAreaManager(CompanionEventAreaManager value) { }

	// RVA: 0x23EDF58 Offset: 0x23E9F58 VA: 0x23EDF58
	private void Start() { }

	// RVA: 0x23EE004 Offset: 0x23EA004 VA: 0x23EE004
	private void Update() { }

	// RVA: 0x23EFB90 Offset: 0x23EBB90 VA: 0x23EFB90
	public void SelectTarget(GameObject target) { }

	// RVA: 0x23EFC74 Offset: 0x23EBC74 VA: 0x23EFC74
	public void ClearTarget() { }

	// RVA: 0x23EFCD8 Offset: 0x23EBCD8 VA: 0x23EFCD8
	public void ClearInsideEventArea() { }

	// RVA: 0x23EFD3C Offset: 0x23EBD3C VA: 0x23EFD3C Slot: 9
	public void OnEnter() { }

	// RVA: 0x23EFDC0 Offset: 0x23EBDC0 VA: 0x23EFDC0 Slot: 10
	public void OnLeave() { }

	// RVA: 0x23F028C Offset: 0x23EC28C VA: 0x23F028C
	public void InitEventAreaData() { }

	// RVA: 0x23F0560 Offset: 0x23EC560 VA: 0x23F0560
	public void SetEventArea(IList<EventArea> eventList) { }

	// RVA: 0x23F0CE4 Offset: 0x23ECCE4 VA: 0x23F0CE4
	public void EventReserve(GameObject target) { }

	// RVA: 0x23EF4FC Offset: 0x23EB4FC VA: 0x23EF4FC
	private void eventStart(EventArea eventArea) { }

	// RVA: 0x23EA254 Offset: 0x23E6254 VA: 0x23EA254
	public void AddDynamicEventArea(int id, EventArea eventArea) { }

	// RVA: 0x23EB404 Offset: 0x23E7404 VA: 0x23EB404
	public void RemoveDynamicEventArea(int id) { }

	// RVA: 0x23F0FE0 Offset: 0x23ECFE0 VA: 0x23F0FE0
	public bool TryGetEscapeTime(out float time) { }

	// RVA: 0x23F1080 Offset: 0x23ED080 VA: 0x23F1080
	public void AddEscapeEventArea(int id, EventArea eventArea) { }

	// RVA: 0x23F12A4 Offset: 0x23ED2A4 VA: 0x23F12A4
	public void RemoveEscapeEventArea(int id) { }

	// RVA: 0x23F1478 Offset: 0x23ED478 VA: 0x23F1478
	public bool CheckAutoEventArea(Vector3 position, out byte type) { }

	// RVA: 0x23F1824 Offset: 0x23ED824 VA: 0x23F1824
	public EventArea[] GetEventList(EventArea.MiniMapType[] types) { }

	// RVA: 0x23F18AC Offset: 0x23ED8AC VA: 0x23F18AC Slot: 6
	public override ValueTuple<GameObject, float> GetNearInCameraTarget(Vector3 pos, float rad, float height, GameObject exclusions) { }

	// RVA: 0x23F1CC0 Offset: 0x23EDCC0 VA: 0x23F1CC0 Slot: 7
	public override ValueTuple<GameObject, float> GetFarInCameraTarget(Vector3 pos, float rad, float height, GameObject exclusions) { }

	// RVA: 0x23F20D4 Offset: 0x23EE0D4 VA: 0x23F20D4
	public void .ctor() { }
}
