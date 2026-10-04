// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UITouchEffectManager : MonoBehaviour // TypeDefIndex: 9054
{
	// Fields
	private const int MaxTouchNum = 16;
	[SerializeField]
	private Camera viewCamera; // 0x20
	[SerializeField]
	private UIAtlas tapAtlas; // 0x28
	private int[] missTapIdList; // 0x30
	private int missTapIndex; // 0x38
	private Material tapMaterial; // 0x40
	private Rect tapUV; // 0x48
	private int tapCreateIndex; // 0x58
	private byte updateFrame; // 0x5C
	private UITouchEffectManager.TapData[] tapDataList; // 0x60
	private bool renderSkip; // 0x68
	private bool hideTapEffect; // 0x69

	// Methods

	// RVA: 0x1EA30F8 Offset: 0x1E9F0F8 VA: 0x1EA30F8
	private void Awake() { }

	// RVA: 0x1EA32BC Offset: 0x1E9F2BC VA: 0x1EA32BC
	public void AddMissTouchEffect(int touchId) { }

	// RVA: 0x1EA3304 Offset: 0x1E9F304 VA: 0x1EA3304
	public void SetHideTapEffect(bool hideFlag) { }

	// RVA: 0x1EA3310 Offset: 0x1E9F310 VA: 0x1EA3310
	private void LateUpdate() { }

	// RVA: 0x1EA35D4 Offset: 0x1E9F5D4 VA: 0x1EA35D4
	private void UpdateTapData(int id, Vector3 pos, float deltaTime) { }

	// RVA: 0x1EA3978 Offset: 0x1E9F978 VA: 0x1EA3978
	public void OnRenderObject() { }

	// RVA: 0x1EA3C00 Offset: 0x1E9FC00 VA: 0x1EA3C00
	public void .ctor() { }
}
