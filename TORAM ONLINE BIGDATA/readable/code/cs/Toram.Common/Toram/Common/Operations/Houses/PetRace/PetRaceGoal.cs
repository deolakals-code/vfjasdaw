// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.PetRace
public class PetRaceGoal : OperationRequestBase // TypeDefIndex: 12218
{
	// Fields
	[CompilerGenerated]
	private string <PetName>k__BackingField; // 0x20

	// Properties
	public string PetName { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35E2990 Offset: 0x35DE990 VA: 0x35E2990
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35E2998 Offset: 0x35DE998 VA: 0x35E2998
	public string get_PetName() { }

	[CompilerGenerated]
	// RVA: 0x35E29A0 Offset: 0x35DE9A0 VA: 0x35E29A0
	public void set_PetName(string value) { }

	// RVA: 0x35E29A8 Offset: 0x35DE9A8 VA: 0x35E29A8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35E29B0 Offset: 0x35DE9B0 VA: 0x35E29B0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35E29B8 Offset: 0x35DE9B8 VA: 0x35E29B8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x35E2A24 Offset: 0x35DEA24 VA: 0x35E2A24 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
