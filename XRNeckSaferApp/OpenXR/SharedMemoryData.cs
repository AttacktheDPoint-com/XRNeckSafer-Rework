using System.Runtime.InteropServices;

namespace XRNeckSafer
{
    // Explicit sequential layout to guarantee byte-for-byte match with the C++
    // shmVal_s struct in dllmain.cpp. Without this attribute, the CLR could
    // insert padding between the bool fields that doesn't match MSVC's layout,
    // causing silent data corruption across the shared memory boundary.
    [StructLayout(LayoutKind.Sequential)]
    public struct SharedMemoryData
    {
        public float hmdYawAngle;
        public float hmdPitchAngle;
        public float yawOffset;
        public float pitchOffset;
        public float lateralOffset;
        public float longitudinalOffset;
        public float rightMultiplier;
        public float leftMultiplier;
        public float upMultiplier;
        public float downMultiplier;
        public int leftStartAt;
        public int rightStartAt;
        public int upStartAt;
        public int downStartAt;
        public bool resetHmdOrientation;
        public bool useLinearRotation;
        public bool useLinearPitchRotation;
        public bool holdLinearRotation;
        public bool holdLinearPitchRotation;
        public bool hasBeenCentered;
    }
}
