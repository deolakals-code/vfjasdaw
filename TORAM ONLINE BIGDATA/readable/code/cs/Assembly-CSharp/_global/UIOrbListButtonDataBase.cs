// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIOrbListButtonDataBase // TypeDefIndex: 7606
{
	// Fields
	[CompilerGenerated]
	private int <ButtonId>k__BackingField; // 0x10
	[CompilerGenerated]
	private byte <Index>k__BackingField; // 0x14
	[CompilerGenerated]
	private byte <Size>k__BackingField; // 0x15
	[CompilerGenerated]
	private string <BackPanelName>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <BackPanelFolderName>k__BackingField; // 0x20
	[CompilerGenerated]
	private UIOrbListButtonDataBase.ActionTypes <ActionType>k__BackingField; // 0x28
	[CompilerGenerated]
	private UIOrbListButtonDataBase.EffectFlags <EffectFlag>k__BackingField; // 0x2C
	private List<UIOrbListButtonDataBase.AddEffect> addEffect; // 0x30
	private UIOrbListButtonDataBase.BuyPopTexure buyPopTexure; // 0x38

	// Properties
	public int ButtonId { get; set; }
	public byte Index { get; set; }
	public byte Size { get; set; }
	public string BackPanelName { get; set; }
	public string BackPanelFolderName { get; set; }
	public UIOrbListButtonDataBase.ActionTypes ActionType { get; set; }
	public UIOrbListButtonDataBase.EffectFlags EffectFlag { get; set; }
	public UIOrbListButtonDataBase.AddEffect[] AddEffectData { get; }
	public UIOrbListButtonDataBase.BuyPopTexure BuyPopTexureData { get; }
	public byte Width { get; }
	public byte Height { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1BBE208 Offset: 0x1BBA208 VA: 0x1BBE208
	public int get_ButtonId() { }

	[CompilerGenerated]
	// RVA: 0x1BBE210 Offset: 0x1BBA210 VA: 0x1BBE210
	private void set_ButtonId(int value) { }

	[CompilerGenerated]
	// RVA: 0x1BBE218 Offset: 0x1BBA218 VA: 0x1BBE218
	public byte get_Index() { }

	[CompilerGenerated]
	// RVA: 0x1BBE220 Offset: 0x1BBA220 VA: 0x1BBE220
	private void set_Index(byte value) { }

	[CompilerGenerated]
	// RVA: 0x1BBE228 Offset: 0x1BBA228 VA: 0x1BBE228
	public byte get_Size() { }

	[CompilerGenerated]
	// RVA: 0x1BBE230 Offset: 0x1BBA230 VA: 0x1BBE230
	private void set_Size(byte value) { }

	[CompilerGenerated]
	// RVA: 0x1BBE238 Offset: 0x1BBA238 VA: 0x1BBE238
	public string get_BackPanelName() { }

	[CompilerGenerated]
	// RVA: 0x1BBE240 Offset: 0x1BBA240 VA: 0x1BBE240
	private void set_BackPanelName(string value) { }

	[CompilerGenerated]
	// RVA: 0x1BBE248 Offset: 0x1BBA248 VA: 0x1BBE248
	public string get_BackPanelFolderName() { }

	[CompilerGenerated]
	// RVA: 0x1BBE250 Offset: 0x1BBA250 VA: 0x1BBE250
	private void set_BackPanelFolderName(string value) { }

	[CompilerGenerated]
	// RVA: 0x1BBE258 Offset: 0x1BBA258 VA: 0x1BBE258
	public UIOrbListButtonDataBase.ActionTypes get_ActionType() { }

	[CompilerGenerated]
	// RVA: 0x1BBE260 Offset: 0x1BBA260 VA: 0x1BBE260
	private void set_ActionType(UIOrbListButtonDataBase.ActionTypes value) { }

	[CompilerGenerated]
	// RVA: 0x1BBE268 Offset: 0x1BBA268 VA: 0x1BBE268
	public UIOrbListButtonDataBase.EffectFlags get_EffectFlag() { }

	[CompilerGenerated]
	// RVA: 0x1BBE270 Offset: 0x1BBA270 VA: 0x1BBE270
	protected void set_EffectFlag(UIOrbListButtonDataBase.EffectFlags value) { }

	// RVA: 0x1BBE1A8 Offset: 0x1BBA1A8 VA: 0x1BBE1A8
	public UIOrbListButtonDataBase.AddEffect[] get_AddEffectData() { }

	// RVA: 0x1BBE278 Offset: 0x1BBA278 VA: 0x1BBE278
	public UIOrbListButtonDataBase.BuyPopTexure get_BuyPopTexureData() { }

	// RVA: 0x1BBE280 Offset: 0x1BBA280 VA: 0x1BBE280
	public byte get_Width() { }

	// RVA: 0x1BBE28C Offset: 0x1BBA28C VA: 0x1BBE28C
	public byte get_Height() { }

	// RVA: 0x1BBE298 Offset: 0x1BBA298 VA: 0x1BBE298
	public void .ctor(int buttonId, string panelFolderName, string panelName, byte index, byte size, UIOrbListButtonDataBase.ActionTypes actionTypes) { }

	// RVA: 0x1BBE314 Offset: 0x1BBA314 VA: 0x1BBE314
	public void .ctor(UIOrbListButtonDataBase copy, UIOrbListButtonDataBase.ActionTypes type) { }

	// RVA: 0x1BBE394 Offset: 0x1BBA394 VA: 0x1BBE394
	public void .ctor(int buttonId, byte index, UIOrbListButtonDataBase copy, UIOrbListButtonDataBase.ActionTypes type) { }

	// RVA: 0x1BBE774 Offset: 0x1BBA774 VA: 0x1BBE774
	public void SetEffect(int setEffect) { }

	// RVA: 0x1BBDD2C Offset: 0x1BB9D2C VA: 0x1BBDD2C
	public bool CheckEffectFlag(UIOrbListButtonDataBase.EffectFlags flag) { }

	// RVA: 0x1BBE77C Offset: 0x1BBA77C VA: 0x1BBE77C
	public void SetEffectFlag(UIOrbListButtonDataBase.EffectFlags bitFlag, bool flag) { }

	// RVA: 0x1BBE5E0 Offset: 0x1BBA5E0 VA: 0x1BBE5E0
	public void SetAddEffect(string spriteFolderName, string spriteName, short spriteX, short spriteY, short spriteRot, byte spriteFlag, byte spriteScale) { }

	// RVA: 0x1BBE820 Offset: 0x1BBA820 VA: 0x1BBE820
	public void SetBuyPopTexture(string spriteFolderName, string spriteName) { }

	// RVA: 0x1BBE894 Offset: 0x1BBA894 VA: 0x1BBE894
	public int CheckSort(UIOrbListButtonDataBase sort) { }
}
