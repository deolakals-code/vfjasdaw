// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Parameter
public class ParameterOrderChangeResponse : OperationResponseBase // TypeDefIndex: 11997
{
	// Fields
	[CompilerGenerated]
	private byte[] <ParameterOrder>k__BackingField; // 0x20

	// Properties
	public byte[] ParameterOrder { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3774084 Offset: 0x3770084 VA: 0x3774084
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x377408C Offset: 0x377008C VA: 0x377408C
	public byte[] get_ParameterOrder() { }

	[CompilerGenerated]
	// RVA: 0x3774094 Offset: 0x3770094 VA: 0x3774094
	public void set_ParameterOrder(byte[] value) { }

	// RVA: 0x377409C Offset: 0x377009C VA: 0x377409C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37740A4 Offset: 0x37700A4 VA: 0x37740A4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37740AC Offset: 0x37700AC VA: 0x37740AC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3774204 Offset: 0x3770204 VA: 0x3774204 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
