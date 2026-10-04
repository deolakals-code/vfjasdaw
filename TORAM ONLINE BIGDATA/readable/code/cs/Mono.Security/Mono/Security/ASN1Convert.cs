// Assembly: Mono.Security.dll
// Namespace: Mono.Security
public static class ASN1Convert // TypeDefIndex: 16866
{
	// Methods

	// RVA: 0x2E42910 Offset: 0x2E3E910 VA: 0x2E42910
	public static ASN1 FromInt32(int value) { }

	// RVA: 0x2E42AA0 Offset: 0x2E3EAA0 VA: 0x2E42AA0
	public static ASN1 FromOid(string oid) { }

	// RVA: 0x2E42B7C Offset: 0x2E3EB7C VA: 0x2E42B7C
	public static ASN1 FromUnsignedBigInteger(byte[] big) { }

	// RVA: 0x2E42C98 Offset: 0x2E3EC98 VA: 0x2E42C98
	public static int ToInt32(ASN1 asn1) { }

	// RVA: 0x2E42DA8 Offset: 0x2E3EDA8 VA: 0x2E42DA8
	public static string ToOid(ASN1 asn1) { }

	// RVA: 0x2E43030 Offset: 0x2E3F030 VA: 0x2E43030
	public static DateTime ToDateTime(ASN1 time) { }
}
