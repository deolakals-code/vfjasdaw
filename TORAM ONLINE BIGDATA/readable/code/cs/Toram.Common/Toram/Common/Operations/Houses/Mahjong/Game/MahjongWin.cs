// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Mahjong.Game
public class MahjongWin : OperationRequestBase // TypeDefIndex: 12342
{
	// Fields
	[CompilerGenerated]
	private bool <IsTumo>k__BackingField; // 0x20

	// Properties
	public bool IsTumo { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35F7A90 Offset: 0x35F3A90 VA: 0x35F7A90
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35F7A98 Offset: 0x35F3A98 VA: 0x35F7A98
	public bool get_IsTumo() { }

	[CompilerGenerated]
	// RVA: 0x35F7AA0 Offset: 0x35F3AA0 VA: 0x35F7AA0
	public void set_IsTumo(bool value) { }

	// RVA: 0x35F7AAC Offset: 0x35F3AAC VA: 0x35F7AAC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35F7AB4 Offset: 0x35F3AB4 VA: 0x35F7AB4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35F7ABC Offset: 0x35F3ABC VA: 0x35F7ABC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x35F7B5C Offset: 0x35F3B5C VA: 0x35F7B5C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
