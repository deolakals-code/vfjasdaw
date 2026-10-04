// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds.Bgm
public class GuildOpenBgmResponse : OperationResponseBase // TypeDefIndex: 12480
{
	// Fields
	[CompilerGenerated]
	private short <RecipeId>k__BackingField; // 0x20
	[CompilerGenerated]
	private GuildVariableData[] <Variables>k__BackingField; // 0x28
	[CompilerGenerated]
	private GuildItemData[] <Items>k__BackingField; // 0x30

	// Properties
	public short RecipeId { get; set; }
	public GuildVariableData[] Variables { get; set; }
	public GuildItemData[] Items { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x360E2FC Offset: 0x360A2FC VA: 0x360E2FC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x360E304 Offset: 0x360A304 VA: 0x360E304
	public short get_RecipeId() { }

	[CompilerGenerated]
	// RVA: 0x360E30C Offset: 0x360A30C VA: 0x360E30C
	public void set_RecipeId(short value) { }

	[CompilerGenerated]
	// RVA: 0x360E314 Offset: 0x360A314 VA: 0x360E314
	public GuildVariableData[] get_Variables() { }

	[CompilerGenerated]
	// RVA: 0x360E31C Offset: 0x360A31C VA: 0x360E31C
	public void set_Variables(GuildVariableData[] value) { }

	[CompilerGenerated]
	// RVA: 0x360E324 Offset: 0x360A324 VA: 0x360E324
	public GuildItemData[] get_Items() { }

	[CompilerGenerated]
	// RVA: 0x360E32C Offset: 0x360A32C VA: 0x360E32C
	public void set_Items(GuildItemData[] value) { }

	// RVA: 0x360E334 Offset: 0x360A334 VA: 0x360E334 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x360E33C Offset: 0x360A33C VA: 0x360E33C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x360E344 Offset: 0x360A344 VA: 0x360E344 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x360E454 Offset: 0x360A454 VA: 0x360E454 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
