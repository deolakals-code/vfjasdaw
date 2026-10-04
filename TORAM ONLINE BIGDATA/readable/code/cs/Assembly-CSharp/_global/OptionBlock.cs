// Assembly: Assembly-CSharp.dll
// Namespace: 
[Serializable]
public class OptionBlock // TypeDefIndex: 5357
{
	// Fields
	private Dictionary<int, string> blockList; // 0x10

	// Methods

	// RVA: 0x26498C4 Offset: 0x26458C4 VA: 0x26498C4
	public void .ctor() { }

	// RVA: 0x264994C Offset: 0x264594C VA: 0x264994C
	public void BlockOptionLoad() { }

	// RVA: 0x2649B18 Offset: 0x2645B18 VA: 0x2649B18
	public void SaveBlock() { }

	// RVA: 0x2649E30 Offset: 0x2645E30 VA: 0x2649E30
	public void AddBlockUser(int avatarUid, int regionCode, string userName) { }

	// RVA: 0x264A118 Offset: 0x2646118 VA: 0x264A118
	public void RemoveBlockUser(int avatarUid) { }

	// RVA: 0x264A1A8 Offset: 0x26461A8 VA: 0x264A1A8
	public bool CheckBlockUser(int avatarUid) { }

	// RVA: 0x264A200 Offset: 0x2646200 VA: 0x264A200
	public Dictionary<int, string> GetListData() { }
}
