// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class UIBasePanel : MonoBehaviour // TypeDefIndex: 8857
{
	// Fields
	protected SystemTextManager systemTextManager; // 0x20
	protected bool shortcutChangeState; // 0x28

	// Properties
	public bool ShortcutChangeState { get; }

	// Methods

	// RVA: 0x1E39F20 Offset: 0x1E35F20 VA: 0x1E39F20
	public bool get_ShortcutChangeState() { }

	// RVA: 0x1E39F28 Offset: 0x1E35F28 VA: 0x1E39F28 Slot: 4
	public virtual void OnOpenShortcutPanel(GameObject shortcutManager) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void OnLeftTopButton();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void OnRightTopButton();

	// RVA: 0x1E39F2C Offset: 0x1E35F2C VA: 0x1E39F2C
	protected void .ctor() { }
}
