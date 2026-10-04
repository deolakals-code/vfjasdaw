// Assembly: Assembly-CSharp-firstpass.dll
// Namespace: Asobimo.Plugin
public interface IAsobimoAuthListener // TypeDefIndex: 17140
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnLogin();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnLoginError(string code, bool reboot, bool localizeKey);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnCheckToken(bool isValid);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnRefreshToken(bool isSuccess);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void OnCloseMenu();
}
