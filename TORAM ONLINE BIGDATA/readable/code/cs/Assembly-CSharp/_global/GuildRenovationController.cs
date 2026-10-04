// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GuildRenovationController : IUIGuildCustomController // TypeDefIndex: 6592
{
	// Methods

	// RVA: 0x1993688 Offset: 0x198F688 VA: 0x1993688 Slot: 6
	public int GetCurrentId() { }

	// RVA: 0x19936B4 Offset: 0x198F6B4 VA: 0x19936B4 Slot: 7
	public byte GetOpenSubCode() { }

	// RVA: 0x19936BC Offset: 0x198F6BC VA: 0x19936BC Slot: 8
	public byte GetChangeSubCode() { }

	// RVA: 0x19936C4 Offset: 0x198F6C4 VA: 0x19936C4 Slot: 14
	public bool HasPreview() { }

	// RVA: 0x19936CC Offset: 0x198F6CC VA: 0x19936CC Slot: 11
	public bool IsCheckConnection(byte subCode) { }

	[IteratorStateMachine(typeof(GuildRenovationController.<LoadMasterData>d__5))]
	// RVA: 0x1993728 Offset: 0x198F728 VA: 0x1993728 Slot: 5
	public IEnumerator LoadMasterData(Action<List<GuildHomeRecipeData>> onLoaded, Action onError) { }

	[IteratorStateMachine(typeof(GuildRenovationController.<OnPreview>d__6))]
	// RVA: 0x19937EC Offset: 0x198F7EC VA: 0x19937EC Slot: 15
	public IEnumerator OnPreview(int id, Transform parent, Action callBack) { }

	// RVA: 0x1993880 Offset: 0x198F880 VA: 0x1993880 Slot: 10
	public void SendChangeRequest(int id) { }

	// RVA: 0x19938D8 Offset: 0x198F8D8 VA: 0x19938D8 Slot: 9
	public void SendOpenRequest(int id) { }

	// RVA: 0x1993930 Offset: 0x198F930 VA: 0x1993930 Slot: 12
	public bool TryGetError(byte subCode, out short code) { }

	// RVA: 0x199399C Offset: 0x198F99C VA: 0x199399C
	private List<GuildHomeRecipeData> ParseBinary(byte[] binary) { }

	// RVA: 0x199407C Offset: 0x199007C VA: 0x199407C Slot: 4
	public GuildCustomUIData GetUIData() { }

	// RVA: 0x1994284 Offset: 0x1990284 VA: 0x1994284 Slot: 13
	public float GetLoadWaitTime() { }

	// RVA: 0x199428C Offset: 0x199028C VA: 0x199428C Slot: 16
	public void Destroy() { }

	// RVA: 0x1994290 Offset: 0x1990290 VA: 0x1994290 Slot: 17
	public bool CheckOpen(int id) { }

	// RVA: 0x19942D4 Offset: 0x19902D4 VA: 0x19942D4 Slot: 18
	public bool CheckUnlockable(long id) { }

	// RVA: 0x199430C Offset: 0x199030C VA: 0x199430C Slot: 19
	public bool HasSelectionAuthority() { }

	// RVA: 0x1994358 Offset: 0x1990358 VA: 0x1994358 Slot: 20
	public bool HasOpenAuthority() { }

	// RVA: 0x19943A4 Offset: 0x19903A4 VA: 0x19943A4
	public void .ctor() { }
}
