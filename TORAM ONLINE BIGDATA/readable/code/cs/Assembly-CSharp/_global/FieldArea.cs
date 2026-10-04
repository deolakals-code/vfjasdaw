// Assembly: Assembly-CSharp.dll
// Namespace: 
[ExecuteInEditMode]
public class FieldArea : MonoBehaviour // TypeDefIndex: 3892
{
	// Fields
	[SerializeField]
	private FieldArea.FieldAreaEffect[] fieldAreaEffectList; // 0x20
	[SerializeField]
	private int layerId; // 0x28
	[SerializeField]
	private float rad; // 0x2C
	[SerializeField]
	private Vector3 size; // 0x30
	[SerializeField]
	private FieldArea.DecisionType decision; // 0x3C
	private Cylinder cylinder; // 0x40
	private OBB obb; // 0x48

	// Properties
	public FieldArea.FieldAreaEffect[] FieldAreaEffectList { get; }
	public int LayerId { get; }
	public float Rad { get; }
	public Vector3 Size { get; }
	public FieldArea.DecisionType Decision { get; }

	// Methods

	// RVA: 0x2407A04 Offset: 0x2403A04 VA: 0x2407A04
	public FieldArea.FieldAreaEffect[] get_FieldAreaEffectList() { }

	// RVA: 0x2407A0C Offset: 0x2403A0C VA: 0x2407A0C
	public int get_LayerId() { }

	// RVA: 0x2407A14 Offset: 0x2403A14 VA: 0x2407A14
	public float get_Rad() { }

	// RVA: 0x2407A1C Offset: 0x2403A1C VA: 0x2407A1C
	public Vector3 get_Size() { }

	// RVA: 0x2407A28 Offset: 0x2403A28 VA: 0x2407A28
	public FieldArea.DecisionType get_Decision() { }

	// RVA: 0x2407A30 Offset: 0x2403A30 VA: 0x2407A30
	private void Start() { }

	// RVA: 0x2407A34 Offset: 0x2403A34 VA: 0x2407A34
	private void createDecision() { }

	// RVA: 0x2407C90 Offset: 0x2403C90 VA: 0x2407C90
	public bool CheckDecision(Vector3 pos, float rad) { }

	// RVA: 0x2407CDC Offset: 0x2403CDC VA: 0x2407CDC
	public void .ctor() { }
}
