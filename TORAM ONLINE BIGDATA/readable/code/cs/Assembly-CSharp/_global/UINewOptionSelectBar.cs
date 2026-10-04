// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UINewOptionSelectBar : MonoBehaviour // TypeDefIndex: 7488
{
	// Fields
	[SerializeField]
	private GameObject[] buttons; // 0x20
	[SerializeField]
	private GameObject moveIconObj; // 0x28
	[SerializeField]
	private UILabel moveIconLabel; // 0x30
	[SerializeField]
	private GameObject baseIconObj; // 0x38
	[SerializeField]
	private BoxCollider lineBoxCol; // 0x40
	[CompilerGenerated]
	private int <BaseParam>k__BackingField; // 0x48
	private string[] selectList; // 0x50
	private int addParam; // 0x58
	private int selectNum; // 0x5C
	private const float lineLength = 650;
	private Transform mTrans; // 0x60
	private Vector2 mSize; // 0x68
	private Vector2 mCenter; // 0x70

	// Properties
	public int BaseParam { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1B69384 Offset: 0x1B65384 VA: 0x1B69384
	private void set_BaseParam(int value) { }

	[CompilerGenerated]
	// RVA: 0x1B6938C Offset: 0x1B6538C VA: 0x1B6938C
	public int get_BaseParam() { }

	// RVA: 0x1B69394 Offset: 0x1B65394 VA: 0x1B69394
	private void Start() { }

	// RVA: 0x1B67AE8 Offset: 0x1B63AE8 VA: 0x1B67AE8
	public void Initialize(int baseParam, int defaultParam, int addParam, string[] textList) { }

	// RVA: 0x1B69440 Offset: 0x1B65440 VA: 0x1B69440
	public void UpdateText() { }

	// RVA: 0x1B694D8 Offset: 0x1B654D8 VA: 0x1B694D8
	public void ChangeDepth(int baseDepth) { }

	// RVA: 0x1B696C4 Offset: 0x1B656C4 VA: 0x1B696C4
	public void OnLeft() { }

	// RVA: 0x1B696E4 Offset: 0x1B656E4 VA: 0x1B696E4
	public void OnRight() { }

	// RVA: 0x1B69704 Offset: 0x1B65704 VA: 0x1B69704
	private void OnDrag(Vector2 delta) { }

	// RVA: 0x1B69B90 Offset: 0x1B65B90 VA: 0x1B69B90
	private void OnPress(bool pressed) { }

	// RVA: 0x1B6972C Offset: 0x1B6572C VA: 0x1B6972C
	private void UpdateSelect() { }

	// RVA: 0x1B69408 Offset: 0x1B65408 VA: 0x1B69408
	private Vector3 GetIconPos(int param) { }

	// RVA: 0x1B69C1C Offset: 0x1B65C1C VA: 0x1B69C1C
	public void .ctor() { }
}
