// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GuideRouteData : IAttachedRouteData // TypeDefIndex: 1617
{
	// Fields
	private int[,] serch_point_guide; // 0x10
	private int prev_point_index; // 0x18
	private int next_point_index; // 0x1C
	private int goal_point_index; // 0x20
	private RoutePointData route_point_data; // 0x28
	private IScriptAICentral script_ai; // 0x30

	// Properties
	public RouteDataType DataType { get; }
	public bool IsExistData { get; }

	// Methods

	// RVA: 0x20955A4 Offset: 0x20915A4 VA: 0x20955A4 Slot: 4
	public RouteDataType get_DataType() { }

	// RVA: 0x20955AC Offset: 0x20915AC VA: 0x20955AC Slot: 5
	public bool get_IsExistData() { }

	// RVA: 0x20956F8 Offset: 0x20916F8 VA: 0x20956F8
	public void .ctor(IScriptAICentral _script_ai, RoutePointData _route_data, int[,] _can_go_route_data) { }

	// RVA: 0x2095768 Offset: 0x2091768 VA: 0x2095768 Slot: 11
	public void DrawGUI() { }

	// RVA: 0x20958B0 Offset: 0x20918B0 VA: 0x20958B0
	private void draw_arrouw_route() { }

	// RVA: 0x2095C38 Offset: 0x2091C38 VA: 0x2095C38 Slot: 6
	public void InitializeStart() { }

	// RVA: 0x2095FA8 Offset: 0x2091FA8 VA: 0x2095FA8 Slot: 7
	public void AddRecordData() { }

	// RVA: 0x2095FAC Offset: 0x2091FAC VA: 0x2095FAC Slot: 8
	public Vector3 GetNowPointData() { }

	// RVA: 0x2096018 Offset: 0x2092018 VA: 0x2096018 Slot: 9
	public void NextPoint() { }

	// RVA: 0x2096484 Offset: 0x2092484 VA: 0x2096484 Slot: 10
	public void Finish() { }

	// RVA: 0x2095EA0 Offset: 0x2091EA0 VA: 0x2095EA0
	private int calc_nearlist_route_point(Vector3 _research_point) { }
}
