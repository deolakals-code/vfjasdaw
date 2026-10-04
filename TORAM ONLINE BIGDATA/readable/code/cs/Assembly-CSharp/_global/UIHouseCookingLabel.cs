// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIHouseCookingLabel : UINameLabel // TypeDefIndex: 8923
{
	// Fields
	[SerializeField]
	private GameObject cookingIcon; // 0x88
	[SerializeField]
	private GameObject foodIcon; // 0x90
	[SerializeField]
	private GameObject[] frame; // 0x98
	private UIGLSprite[] frameSprite; // 0xA0
	private HouseCuisineManager cuisineManager; // 0xA8
	private bool isFood; // 0xB0
	private int itemUid; // 0xB4
	private float distSize; // 0xB8
	private HouseCuisineManager.CuisineType type; // 0xBC
	private UI3DNameManager nameManager; // 0xC0

	// Properties
	protected override bool ActiveFlag { get; }
	protected override bool IsCorrectPosInView { get; }
	public override bool IsEnabled { get; }

	// Methods

	// RVA: 0x1E56F64 Offset: 0x1E52F64 VA: 0x1E56F64 Slot: 4
	protected override bool get_ActiveFlag() { }

	// RVA: 0x1E56F6C Offset: 0x1E52F6C VA: 0x1E56F6C Slot: 6
	protected override bool get_IsCorrectPosInView() { }

	// RVA: 0x1E56F74 Offset: 0x1E52F74 VA: 0x1E56F74 Slot: 5
	public override bool get_IsEnabled() { }

	// RVA: 0x1E571F8 Offset: 0x1E531F8 VA: 0x1E571F8
	public void Initialize(UI3DNameManager manager, int uid, Transform traceObject, float height, Vector3 size, HouseCuisineManager.CuisineType type) { }

	// RVA: 0x1E57610 Offset: 0x1E53610 VA: 0x1E57610 Slot: 8
	protected override void StatusUpdate() { }

	// RVA: 0x1E5741C Offset: 0x1E5341C VA: 0x1E5741C
	private void UpdateIcon() { }

	// RVA: 0x1E57620 Offset: 0x1E53620 VA: 0x1E57620 Slot: 9
	protected override void OnClick() { }

	// RVA: 0x1E57920 Offset: 0x1E53920 VA: 0x1E57920
	public void .ctor() { }
}
