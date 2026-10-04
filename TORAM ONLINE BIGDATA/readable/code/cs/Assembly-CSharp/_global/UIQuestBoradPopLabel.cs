// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIQuestBoradPopLabel : MonoBehaviour // TypeDefIndex: 7891
{
	// Fields
	[SerializeField]
	private UILabel messageLabel; // 0x20
	[SerializeField]
	private UILabel paramLabel; // 0x28
	[SerializeField]
	private TweenAlpha flashTween; // 0x30
	private bool effectCheck; // 0x38

	// Properties
	public bool IsEffectCheck { get; }

	// Methods

	// RVA: 0x1C5701C Offset: 0x1C5301C VA: 0x1C5701C
	public bool get_IsEffectCheck() { }

	// RVA: 0x1C5704C Offset: 0x1C5304C VA: 0x1C5704C
	public void Initialize(string message, string param, bool effect, bool enterCheck) { }

	// RVA: 0x1C571E0 Offset: 0x1C531E0 VA: 0x1C571E0
	public void FlashEffect() { }

	// RVA: 0x1C57320 Offset: 0x1C53320 VA: 0x1C57320
	public void .ctor() { }
}
