// Assembly: UnityEngine.AndroidJNIModule.dll
// Namespace: UnityEngine
public sealed class AndroidJavaException : Exception // TypeDefIndex: 17062
{
	// Fields
	private string mJavaStackTrace; // 0x90

	// Properties
	public override string StackTrace { get; }

	// Methods

	// RVA: 0x37BD304 Offset: 0x37B9304 VA: 0x37BD304
	internal void .ctor(string message, string javaStackTrace) { }

	// RVA: 0x37C0854 Offset: 0x37BC854 VA: 0x37C0854 Slot: 9
	public override string get_StackTrace() { }
}
