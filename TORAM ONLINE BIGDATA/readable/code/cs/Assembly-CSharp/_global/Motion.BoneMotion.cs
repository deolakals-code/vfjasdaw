// Assembly: Assembly-CSharp.dll
// Namespace: 
private class Motion.BoneMotion // TypeDefIndex: 299
{
	// Fields
	private short positionX; // 0x10
	private short positionY; // 0x12
	private short positionZ; // 0x14
	private short rotationX; // 0x16
	private short rotationY; // 0x18
	private short rotationZ; // 0x1A
	private short rotationW; // 0x1C
	private short scaleX; // 0x1E
	private short scaleY; // 0x20
	private short scaleZ; // 0x22
	private Transform bone; // 0x28
	private BoneClip activeClip; // 0x30
	private WrapMode playMode; // 0x38
	private float clipLen; // 0x3C
	private Vector3 crossStartPosition; // 0x40
	private Quaternion crossStartRotation; // 0x4C
	private Vector3 crossStartScale; // 0x5C
	private Vector3 crossEndPosition; // 0x68
	private Quaternion crossEndRotation; // 0x74
	private Vector3 crossEndScale; // 0x84
	private Vector3 updatePosition; // 0x90
	private Quaternion updateRotation; // 0x9C
	private Vector3 updateScale; // 0xAC
	private static BoneClip.MotionKeyFrame startFrameX; // 0x0
	private static BoneClip.MotionKeyFrame endFrameX; // 0x18
	private static BoneClip.MotionKeyFrame startFrameY; // 0x30
	private static BoneClip.MotionKeyFrame endFrameY; // 0x48
	private static BoneClip.MotionKeyFrame startFrameZ; // 0x60
	private static BoneClip.MotionKeyFrame endFrameZ; // 0x78
	private static BoneClip.MotionKeyFrame startFrame; // 0x90
	private static BoneClip.MotionKeyFrame endFrame; // 0xA8
	[CompilerGenerated]
	private byte <BoneId>k__BackingField; // 0xB8

	// Properties
	public byte BoneId { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2381D14 Offset: 0x237DD14 VA: 0x2381D14
	public byte get_BoneId() { }

	[CompilerGenerated]
	// RVA: 0x2381D1C Offset: 0x237DD1C VA: 0x2381D1C
	private void set_BoneId(byte value) { }

	// RVA: 0x2380C9C Offset: 0x237CC9C VA: 0x2380C9C
	public void .ctor(byte boneId, Transform trans) { }

	// RVA: 0x2381D24 Offset: 0x237DD24 VA: 0x2381D24
	public void SetBone(byte boneId, Transform trans) { }

	// RVA: 0x2381194 Offset: 0x237D194 VA: 0x2381194
	public void Play(BoneClip playClip, WrapMode playMode, float clipLen) { }

	// RVA: 0x2381554 Offset: 0x237D554 VA: 0x2381554
	public void CrossFade(BoneClip playClip, WrapMode playMode, float clipLen) { }

	// RVA: 0x2381D34 Offset: 0x237DD34 VA: 0x2381D34
	public void CrossFade(BoneClip playClip, WrapMode playMode, float crossLen, float clipLen) { }

	// RVA: 0x23823BC Offset: 0x237E3BC VA: 0x23823BC
	public void ChangePlayMode(WrapMode changeMode) { }

	// RVA: 0x23823C4 Offset: 0x237E3C4 VA: 0x23823C4
	private short GetFrame(float frame, short index, BoneClip.MotionKeyFrame[] list, out BoneClip.MotionKeyFrame startFrame, out BoneClip.MotionKeyFrame endFrame) { }

	// RVA: 0x2382550 Offset: 0x237E550 VA: 0x2382550
	private float Lerp(float frame, BoneClip.MotionKeyFrame startFrame, BoneClip.MotionKeyFrame endFrame) { }

	// RVA: 0x2382598 Offset: 0x237E598 VA: 0x2382598
	private float Lerp(float lerp, float startVal1, float endVal2) { }

	// RVA: 0x2381DFC Offset: 0x237DDFC VA: 0x2381DFC
	private Vector3 LerpPosition(float frame) { }

	// RVA: 0x2381FF0 Offset: 0x237DFF0 VA: 0x2381FF0
	private Quaternion LerpRotation(float frame) { }

	// RVA: 0x23821C8 Offset: 0x237E1C8 VA: 0x23821C8
	private Vector3 LerpScale(float frame) { }

	// RVA: 0x2381308 Offset: 0x237D308 VA: 0x2381308
	public void UpdateAnimtion(float frame) { }

	// RVA: 0x2381B68 Offset: 0x237DB68 VA: 0x2381B68
	public void UpdateFade(float lerp) { }
}
