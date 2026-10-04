// Assembly: Assembly-CSharp.dll
// Namespace: 
public class AICentralManager : MonoBehaviour, IAICentral // TypeDefIndex: 604
{
	// Fields
	private int _StackCount; // 0x20
	private IStateData _LastSelectedState; // 0x28
	private Stack<IStateData> stateStack; // 0x30
	private bool isPlay; // 0x38
	[CompilerGenerated]
	private IStateData <DefaultTransition>k__BackingField; // 0x40
	[CompilerGenerated]
	private Func<AIStateType, IStateData> <Factory>k__BackingField; // 0x48

	// Properties
	private IStateData DefaultTransition { get; set; }
	private Func<AIStateType, IStateData> Factory { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x19DE314 Offset: 0x19DA314 VA: 0x19DE314
	private IStateData get_DefaultTransition() { }

	[CompilerGenerated]
	// RVA: 0x19DE31C Offset: 0x19DA31C VA: 0x19DE31C
	private void set_DefaultTransition(IStateData value) { }

	[CompilerGenerated]
	// RVA: 0x19DE324 Offset: 0x19DA324 VA: 0x19DE324
	private Func<AIStateType, IStateData> get_Factory() { }

	[CompilerGenerated]
	// RVA: 0x19DE32C Offset: 0x19DA32C VA: 0x19DE32C
	private void set_Factory(Func<AIStateType, IStateData> value) { }

	// RVA: 0x19DE334 Offset: 0x19DA334 VA: 0x19DE334 Slot: 7
	public void Reset() { }

	// RVA: 0x19DE528 Offset: 0x19DA528 VA: 0x19DE528
	public void SetStateData(IStateData state) { }

	// RVA: 0x19DE604 Offset: 0x19DA604 VA: 0x19DE604 Slot: 5
	public IStateData SetStateData(AIStateType type) { }

	// RVA: 0x19DE650 Offset: 0x19DA650 VA: 0x19DE650
	public void ForcingStateChange(IStateData state) { }

	// RVA: 0x19DE678 Offset: 0x19DA678 VA: 0x19DE678 Slot: 6
	public IStateData ForcingStateChange(AIStateType type) { }

	// RVA: 0x19DE6A0 Offset: 0x19DA6A0 VA: 0x19DE6A0
	private void Update() { }

	// RVA: 0x19DE97C Offset: 0x19DA97C VA: 0x19DE97C
	private void LateUpdate() { }

	[IteratorStateMachine(typeof(AICentralManager.<GetParam>d__19))]
	// RVA: 0x19DEA68 Offset: 0x19DAA68 VA: 0x19DEA68 Slot: 4
	public IEnumerable<string> GetParam() { }

	// RVA: 0x19DEB18 Offset: 0x19DAB18 VA: 0x19DEB18 Slot: 8
	public void Stop() { }

	// RVA: 0x19DEB20 Offset: 0x19DAB20 VA: 0x19DEB20 Slot: 9
	public void AIStart() { }

	// RVA: 0x19DEB2C Offset: 0x19DAB2C VA: 0x19DEB2C Slot: 10
	public void Init(IStateData defaultTransition, Func<AIStateType, IStateData> factory) { }

	// RVA: 0x19DEB60 Offset: 0x19DAB60 VA: 0x19DEB60
	public void .ctor() { }
}
