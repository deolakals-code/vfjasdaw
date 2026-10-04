// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UICraneGameFlashingManager : MonoBehaviour // TypeDefIndex: 4315
{
	// Fields
	[SerializeField]
	private AnimationCurve curve; // 0x20
	[SerializeField]
	private Color firstColor; // 0x28
	[SerializeField]
	private Color secondColor; // 0x38
	[SerializeField]
	private UISprite targetSprite; // 0x48
	[SerializeField]
	private float delayTime; // 0x50
	private float value; // 0x54
	private bool isMoveAnimation; // 0x58

	// Properties
	public bool IsMoveAnimation { get; set; }

	// Methods

	// RVA: 0x24CD888 Offset: 0x24C9888 VA: 0x24CD888
	public bool get_IsMoveAnimation() { }

	// RVA: 0x24CD890 Offset: 0x24C9890 VA: 0x24CD890
	public void set_IsMoveAnimation(bool value) { }

	[IteratorStateMachine(typeof(UICraneGameFlashingManager.<LoopAnimation>d__10))]
	// RVA: 0x24CD89C Offset: 0x24C989C VA: 0x24CD89C
	public IEnumerator LoopAnimation() { }

	// RVA: 0x24CD930 Offset: 0x24C9930 VA: 0x24CD930
	public void .ctor() { }
}
