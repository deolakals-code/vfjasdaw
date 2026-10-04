// Assembly: Unity.Services.Analytics.dll
// Namespace: Unity.Services.Analytics.Internal
internal interface IIdentityManager // TypeDefIndex: 17452
{
	// Properties
	public abstract string UserId { get; }
	public abstract string InstallId { get; }
	public abstract string PlayerId { get; }
	public abstract bool IsNewPlayer { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_UserId();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_InstallId();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string get_PlayerId();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool get_IsNewPlayer();

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 4
	public abstract void add_OnPlayerChanged(Action value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 5
	public abstract void remove_OnPlayerChanged(Action value);
}
