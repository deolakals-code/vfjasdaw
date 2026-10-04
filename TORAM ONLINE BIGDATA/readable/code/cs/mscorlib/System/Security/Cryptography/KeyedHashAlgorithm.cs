// Assembly: mscorlib.dll
// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class KeyedHashAlgorithm : HashAlgorithm // TypeDefIndex: 10125
{
	// Fields
	protected byte[] KeyValue; // 0x28

	// Properties
	public virtual byte[] Key { get; set; }

	// Methods

	// RVA: 0x2EB0218 Offset: 0x2EAC218 VA: 0x2EB0218
	protected void .ctor() { }

	// RVA: 0x2EB01B0 Offset: 0x2EAC1B0 VA: 0x2EB01B0 Slot: 12
	protected override void Dispose(bool disposing) { }

	// RVA: 0x2EB0D5C Offset: 0x2EACD5C VA: 0x2EB0D5C Slot: 19
	public virtual byte[] get_Key() { }

	// RVA: 0x2EB0DD4 Offset: 0x2EACDD4 VA: 0x2EB0DD4 Slot: 20
	public virtual void set_Key(byte[] value) { }
}
