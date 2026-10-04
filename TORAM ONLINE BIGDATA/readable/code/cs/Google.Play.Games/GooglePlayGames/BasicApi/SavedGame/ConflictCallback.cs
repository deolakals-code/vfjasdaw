// Assembly: Google.Play.Games.dll
// Namespace: GooglePlayGames.BasicApi.SavedGame
public sealed class ConflictCallback : MulticastDelegate // TypeDefIndex: 16839
{
	// Methods

	// RVA: 0x2E3384C Offset: 0x2E2F84C VA: 0x2E3384C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2E33958 Offset: 0x2E2F958 VA: 0x2E33958 Slot: 12
	public virtual void Invoke(IConflictResolver resolver, ISavedGameMetadata original, byte[] originalData, ISavedGameMetadata unmerged, byte[] unmergedData) { }

	// RVA: 0x2E3396C Offset: 0x2E2F96C VA: 0x2E3396C Slot: 13
	public virtual IAsyncResult BeginInvoke(IConflictResolver resolver, ISavedGameMetadata original, byte[] originalData, ISavedGameMetadata unmerged, byte[] unmergedData, AsyncCallback callback, object object) { }

	// RVA: 0x2E3399C Offset: 0x2E2F99C VA: 0x2E3399C Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }
}
