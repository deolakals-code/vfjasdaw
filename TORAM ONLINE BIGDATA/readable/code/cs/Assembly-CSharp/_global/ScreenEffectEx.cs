// Assembly: Assembly-CSharp.dll
// Namespace: 
[AddComponentMenu("Iruna2/Render/ScreenEffectEx")]
public class ScreenEffectEx : MonoBehaviour // TypeDefIndex: 4004
{
	// Fields
	private PlayerDataManager playerDataManager; // 0x20
	private MeshRenderer meshRenderer; // 0x28
	private float fadeParam; // 0x30
	private Color screenColor; // 0x34
	[SerializeField]
	private int screenEffectType; // 0x44
	[SerializeField]
	private int screenEffectUpdateType; // 0x48
	[SerializeField]
	private int[] paramList; // 0x50

	// Properties
	private float BrightnessPower { get; }
	private float ForwardPower { get; }
	private bool IsFloorBrightness { get; }
	private bool IsAreaColor { get; }
	private bool IsCameraForward { get; }
	private bool IsFade { get; }
	private bool IsAlpha { get; }
	private bool IsBrightness { get; }
	private bool IsPower { get; }
	private bool IsParam { get; }
	private bool IsEx { get; }

	// Methods

	// RVA: 0x246E230 Offset: 0x246A230 VA: 0x246E230
	private float get_BrightnessPower() { }

	// RVA: 0x246E260 Offset: 0x246A260 VA: 0x246E260
	private float get_ForwardPower() { }

	// RVA: 0x246E290 Offset: 0x246A290 VA: 0x246E290
	private bool get_IsFloorBrightness() { }

	// RVA: 0x246E29C Offset: 0x246A29C VA: 0x246E29C
	private bool get_IsAreaColor() { }

	// RVA: 0x246E2A8 Offset: 0x246A2A8 VA: 0x246E2A8
	private bool get_IsCameraForward() { }

	// RVA: 0x246E2B4 Offset: 0x246A2B4 VA: 0x246E2B4
	private bool get_IsFade() { }

	// RVA: 0x246E2C0 Offset: 0x246A2C0 VA: 0x246E2C0
	private bool get_IsAlpha() { }

	// RVA: 0x246E2CC Offset: 0x246A2CC VA: 0x246E2CC
	private bool get_IsBrightness() { }

	// RVA: 0x246E2D8 Offset: 0x246A2D8 VA: 0x246E2D8
	private bool get_IsPower() { }

	// RVA: 0x246E2E4 Offset: 0x246A2E4 VA: 0x246E2E4
	private bool get_IsParam() { }

	// RVA: 0x246E2F0 Offset: 0x246A2F0 VA: 0x246E2F0
	private bool get_IsEx() { }

	// RVA: 0x246E2FC Offset: 0x246A2FC VA: 0x246E2FC
	private void Start() { }

	// RVA: 0x246E42C Offset: 0x246A42C VA: 0x246E42C
	private void LateUpdate() { }

	// RVA: 0x246EA4C Offset: 0x246AA4C VA: 0x246EA4C
	private float SetColor(float color, float moveColor, float speed) { }

	// RVA: 0x246EAA8 Offset: 0x246AAA8 VA: 0x246EAA8
	private void SetParam(bool active, Material mat, string type, float setParam) { }

	// RVA: 0x246EB10 Offset: 0x246AB10 VA: 0x246EB10
	public void .ctor() { }
}
