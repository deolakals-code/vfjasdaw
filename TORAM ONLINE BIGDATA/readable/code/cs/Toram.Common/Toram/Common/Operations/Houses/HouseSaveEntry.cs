// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses
public class HouseSaveEntry : OperationRequestBase // TypeDefIndex: 12186
{
	// Fields
	[CompilerGenerated]
	private byte <EditState>k__BackingField; // 0x20

	// Properties
	public byte EditState { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35DDD98 Offset: 0x35D9D98 VA: 0x35DDD98
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35DDDA0 Offset: 0x35D9DA0 VA: 0x35DDDA0
	public byte get_EditState() { }

	[CompilerGenerated]
	// RVA: 0x35DDDA8 Offset: 0x35D9DA8 VA: 0x35DDDA8
	public void set_EditState(byte value) { }

	// RVA: 0x35DDDB0 Offset: 0x35D9DB0 VA: 0x35DDDB0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35DDDB8 Offset: 0x35D9DB8 VA: 0x35DDDB8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35DDDC0 Offset: 0x35D9DC0 VA: 0x35DDDC0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35DDEE0 Offset: 0x35D9EE0 VA: 0x35DDEE0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
