// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Orb
public class OrbItemUseResponse : OperationResponseBase // TypeDefIndex: 11812
{
	// Fields
	[CompilerGenerated]
	private int <OrbItemId>k__BackingField; // 0x20
	[CompilerGenerated]
	private OrbItemData[] <OrbItemList>k__BackingField; // 0x28
	[CompilerGenerated]
	private Dictionary<object, object> <ResultParam>k__BackingField; // 0x30

	// Properties
	[PacketParameter(Code = 91)]
	public int OrbItemId { get; set; }
	[PacketClass(Code = 231, IsOptional = True)]
	public OrbItemData[] OrbItemList { get; set; }
	[PacketClass(Code = 18, IsOptional = True)]
	public Dictionary<object, object> ResultParam { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3750014 Offset: 0x374C014 VA: 0x3750014
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x375001C Offset: 0x374C01C VA: 0x375001C
	public int get_OrbItemId() { }

	[CompilerGenerated]
	// RVA: 0x3750024 Offset: 0x374C024 VA: 0x3750024
	public void set_OrbItemId(int value) { }

	[CompilerGenerated]
	// RVA: 0x375002C Offset: 0x374C02C VA: 0x375002C
	public OrbItemData[] get_OrbItemList() { }

	[CompilerGenerated]
	// RVA: 0x3750034 Offset: 0x374C034 VA: 0x3750034
	public void set_OrbItemList(OrbItemData[] value) { }

	[CompilerGenerated]
	// RVA: 0x375003C Offset: 0x374C03C VA: 0x375003C
	public Dictionary<object, object> get_ResultParam() { }

	[CompilerGenerated]
	// RVA: 0x3750044 Offset: 0x374C044 VA: 0x3750044
	public void set_ResultParam(Dictionary<object, object> value) { }

	// RVA: 0x375004C Offset: 0x374C04C VA: 0x375004C
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x37501D4 Offset: 0x374C1D4 VA: 0x37501D4
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x375027C Offset: 0x374C27C VA: 0x375027C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3750284 Offset: 0x374C284 VA: 0x3750284 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x375028C Offset: 0x374C28C VA: 0x375028C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37503BC Offset: 0x374C3BC VA: 0x37503BC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
