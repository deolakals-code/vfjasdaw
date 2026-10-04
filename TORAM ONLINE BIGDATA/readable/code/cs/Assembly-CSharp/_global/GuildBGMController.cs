// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GuildBGMController : IUIGuildCustomController // TypeDefIndex: 6600
{
	// Fields
	private List<GuildHomeRecipeData> recipeDataList; // 0x10

	// Methods

	// RVA: 0x1994714 Offset: 0x1990714 VA: 0x1994714 Slot: 6
	public int GetCurrentId() { }

	// RVA: 0x1994820 Offset: 0x1990820 VA: 0x1994820 Slot: 7
	public byte GetOpenSubCode() { }

	// RVA: 0x1994828 Offset: 0x1990828 VA: 0x1994828 Slot: 8
	public byte GetChangeSubCode() { }

	// RVA: 0x1994830 Offset: 0x1990830 VA: 0x1994830 Slot: 14
	public bool HasPreview() { }

	// RVA: 0x1994838 Offset: 0x1990838 VA: 0x1994838 Slot: 11
	public bool IsCheckConnection(byte subCode) { }

	[IteratorStateMachine(typeof(GuildBGMController.<LoadMasterData>d__7))]
	// RVA: 0x1994894 Offset: 0x1990894 VA: 0x1994894 Slot: 5
	public IEnumerator LoadMasterData(Action<List<GuildHomeRecipeData>> onLoaded, Action onError) { }

	[IteratorStateMachine(typeof(GuildBGMController.<OnPreview>d__8))]
	// RVA: 0x1994958 Offset: 0x1990958 VA: 0x1994958 Slot: 15
	public IEnumerator OnPreview(int id, Transform parent, Action callBack) { }

	// RVA: 0x1994A2C Offset: 0x1990A2C VA: 0x1994A2C Slot: 10
	public void SendChangeRequest(int id) { }

	// RVA: 0x1994B84 Offset: 0x1990B84 VA: 0x1994B84 Slot: 9
	public void SendOpenRequest(int id) { }

	// RVA: 0x1994C64 Offset: 0x1990C64 VA: 0x1994C64 Slot: 12
	public bool TryGetError(byte subCode, out short code) { }

	// RVA: 0x1994CD0 Offset: 0x1990CD0 VA: 0x1994CD0
	private List<GuildHomeRecipeData> ParseBinary(byte[] binary) { }

	// RVA: 0x19953E4 Offset: 0x19913E4 VA: 0x19953E4 Slot: 4
	public GuildCustomUIData GetUIData() { }

	// RVA: 0x19955B4 Offset: 0x19915B4 VA: 0x19955B4 Slot: 13
	public float GetLoadWaitTime() { }

	// RVA: 0x19955BC Offset: 0x19915BC VA: 0x19955BC Slot: 16
	public void Destroy() { }

	// RVA: 0x1995610 Offset: 0x1991610 VA: 0x1995610 Slot: 17
	public bool CheckOpen(int id) { }

	// RVA: 0x1995644 Offset: 0x1991644 VA: 0x1995644 Slot: 18
	public bool CheckUnlockable(long id) { }

	// RVA: 0x199564C Offset: 0x199164C VA: 0x199564C Slot: 19
	public bool HasSelectionAuthority() { }

	// RVA: 0x1995654 Offset: 0x1991654 VA: 0x1995654 Slot: 20
	public bool HasOpenAuthority() { }

	// RVA: 0x19956A0 Offset: 0x19916A0 VA: 0x19956A0
	public void .ctor() { }
}
