// Assembly: Google.Play.Games.dll
// Namespace: GooglePlayGames
internal sealed class ReportProgress : MulticastDelegate // TypeDefIndex: 16699
{
	// Methods

	// RVA: 0x2E08604 Offset: 0x2E04604 VA: 0x2E08604
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2E086B8 Offset: 0x2E046B8 VA: 0x2E086B8 Slot: 12
	public virtual void Invoke(string id, double progress, Action<bool> callback) { }

	// RVA: 0x2E086CC Offset: 0x2E046CC VA: 0x2E086CC Slot: 13
	public virtual IAsyncResult BeginInvoke(string id, double progress, Action<bool> callback, AsyncCallback __callback, object object) { }

	// RVA: 0x2E08764 Offset: 0x2E04764 VA: 0x2E08764 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }
}
