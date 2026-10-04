// Assembly: mscorlib.dll
// Namespace: System
[Serializable]
public class MissingMemberException : MemberAccessException // TypeDefIndex: 9720
{
	// Fields
	protected string ClassName; // 0x90
	protected string MemberName; // 0x98
	protected byte[] Signature; // 0xA0

	// Properties
	public override string Message { get; }

	// Methods

	// RVA: 0x3006E7C Offset: 0x3002E7C VA: 0x3006E7C
	public void .ctor() { }

	// RVA: 0x3006DF4 Offset: 0x3002DF4 VA: 0x3006DF4
	public void .ctor(string message) { }

	// RVA: 0x3006EDC Offset: 0x3002EDC VA: 0x3006EDC
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x30072B8 Offset: 0x30032B8 VA: 0x30072B8 Slot: 11
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x3007190 Offset: 0x3003190 VA: 0x3007190 Slot: 5
	public override string get_Message() { }

	// RVA: 0x3007414 Offset: 0x3003414 VA: 0x3007414
	internal static string FormatSignature(byte[] signature) { }
}
