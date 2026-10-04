// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MasteryScriptAI : MonoBehaviour // TypeDefIndex: 1615
{
	// Fields
	private Dictionary<int, IAIAction> mastery_action_dic; // 0x20
	private ActionMaterialPropatyData material_data; // 0x28

	// Properties
	public ActionMaterialPropatyData MaterialData { get; }
	public bool CanUseMaterialData { get; }

	// Methods

	// RVA: 0x20938D0 Offset: 0x208F8D0 VA: 0x20938D0
	public ActionMaterialPropatyData get_MaterialData() { }

	// RVA: 0x208B9B4 Offset: 0x20879B4 VA: 0x208B9B4
	public bool get_CanUseMaterialData() { }

	// RVA: 0x20938D8 Offset: 0x208F8D8 VA: 0x20938D8
	public void DrawGUI() { }

	// RVA: 0x20939D8 Offset: 0x208F9D8 VA: 0x20939D8
	private void Start() { }

	// RVA: 0x2093A60 Offset: 0x208FA60 VA: 0x2093A60
	private void Update() { }

	// RVA: 0x2093C78 Offset: 0x208FC78 VA: 0x2093C78
	public void SetMaterialData(short _crate_material_bit_propaty) { }

	// RVA: 0x2093D0C Offset: 0x208FD0C VA: 0x2093D0C
	public void SetAllwaysAction(int _act_id, IAIAction _action) { }

	// RVA: 0x2093E34 Offset: 0x208FE34 VA: 0x2093E34
	public void .ctor() { }
}
