// Assembly: Assembly-CSharp.dll
// Namespace: 
[ExecuteInEditMode]
public class EventArea : MonoBehaviour // TypeDefIndex: 3889
{
	// Fields
	[SerializeField]
	private float rad; // 0x20
	[SerializeField]
	private Vector3 size; // 0x24
	[SerializeField]
	private EventArea.DecisionType decision; // 0x30
	[SerializeField]
	private EventArea.EventType eventType; // 0x34
	[SerializeField]
	private Vector3 targetCursorPos; // 0x38
	[SerializeField]
	private int targetSize; // 0x44
	[SerializeField]
	private bool useTargetCursor; // 0x48
	[SerializeField]
	private bool autoStart; // 0x49
	[SerializeField]
	private bool deadForcingStart; // 0x4A
	[SerializeField]
	private int scriptId; // 0x4C
	[SerializeField]
	private bool autoEventLock; // 0x50
	[SerializeField]
	private bool eventLabelUse; // 0x51
	[SerializeField]
	private int eventTextLabelId; // 0x54
	[SerializeField]
	private int eventTextLabelAddId; // 0x58
	[SerializeField]
	private int execRange; // 0x5C
	[SerializeField]
	private EventArea.MiniMapType miniMapType; // 0x60
	[SerializeField]
	private EventArea.TimeCountType timeType; // 0x64
	[SerializeField]
	private float startTime; // 0x68
	private bool inExecRange; // 0x6C
	private bool inExecRangeY; // 0x6D
	private Cylinder cylinder; // 0x70
	private OBB obb; // 0x78
	private Vector3 worldCursorPos; // 0x80
	private bool isMoveArea; // 0x8C
	[CompilerGenerated]
	private bool <IsInsidePlayer>k__BackingField; // 0x8D

	// Properties
	public int ScriptId { get; }
	public float ExecRange { get; }
	public bool IsInExecRange { get; }
	public float AreaSize { get; }
	public bool UseTargetCursor { get; }
	public Vector3 TargetCursorPosition { get; }
	public int TargetSize { get; }
	public bool IsAutoStart { get; }
	public bool IsDeadForcingStart { get; }
	public bool IsAutoEventLock { get; }
	public bool IsEventLabelUse { get; }
	public int EventTextLabelId { get; }
	public int EventTextLabelAddId { get; }
	public bool IsInsidePlayer { get; set; }
	public EventArea.EventType GetEventType { get; }
	public EventArea.TimeCountType TimeType { get; }
	public EventArea.MiniMapType MiniMap { get; }
	public float StartTime { get; }
	public bool IsMoveArea { get; }

	// Methods

	// RVA: 0x2405D68 Offset: 0x2401D68 VA: 0x2405D68
	public int get_ScriptId() { }

	// RVA: 0x2405D70 Offset: 0x2401D70 VA: 0x2405D70
	public float get_ExecRange() { }

	// RVA: 0x2405D7C Offset: 0x2401D7C VA: 0x2405D7C
	public bool get_IsInExecRange() { }

	// RVA: 0x2405DB0 Offset: 0x2401DB0 VA: 0x2405DB0
	public float get_AreaSize() { }

	// RVA: 0x2405E40 Offset: 0x2401E40 VA: 0x2405E40
	public bool get_UseTargetCursor() { }

	// RVA: 0x2405E48 Offset: 0x2401E48 VA: 0x2405E48
	public Vector3 get_TargetCursorPosition() { }

	// RVA: 0x2405E54 Offset: 0x2401E54 VA: 0x2405E54
	public int get_TargetSize() { }

	// RVA: 0x2405E5C Offset: 0x2401E5C VA: 0x2405E5C
	public bool get_IsAutoStart() { }

	// RVA: 0x2405E64 Offset: 0x2401E64 VA: 0x2405E64
	public bool get_IsDeadForcingStart() { }

	// RVA: 0x2405E6C Offset: 0x2401E6C VA: 0x2405E6C
	public bool get_IsAutoEventLock() { }

	// RVA: 0x2405E74 Offset: 0x2401E74 VA: 0x2405E74
	public bool get_IsEventLabelUse() { }

	// RVA: 0x2405E7C Offset: 0x2401E7C VA: 0x2405E7C
	public int get_EventTextLabelId() { }

	// RVA: 0x2405E84 Offset: 0x2401E84 VA: 0x2405E84
	public int get_EventTextLabelAddId() { }

	[CompilerGenerated]
	// RVA: 0x2405E8C Offset: 0x2401E8C VA: 0x2405E8C
	public bool get_IsInsidePlayer() { }

	[CompilerGenerated]
	// RVA: 0x2405E94 Offset: 0x2401E94 VA: 0x2405E94
	private void set_IsInsidePlayer(bool value) { }

	// RVA: 0x2405EA0 Offset: 0x2401EA0 VA: 0x2405EA0
	public EventArea.EventType get_GetEventType() { }

	// RVA: 0x2405EA8 Offset: 0x2401EA8 VA: 0x2405EA8
	public EventArea.TimeCountType get_TimeType() { }

	// RVA: 0x2405EB0 Offset: 0x2401EB0 VA: 0x2405EB0
	public EventArea.MiniMapType get_MiniMap() { }

	// RVA: 0x2405EB8 Offset: 0x2401EB8 VA: 0x2405EB8
	public float get_StartTime() { }

	// RVA: 0x2405EC0 Offset: 0x2401EC0 VA: 0x2405EC0
	public bool get_IsMoveArea() { }

	// RVA: 0x2405EC8 Offset: 0x2401EC8 VA: 0x2405EC8
	public static GameObject CreateEventArea(string name, Vector3 pos, byte scriptId, int size, byte flag) { }

	// RVA: 0x2405ED8 Offset: 0x2401ED8 VA: 0x2405ED8
	public static GameObject CreateEventArea(string name, Vector3 pos, byte scriptId, int size, byte flag, int localizeId, int localizeAddId) { }

	// RVA: 0x2405EE0 Offset: 0x2401EE0 VA: 0x2405EE0
	public static GameObject CreateEventArea(string name, Vector3 pos, byte scriptId, int size, byte flag, int localizeId, int localizeAddId, byte miniMapType) { }

	// RVA: 0x2406294 Offset: 0x2402294 VA: 0x2406294
	public static GameObject CreateTypeEventArea(EventArea.DecisionType dtype, string name, Vector3 pos, float rot, byte scriptId, Vector3 size, byte flag, int localizeId, int localizeAddId, byte miniMapType) { }

	// RVA: 0x240650C Offset: 0x240250C VA: 0x240650C
	public static GameObject CreateActionEventArea(string name, Vector3 pos, byte scriptId, Vector3 size, bool autoFlag) { }

	// RVA: 0x24066F4 Offset: 0x24026F4 VA: 0x24066F4
	public static GameObject CreateEscapeEventArea(string name, Vector3 pos, byte scriptId, int size, byte flag) { }

	// RVA: 0x24068BC Offset: 0x24028BC VA: 0x24068BC
	public static GameObject CreateRandamMapEventArea(string name, Vector3 pos, byte scriptId, int size, byte flag) { }

	// RVA: 0x2406A98 Offset: 0x2402A98 VA: 0x2406A98
	public static GameObject CreateTargetUIMenuEventArea(string name, Vector3 pos, UIActiveState state, int size, int localizeId, int localizeAddId, byte miniMapType) { }

	// RVA: 0x2406A9C Offset: 0x2402A9C VA: 0x2406A9C
	public static GameObject CreateTargetUIMenuEventArea(string name, Vector3 pos, UIActiveState state, int size, int localizeId, int localizeAddId, byte miniMapType, bool isMove) { }

	// RVA: 0x2406CF0 Offset: 0x2402CF0 VA: 0x2406CF0
	public static GameObject CreateHouseEditEventArea(string name, Vector3 pos, int uid, int itemId, int size) { }

	// RVA: 0x2406F50 Offset: 0x2402F50 VA: 0x2406F50
	public static GameObject CreateWorldTreasureEventArea(string name, Vector3 pos, byte scriptId, int size) { }

	// RVA: 0x2407198 Offset: 0x2403198 VA: 0x2407198
	public static GameObject CreateRoomSetPointEventArea(string name, Vector3 pos, byte scriptId, int size) { }

	// RVA: 0x24073A8 Offset: 0x24033A8 VA: 0x24073A8
	private void Start() { }

	// RVA: 0x24060F0 Offset: 0x24020F0 VA: 0x24060F0
	private void createDecision() { }

	// RVA: 0x2407430 Offset: 0x2403430 VA: 0x2407430
	public bool checkDecision(Vector3 pos, float rad) { }

	// RVA: 0x2407768 Offset: 0x2403768 VA: 0x2407768
	public bool checkDecisionSimple(Vector3 pos, float rad) { }

	// RVA: 0x2407974 Offset: 0x2403974 VA: 0x2407974
	public void .ctor() { }
}
