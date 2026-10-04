// Assembly: Firebase.App.dll
// Namespace: Firebase
public sealed class InitializationException : Exception // TypeDefIndex: 17200
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private InitResult <InitResult>k__BackingField; // 0x8C

	// Properties
	public InitResult InitResult { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x265176C Offset: 0x264D76C VA: 0x265176C
	public InitResult get_InitResult() { }

	[CompilerGenerated]
	// RVA: 0x2651774 Offset: 0x264D774 VA: 0x2651774
	private void set_InitResult(InitResult value) { }

	// RVA: 0x265177C Offset: 0x264D77C VA: 0x265177C
	public void .ctor(InitResult result, string message) { }

	// RVA: 0x26517F0 Offset: 0x264D7F0 VA: 0x26517F0
	public void .ctor(InitResult result, string message, Exception inner) { }
}
