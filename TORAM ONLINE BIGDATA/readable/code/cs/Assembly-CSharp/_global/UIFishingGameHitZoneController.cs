// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIFishingGameHitZoneController : MonoBehaviour // TypeDefIndex: 4360
{
	// Fields
	[SerializeField]
	private float sizeCorrectionValue; // 0x20
	private UIFishingGameController mainController; // 0x28
	private UISprite hitZoneSprite; // 0x30
	private float movePower; // 0x38
	private float inertia; // 0x3C
	private float inertiaSpeed; // 0x40
	private float maxInertia; // 0x44
	private int posPercent; // 0x48
	private List<int> inputCheckData; // 0x50
	private UIFishingGameHitZoneController.InputType inputType; // 0x58

	// Properties
	public int PosPercent { get; }
	public Vector2 Position { get; }
	public int[] InputCheckData { get; }

	// Methods

	// RVA: 0x24DB8F0 Offset: 0x24D78F0 VA: 0x24DB8F0
	private float GetInertiaCompensation(int value) { }

	// RVA: 0x24DB91C Offset: 0x24D791C VA: 0x24DB91C
	public int get_PosPercent() { }

	// RVA: 0x24DB924 Offset: 0x24D7924 VA: 0x24DB924
	public Vector2 get_Position() { }

	// RVA: 0x24DB950 Offset: 0x24D7950 VA: 0x24DB950
	public int[] get_InputCheckData() { }

	// RVA: 0x24DB9A0 Offset: 0x24D79A0 VA: 0x24DB9A0
	private void Update() { }

	// RVA: 0x24DBA8C Offset: 0x24D7A8C VA: 0x24DBA8C
	private void CalculatePositionPercentage() { }

	// RVA: 0x24DBBD8 Offset: 0x24D7BD8 VA: 0x24DBBD8
	private void CheckInputType() { }

	// RVA: 0x24DBC88 Offset: 0x24D7C88 VA: 0x24DBC88
	private void UpdateInertia() { }

	// RVA: 0x24DBD88 Offset: 0x24D7D88 VA: 0x24DBD88
	private void ApplyMovement() { }

	// RVA: 0x24DBE98 Offset: 0x24D7E98 VA: 0x24DBE98
	public void Initialize(UIFishingGameController fishingGameController) { }

	// RVA: 0x24DC178 Offset: 0x24D8178 VA: 0x24DC178
	public void InputMovePower(float widthPower) { }

	// RVA: 0x24DC268 Offset: 0x24D8268 VA: 0x24DC268
	public float GetScaleHalfSize() { }

	// RVA: 0x24DC0C8 Offset: 0x24D80C8 VA: 0x24DC0C8
	public void ChangeRandomStartPos() { }

	// RVA: 0x24DC048 Offset: 0x24D8048 VA: 0x24DC048
	public void ChangeHitZoneWidth() { }

	// RVA: 0x24DC294 Offset: 0x24D8294 VA: 0x24DC294
	public void .ctor() { }
}
