// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ScreenIceFadeManager : MonoBehaviour // TypeDefIndex: 1553
{
	// Fields
	private float mask; // 0x20
	private MeshRenderer meshRenderer; // 0x28
	private Coroutine fadeCoroutine; // 0x30
	[CompilerGenerated]
	private float <CurrentMask>k__BackingField; // 0x38

	// Properties
	public bool IsFade { get; }
	public float CurrentMask { get; set; }

	// Methods

	// RVA: 0x2089BDC Offset: 0x2085BDC VA: 0x2089BDC
	public bool get_IsFade() { }

	[CompilerGenerated]
	// RVA: 0x2089BEC Offset: 0x2085BEC VA: 0x2089BEC
	public float get_CurrentMask() { }

	[CompilerGenerated]
	// RVA: 0x2089BF4 Offset: 0x2085BF4 VA: 0x2089BF4
	private void set_CurrentMask(float value) { }

	// RVA: 0x2089BFC Offset: 0x2085BFC VA: 0x2089BFC
	public void Initialize() { }

	// RVA: 0x2089C0C Offset: 0x2085C0C VA: 0x2089C0C
	public void SetRenderer(float mask) { }

	// RVA: 0x2089D94 Offset: 0x2085D94 VA: 0x2089D94
	public void FadeRenderer(float startMask, float endMask, float timer) { }

	// RVA: 0x2089E80 Offset: 0x2085E80 VA: 0x2089E80
	public void StopFade() { }

	[IteratorStateMachine(typeof(ScreenIceFadeManager.<FadeProc>d__13))]
	// RVA: 0x2089DFC Offset: 0x2085DFC VA: 0x2089DFC
	private IEnumerator FadeProc(float addMask, float time) { }

	// RVA: 0x2089EBC Offset: 0x2085EBC VA: 0x2089EBC
	public void .ctor() { }
}
