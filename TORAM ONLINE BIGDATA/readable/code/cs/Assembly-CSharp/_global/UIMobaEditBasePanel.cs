// Assembly: Assembly-CSharp.dll
// Namespace: 
public interface UIMobaEditBasePanel // TypeDefIndex: 6100
{
	// Properties
	public abstract bool IsActive { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Initialize(MobaRoomData mobaRoomData, UIMobaMainGamePanel mainPanel);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IEnumerator PushLeftTopButton(Action<bool> stayCheck);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IEnumerator PushRightTopButton(Action<bool> stayCheck);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract IEnumerator FadeIn();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IEnumerator FadeOut();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsActive();
}
