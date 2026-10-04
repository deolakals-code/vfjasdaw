// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Systems
public class BanWordUpdate : PacketBase // TypeDefIndex: 11951
{
	// Fields
	[CompilerGenerated]
	private DateTime <ClientDate>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 172)]
	public DateTime ClientDate { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x376CCA8 Offset: 0x3768CA8 VA: 0x376CCA8
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x376CCB0 Offset: 0x3768CB0 VA: 0x376CCB0
	public DateTime get_ClientDate() { }

	[CompilerGenerated]
	// RVA: 0x376CCB8 Offset: 0x3768CB8 VA: 0x376CCB8
	public void set_ClientDate(DateTime value) { }

	// RVA: 0x376CCC0 Offset: 0x3768CC0 VA: 0x376CCC0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x376CCC8 Offset: 0x3768CC8 VA: 0x376CCC8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x376CE08 Offset: 0x3768E08 VA: 0x376CE08 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
