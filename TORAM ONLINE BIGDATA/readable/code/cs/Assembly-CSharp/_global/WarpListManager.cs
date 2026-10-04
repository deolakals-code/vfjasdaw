// Assembly: Assembly-CSharp.dll
// Namespace: 
public class WarpListManager // TypeDefIndex: 1868
{
	// Fields
	private Dictionary<int, WarpListMasterData> masterDataList; // 0x10
	[CompilerGenerated]
	private bool <IsInitialized>k__BackingField; // 0x18

	// Properties
	public bool IsInitialized { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x20F73EC Offset: 0x20F33EC VA: 0x20F73EC
	public bool get_IsInitialized() { }

	[CompilerGenerated]
	// RVA: 0x20F73F4 Offset: 0x20F33F4 VA: 0x20F73F4
	private void set_IsInitialized(bool value) { }

	// RVA: 0x20F7400 Offset: 0x20F3400 VA: 0x20F7400
	public void .ctor() { }

	// RVA: 0x20F7488 Offset: 0x20F3488 VA: 0x20F7488
	public void Initialize(byte[] binary) { }

	// RVA: 0x20F7B5C Offset: 0x20F3B5C VA: 0x20F7B5C
	public bool TryGetMasterData(int listId, out WarpListMasterData data) { }
}
