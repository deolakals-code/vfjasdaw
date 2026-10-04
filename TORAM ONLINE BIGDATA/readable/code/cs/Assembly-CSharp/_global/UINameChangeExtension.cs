// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UINameChangeExtension : MonoBehaviour // TypeDefIndex: 9008
{
	// Fields
	[SerializeField]
	private UIInput inputData; // 0x20
	[SerializeField]
	private UISlider nameGaugeSlider; // 0x28
	[SerializeField]
	private UISprite sliderSprite; // 0x30
	[SerializeField]
	private UILabel numLabel; // 0x38
	[SerializeField]
	private UINameChangeLabel nameLabel; // 0x40
	public static readonly int MaxLengthFullWidth; // 0x0
	public static readonly int MaxLengthHalfWidth; // 0x4
	private SystemTextManager systemTextManager; // 0x48
	private int maxCount; // 0x50
	private string prevNameText; // 0x58
	private bool isHalfWidth; // 0x60
	private bool isSelected; // 0x61
	private string maxCountText; // 0x68
	private UISpriteBorderSetting spriteBorder; // 0x70
	private bool isInit; // 0x78

	// Methods

	[IteratorStateMachine(typeof(UINameChangeExtension.<Start>d__15))]
	// RVA: 0x1E8F8E0 Offset: 0x1E8B8E0 VA: 0x1E8F8E0
	private IEnumerator Start() { }

	// RVA: 0x1E8F974 Offset: 0x1E8B974 VA: 0x1E8F974
	private void Update() { }

	// RVA: 0x1E8FAD0 Offset: 0x1E8BAD0 VA: 0x1E8FAD0
	private void LabelUpdate() { }

	// RVA: 0x1E8FB48 Offset: 0x1E8BB48 VA: 0x1E8FB48
	private void CharacterCountUpdate() { }

	// RVA: 0x1E8FC5C Offset: 0x1E8BC5C VA: 0x1E8FC5C
	private void AvailableRemainingLengthSliderUpdate() { }

	// RVA: 0x1E8FE90 Offset: 0x1E8BE90 VA: 0x1E8FE90
	public void .ctor() { }

	// RVA: 0x1E8FF00 Offset: 0x1E8BF00 VA: 0x1E8FF00
	private static void .cctor() { }
}
