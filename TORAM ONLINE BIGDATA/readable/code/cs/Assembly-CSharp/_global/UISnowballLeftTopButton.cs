// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UISnowballLeftTopButton : MonoBehaviour // TypeDefIndex: 6020
{
	// Fields
	[SerializeField]
	private GameObject buttonObj; // 0x20
	[SerializeField]
	private UILabel buttonLabel; // 0x28
	[SerializeField]
	private UISprite buttonIcon; // 0x30
	[SerializeField]
	private GameObject batsuIconObj; // 0x38
	private UISnowballLeftTopButton.ButtonType selectedButtonType; // 0x40
	private UIIruna2Anchor anchor; // 0x48
	private Action exitAction; // 0x50
	private Action checkOnAction; // 0x58
	private Action checkOffAction; // 0x60
	private BoxCollider boxCol; // 0x68
	private bool isPress; // 0x70
	private SystemTextManager systemTextManager; // 0x78

	// Properties
	public bool IsEnable { get; }
	public UISnowballLeftTopButton.ButtonType SelectedButtonType { get; }

	// Methods

	// RVA: 0x186A8A4 Offset: 0x18668A4 VA: 0x186A8A4
	public bool get_IsEnable() { }

	// RVA: 0x186CF34 Offset: 0x1868F34 VA: 0x186CF34
	public UISnowballLeftTopButton.ButtonType get_SelectedButtonType() { }

	// RVA: 0x186CF3C Offset: 0x1868F3C VA: 0x186CF3C
	private void Start() { }

	// RVA: 0x1868D5C Offset: 0x1864D5C VA: 0x1868D5C
	public void SetButtonType(UISnowballLeftTopButton.ButtonType type) { }

	// RVA: 0x18677DC Offset: 0x18637DC VA: 0x18677DC
	public void SetEnable(bool isEnable) { }

	// RVA: 0x186D024 Offset: 0x1869024 VA: 0x186D024
	public void SetExitAction(Action exitAction) { }

	// RVA: 0x1868FF8 Offset: 0x1864FF8 VA: 0x1868FF8
	public void SetCheckAction(Action checkOnAction, Action checkOffAction) { }

	// RVA: 0x186D02C Offset: 0x186902C VA: 0x186D02C
	private void OnClick() { }

	// RVA: 0x186D0C4 Offset: 0x18690C4 VA: 0x186D0C4
	private void OnPress(bool isPressed) { }

	// RVA: 0x186D104 Offset: 0x1869104 VA: 0x186D104
	public void .ctor() { }
}
