// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Rooms.Wave
public class GetWaveReward : OperationRequestBase // TypeDefIndex: 11795
{
	// Fields
	[CompilerGenerated]
	private int <FieldId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <WaveNo>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <Index>k__BackingField; // 0x25

	// Properties
	public override byte Code { get; }
	[UnityHash(Code = 244)]
	public override byte SubCode { get; }
	[UnityHash(Code = 60)]
	public int FieldId { get; set; }
	[UnityHash(Code = 210)]
	public byte WaveNo { get; set; }
	[UnityHash(Code = 195)]
	public byte Index { get; set; }

	// Methods

	// RVA: 0x374D0F0 Offset: 0x37490F0 VA: 0x374D0F0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x374D0F8 Offset: 0x37490F8 VA: 0x374D0F8 Slot: 7
	public override byte get_SubCode() { }

	[CompilerGenerated]
	// RVA: 0x374D100 Offset: 0x3749100 VA: 0x374D100
	public int get_FieldId() { }

	[CompilerGenerated]
	// RVA: 0x374D108 Offset: 0x3749108 VA: 0x374D108
	public void set_FieldId(int value) { }

	[CompilerGenerated]
	// RVA: 0x374D110 Offset: 0x3749110 VA: 0x374D110
	public byte get_WaveNo() { }

	[CompilerGenerated]
	// RVA: 0x374D118 Offset: 0x3749118 VA: 0x374D118
	public void set_WaveNo(byte value) { }

	[CompilerGenerated]
	// RVA: 0x374D120 Offset: 0x3749120 VA: 0x374D120
	public byte get_Index() { }

	[CompilerGenerated]
	// RVA: 0x374D128 Offset: 0x3749128 VA: 0x374D128
	public void set_Index(byte value) { }

	// RVA: 0x374D130 Offset: 0x3749130 VA: 0x374D130
	public void .ctor() { }

	// RVA: 0x374D138 Offset: 0x3749138 VA: 0x374D138 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x374D244 Offset: 0x3749244 VA: 0x374D244 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
