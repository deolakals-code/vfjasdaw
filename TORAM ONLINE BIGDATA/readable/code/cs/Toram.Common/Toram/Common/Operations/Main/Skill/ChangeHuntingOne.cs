// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Skill
public class ChangeHuntingOne : OperationRequestBase // TypeDefIndex: 12096
{
	// Fields
	[CompilerGenerated]
	private byte <SelectNo>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Color>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <Flag>k__BackingField; // 0x28

	// Properties
	public byte SelectNo { get; set; }
	public int Color { get; set; }
	public int Flag { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3786498 Offset: 0x3782498 VA: 0x3786498
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x37864A0 Offset: 0x37824A0 VA: 0x37864A0
	public byte get_SelectNo() { }

	[CompilerGenerated]
	// RVA: 0x37864A8 Offset: 0x37824A8 VA: 0x37864A8
	public void set_SelectNo(byte value) { }

	[CompilerGenerated]
	// RVA: 0x37864B0 Offset: 0x37824B0 VA: 0x37864B0
	public int get_Color() { }

	[CompilerGenerated]
	// RVA: 0x37864B8 Offset: 0x37824B8 VA: 0x37864B8
	public void set_Color(int value) { }

	[CompilerGenerated]
	// RVA: 0x37864C0 Offset: 0x37824C0 VA: 0x37864C0
	public int get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x37864C8 Offset: 0x37824C8 VA: 0x37864C8
	public void set_Flag(int value) { }

	// RVA: 0x37864D0 Offset: 0x37824D0 VA: 0x37864D0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37864D8 Offset: 0x37824D8 VA: 0x37864D8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37864E0 Offset: 0x37824E0 VA: 0x37864E0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x37865EC Offset: 0x37825EC VA: 0x37865EC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
