// Assembly: Assembly-CSharp.dll
// Namespace: BlackKnightAI
public class MobBlackKnightTaskAction : IMobBlackKnightTask // TypeDefIndex: 9109
{
	// Fields
	private bool isDoneFirstAction; // 0x10
	private MobBlackKnightAIConditionBase condition; // 0x18
	private IMobBlackKnightAction firstAction; // 0x20
	private IMobBlackKnightAction continueAction; // 0x28
	private bool forceEnd; // 0x30

	// Properties
	public bool isEndTask { get; }

	// Methods

	// RVA: 0x1EAD8F8 Offset: 0x1EA98F8 VA: 0x1EAD8F8 Slot: 4
	public bool get_isEndTask() { }

	// RVA: 0x1EAD898 Offset: 0x1EA9898 VA: 0x1EAD898
	public void .ctor(IMobBlackKnightAction firstAction, MobBlackKnightAIConditionBase conditionAction, IMobBlackKnightAction continueAction) { }

	// RVA: 0x1EAD920 Offset: 0x1EA9920 VA: 0x1EAD920 Slot: 8
	public virtual void FirstAction() { }

	// RVA: 0x1EAD9D4 Offset: 0x1EA99D4 VA: 0x1EAD9D4 Slot: 9
	public virtual void Action() { }

	// RVA: 0x1EADAB0 Offset: 0x1EA9AB0 VA: 0x1EADAB0 Slot: 7
	public void ActionEnd() { }
}
