// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GemEffectPlayer : MonoBehaviour // TypeDefIndex: 286
{
	// Fields
	private TakeController takeController; // 0x20
	private int[] gemList; // 0x28
	private int takeUid; // 0x30
	private GemEffectPlayer.EffectType effectType; // 0x34
	private TextManagerBase textManager; // 0x38

	// Methods

	// RVA: 0x22B495C Offset: 0x22B095C VA: 0x22B495C
	public void Initialize(int[] gemList, GameObject target, GemEffectPlayer.EffectType type = 0) { }

	// RVA: 0x22B4AAC Offset: 0x22B0AAC VA: 0x22B4AAC
	public void OnEvent(int takePlayerUid, TakeEventType eventType, int param) { }

	[IteratorStateMachine(typeof(GemEffectPlayer.<PopLabelThread>d__8))]
	// RVA: 0x22B4B00 Offset: 0x22B0B00 VA: 0x22B4B00
	private IEnumerator PopLabelThread() { }

	// RVA: 0x22B4B94 Offset: 0x22B0B94 VA: 0x22B4B94
	private string GetEffectLabelText(int id) { }

	// RVA: 0x22B4D28 Offset: 0x22B0D28 VA: 0x22B4D28
	public void .ctor() { }
}
