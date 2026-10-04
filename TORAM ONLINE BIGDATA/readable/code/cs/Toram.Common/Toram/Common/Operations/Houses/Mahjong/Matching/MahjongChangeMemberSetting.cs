// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Mahjong.Matching
public class MahjongChangeMemberSetting : OperationRequestBase // TypeDefIndex: 12343
{
	// Fields
	[CompilerGenerated]
	private byte <Psi>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <VoiceId>k__BackingField; // 0x21

	// Properties
	public byte Psi { get; set; }
	public byte VoiceId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35F7C40 Offset: 0x35F3C40 VA: 0x35F7C40
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35F7C48 Offset: 0x35F3C48 VA: 0x35F7C48
	public byte get_Psi() { }

	[CompilerGenerated]
	// RVA: 0x35F7C50 Offset: 0x35F3C50 VA: 0x35F7C50
	public void set_Psi(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35F7C58 Offset: 0x35F3C58 VA: 0x35F7C58
	public byte get_VoiceId() { }

	[CompilerGenerated]
	// RVA: 0x35F7C60 Offset: 0x35F3C60 VA: 0x35F7C60
	public void set_VoiceId(byte value) { }

	// RVA: 0x35F7C68 Offset: 0x35F3C68 VA: 0x35F7C68 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35F7C70 Offset: 0x35F3C70 VA: 0x35F7C70 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35F7C78 Offset: 0x35F3C78 VA: 0x35F7C78 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x35F7D40 Offset: 0x35F3D40 VA: 0x35F7D40 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
