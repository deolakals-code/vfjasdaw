// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIFishingRodStatusBar : MonoBehaviour // TypeDefIndex: 7061
{
	// Fields
	[SerializeField]
	private UICreateFishingRodManager.MaterialType materialType; // 0x20
	[SerializeField]
	private UISlider statusSlider; // 0x28
	[SerializeField]
	private UISprite sliderSprite; // 0x30
	[SerializeField]
	private UILabel materialNameLabel; // 0x38
	[SerializeField]
	private UILabel sliderLabel; // 0x40
	[SerializeField]
	private GameObject leftButton; // 0x48
	[SerializeField]
	private GameObject rightButton; // 0x50
	private UICreateFishingRodManager mainManager; // 0x58
	private SystemTextManager systemTextManager; // 0x60
	private int _point; // 0x68
	private int playerMaterialPoint; // 0x6C
	private BoxCollider thisContentCollider; // 0x70
	private BoxCollider statusSliderCollider; // 0x78

	// Properties
	public UICreateFishingRodManager.MaterialType MaterialType { get; }

	// Methods

	// RVA: 0x1A86D20 Offset: 0x1A82D20 VA: 0x1A86D20
	public UICreateFishingRodManager.MaterialType get_MaterialType() { }

	// RVA: 0x1A86D28 Offset: 0x1A82D28 VA: 0x1A86D28
	private void Start() { }

	// RVA: 0x1A86D60 Offset: 0x1A82D60 VA: 0x1A86D60
	private void Update() { }

	// RVA: 0x1A86E50 Offset: 0x1A82E50 VA: 0x1A86E50
	public void Initialize(UICreateFishingRodManager manager) { }

	// RVA: 0x1A8725C Offset: 0x1A8325C VA: 0x1A8725C
	public void OnPressMaterialButton(bool isAdd) { }

	// RVA: 0x1A87284 Offset: 0x1A83284 VA: 0x1A87284
	private void OnSliderChange(float param) { }

	// RVA: 0x1A87344 Offset: 0x1A83344 VA: 0x1A87344
	public void SliderEnable(bool enable) { }

	// RVA: 0x1A8738C Offset: 0x1A8338C VA: 0x1A8738C
	public void CheckLimit() { }

	// RVA: 0x1A86FFC Offset: 0x1A82FFC VA: 0x1A86FFC
	private void UpdatePoint(int updatePoint) { }

	// RVA: 0x1A86D64 Offset: 0x1A82D64 VA: 0x1A86D64
	private void UpdateButtonStates() { }

	// RVA: 0x1A87468 Offset: 0x1A83468 VA: 0x1A87468
	private void OnDrag(Vector2 delta) { }

	// RVA: 0x1A87490 Offset: 0x1A83490 VA: 0x1A87490
	private void OnPressThumb(GameObject go, bool pressed) { }

	// RVA: 0x1A874B8 Offset: 0x1A834B8 VA: 0x1A874B8
	private void OnDragThumb(GameObject go, Vector3 delta) { }

	// RVA: 0x1A874E0 Offset: 0x1A834E0 VA: 0x1A874E0
	private void OnPress(bool flag) { }

	// RVA: 0x1A87580 Offset: 0x1A83580 VA: 0x1A87580
	public void .ctor() { }
}
