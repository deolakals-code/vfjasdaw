// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Skill
public class GetFamiliaResponse : OperationResponseBase // TypeDefIndex: 12109
{
	// Fields
	[CompilerGenerated]
	private byte <SelectNo>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Color>k__BackingField; // 0x24
	[CompilerGenerated]
	private long <Model>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <Flag>k__BackingField; // 0x30

	// Properties
	public byte SelectNo { get; set; }
	public int Color { get; set; }
	public long Model { get; set; }
	public int Flag { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3788B40 Offset: 0x3784B40 VA: 0x3788B40
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3788B48 Offset: 0x3784B48 VA: 0x3788B48
	public byte get_SelectNo() { }

	[CompilerGenerated]
	// RVA: 0x3788B50 Offset: 0x3784B50 VA: 0x3788B50
	public void set_SelectNo(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3788B58 Offset: 0x3784B58 VA: 0x3788B58
	public int get_Color() { }

	[CompilerGenerated]
	// RVA: 0x3788B60 Offset: 0x3784B60 VA: 0x3788B60
	public void set_Color(int value) { }

	[CompilerGenerated]
	// RVA: 0x3788B68 Offset: 0x3784B68 VA: 0x3788B68
	public long get_Model() { }

	[CompilerGenerated]
	// RVA: 0x3788B70 Offset: 0x3784B70 VA: 0x3788B70
	public void set_Model(long value) { }

	[CompilerGenerated]
	// RVA: 0x3788B78 Offset: 0x3784B78 VA: 0x3788B78
	public int get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x3788B80 Offset: 0x3784B80 VA: 0x3788B80
	public void set_Flag(int value) { }

	// RVA: 0x3788B88 Offset: 0x3784B88 VA: 0x3788B88 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3788B90 Offset: 0x3784B90 VA: 0x3788B90 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3788B98 Offset: 0x3784B98 VA: 0x3788B98 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3788DE0 Offset: 0x3784DE0 VA: 0x3788DE0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
