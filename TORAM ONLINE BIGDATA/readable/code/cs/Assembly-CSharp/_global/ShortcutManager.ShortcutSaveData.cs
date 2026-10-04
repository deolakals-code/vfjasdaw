// Assembly: Assembly-CSharp.dll
// Namespace: 
private class ShortcutManager.ShortcutSaveData // TypeDefIndex: 5394
{
	// Fields
	private ShortcutManager.ShortcutListType listType; // 0x10
	private ShortcutData.ShortcutType type; // 0x14
	private int id; // 0x18
	private int position; // 0x1C

	// Properties
	public int Position { get; }
	public ShortcutData Data { get; }

	// Methods

	// RVA: 0x175C490 Offset: 0x1758490 VA: 0x175C490
	public int get_Position() { }

	// RVA: 0x175633C Offset: 0x175233C VA: 0x175633C
	public void .ctor(ShortcutManager.ShortcutListType listType, ShortcutData.ShortcutType type, int id, int position) { }

	// RVA: 0x1758788 Offset: 0x1754788 VA: 0x1758788
	public ShortcutData get_Data() { }

	// RVA: 0x1757990 Offset: 0x1753990 VA: 0x1757990
	public void SaveShortcut(int characterSlot) { }
}
