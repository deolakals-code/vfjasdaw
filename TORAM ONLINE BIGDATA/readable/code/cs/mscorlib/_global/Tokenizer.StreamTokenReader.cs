// Assembly: mscorlib.dll
// Namespace: 
internal class Tokenizer.StreamTokenReader : Tokenizer.ITokenReader // TypeDefIndex: 10082
{
	// Fields
	internal StreamReader _in; // 0x10
	internal int _numCharRead; // 0x18

	// Properties
	internal int NumCharEncountered { get; }

	// Methods

	// RVA: 0x2EA7940 Offset: 0x2EA3940 VA: 0x2EA7940
	internal void .ctor(StreamReader input) { }

	// RVA: 0x2EA7D88 Offset: 0x2EA3D88 VA: 0x2EA7D88 Slot: 5
	public virtual int Read() { }

	// RVA: 0x2EA7DC4 Offset: 0x2EA3DC4 VA: 0x2EA7DC4
	internal int get_NumCharEncountered() { }
}
