// Assembly: mscorlib.dll
// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class AsymmetricAlgorithm : IDisposable // TypeDefIndex: 10101
{
	// Fields
	protected int KeySizeValue; // 0x10
	protected KeySizes[] LegalKeySizesValue; // 0x18

	// Properties
	public virtual int KeySize { get; set; }

	// Methods

	// RVA: 0x2EAD584 Offset: 0x2EA9584 VA: 0x2EAD584
	protected void .ctor() { }

	// RVA: 0x2EAD58C Offset: 0x2EA958C VA: 0x2EAD58C Slot: 4
	public void Dispose() { }

	// RVA: 0x2EAD590 Offset: 0x2EA9590 VA: 0x2EAD590
	public void Clear() { }

	// RVA: 0x2EAD5FC Offset: 0x2EA95FC VA: 0x2EAD5FC Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x2EAD600 Offset: 0x2EA9600 VA: 0x2EAD600 Slot: 6
	public virtual int get_KeySize() { }

	// RVA: 0x2EAD608 Offset: 0x2EA9608 VA: 0x2EAD608 Slot: 7
	public virtual void set_KeySize(int value) { }

	// RVA: 0x2EAD704 Offset: 0x2EA9704 VA: 0x2EAD704 Slot: 8
	public virtual void FromXmlString(string xmlString) { }

	// RVA: 0x2EAD73C Offset: 0x2EA973C VA: 0x2EAD73C Slot: 9
	public virtual string ToXmlString(bool includePrivateParameters) { }
}
