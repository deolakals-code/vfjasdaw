// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Mahjong.Game
public class MahjongCall : OperationRequestBase // TypeDefIndex: 12340
{
	// Fields
	[CompilerGenerated]
	private byte <CallType>k__BackingField; // 0x20
	[CompilerGenerated]
	private int[] <MyTileUidList>k__BackingField; // 0x28

	// Properties
	public byte CallType { get; set; }
	public int[] MyTileUidList { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35F71FC Offset: 0x35F31FC VA: 0x35F71FC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35F7204 Offset: 0x35F3204 VA: 0x35F7204
	public byte get_CallType() { }

	[CompilerGenerated]
	// RVA: 0x35F720C Offset: 0x35F320C VA: 0x35F720C
	public void set_CallType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35F7214 Offset: 0x35F3214 VA: 0x35F7214
	public int[] get_MyTileUidList() { }

	[CompilerGenerated]
	// RVA: 0x35F721C Offset: 0x35F321C VA: 0x35F721C
	public void set_MyTileUidList(int[] value) { }

	// RVA: 0x35F7224 Offset: 0x35F3224 VA: 0x35F7224 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35F722C Offset: 0x35F322C VA: 0x35F722C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35F7234 Offset: 0x35F3234 VA: 0x35F7234 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x35F72EC Offset: 0x35F32EC VA: 0x35F72EC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
