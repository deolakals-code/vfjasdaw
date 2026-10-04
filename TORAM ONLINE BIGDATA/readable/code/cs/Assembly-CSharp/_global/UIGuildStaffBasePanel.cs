// Assembly: Assembly-CSharp.dll
// Namespace: 
public interface UIGuildStaffBasePanel // TypeDefIndex: 6694
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Initialize(UIGuildStaffMainManager manager, SystemTextManager systemTextManager);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool PushLeftTopButton();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool PushRightTopButton();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract GameObject Panel();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void FadeIn();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IEnumerator FadeOut();
}
