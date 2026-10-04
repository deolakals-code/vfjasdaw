// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CraneGameShadow : MonoBehaviour // TypeDefIndex: 4313
{
	// Fields
	[SerializeField]
	private List<GameObject> fields; // 0x20
	private GameObject shadowObj; // 0x28
	private CraneGameController controller; // 0x30
	private Renderer[] shadowRenderer; // 0x38
	private Dictionary<Material, bool> materialList; // 0x40
	private Coroutine initCoroutine; // 0x48

	// Methods

	// RVA: 0x24CCA1C Offset: 0x24C8A1C VA: 0x24CCA1C
	private void Start() { }

	// RVA: 0x24CCAB8 Offset: 0x24C8AB8 VA: 0x24CCAB8
	private void LateUpdate() { }

	// RVA: 0x24CD070 Offset: 0x24C9070 VA: 0x24CD070
	private void OnDestroy() { }

	// RVA: 0x24CD110 Offset: 0x24C9110 VA: 0x24CD110
	private void OnDisable() { }

	[IteratorStateMachine(typeof(CraneGameShadow.<Initialize>d__10))]
	// RVA: 0x24CCA4C Offset: 0x24C8A4C VA: 0x24CCA4C
	private IEnumerator Initialize() { }

	[IteratorStateMachine(typeof(CraneGameShadow.<CreateShadowObj>d__11))]
	// RVA: 0x24CD150 Offset: 0x24C9150 VA: 0x24CD150
	private IEnumerator CreateShadowObj() { }

	// RVA: 0x24CCEF4 Offset: 0x24C8EF4 VA: 0x24CCEF4
	private bool CheckContainsField(GameObject obj) { }

	// RVA: 0x24CD1E4 Offset: 0x24C91E4 VA: 0x24CD1E4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x24CD2C0 Offset: 0x24C92C0 VA: 0x24CD2C0
	private void <CreateShadowObj>b__11_0(bool isCreate, GameObject shadow) { }
}
