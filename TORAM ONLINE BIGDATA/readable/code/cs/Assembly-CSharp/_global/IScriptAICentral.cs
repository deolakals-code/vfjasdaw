// Assembly: Assembly-CSharp.dll
// Namespace: 
public interface IScriptAICentral // TypeDefIndex: 1614
{
	// Properties
	public abstract GameObject Mine { get; }
	public abstract GameObject Target { get; }
	public abstract IMove CharaMove { get; }
	public abstract AnimationBase Animation { get; }
	public abstract RouteDataManager RouteManager { get; }
	public abstract bool ExistMasteryComponent { get; }
	public abstract MasteryScriptAI MasteryScriptAi { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract GameObject get_Mine();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract GameObject get_Target();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IMove get_CharaMove();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract AnimationBase get_Animation();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract RouteDataManager get_RouteManager();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_ExistMasteryComponent();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract MasteryScriptAI get_MasteryScriptAi();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void ChangeStateAction(int _no);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract int GetPropertyData(AIDataProperty _accesser);
}
