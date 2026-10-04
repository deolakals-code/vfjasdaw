// Assembly: Assembly-CSharp.dll
// Namespace: 
public interface UIItemScrollPanelManager // TypeDefIndex: 8991
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnPress(UIItemScrollPanelButton select);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnRelease(UIItemScrollPanelButton select);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnDrag(UIItemScrollPanelButton select);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnDragRelease(UIItemScrollPanelButton select);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void OnPanelChangeClick();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void OnRightButtonClick();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void OnLeftButtonClick();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void OnFilterButton();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool CheckIconDrag();
}
