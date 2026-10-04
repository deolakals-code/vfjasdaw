// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FunctionLimitManager : Singleton<FunctionLimitManager> // TypeDefIndex: 4023
{
	// Fields
	private Dictionary<int, GameSystemFlagData> limitedFunction; // 0x20
	private Dictionary<int, GameSystemFlagData> cdnlimitedFunction; // 0x28
	private int cdnGamesystemFlagVersion; // 0x30

	// Methods

	// RVA: 0x2471C74 Offset: 0x246DC74 VA: 0x2471C74
	public void .ctor() { }

	[IteratorStateMachine(typeof(FunctionLimitManager.<DownloadCsv>d__5))]
	// RVA: 0x2471D3C Offset: 0x246DD3C VA: 0x2471D3C
	private IEnumerator DownloadCsv(int version) { }

	// RVA: 0x2471DE0 Offset: 0x246DDE0 VA: 0x2471DE0
	public void UpdateLimitedFunction(GameSystemFlagData[] updateFunction) { }

	// RVA: 0x2471F1C Offset: 0x246DF1C VA: 0x2471F1C
	public void AddLimitedFunction(GameSystemFlag flag, bool isLimit) { }

	// RVA: 0x2471FCC Offset: 0x246DFCC VA: 0x2471FCC
	public void AddLimitedFunction(FunctionLimitManager.CDNGameSystemFlag flag, bool isLimit) { }

	// RVA: 0x2471F30 Offset: 0x246DF30 VA: 0x2471F30
	private void addLimitedFunction(Dictionary<int, GameSystemFlagData> function, int flag, bool isLimit) { }

	// RVA: 0x2471FE0 Offset: 0x246DFE0 VA: 0x2471FE0
	public void Clear() { }

	// RVA: 0x2472040 Offset: 0x246E040 VA: 0x2472040
	public bool IsLimited(GameSystemFlag limitedType) { }

	// RVA: 0x247215C Offset: 0x246E15C VA: 0x247215C
	public bool IsLimited(FunctionLimitManager.CDNGameSystemFlag limitedType) { }

	// RVA: 0x24721FC Offset: 0x246E1FC VA: 0x24721FC
	public bool GetValue(GameSystemFlag limitedType, out int param) { }

	// RVA: 0x24722A4 Offset: 0x246E2A4 VA: 0x24722A4
	public bool GetValue(FunctionLimitManager.CDNGameSystemFlag limitedType, out int param) { }

	// RVA: 0x2472210 Offset: 0x246E210 VA: 0x2472210
	private bool getValue(Dictionary<int, GameSystemFlagData> function, int limitedType, out int param) { }

	// RVA: 0x24722B8 Offset: 0x246E2B8 VA: 0x24722B8
	public void ShowLimitedFunctionMessage(Action callback) { }

	[IteratorStateMachine(typeof(FunctionLimitManager.<ShowLimitedFunctionMessageCoroutine>d__17))]
	// RVA: 0x2472320 Offset: 0x246E320 VA: 0x2472320
	public IEnumerator ShowLimitedFunctionMessageCoroutine(Action callback) { }

	// RVA: 0x24723B4 Offset: 0x246E3B4 VA: 0x24723B4
	public bool ContainsFlag(GameSystemFlag limitedType) { }
}
