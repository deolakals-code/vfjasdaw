// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.PetRace
public class PetRacePassingCheckPoint : OperationRequestBase // TypeDefIndex: 12227
{
	// Fields
	[CompilerGenerated]
	private int <CheckPointNo>k__BackingField; // 0x20

	// Properties
	public int CheckPointNo { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35E3A7C Offset: 0x35DFA7C VA: 0x35E3A7C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35E3A84 Offset: 0x35DFA84 VA: 0x35E3A84
	public int get_CheckPointNo() { }

	[CompilerGenerated]
	// RVA: 0x35E3A8C Offset: 0x35DFA8C VA: 0x35E3A8C
	public void set_CheckPointNo(int value) { }

	// RVA: 0x35E3A94 Offset: 0x35DFA94 VA: 0x35E3A94 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35E3A9C Offset: 0x35DFA9C VA: 0x35E3A9C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35E3AA4 Offset: 0x35DFAA4 VA: 0x35E3AA4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x35E3B44 Offset: 0x35DFB44 VA: 0x35E3B44 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
