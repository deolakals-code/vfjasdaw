// Assembly: Assembly-CSharp.dll
// Namespace: 
[AddComponentMenu("NGUI/Interaction/Toggled Components")]
[RequireComponent(typeof(UIToggle))]
[ExecuteInEditMode]
public class UIToggledComponents : MonoBehaviour // TypeDefIndex: 60
{
	// Fields
	public List<MonoBehaviour> activate; // 0x20
	public List<MonoBehaviour> deactivate; // 0x28
	[SerializeField]
	[HideInInspector]
	private MonoBehaviour target; // 0x30
	[SerializeField]
	[HideInInspector]
	private bool inverse; // 0x38

	// Methods

	// RVA: 0x17279B8 Offset: 0x17239B8 VA: 0x17279B8
	private void Awake() { }

	// RVA: 0x1727BA8 Offset: 0x1723BA8 VA: 0x1727BA8
	public void Toggle() { }

	// RVA: 0x1727D08 Offset: 0x1723D08 VA: 0x1727D08
	public void .ctor() { }
}
