// Assembly: Assembly-CSharp.dll
// Namespace: 
public class LabelWithIcon : MonoBehaviour // TypeDefIndex: 8345
{
	// Fields
	[SerializeField]
	private UILabel baseLabel; // 0x20
	[SerializeField]
	private UIWidget Icon; // 0x28
	[SerializeField]
	private LabelWithIcon.WithAnchor anchor; // 0x30
	[SerializeField]
	private float iconScale; // 0x34
	[SerializeField]
	private float iconOffset; // 0x38
	[SerializeField]
	private float iconPosX; // 0x3C
	[SerializeField]
	private float iconPosY; // 0x40
	private UILabelSizeControl labelSizeControl; // 0x48

	// Properties
	public UILabel Label { get; }

	// Methods

	// RVA: 0x1D29A2C Offset: 0x1D25A2C VA: 0x1D29A2C
	public UILabel get_Label() { }

	// RVA: 0x1D29A34 Offset: 0x1D25A34 VA: 0x1D29A34
	private void Awake() { }

	// RVA: 0x1D29E48 Offset: 0x1D25E48 VA: 0x1D29E48
	public void Initialize(UILabel label, UIWidget icon) { }

	// RVA: 0x1D29E78 Offset: 0x1D25E78 VA: 0x1D29E78
	public void SetScale(float scale) { }

	// RVA: 0x1D29B44 Offset: 0x1D25B44 VA: 0x1D29B44
	private void Update() { }

	// RVA: 0x1D29E80 Offset: 0x1D25E80 VA: 0x1D29E80
	public void SetPos(float x, float y) { }

	// RVA: 0x1D29E88 Offset: 0x1D25E88 VA: 0x1D29E88
	public void Set(UIAtlas atlas, string iconSpriteName, string labelText) { }

	// RVA: 0x1D29F30 Offset: 0x1D25F30 VA: 0x1D29F30
	public void Set(string iconSpriteName, string labelText) { }

	// RVA: 0x1D29FE0 Offset: 0x1D25FE0 VA: 0x1D29FE0
	public void .ctor() { }
}
