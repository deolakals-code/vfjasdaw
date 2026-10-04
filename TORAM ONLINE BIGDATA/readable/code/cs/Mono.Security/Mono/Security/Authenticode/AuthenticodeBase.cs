// Assembly: Mono.Security.dll
// Namespace: Mono.Security.Authenticode
public class AuthenticodeBase // TypeDefIndex: 16926
{
	// Fields
	private byte[] fileblock; // 0x10
	private Stream fs; // 0x18
	private int blockNo; // 0x20
	private int blockLength; // 0x24
	private int peOffset; // 0x28
	private int dirSecurityOffset; // 0x2C
	private int dirSecuritySize; // 0x30
	private int coffSymbolTableOffset; // 0x34
	private bool pe64; // 0x38

	// Properties
	internal int PEOffset { get; }

	// Methods

	// RVA: 0x2E5E240 Offset: 0x2E5A240 VA: 0x2E5E240
	public void .ctor() { }

	// RVA: 0x2E5E2A4 Offset: 0x2E5A2A4 VA: 0x2E5E2A4
	internal int get_PEOffset() { }

	// RVA: 0x2E5E39C Offset: 0x2E5A39C VA: 0x2E5E39C
	internal void Open(string filename) { }

	// RVA: 0x2E5E470 Offset: 0x2E5A470 VA: 0x2E5E470
	internal void Open(byte[] rawdata) { }

	// RVA: 0x2E5E434 Offset: 0x2E5A434 VA: 0x2E5E434
	internal void Close() { }

	// RVA: 0x2E5E2CC Offset: 0x2E5A2CC VA: 0x2E5E2CC
	internal void ReadFirstBlock() { }

	// RVA: 0x2E5E500 Offset: 0x2E5A500 VA: 0x2E5E500
	internal int ProcessFirstBlock() { }

	// RVA: 0x2E5E738 Offset: 0x2E5A738 VA: 0x2E5E738
	internal byte[] GetSecurityEntry() { }

	// RVA: 0x2E5E808 Offset: 0x2E5A808 VA: 0x2E5E808
	internal byte[] GetHash(HashAlgorithm hash) { }
}
