// Assembly: Assembly-CSharp.dll
// Namespace: 
internal interface IAttachedRouteData // TypeDefIndex: 1619
{
	// Properties
	public abstract RouteDataType DataType { get; }
	public abstract bool IsExistData { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract RouteDataType get_DataType();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_IsExistData();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void InitializeStart();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void AddRecordData();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Vector3 GetNowPointData();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void NextPoint();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void Finish();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void DrawGUI();
}
