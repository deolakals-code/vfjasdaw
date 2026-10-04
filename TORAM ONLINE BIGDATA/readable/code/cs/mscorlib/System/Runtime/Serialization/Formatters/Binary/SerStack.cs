// Assembly: mscorlib.dll
// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class SerStack // TypeDefIndex: 10425
{
	// Fields
	internal object[] objects; // 0x10
	internal string stackId; // 0x18
	internal int top; // 0x20

	// Methods

	// RVA: 0x2F1AD58 Offset: 0x2F16D58 VA: 0x2F1AD58
	internal void .ctor(string stackId) { }

	// RVA: 0x2F1ADE0 Offset: 0x2F16DE0 VA: 0x2F1ADE0
	internal void Push(object obj) { }

	// RVA: 0x2F1AF20 Offset: 0x2F16F20 VA: 0x2F1AF20
	internal object Pop() { }

	// RVA: 0x2F1AE90 Offset: 0x2F16E90 VA: 0x2F1AE90
	internal void IncreaseCapacity() { }

	// RVA: 0x2F1AF7C Offset: 0x2F16F7C VA: 0x2F1AF7C
	internal object Peek() { }

	// RVA: 0x2F1AFBC Offset: 0x2F16FBC VA: 0x2F1AFBC
	internal object PeekPeek() { }

	// RVA: 0x2F1B000 Offset: 0x2F17000 VA: 0x2F1B000
	internal bool IsEmpty() { }
}
