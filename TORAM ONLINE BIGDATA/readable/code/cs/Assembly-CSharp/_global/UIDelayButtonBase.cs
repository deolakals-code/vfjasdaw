// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIDelayButtonBase : MonoBehaviour // TypeDefIndex: 6497
{
	// Fields
	[SerializeField]
	protected UIGLSpriteTransition buttonSprite; // 0x20
	[SerializeField]
	protected UIGLSprite shortcutIcon; // 0x28
	[SerializeField]
	protected UIGLLabel delayTimeLabel; // 0x30
	[SerializeField]
	protected UIGLLabel nameLabel; // 0x38
	[SerializeField]
	protected UIGLImageButton imageButton; // 0x40
	protected SystemTextManager systemTextManager; // 0x48
	protected bool activeStick; // 0x50
	protected UIIruna2Anchor anchor; // 0x58
	protected PlayerBattleManager battleManager; // 0x60
	protected bool isEnabled; // 0x68

	// Methods

	// RVA: 0x195EC00 Offset: 0x195AC00 VA: 0x195EC00 Slot: 4
	protected virtual void Start() { }

	// RVA: 0x195ECF0 Offset: 0x195ACF0 VA: 0x195ECF0 Slot: 5
	protected virtual void Update() { }

	// RVA: 0x195ECF4 Offset: 0x195ACF4 VA: 0x195ECF4 Slot: 6
	protected virtual void OnPress(bool isDown) { }

	// RVA: 0x195ECF8 Offset: 0x195ACF8 VA: 0x195ECF8
	protected void SetDelayTimeLabel(int time) { }

	// RVA: 0x195EDC8 Offset: 0x195ADC8 VA: 0x195EDC8 Slot: 7
	public virtual void Fade(bool flag) { }

	// RVA: 0x195EDCC Offset: 0x195ADCC VA: 0x195EDCC
	public void .ctor() { }
}
