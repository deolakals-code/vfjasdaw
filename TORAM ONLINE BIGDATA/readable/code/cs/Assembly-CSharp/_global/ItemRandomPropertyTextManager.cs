// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ItemRandomPropertyTextManager : TextManagerBase // TypeDefIndex: 5234
{
	// Fields
	private Dictionary<int, ItemRandomPropertyTextManagerData> TextData; // 0x18
	private List<int> getSearchIdList; // 0x20

	// Methods

	// RVA: 0x26127E4 Offset: 0x260E7E4 VA: 0x26127E4 Slot: 6
	public override void Initialize(byte[] binary) { }

	// RVA: -1 Offset: -1 Slot: 4
	public override T Get<T>(int id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C5EC8 Offset: 0x26C1EC8 VA: 0x26C5EC8
	|-ItemRandomPropertyTextManager.Get<object>
	*/

	// RVA: 0x2613034 Offset: 0x260F034 VA: 0x2613034 Slot: 7
	public override void Clear() { }

	// RVA: 0x261308C Offset: 0x260F08C VA: 0x261308C
	public Dictionary<int, string> GetDatas() { }

	// RVA: 0x2613264 Offset: 0x260F264 VA: 0x2613264
	public Dictionary<int, string> GetSearchDatas() { }

	// RVA: 0x2613648 Offset: 0x260F648 VA: 0x2613648
	public void .ctor() { }
}
