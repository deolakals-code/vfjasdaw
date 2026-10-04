// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UICardGameCardBase : MonoBehaviour // TypeDefIndex: 5670
{
	// Fields
	[SerializeField]
	protected BoxCollider col; // 0x20
	protected CardGamePlayerCard status; // 0x28
	protected bool select; // 0x30
	protected Vector3 offset; // 0x34
	protected Vector3 lastPos; // 0x40
	private TweenPosition tweenPosition; // 0x50

	// Properties
	protected bool IsMove { get; }
	public CardGamePlayerCard Status { get; }
	public bool isEnable { get; set; }

	// Methods

	// RVA: 0x17C2FB8 Offset: 0x17BEFB8 VA: 0x17C2FB8
	protected bool get_IsMove() { }

	// RVA: 0x17C3040 Offset: 0x17BF040 VA: 0x17C3040
	public CardGamePlayerCard get_Status() { }

	// RVA: 0x17C3048 Offset: 0x17BF048 VA: 0x17C3048
	public bool get_isEnable() { }

	// RVA: 0x17C3064 Offset: 0x17BF064 VA: 0x17C3064
	public void set_isEnable(bool value) { }

	// RVA: 0x17C3084 Offset: 0x17BF084 VA: 0x17C3084
	private void DragCardUpdate() { }

	// RVA: 0x17C31F4 Offset: 0x17BF1F4 VA: 0x17C31F4
	protected void BaseUpdate() { }

	// RVA: 0x17C3218 Offset: 0x17BF218 VA: 0x17C3218
	protected void PressedCard(bool isPushCard) { }

	// RVA: 0x17C3320 Offset: 0x17BF320 VA: 0x17C3320 Slot: 4
	public virtual void OnClickCard() { }

	// RVA: 0x17C3324 Offset: 0x17BF324 VA: 0x17C3324 Slot: 5
	public virtual void OnPressCard() { }

	// RVA: 0x17C3328 Offset: 0x17BF328 VA: 0x17C3328 Slot: 6
	public virtual void OnReleaseCard() { }

	// RVA: 0x17C332C Offset: 0x17BF32C VA: 0x17C332C
	public void movePosition(Vector3 pos, float time) { }

	// RVA: 0x17C3408 Offset: 0x17BF408 VA: 0x17C3408
	public void movePosition(Vector3 start, Vector3 end, float time) { }

	// RVA: 0x17C3524 Offset: 0x17BF524 VA: 0x17C3524
	public void .ctor() { }
}
