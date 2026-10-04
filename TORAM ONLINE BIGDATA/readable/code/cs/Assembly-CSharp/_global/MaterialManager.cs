// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MaterialManager // TypeDefIndex: 1389
{
	// Fields
	public const int MaxFoodPoint = 999999999;
	private Dictionary<MaterialManager.pair, MaterialData> materialList; // 0x10
	private int foodPoint; // 0x18

	// Methods

	// RVA: 0x1FE7AF8 Offset: 0x1FE3AF8 VA: 0x1FE7AF8
	public void Initialize(MaterialData[] material) { }

	// RVA: 0x1FE7BCC Offset: 0x1FE3BCC VA: 0x1FE7BCC
	public int GetMaterialPoint(int id, int lv) { }

	// RVA: 0x1FE7C78 Offset: 0x1FE3C78 VA: 0x1FE7C78
	public void UpdateMaterialData(MaterialData material) { }

	// RVA: 0x1FE7D44 Offset: 0x1FE3D44 VA: 0x1FE7D44
	public void UpdateMaterialData(MaterialData[] material) { }

	// RVA: 0x1FE7DAC Offset: 0x1FE3DAC VA: 0x1FE7DAC
	public void UpdateFoodPoint(int point) { }

	// RVA: 0x1FE7DB4 Offset: 0x1FE3DB4 VA: 0x1FE7DB4
	public int GetFoodPoint() { }

	// RVA: 0x1FE7DBC Offset: 0x1FE3DBC VA: 0x1FE7DBC
	public void .ctor() { }
}
