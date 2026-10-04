// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FloorLightMap : MonoBehaviour // TypeDefIndex: 3931
{
	// Fields
	private FieldRayPick fieldRayPick; // 0x20
	private bool activeFloorLight; // 0x28
	private SkinnedMeshRenderer[] rendererList; // 0x30
	private int shaderPropertyId; // 0x38
	private float brightness; // 0x3C

	// Properties
	public bool ActiveFloorLight { get; set; }

	// Methods

	// RVA: 0x24180B0 Offset: 0x24140B0 VA: 0x24180B0
	public bool get_ActiveFloorLight() { }

	// RVA: 0x24180B8 Offset: 0x24140B8 VA: 0x24180B8
	public void set_ActiveFloorLight(bool value) { }

	// RVA: 0x24180D0 Offset: 0x24140D0 VA: 0x24180D0
	public void Initialize(FieldRayPick ray, SkinnedMeshRenderer[] skinList) { }

	// RVA: 0x2418158 Offset: 0x2414158 VA: 0x2418158
	private void LateUpdate() { }

	// RVA: 0x2418368 Offset: 0x2414368 VA: 0x2418368
	public void .ctor() { }
}
