// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Pets
public class HousePetColoring : OperationRequestBase // TypeDefIndex: 12293
{
	// Fields
	[CompilerGenerated]
	private long[] <ChoiceUuids>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <UseOrb>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <Orb>k__BackingField; // 0x2C

	// Properties
	public long[] ChoiceUuids { get; set; }
	public int UseOrb { get; set; }
	public int Orb { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35ED6A4 Offset: 0x35E96A4 VA: 0x35ED6A4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35ED6AC Offset: 0x35E96AC VA: 0x35ED6AC
	public long[] get_ChoiceUuids() { }

	[CompilerGenerated]
	// RVA: 0x35ED6B4 Offset: 0x35E96B4 VA: 0x35ED6B4
	public void set_ChoiceUuids(long[] value) { }

	[CompilerGenerated]
	// RVA: 0x35ED6BC Offset: 0x35E96BC VA: 0x35ED6BC
	public int get_UseOrb() { }

	[CompilerGenerated]
	// RVA: 0x35ED6C4 Offset: 0x35E96C4 VA: 0x35ED6C4
	public void set_UseOrb(int value) { }

	[CompilerGenerated]
	// RVA: 0x35ED6CC Offset: 0x35E96CC VA: 0x35ED6CC
	public int get_Orb() { }

	[CompilerGenerated]
	// RVA: 0x35ED6D4 Offset: 0x35E96D4 VA: 0x35ED6D4
	public void set_Orb(int value) { }

	// RVA: 0x35ED6DC Offset: 0x35E96DC VA: 0x35ED6DC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35ED6E4 Offset: 0x35E96E4 VA: 0x35ED6E4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35ED6EC Offset: 0x35E96EC VA: 0x35ED6EC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x35ED7C4 Offset: 0x35E97C4 VA: 0x35ED7C4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
