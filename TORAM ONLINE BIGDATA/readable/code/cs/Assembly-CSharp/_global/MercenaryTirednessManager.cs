// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MercenaryTirednessManager : MonoBehaviour // TypeDefIndex: 699
{
	// Fields
	private readonly float MexMinutes; // 0x20
	private float time; // 0x24
	private bool isCount; // 0x28
	private int oldMinutes; // 0x2C
	[CompilerGenerated]
	private float <TirednessRate>k__BackingField; // 0x30
	[CompilerGenerated]
	private Action<float> RateChangeEvent; // 0x38

	// Properties
	public int TirednessMinutes { get; }
	public float TirednessRate { get; set; }
	public float TirednessTimeRate { get; }

	// Methods

	// RVA: 0x1AC76A4 Offset: 0x1AC36A4 VA: 0x1AC76A4
	public int get_TirednessMinutes() { }

	[CompilerGenerated]
	// RVA: 0x1AC76D0 Offset: 0x1AC36D0 VA: 0x1AC76D0
	private void set_TirednessRate(float value) { }

	[CompilerGenerated]
	// RVA: 0x1AC76D8 Offset: 0x1AC36D8 VA: 0x1AC76D8
	public float get_TirednessRate() { }

	// RVA: 0x1ABEFB4 Offset: 0x1ABAFB4 VA: 0x1ABEFB4
	public float get_TirednessTimeRate() { }

	[CompilerGenerated]
	// RVA: 0x1ABF24C Offset: 0x1ABB24C VA: 0x1ABF24C
	public void add_RateChangeEvent(Action<float> value) { }

	[CompilerGenerated]
	// RVA: 0x1AC76E0 Offset: 0x1AC36E0 VA: 0x1AC76E0
	public void remove_RateChangeEvent(Action<float> value) { }

	// RVA: 0x1AC7790 Offset: 0x1AC3790 VA: 0x1AC7790
	private void Start() { }

	// RVA: 0x1AC779C Offset: 0x1AC379C VA: 0x1AC779C
	private void Update() { }

	// RVA: 0x1ABEF9C Offset: 0x1ABAF9C VA: 0x1ABEF9C
	public void Init(float startTime, bool useCount) { }

	// RVA: 0x1AC6A88 Offset: 0x1AC2A88 VA: 0x1AC6A88
	public int CalcStatus(int param) { }

	// RVA: 0x1AC786C Offset: 0x1AC386C VA: 0x1AC786C
	public void .ctor() { }
}
