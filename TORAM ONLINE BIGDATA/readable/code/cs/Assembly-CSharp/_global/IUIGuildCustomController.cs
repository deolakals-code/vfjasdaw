// Assembly: Assembly-CSharp.dll
// Namespace: 
public interface IUIGuildCustomController // TypeDefIndex: 6588
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract GuildCustomUIData GetUIData();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IEnumerator LoadMasterData(Action<List<GuildHomeRecipeData>> onLoaded, Action onError);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int GetCurrentId();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract byte GetOpenSubCode();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract byte GetChangeSubCode();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void SendOpenRequest(int id);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void SendChangeRequest(int id);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool IsCheckConnection(byte subCode);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool TryGetError(byte subCode, out short code);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract float GetLoadWaitTime();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract bool HasPreview();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract IEnumerator OnPreview(int id, Transform parent, Action callBack);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void Destroy();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract bool CheckOpen(int id);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract bool CheckUnlockable(long id);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract bool HasSelectionAuthority();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract bool HasOpenAuthority();
}
