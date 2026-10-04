// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class MercenaryAIStateBase : IStateData, IDisposable, INPCParameter // TypeDefIndex: 613
{
	// Fields
	protected IAICentral aiCentral; // 0x10
	[CompilerGenerated]
	private IEnumerator <State>k__BackingField; // 0x18
	[CompilerGenerated]
	private AutoMember <AutoMember>k__BackingField; // 0x20
	[CompilerGenerated]
	private CharacterActionManagerBase <Owner>k__BackingField; // 0x28

	// Properties
	public IEnumerator State { get; set; }
	protected AutoMember AutoMember { get; set; }
	protected CharacterActionManagerBase Owner { get; set; }

	// Methods

	// RVA: 0x19DF85C Offset: 0x19DB85C VA: 0x19DF85C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x19DF894 Offset: 0x19DB894 VA: 0x19DF894 Slot: 5
	public IEnumerator get_State() { }

	[CompilerGenerated]
	// RVA: 0x19DF89C Offset: 0x19DB89C VA: 0x19DF89C
	private void set_State(IEnumerator value) { }

	[CompilerGenerated]
	// RVA: 0x19DF8A4 Offset: 0x19DB8A4 VA: 0x19DF8A4
	protected AutoMember get_AutoMember() { }

	[CompilerGenerated]
	// RVA: 0x19DF8AC Offset: 0x19DB8AC VA: 0x19DF8AC Slot: 11
	public void set_AutoMember(AutoMember value) { }

	[CompilerGenerated]
	// RVA: 0x19DF8B4 Offset: 0x19DB8B4 VA: 0x19DF8B4
	protected CharacterActionManagerBase get_Owner() { }

	[CompilerGenerated]
	// RVA: 0x19DF8BC Offset: 0x19DB8BC VA: 0x19DF8BC Slot: 12
	public void set_Owner(CharacterActionManagerBase value) { }

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void ChackTransition(IAICentral central);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void Dispose();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void LateUpdate();

	// RVA: 0x19DF8C4 Offset: 0x19DB8C4 VA: 0x19DF8C4 Slot: 7
	public void SetCentral(IAICentral central) { }

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void TurnEnd(IAICentral central);

	// RVA: -1 Offset: -1 Slot: 17
	protected abstract IEnumerator GetState();

	[IteratorStateMachine(typeof(MercenaryAIStateBase.<somethingActionWait>d__20))]
	// RVA: 0x19DF8CC Offset: 0x19DB8CC VA: 0x19DF8CC
	protected IEnumerator somethingActionWait(float waitTime, Func<float, bool> act) { }

	[IteratorStateMachine(typeof(MercenaryAIStateBase.<GetParam>d__21))]
	// RVA: 0x19DF970 Offset: 0x19DB970 VA: 0x19DF970 Slot: 18
	public virtual IEnumerable<string> GetParam() { }

	// RVA: 0x19DFA20 Offset: 0x19DBA20 VA: 0x19DFA20
	protected Vector3 MoveWrapper(CharacterMove charaMove, Vector3 move, Vector3 oldMove, float nowRate, float moveSpeed) { }
}
