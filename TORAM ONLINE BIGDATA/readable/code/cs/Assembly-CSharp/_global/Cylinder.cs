// Assembly: Assembly-CSharp.dll
// Namespace: 
public class Cylinder // TypeDefIndex: 5290
{
	// Fields
	private Vector3 center; // 0x10
	private float rad; // 0x1C
	private float height; // 0x20

	// Properties
	public Vector3 Center { get; }
	public float Rad { get; }
	public float Height { get; }

	// Methods

	// RVA: 0x2623B68 Offset: 0x261FB68 VA: 0x2623B68
	public Vector3 get_Center() { }

	// RVA: 0x2623B74 Offset: 0x261FB74 VA: 0x2623B74
	public float get_Rad() { }

	// RVA: 0x2623B7C Offset: 0x261FB7C VA: 0x2623B7C
	public float get_Height() { }

	// RVA: 0x2623B84 Offset: 0x261FB84 VA: 0x2623B84
	public void .ctor(Vector3 center, float rad, float height) { }

	// RVA: 0x2623BE4 Offset: 0x261FBE4 VA: 0x2623BE4
	public void Update(Vector3 center) { }

	// RVA: 0x2623BD4 Offset: 0x261FBD4 VA: 0x2623BD4
	public void Set(Vector3 center, float rad, float height) { }

	// RVA: 0x2623BF0 Offset: 0x261FBF0 VA: 0x2623BF0
	public bool IsHitSphere(Vector3 pos, float rad) { }

	// RVA: 0x2623C48 Offset: 0x261FC48 VA: 0x2623C48
	public bool IsHitCylinder(Vector3 pos, float rad, float height) { }
}
