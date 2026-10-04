// Assembly: System.dll
// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509BasicConstraintsExtension : X509Extension // TypeDefIndex: 14133
{
	// Fields
	internal const string oid = "2.5.29.19";
	internal const string friendlyName = "Basic Constraints";
	private bool _certificateAuthority; // 0x21
	private bool _hasPathLengthConstraint; // 0x22
	private int _pathLengthConstraint; // 0x24
	private AsnDecodeStatus _status; // 0x28

	// Properties
	public bool CertificateAuthority { get; }
	public bool HasPathLengthConstraint { get; }
	public int PathLengthConstraint { get; }

	// Methods

	// RVA: 0x348E5B4 Offset: 0x348A5B4 VA: 0x348E5B4
	public void .ctor() { }

	// RVA: 0x348CD64 Offset: 0x3488D64 VA: 0x348CD64
	public void .ctor(AsnEncodedData encodedBasicConstraints, bool critical) { }

	// RVA: 0x348E820 Offset: 0x348A820 VA: 0x348E820
	public void .ctor(bool certificateAuthority, bool hasPathLengthConstraint, int pathLengthConstraint, bool critical) { }

	// RVA: 0x348EAB4 Offset: 0x348AAB4 VA: 0x348EAB4
	public bool get_CertificateAuthority() { }

	// RVA: 0x348EB1C Offset: 0x348AB1C VA: 0x348EB1C
	public bool get_HasPathLengthConstraint() { }

	// RVA: 0x348EB84 Offset: 0x348AB84 VA: 0x348EB84
	public int get_PathLengthConstraint() { }

	// RVA: 0x348EBEC Offset: 0x348ABEC VA: 0x348EBEC Slot: 4
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x348E65C Offset: 0x348A65C VA: 0x348E65C
	internal AsnDecodeStatus Decode(byte[] extension) { }

	// RVA: 0x348E958 Offset: 0x348A958 VA: 0x348E958
	internal byte[] Encode() { }

	// RVA: 0x348EDB8 Offset: 0x348ADB8 VA: 0x348EDB8 Slot: 6
	internal override string ToString(bool multiLine) { }
}
