// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds.Bgm
public class GuildOpenBgm : OperationRequestBase // TypeDefIndex: 12479
{
	// Fields
	[CompilerGenerated]
	private short <RecipeId>k__BackingField; // 0x20

	// Properties
	public short RecipeId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x360E114 Offset: 0x360A114 VA: 0x360E114
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x360E11C Offset: 0x360A11C VA: 0x360E11C
	public short get_RecipeId() { }

	[CompilerGenerated]
	// RVA: 0x360E124 Offset: 0x360A124 VA: 0x360E124
	public void set_RecipeId(short value) { }

	// RVA: 0x360E12C Offset: 0x360A12C VA: 0x360E12C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x360E134 Offset: 0x360A134 VA: 0x360E134 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x360E13C Offset: 0x360A13C VA: 0x360E13C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x360E1DC Offset: 0x360A1DC VA: 0x360E1DC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
