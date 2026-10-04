// Assembly: System.dll
// Namespace: System.Net.Security
public abstract class AuthenticatedStream : Stream // TypeDefIndex: 14594
{
	// Fields
	private Stream _InnerStream; // 0x28
	private bool _LeaveStreamOpen; // 0x30

	// Properties
	protected Stream InnerStream { get; }
	public abstract bool IsAuthenticated { get; }

	// Methods

	// RVA: 0x345F8A4 Offset: 0x345B8A4 VA: 0x345F8A4
	protected void .ctor(Stream innerStream, bool leaveInnerStreamOpen) { }

	// RVA: 0x345FA40 Offset: 0x345BA40 VA: 0x345FA40
	protected Stream get_InnerStream() { }

	// RVA: 0x345FA48 Offset: 0x345BA48 VA: 0x345FA48 Slot: 19
	protected override void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1 Slot: 37
	public abstract bool get_IsAuthenticated();
}
