// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Communication.Guilds
public class GuildItemData : BinaryBase // TypeDefIndex: 13018
{
	// Fields
	[CompilerGenerated]
	private int <ItemId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private int <Num>k__BackingField; // 0x20

	// Properties
	public int ItemId { get; set; }
	public int Num { get; set; }

	// Methods

	// RVA: 0x368F92C Offset: 0x368B92C VA: 0x368F92C
	public void .ctor() { }

	// RVA: 0x368F934 Offset: 0x368B934 VA: 0x368F934
	public void .ctor(byte[] binary) { }

	[CompilerGenerated]
	// RVA: 0x368F93C Offset: 0x368B93C VA: 0x368F93C
	public int get_ItemId() { }

	[CompilerGenerated]
	// RVA: 0x368F944 Offset: 0x368B944 VA: 0x368F944
	protected void set_ItemId(int value) { }

	[CompilerGenerated]
	// RVA: 0x368F94C Offset: 0x368B94C VA: 0x368F94C
	public int get_Num() { }

	[CompilerGenerated]
	// RVA: 0x368F954 Offset: 0x368B954 VA: 0x368F954
	protected void set_Num(int value) { }

	// RVA: 0x368F95C Offset: 0x368B95C VA: 0x368F95C Slot: 3
	public override string ToString() { }

	// RVA: 0x368F9FC Offset: 0x368B9FC VA: 0x368F9FC Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x368FA38 Offset: 0x368BA38 VA: 0x368FA38 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }
}
