// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ItemTextManager : TextManagerBase // TypeDefIndex: 5237
{
	// Fields
	private Dictionary<int, ItemTextManagerData> TextData; // 0x18
	private List<int> NgItemData; // 0x20

	// Methods

	// RVA: 0x2613868 Offset: 0x260F868 VA: 0x2613868 Slot: 6
	public override void Initialize(byte[] binary) { }

	// RVA: 0x26140E8 Offset: 0x26100E8 VA: 0x26140E8
	public void SetNGItem(byte[] binary) { }

	// RVA: -1 Offset: -1 Slot: 4
	public override T Get<T>(int id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C6010 Offset: 0x26C2010 VA: 0x26C6010
	|-ItemTextManager.Get<object>
	*/

	// RVA: 0x26144A8 Offset: 0x26104A8 VA: 0x26144A8 Slot: 7
	public override void Clear() { }

	// RVA: 0x2614500 Offset: 0x2610500 VA: 0x2614500
	public Dictionary<int, string> GetDatas() { }

	// RVA: 0x26146D8 Offset: 0x26106D8 VA: 0x26146D8
	public void .ctor() { }
}
