// Assembly: Assembly-CSharp.dll
// Namespace: 
[RequireComponent(typeof(UISprite))]
public class StaminaAnimation : MonoBehaviour // TypeDefIndex: 6330
{
	// Fields
	[SerializeField]
	private string[] SpriteNames; // 0x20
	[SerializeField]
	private float ChangeiInterval; // 0x28
	private UISprite sprite; // 0x30
	private bool is_changing; // 0x38
	private float current_interval; // 0x3C
	private int ptr; // 0x40

	// Methods

	// RVA: 0x18EA39C Offset: 0x18E639C VA: 0x18EA39C
	private void Awake() { }

	// RVA: 0x18EA444 Offset: 0x18E6444 VA: 0x18EA444
	private void Start() { }

	// RVA: 0x18EA448 Offset: 0x18E6448 VA: 0x18EA448
	private void Update() { }

	// RVA: 0x18EA53C Offset: 0x18E653C VA: 0x18EA53C
	public void ChangeState() { }

	// RVA: 0x18EA54C Offset: 0x18E654C VA: 0x18EA54C
	public void IntervalTimeChange(float _time) { }

	// RVA: 0x18EA554 Offset: 0x18E6554 VA: 0x18EA554
	public void StartAnimation() { }

	// RVA: 0x18EA634 Offset: 0x18E6634 VA: 0x18EA634
	public void ChangeIcon(string _icon_name) { }

	// RVA: 0x18EA6F0 Offset: 0x18E66F0 VA: 0x18EA6F0
	public void .ctor() { }
}
