// Assembly: UnityEngine.AnimationModule.dll
// Namespace: UnityEngine
[RequiredByNativeCode]
public abstract class StateMachineBehaviour : ScriptableObject // TypeDefIndex: 17664
{
	// Methods

	// RVA: 0x37C79F4 Offset: 0x37C39F4 VA: 0x37C79F4 Slot: 4
	public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x37C79F8 Offset: 0x37C39F8 VA: 0x37C79F8 Slot: 5
	public virtual void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x37C79FC Offset: 0x37C39FC VA: 0x37C79FC Slot: 6
	public virtual void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x37C7A00 Offset: 0x37C3A00 VA: 0x37C7A00 Slot: 7
	public virtual void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x37C7A04 Offset: 0x37C3A04 VA: 0x37C7A04 Slot: 8
	public virtual void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x37C7A08 Offset: 0x37C3A08 VA: 0x37C7A08 Slot: 9
	public virtual void OnStateMachineEnter(Animator animator, int stateMachinePathHash) { }

	// RVA: 0x37C7A0C Offset: 0x37C3A0C VA: 0x37C7A0C Slot: 10
	public virtual void OnStateMachineExit(Animator animator, int stateMachinePathHash) { }

	// RVA: 0x37C7A10 Offset: 0x37C3A10 VA: 0x37C7A10 Slot: 11
	public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x37C7A14 Offset: 0x37C3A14 VA: 0x37C7A14 Slot: 12
	public virtual void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x37C7A18 Offset: 0x37C3A18 VA: 0x37C7A18 Slot: 13
	public virtual void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x37C7A1C Offset: 0x37C3A1C VA: 0x37C7A1C Slot: 14
	public virtual void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x37C7A20 Offset: 0x37C3A20 VA: 0x37C7A20 Slot: 15
	public virtual void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x37C7A24 Offset: 0x37C3A24 VA: 0x37C7A24 Slot: 16
	public virtual void OnStateMachineEnter(Animator animator, int stateMachinePathHash, AnimatorControllerPlayable controller) { }

	// RVA: 0x37C7A28 Offset: 0x37C3A28 VA: 0x37C7A28 Slot: 17
	public virtual void OnStateMachineExit(Animator animator, int stateMachinePathHash, AnimatorControllerPlayable controller) { }

	// RVA: 0x37C7A2C Offset: 0x37C3A2C VA: 0x37C7A2C
	protected void .ctor() { }
}
