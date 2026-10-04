// Assembly: Assembly-CSharp.dll
// Namespace: 
[ExecuteInEditMode]
public class WindowCreater : MonoBehaviour // TypeDefIndex: 8745
{
	// Fields
	[SerializeField]
	private WindowCreater.Anchor anchor; // 0x20
	[SerializeField]
	private GameObject[] topLeftParent; // 0x28
	[SerializeField]
	private GameObject[] topRightParent; // 0x30
	[SerializeField]
	private GameObject[] bottomLeftParent; // 0x38
	[SerializeField]
	private GameObject[] bottomRightParent; // 0x40
	[SerializeField]
	private GameObject[] topParent; // 0x48
	[SerializeField]
	private GameObject[] leftParent; // 0x50
	[SerializeField]
	private GameObject[] rightParent; // 0x58
	[SerializeField]
	private GameObject[] bottomParent; // 0x60
	[SerializeField]
	private UISprite background; // 0x68
	[SerializeField]
	private GameObject topStretchParent; // 0x70
	[SerializeField]
	private GameObject leftStretchParent; // 0x78
	[SerializeField]
	private GameObject rightStretchParent; // 0x80
	[SerializeField]
	private GameObject bottomStretchParent; // 0x88
	[SerializeField]
	public float Width; // 0x90
	[SerializeField]
	public float Height; // 0x94
	private float oldWidth; // 0x98
	private float oldHeight; // 0x9C

	// Methods

	// RVA: 0x1DFE5A0 Offset: 0x1DFA5A0 VA: 0x1DFE5A0
	private void Awake() { }

	// RVA: 0x1DFE628 Offset: 0x1DFA628 VA: 0x1DFE628
	private void Update() { }

	// RVA: 0x1DFE650 Offset: 0x1DFA650 VA: 0x1DFE650
	public void UpdateWindow() { }

	// RVA: 0x1DFE6C8 Offset: 0x1DFA6C8 VA: 0x1DFE6C8
	private UISprite[] getChildren(GameObject parent) { }

	// RVA: 0x1DFE778 Offset: 0x1DFA778 VA: 0x1DFE778
	private void updateWidth(UISprite[] sprites) { }

	// RVA: 0x1DFE9C4 Offset: 0x1DFA9C4 VA: 0x1DFE9C4
	private void updateHeight(UISprite[] sprites) { }

	// RVA: 0x1DFEE54 Offset: 0x1DFAE54 VA: 0x1DFEE54
	private void updateY(GameObject[] parent, float sub) { }

	// RVA: 0x1DFEF14 Offset: 0x1DFAF14 VA: 0x1DFEF14
	private void updateX(GameObject[] parent, float sub) { }

	// RVA: 0x1DFED50 Offset: 0x1DFAD50 VA: 0x1DFED50
	private void updateY() { }

	// RVA: 0x1DFEDE8 Offset: 0x1DFADE8 VA: 0x1DFEDE8
	private void updateX() { }

	// RVA: 0x1DFEFD4 Offset: 0x1DFAFD4 VA: 0x1DFEFD4
	public void .ctor() { }
}
