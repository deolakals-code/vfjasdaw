// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIGLGaugeBase : MonoBehaviour // TypeDefIndex: 6524
{
	// Fields
	[SerializeField]
	protected UIGLSpriteRadial frontSprite; // 0x20
	[SerializeField]
	protected UIGLSpriteRadial backSprite; // 0x28
	[SerializeField]
	protected UIGLLabel label; // 0x30
	[SerializeField]
	protected UIGLSprite icon; // 0x38
	[SerializeField]
	protected UIGLSprite subIcon; // 0x40
	[SerializeField]
	protected bool isNotice; // 0x48
	[SerializeField]
	protected GameObject circlePointObj; // 0x50
	[SerializeField]
	protected UIGLSpriteRadial circlePointSprite; // 0x58
	protected float alpha; // 0x60
	protected float backParam; // 0x64
	protected float rate; // 0x68
	protected float noticeTimer; // 0x6C
	protected int prevCount; // 0x70
	protected int prevTextNum; // 0x74
	protected const float noticeAlpha = 0.5;
	protected UIIruna2Anchor anchor; // 0x78
	protected const float maxRaid = 280;
	protected float maxPointRaid; // 0x80
	protected PlayerDataManager playerDataManager; // 0x88
	protected readonly Color defaultColor; // 0x90
	protected readonly Color crashColor; // 0xA0

	// Methods

	// RVA: 0x196A278 Offset: 0x1966278 VA: 0x196A278 Slot: 4
	protected virtual void Start() { }

	// RVA: 0x196A5AC Offset: 0x19665AC VA: 0x196A5AC
	protected bool IsBattleActive() { }

	// RVA: 0x196A67C Offset: 0x196667C VA: 0x196A67C Slot: 5
	protected virtual void Update() { }

	// RVA: 0x196A680 Offset: 0x1966680 VA: 0x196A680 Slot: 6
	public virtual void Fade(bool flag) { }

	// RVA: 0x196A684 Offset: 0x1966684 VA: 0x196A684
	public void .ctor() { }
}
