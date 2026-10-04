// Assembly: Assembly-CSharp.dll
// Namespace: 
public class RoutePointData // TypeDefIndex: 1622
{
	// Fields
	private int next_index; // 0x10
	private int cache_count; // 0x14
	private List<Vector3> point_data; // 0x18
	private List<int> patrol_index; // 0x20

	// Properties
	public List<Vector3> PointData { get; }
	public int NextIndex { get; }
	public int PrevIndex { get; }
	public int PointCount { get; }

	// Methods

	// RVA: 0x2097968 Offset: 0x2093968 VA: 0x2097968
	public List<Vector3> get_PointData() { }

	// RVA: 0x2097970 Offset: 0x2093970 VA: 0x2097970
	public int get_NextIndex() { }

	// RVA: 0x209711C Offset: 0x209311C VA: 0x209711C
	public int get_PrevIndex() { }

	// RVA: 0x2097978 Offset: 0x2093978 VA: 0x2097978
	public int get_PointCount() { }

	// RVA: 0x2097488 Offset: 0x2093488 VA: 0x2097488
	public void .ctor(int _index, List<Vector3> _trace_point) { }

	// RVA: 0x2097980 Offset: 0x2093980 VA: 0x2097980
	private void trace_point_debug_point_setting() { }

	// RVA: 0x2097960 Offset: 0x2093960 VA: 0x2097960
	public void OnDrawGUI() { }

	// RVA: 0x2097984 Offset: 0x2093984 VA: 0x2097984
	public void DestoryDebugObject() { }

	// RVA: 0x2097988 Offset: 0x2093988 VA: 0x2097988
	private void draw_debug_point() { }

	// RVA: 0x2097B18 Offset: 0x2093B18 VA: 0x2097B18
	private void draw_debug_fo_arrow() { }

	// RVA: 0x2097CA0 Offset: 0x2093CA0 VA: 0x2097CA0
	public void SetRouteIndex(int _start_index, List<int> _rotue_index) { }

	// RVA: 0x2097D40 Offset: 0x2093D40 VA: 0x2097D40
	public void SetRouteIndex(int _start_index, int[] _route_index) { }

	// RVA: 0x2097174 Offset: 0x2093174 VA: 0x2097174
	public Vector3 GetPointData() { }

	// RVA: 0x2095B84 Offset: 0x2091B84 VA: 0x2095B84
	public Vector3 GetInfoPointData(int _index) { }

	// RVA: 0x2097DE0 Offset: 0x2093DE0 VA: 0x2097DE0
	public void SettingNextIndex(int _next_index) { }

	// RVA: 0x208D09C Offset: 0x208909C VA: 0x208D09C
	public void MoveIndex() { }
}
