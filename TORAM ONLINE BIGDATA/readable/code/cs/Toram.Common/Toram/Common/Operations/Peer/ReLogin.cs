// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Peer
public class ReLogin : PacketBase // TypeDefIndex: 11382
{
	// Fields
	[CompilerGenerated]
	private AccountData <Account>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <Signature>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <XSignature>k__BackingField; // 0x30
	[CompilerGenerated]
	private byte[] <USignature>k__BackingField; // 0x38

	// Properties
	public AccountData Account { get; set; }
	public string Signature { get; set; }
	public string XSignature { get; set; }
	[PacketParameter(Code = 96, IsOptional = True)]
	public byte[] USignature { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36FE93C Offset: 0x36FA93C VA: 0x36FE93C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x36FE944 Offset: 0x36FA944 VA: 0x36FE944
	public AccountData get_Account() { }

	[CompilerGenerated]
	// RVA: 0x36FE94C Offset: 0x36FA94C VA: 0x36FE94C
	public void set_Account(AccountData value) { }

	[CompilerGenerated]
	// RVA: 0x36FE954 Offset: 0x36FA954 VA: 0x36FE954
	public string get_Signature() { }

	[CompilerGenerated]
	// RVA: 0x36FE95C Offset: 0x36FA95C VA: 0x36FE95C
	public void set_Signature(string value) { }

	[CompilerGenerated]
	// RVA: 0x36FE964 Offset: 0x36FA964 VA: 0x36FE964
	public string get_XSignature() { }

	[CompilerGenerated]
	// RVA: 0x36FE96C Offset: 0x36FA96C VA: 0x36FE96C
	public void set_XSignature(string value) { }

	[CompilerGenerated]
	// RVA: 0x36FE974 Offset: 0x36FA974 VA: 0x36FE974
	public byte[] get_USignature() { }

	[CompilerGenerated]
	// RVA: 0x36FE97C Offset: 0x36FA97C VA: 0x36FE97C
	public void set_USignature(byte[] value) { }

	// RVA: 0x36FE984 Offset: 0x36FA984 VA: 0x36FE984 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36FE98C Offset: 0x36FA98C VA: 0x36FE98C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36FEC98 Offset: 0x36FAC98 VA: 0x36FEC98 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
