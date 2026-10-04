// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIRhythmGameResultElement : MonoBehaviour // TypeDefIndex: 6211
{
	// Fields
	[SerializeField]
	private UILabel rankLabel; // 0x20
	[SerializeField]
	private UILabel nameLabel; // 0x28
	[SerializeField]
	private UILabel scoreLabel; // 0x30
	[SerializeField]
	private UILabel criticalLabel; // 0x38
	[SerializeField]
	private UILabel hitLabel; // 0x40
	[SerializeField]
	private UILabel grazeLabel; // 0x48

	// Methods

	// RVA: 0x18BA6CC Offset: 0x18B66CC VA: 0x18BA6CC
	public void Initialize(string rank, string name, int score, int critical, int hit, int graze) { }

	// RVA: 0x18BA8C8 Offset: 0x18B68C8 VA: 0x18BA8C8
	public void Open(float waitTime) { }

	[IteratorStateMachine(typeof(UIRhythmGameResultElement.<OpenPanel>d__8))]
	// RVA: 0x18BA8E8 Offset: 0x18B68E8 VA: 0x18BA8E8
	private IEnumerator OpenPanel(float waitTime) { }

	// RVA: 0x18BA98C Offset: 0x18B698C VA: 0x18BA98C
	public void .ctor() { }
}
