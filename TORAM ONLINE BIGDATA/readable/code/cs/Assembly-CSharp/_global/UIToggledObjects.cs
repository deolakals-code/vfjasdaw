// Assembly: Assembly-CSharp.dll
// Namespace: 
[AddComponentMenu("NGUI/Interaction/Toggled Objects")]
[ExecuteInEditMode]
public class UIToggledObjects : MonoBehaviour // TypeDefIndex: 61
{
	// Fields
	public List<GameObject> activate; // 0x20
	public List<GameObject> deactivate; // 0x28
	[SerializeField]
	[HideInInspector]
	private GameObject target; // 0x30
	[SerializeField]
	[HideInInspector]
	private bool inverse; // 0x38

	// Methods

	// RVA: 0x1727D10 Offset: 0x1723D10 VA: 0x1727D10
	private void Awake() { }

	// RVA: 0x1727F00 Offset: 0x1723F00 VA: 0x1727F00
	public void Toggle() { }

	// RVA: 0x1728050 Offset: 0x1724050 VA: 0x1728050
	private void Set(GameObject go, bool state) { }

	// RVA: 0x1728180 Offset: 0x1724180 VA: 0x1728180
	public void .ctor() { }
}
