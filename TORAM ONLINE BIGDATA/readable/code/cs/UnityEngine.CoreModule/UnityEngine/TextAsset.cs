// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[NativeHeader("Runtime/Scripting/TextAsset.h")]
public class TextAsset : Object // TypeDefIndex: 16372
{
	// Properties
	public byte[] bytes { get; }
	public string text { get; }

	// Methods

	// RVA: 0x37EE9BC Offset: 0x37EA9BC VA: 0x37EE9BC
	public byte[] get_bytes() { }

	// RVA: 0x37EE9F8 Offset: 0x37EA9F8 VA: 0x37EE9F8
	private static void Internal_CreateInstance(TextAsset self, string text) { }

	// RVA: 0x37EEA3C Offset: 0x37EAA3C VA: 0x37EEA3C
	public string get_text() { }

	// RVA: 0x37EED54 Offset: 0x37EAD54 VA: 0x37EED54 Slot: 3
	public override string ToString() { }

	// RVA: 0x37EED58 Offset: 0x37EAD58 VA: 0x37EED58
	public void .ctor() { }

	// RVA: 0x37EED64 Offset: 0x37EAD64 VA: 0x37EED64
	internal void .ctor(TextAsset.CreateOptions options, string text) { }

	// RVA: 0x37EEACC Offset: 0x37EAACC VA: 0x37EEACC
	internal static string DecodeString(byte[] bytes) { }
}
