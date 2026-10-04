// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PetCaptureDataManager // TypeDefIndex: 1062
{
	// Fields
	private static PetCaptureDataManager instance; // 0x0
	private List<PetCaptureData> captureDataList; // 0x10

	// Properties
	public static PetCaptureDataManager Instance { get; }

	// Methods

	// RVA: 0x1F3FD04 Offset: 0x1F3BD04 VA: 0x1F3FD04
	public static PetCaptureDataManager get_Instance() { }

	// RVA: 0x1F3FD5C Offset: 0x1F3BD5C VA: 0x1F3FD5C
	private void .ctor() { }

	// RVA: 0x1F3FDE4 Offset: 0x1F3BDE4 VA: 0x1F3FDE4
	public bool Read(byte[] data) { }

	// RVA: 0x1F401E8 Offset: 0x1F3C1E8 VA: 0x1F401E8
	public bool Contains(int uuid, int modelId) { }

	// RVA: 0x1F402C8 Offset: 0x1F3C2C8 VA: 0x1F402C8
	public bool TryGet(int uuid, int modelId, out PetCaptureData captureData) { }

	// RVA: 0x1F403D4 Offset: 0x1F3C3D4 VA: 0x1F403D4
	public bool Contains(int uuid) { }

	// RVA: 0x1F404B0 Offset: 0x1F3C4B0 VA: 0x1F404B0
	public bool TryGet(int uuid, out PetCaptureData captureData) { }

	// RVA: 0x1F405B0 Offset: 0x1F3C5B0 VA: 0x1F405B0
	private static void .cctor() { }
}
