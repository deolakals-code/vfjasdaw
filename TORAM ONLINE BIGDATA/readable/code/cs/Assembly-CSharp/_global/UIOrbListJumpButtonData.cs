// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIOrbListJumpButtonData : UIOrbListButtonDataBase // TypeDefIndex: 7607
{
	// Fields
	[CompilerGenerated]
	private byte <PageId>k__BackingField; // 0x40
	[CompilerGenerated]
	private byte <ViewIndex>k__BackingField; // 0x41
	[CompilerGenerated]
	private int <TextId>k__BackingField; // 0x44
	[CompilerGenerated]
	private byte <TextPosition>k__BackingField; // 0x48

	// Properties
	public byte PageId { get; set; }
	public byte ViewIndex { get; set; }
	public int TextId { get; set; }
	public byte TextPosition { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1BBE8C8 Offset: 0x1BBA8C8 VA: 0x1BBE8C8
	public byte get_PageId() { }

	[CompilerGenerated]
	// RVA: 0x1BBE8D0 Offset: 0x1BBA8D0 VA: 0x1BBE8D0
	private void set_PageId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x1BBE8D8 Offset: 0x1BBA8D8 VA: 0x1BBE8D8
	public byte get_ViewIndex() { }

	[CompilerGenerated]
	// RVA: 0x1BBE8E0 Offset: 0x1BBA8E0 VA: 0x1BBE8E0
	private void set_ViewIndex(byte value) { }

	[CompilerGenerated]
	// RVA: 0x1BBE8E8 Offset: 0x1BBA8E8 VA: 0x1BBE8E8
	public int get_TextId() { }

	[CompilerGenerated]
	// RVA: 0x1BBE8F0 Offset: 0x1BBA8F0 VA: 0x1BBE8F0
	private void set_TextId(int value) { }

	[CompilerGenerated]
	// RVA: 0x1BBE8F8 Offset: 0x1BBA8F8 VA: 0x1BBE8F8
	public byte get_TextPosition() { }

	[CompilerGenerated]
	// RVA: 0x1BBE900 Offset: 0x1BBA900 VA: 0x1BBE900
	private void set_TextPosition(byte value) { }

	// RVA: 0x1BBE908 Offset: 0x1BBA908 VA: 0x1BBE908
	public void .ctor(int buttonId, string panelFolderName, string panelName, byte index, byte size, byte pageId, byte viewIndex) { }

	// RVA: 0x1BBE940 Offset: 0x1BBA940 VA: 0x1BBE940
	public void .ctor(int buttonId, string panelFolderName, string panelName, byte index, byte size, byte pageId, byte viewIndex, int textId, byte position) { }

	// RVA: 0x1BBE988 Offset: 0x1BBA988 VA: 0x1BBE988
	public void .ctor(UIOrbListButtonDataBase copy, UIOrbListButtonDataBase.ActionTypes type) { }

	// RVA: 0x1BBE98C Offset: 0x1BBA98C VA: 0x1BBE98C
	public void .ctor(UIOrbListButtonDataBase copy, byte pageId, byte viewIndex) { }

	// RVA: 0x1BBE9C4 Offset: 0x1BBA9C4 VA: 0x1BBE9C4
	public void .ctor(UIOrbListButtonDataBase copy, byte pageId, byte viewIndex, int textId, byte position) { }

	// RVA: 0x1BBEA0C Offset: 0x1BBAA0C VA: 0x1BBEA0C
	public void .ctor(int buttonId, byte index, UIOrbListJumpButtonData copy) { }
}
