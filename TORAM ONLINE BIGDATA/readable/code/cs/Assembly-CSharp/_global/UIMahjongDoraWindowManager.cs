// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMahjongDoraWindowManager : MonoBehaviour // TypeDefIndex: 5878
{
	// Fields
	public UIMahjongTileController[] tiles; // 0x20
	[SerializeField]
	private GameObject window; // 0x28

	// Properties
	public int OpenDoraCount { get; }

	// Methods

	// RVA: 0x1816AE8 Offset: 0x1812AE8 VA: 0x1816AE8
	public int get_OpenDoraCount() { }

	// RVA: 0x1816BFC Offset: 0x1812BFC VA: 0x1816BFC
	public void Initialize(MahjongRoomData roomData) { }

	// RVA: 0x1816CE8 Offset: 0x1812CE8 VA: 0x1816CE8
	public void SetDoraList(MahjongRoomData roomData, List<MahjongTileData> doraList) { }

	// RVA: 0x1816DE8 Offset: 0x1812DE8 VA: 0x1816DE8
	public void ChageActiveDoraWindow(bool flag) { }

	// RVA: 0x1816E08 Offset: 0x1812E08 VA: 0x1816E08
	public void .ctor() { }
}
