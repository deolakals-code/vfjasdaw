// Assembly: Assembly-CSharp.dll
// Namespace: 
public interface ICamaraInputManager // TypeDefIndex: 368
{
	// Properties
	public abstract bool RightInputKey { get; }
	public abstract Vector2 RightInputFirstDeltaValue { get; }
	public abstract bool ScreenTapInputKey { get; }
	public abstract bool IsScreenPress { get; }
	public abstract bool ScreenPinchInputKey { get; }
	public abstract float ScreenPinchInputValue { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_RightInputKey();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Vector2 get_RightInputFirstDeltaValue();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_ScreenTapInputKey();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool get_IsScreenPress();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool get_ScreenPinchInputKey();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract float get_ScreenPinchInputValue();
}
