// Assembly: Mono.Security.dll
// Namespace: Mono.Security.X509
public class X509Extension // TypeDefIndex: 16884
{
	// Fields
	protected string extnOid; // 0x10
	protected bool extnCritical; // 0x18
	protected ASN1 extnValue; // 0x20

	// Properties
	public string Oid { get; }
	public bool Critical { get; }
	public ASN1 Value { get; }

	// Methods

	// RVA: 0x2E519C4 Offset: 0x2E4D9C4 VA: 0x2E519C4
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x2E51CA4 Offset: 0x2E4DCA4 VA: 0x2E51CA4
	public void .ctor(X509Extension extension) { }

	// RVA: 0x2E51E24 Offset: 0x2E4DE24 VA: 0x2E51E24 Slot: 4
	protected virtual void Decode() { }

	// RVA: 0x2E51E28 Offset: 0x2E4DE28 VA: 0x2E51E28 Slot: 5
	protected virtual void Encode() { }

	// RVA: 0x2E51E2C Offset: 0x2E4DE2C VA: 0x2E51E2C
	public string get_Oid() { }

	// RVA: 0x2E51E34 Offset: 0x2E4DE34 VA: 0x2E51E34
	public bool get_Critical() { }

	// RVA: 0x2E51DF8 Offset: 0x2E4DDF8 VA: 0x2E51DF8
	public ASN1 get_Value() { }

	// RVA: 0x2E51E3C Offset: 0x2E4DE3C VA: 0x2E51E3C Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2E51F8C Offset: 0x2E4DF8C VA: 0x2E51F8C Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2E51FAC Offset: 0x2E4DFAC VA: 0x2E51FAC
	private void WriteLine(StringBuilder sb, int n, int pos) { }

	// RVA: 0x2E521D4 Offset: 0x2E4E1D4 VA: 0x2E521D4 Slot: 3
	public override string ToString() { }
}
