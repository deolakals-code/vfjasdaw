// Assembly: AppsFlyer.dll
// Namespace: AppsFlyerSDK
public interface IAppsFlyerUserInvite // TypeDefIndex: 17306
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void onInviteLinkGenerated(string link);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void onInviteLinkGeneratedFailure(string error);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void onOpenStoreLinkGenerated(string link);
}
