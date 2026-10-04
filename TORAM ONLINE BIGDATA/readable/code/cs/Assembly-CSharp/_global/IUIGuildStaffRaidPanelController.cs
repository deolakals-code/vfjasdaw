// Assembly: Assembly-CSharp.dll
// Namespace: 
public interface IUIGuildStaffRaidPanelController // TypeDefIndex: 6695
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void ChangeOrbPanelEnable(bool isEnable);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IEnumerator ConnectWait(Func<bool> connectCheck, Action callback);
}
