// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class ActionStateBase : IAIAction // TypeDefIndex: 1578
{
	// Fields
	protected IScriptAICentral script_central; // 0x10

	// Properties
	public virtual bool ContinueAction { get; }

	// Methods

	// RVA: 0x208EA84 Offset: 0x208AA84 VA: 0x208EA84 Slot: 6
	public virtual bool get_ContinueAction() { }

	// RVA: 0x208B1EC Offset: 0x20871EC VA: 0x208B1EC
	public void .ctor(IScriptAICentral _script_central) { }

	// RVA: 0x208EA8C Offset: 0x208AA8C VA: 0x208EA8C Slot: 7
	public virtual void OnDrawGizmo() { }

	// RVA: 0x208EA90 Offset: 0x208AA90 VA: 0x208EA90 Slot: 8
	public virtual void Init() { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool Action();

	// RVA: 0x208EA94 Offset: 0x208AA94 VA: 0x208EA94 Slot: 10
	public virtual void DestroyDebugObject() { }
}
