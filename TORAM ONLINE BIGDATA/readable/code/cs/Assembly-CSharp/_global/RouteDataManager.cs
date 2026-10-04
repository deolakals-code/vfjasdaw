// Assembly: Assembly-CSharp.dll
// Namespace: 
public class RouteDataManager // TypeDefIndex: 1620
{
	// Fields
	private RoutePointData route_point_data; // 0x10
	private IScriptAICentral script_ai; // 0x18
	private Dictionary<RouteDataType, IAttachedRouteData> route_data_accesss; // 0x20

	// Properties
	public RoutePointData RouteDataP { get; }
	public Vector3 NextTracePoint { get; }

	// Methods

	// RVA: 0x2097328 Offset: 0x2093328 VA: 0x2097328
	public RoutePointData get_RouteDataP() { }

	// RVA: 0x2097330 Offset: 0x2093330 VA: 0x2097330
	public void .ctor(int _route_index, List<Vector3> _trace_point, IScriptAICentral _ai_script) { }

	// RVA: 0x20975F0 Offset: 0x20935F0 VA: 0x20975F0
	public void AddGuideData(int[,] _guide_data) { }

	// RVA: 0x208D084 Offset: 0x2089084 VA: 0x208D084
	public Vector3 get_NextTracePoint() { }

	// RVA: 0x208F444 Offset: 0x208B444 VA: 0x208F444
	public bool IsUseDataType(RouteDataType _requested_data_type) { }

	// RVA: 0x208BAD8 Offset: 0x2087AD8 VA: 0x208BAD8
	public bool IsExistData(RouteDataType _requested_data_type) { }

	// RVA: 0x2092DC0 Offset: 0x208EDC0 VA: 0x2092DC0
	public void Startinitalize(RouteDataType _requested) { }

	// RVA: 0x208B6AC Offset: 0x20876AC VA: 0x208B6AC
	public void AddDataPoint(RouteDataType _requested_data) { }

	// RVA: 0x208C2E0 Offset: 0x20882E0 VA: 0x208C2E0
	public Vector3 GetNeedPosition(RouteDataType _requested_data_type) { }

	// RVA: 0x208C420 Offset: 0x2088420 VA: 0x208C420
	public void RequestedNextPoint(RouteDataType _requested_data_type) { }

	// RVA: 0x208C528 Offset: 0x2088528 VA: 0x208C528
	public void FinishRouteData(RouteDataType _requested_data_type) { }

	// RVA: 0x209768C Offset: 0x209368C VA: 0x209768C
	public void DrawGUI() { }

	// RVA: 0x2097964 Offset: 0x2093964 VA: 0x2097964
	public void DestroyDebugObject() { }
}
