// Assembly: Assembly-CSharp.dll
// Namespace: 
[Obsolete("このRouteDataの形式は、旧式です。")]
public class RouteData // TypeDefIndex: 1616
{
	// Fields
	private readonly float memory_rad; // 0x10
	private readonly float memory_length; // 0x14
	private IScriptAICentral ai_manager; // 0x18
	private int next_index; // 0x20
	private List<Vector3> trace_point; // 0x28
	private int proximity_index; // 0x30
	private float proximity_length; // 0x34
	private Vector3 following_vec; // 0x38
	private List<Vector3> back_trace_point; // 0x48
	private int[,] serch_point_guide; // 0x50
	private int goal_point_index; // 0x58
	private int next_point_index; // 0x5C
	private int prev_point_index; // 0x60

	// Properties
	public Vector3 NextTracePoint { get; }
	public List<Vector3> TracePoint { get; }
	public bool IsExistBackTraceData { get; }
	public Vector3 BackTraceLastPoint { get; }
	public Vector3 NearlestPosition { get; }
	public bool CheckGuideTraceEnd { get; }
	public bool IsCanUseGoPointData { get; }

	// Methods

	// RVA: 0x2093E3C Offset: 0x208FE3C VA: 0x2093E3C
	public Vector3 get_NextTracePoint() { }

	// RVA: 0x2093EB0 Offset: 0x208FEB0 VA: 0x2093EB0
	public List<Vector3> get_TracePoint() { }

	// RVA: 0x2093EB8 Offset: 0x208FEB8 VA: 0x2093EB8
	public bool get_IsExistBackTraceData() { }

	// RVA: 0x2093F08 Offset: 0x208FF08 VA: 0x2093F08
	public Vector3 get_BackTraceLastPoint() { }

	// RVA: 0x2093FB0 Offset: 0x208FFB0 VA: 0x2093FB0
	public Vector3 get_NearlestPosition() { }

	// RVA: 0x2094118 Offset: 0x2090118 VA: 0x2094118
	public bool get_CheckGuideTraceEnd() { }

	// RVA: 0x209412C Offset: 0x209012C VA: 0x209412C
	public bool get_IsCanUseGoPointData() { }

	// RVA: 0x209413C Offset: 0x209013C VA: 0x209413C
	public void .ctor(int _route_index, List<Vector3> _trace_point, IScriptAICentral _ai_manager) { }

	// RVA: 0x2094218 Offset: 0x2090218 VA: 0x2094218
	public void .ctor(int _route_index, List<Vector3> _trace_point, IScriptAICentral _ai_manager, int[,] _guide_data) { }

	// RVA: 0x2094310 Offset: 0x2090310 VA: 0x2094310
	private void trace_point_debug_point_setting() { }

	// RVA: 0x2094314 Offset: 0x2090314 VA: 0x2094314
	public void DrawGUI() { }

	// RVA: 0x2094318 Offset: 0x2090318 VA: 0x2094318
	private void draw_arrow_places_to_go() { }

	// RVA: 0x209466C Offset: 0x209066C VA: 0x209466C
	public void NextIndex() { }

	// RVA: 0x20946E0 Offset: 0x20906E0 VA: 0x20946E0
	public void StartRecord() { }

	// RVA: 0x20949FC Offset: 0x20909FC VA: 0x20949FC
	public void AddBackTracePoint() { }

	// RVA: 0x20951B8 Offset: 0x20911B8 VA: 0x20951B8
	public void RemoveBackTrace() { }

	// RVA: 0x2095250 Offset: 0x2091250 VA: 0x2095250
	public void CompleteBackTrace() { }

	// RVA: 0x2094884 Offset: 0x2090884 VA: 0x2094884
	private int set_nearlist_point(Vector3 _now_pos) { }

	// RVA: 0x2094EA0 Offset: 0x2090EA0 VA: 0x2094EA0
	private bool cheak_close_proximity_point(Vector3 _now_pos) { }

	// RVA: 0x20949AC Offset: 0x20909AC VA: 0x20949AC
	private void reset_back_trace_data() { }

	// RVA: 0x209525C Offset: 0x209125C VA: 0x209525C
	public Vector3 GetPointNearPosition() { }

	// RVA: 0x209530C Offset: 0x209130C VA: 0x209530C
	public void NextGuidePoint() { }

	// RVA: 0x20953DC Offset: 0x20913DC VA: 0x20953DC
	public void CalcToPointMostNearRoot(Vector3 _mypositon, Vector3 _to_position) { }

	// RVA: 0x2095438 Offset: 0x2091438 VA: 0x2095438
	private int calc_nearlist_route_point(Vector3 _research_point) { }

	// RVA: 0x2095580 Offset: 0x2091580 VA: 0x2095580
	public void CompleteIndex() { }
}
