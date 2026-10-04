// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ReturnRoutePointData : IAttachedRouteData // TypeDefIndex: 1618
{
	// Fields
	private readonly float memory_rad; // 0x10
	private readonly float memory_length; // 0x14
	private List<Vector3> back_trace_point; // 0x18
	private IScriptAICentral script_ai; // 0x20
	private RoutePointData route_point_data; // 0x28
	private Vector3 following_vec; // 0x30
	private int proximity_index; // 0x3C
	private float proximity_length; // 0x40

	// Properties
	public RouteDataType DataType { get; }
	public bool IsExistData { get; }

	// Methods

	// RVA: 0x20964A4 Offset: 0x20924A4 VA: 0x20964A4 Slot: 4
	public RouteDataType get_DataType() { }

	// RVA: 0x20964AC Offset: 0x20924AC VA: 0x20964AC
	public void .ctor(IScriptAICentral _script_ai, RoutePointData _route_data) { }

	// RVA: 0x2096570 Offset: 0x2092570 VA: 0x2096570 Slot: 5
	public bool get_IsExistData() { }

	// RVA: 0x20965C0 Offset: 0x20925C0 VA: 0x20965C0 Slot: 6
	public void InitializeStart() { }

	// RVA: 0x20968EC Offset: 0x20928EC VA: 0x20968EC Slot: 7
	public void AddRecordData() { }

	// RVA: 0x2096FE0 Offset: 0x2092FE0 VA: 0x2096FE0 Slot: 10
	public void Finish() { }

	// RVA: 0x2097008 Offset: 0x2093008 VA: 0x2097008 Slot: 8
	public Vector3 GetNowPointData() { }

	// RVA: 0x2097084 Offset: 0x2093084 VA: 0x2097084 Slot: 9
	public void NextPoint() { }

	// RVA: 0x20966E8 Offset: 0x20926E8 VA: 0x20966E8
	private int set_nearlist_point(Vector3 _now_pos) { }

	// RVA: 0x20967C8 Offset: 0x20927C8 VA: 0x20967C8
	private void reset_back_trace_data() { }

	// RVA: 0x2096818 Offset: 0x2092818 VA: 0x2096818
	private void record_pos(Vector3 _now_pos) { }

	// RVA: 0x2096CF4 Offset: 0x2092CF4 VA: 0x2096CF4
	private bool cheak_close_proximity_point(Vector3 _now_pos) { }

	// RVA: 0x2097250 Offset: 0x2093250 VA: 0x2097250 Slot: 11
	public void DrawGUI() { }
}
