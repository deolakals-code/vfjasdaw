// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FieldAreaManager : Singleton<FieldAreaManager>, ISceneChangeManager // TypeDefIndex: 3896
{
	// Fields
	private Dictionary<AreaEffectType, List<FieldAreaData>> fieldAreaList; // 0x20
	private PlayerDataManager playerDataManager; // 0x28
	private float fogTimer; // 0x30
	private FieldFogAreaData activeFogData; // 0x38
	private Color baseFogColor; // 0x40
	private float baseFogNear; // 0x50
	private float baseFogFar; // 0x54
	private float baseFogDensity; // 0x58

	// Methods

	// RVA: 0x2407ED8 Offset: 0x2403ED8 VA: 0x2407ED8
	private void Start() { }

	// RVA: 0x2407F48 Offset: 0x2403F48 VA: 0x2407F48
	private FieldAreaData SearchFieldAreaData(AreaEffectType type, Vector3 position, float rad) { }

	// RVA: 0x2408268 Offset: 0x2404268 VA: 0x2408268
	public int GetFieldAreaData(AreaEffectType type, Vector3 position, float rad) { }

	// RVA: 0x24082DC Offset: 0x24042DC VA: 0x24082DC
	public FieldAreaData GetCurrentFieldArea(AreaEffectType type, Vector3 position, float rad) { }

	// RVA: 0x24082E0 Offset: 0x24042E0 VA: 0x24082E0
	public Vector3 CreateVirtualMiniMapDisplaySize() { }

	// RVA: 0x2408540 Offset: 0x2404540 VA: 0x2408540
	public bool GetFieldAreaData(AreaEffectType type, Vector3 position, float rad, out int outParam) { }

	// RVA: 0x24082B4 Offset: 0x24042B4 VA: 0x24082B4
	private int DefaultParam(AreaEffectType type) { }

	// RVA: 0x2408584 Offset: 0x2404584 VA: 0x2408584
	private void AddAreaList(AreaEffectType type, FieldAreaData areaData) { }

	// RVA: 0x24086DC Offset: 0x24046DC VA: 0x24086DC
	private void SettingFieldArea(FieldArea[] fieldAreaList) { }

	// RVA: 0x2408A60 Offset: 0x2404A60 VA: 0x2408A60
	private void FogArea(Vector3 position, float rad) { }

	// RVA: 0x2408CC4 Offset: 0x2404CC4 VA: 0x2408CC4
	private void LateUpdate() { }

	// RVA: 0x2408EF4 Offset: 0x2404EF4 VA: 0x2408EF4 Slot: 4
	public void OnEnter() { }

	// RVA: 0x2409080 Offset: 0x2405080 VA: 0x2409080 Slot: 5
	public void OnLeave() { }

	// RVA: 0x24090D0 Offset: 0x24050D0 VA: 0x24090D0
	public void .ctor() { }
}
