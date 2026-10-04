// Assembly: Assembly-CSharp.dll
// Namespace: 
public class D3GLSignboard : MonoBehaviour // TypeDefIndex: 8837
{
	// Fields
	[SerializeField]
	private UIAtlas iconAtlas; // 0x20
	[SerializeField]
	private UIAtlas spriteAtlas; // 0x28
	[SerializeField]
	private UIFont textAtlas; // 0x30
	[SerializeField]
	private UIFont dynamicFont; // 0x38
	private Transform cameraTrans; // 0x40
	private UIBaseSignBoard baseSignBoard; // 0x48
	private Transform traceObj; // 0x50
	private UIGL3DSignboardSpriteSliecedView backSprite; // 0x58
	private UIGL3DSignboardSpriteView iconSprite; // 0x60
	private UIGL3DSignboardLabelView textLabel; // 0x68
	private bool isActive; // 0x70
	private const float BaseLabelSize = 0.012;
	private float labelSize; // 0x74
	private int labelWidth; // 0x78
	private int holdWidth; // 0x7C
	private Material textMaterial; // 0x80
	private Vector3 iconPos; // 0x88
	private const int BaseSpriteWidth = 245;
	private const int BaseSpriteHeight = 35;
	private readonly Vector3 CenterIconPos; // 0x94
	private readonly Vector3 LeftIconPos; // 0xA0

	// Methods

	// RVA: 0x1E2F874 Offset: 0x1E2B874 VA: 0x1E2F874
	private void Update() { }

	// RVA: 0x1E2FAA8 Offset: 0x1E2BAA8 VA: 0x1E2FAA8
	private void LateUpdate() { }

	// RVA: 0x1E2FEDC Offset: 0x1E2BEDC VA: 0x1E2FEDC
	private void OnDestroy() { }

	// RVA: 0x1E2FF7C Offset: 0x1E2BF7C VA: 0x1E2FF7C
	public void Initialize(UIBaseSignBoard baseSignBoard) { }

	// RVA: 0x1E306D8 Offset: 0x1E2C6D8 VA: 0x1E306D8
	public void Render() { }

	// RVA: 0x1E30508 Offset: 0x1E2C508 VA: 0x1E30508
	public void UpdateLabel(string text) { }

	// RVA: 0x1E306A4 Offset: 0x1E2C6A4 VA: 0x1E306A4
	public void SetLabelEnable(bool isEnable) { }

	// RVA: 0x1E30274 Offset: 0x1E2C274 VA: 0x1E30274
	public void UpdateBaseSpriteWidth(D3GLSignboard.BaseWidthType type) { }

	// RVA: 0x1E303C4 Offset: 0x1E2C3C4 VA: 0x1E303C4
	public void UpdateIcon(D3GLSignboard.IconPosType type) { }

	// RVA: 0x1E306B8 Offset: 0x1E2C6B8 VA: 0x1E306B8
	public void SetBaseSpriteColor(Color color) { }

	// RVA: 0x1E2FA50 Offset: 0x1E2BA50 VA: 0x1E2FA50
	private void UpdateLabelSize() { }

	// RVA: 0x1E30AD8 Offset: 0x1E2CAD8 VA: 0x1E30AD8
	private Vector3 GetLabelSize() { }

	// RVA: 0x1E30B8C Offset: 0x1E2CB8C VA: 0x1E30B8C
	public void .ctor() { }
}
