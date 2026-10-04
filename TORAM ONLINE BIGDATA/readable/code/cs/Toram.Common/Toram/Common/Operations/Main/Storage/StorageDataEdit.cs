// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Storage
public class StorageDataEdit : OperationRequestBase // TypeDefIndex: 12053
{
	// Fields
	[CompilerGenerated]
	private byte <StorageNo>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <Info>k__BackingField; // 0x30

	// Properties
	[PacketParameter(Code = 210)]
	public byte StorageNo { get; set; }
	[PacketParameter(Code = 211, IsOptional = True)]
	public string Name { get; set; }
	[PacketParameter(Code = 212, IsOptional = True)]
	public string Info { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x377E4C4 Offset: 0x377A4C4 VA: 0x377E4C4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x377E4CC Offset: 0x377A4CC VA: 0x377E4CC
	public byte get_StorageNo() { }

	[CompilerGenerated]
	// RVA: 0x377E4D4 Offset: 0x377A4D4 VA: 0x377E4D4
	public void set_StorageNo(byte value) { }

	[CompilerGenerated]
	// RVA: 0x377E4DC Offset: 0x377A4DC VA: 0x377E4DC
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x377E4E4 Offset: 0x377A4E4 VA: 0x377E4E4
	public void set_Name(string value) { }

	[CompilerGenerated]
	// RVA: 0x377E4EC Offset: 0x377A4EC VA: 0x377E4EC
	public string get_Info() { }

	[CompilerGenerated]
	// RVA: 0x377E4F4 Offset: 0x377A4F4 VA: 0x377E4F4
	public void set_Info(string value) { }

	// RVA: 0x377E4FC Offset: 0x377A4FC VA: 0x377E4FC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x377E504 Offset: 0x377A504 VA: 0x377E504 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x377E50C Offset: 0x377A50C VA: 0x377E50C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x377E71C Offset: 0x377A71C VA: 0x377E71C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
