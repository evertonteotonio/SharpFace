//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CVPoint2DPair : global::System.IDisposable
{
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;

    internal CVPoint2DPair(global::System.IntPtr cPtr, bool cMemoryOwn)
    {
        swigCMemOwn = cMemoryOwn;
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }

    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CVPoint2DPair obj)
    {
        return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }

    ~CVPoint2DPair()
    {
        Dispose();
    }

    public virtual void Dispose()
    {
        lock(this)
        {
            if (swigCPtr.Handle != global::System.IntPtr.Zero)
            {
                if (swigCMemOwn)
                {
                    swigCMemOwn = false;
                    LandmarkDetectorPINVOKE.delete_CVPoint2DPair(swigCPtr);
                }
                swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
            }
            global::System.GC.SuppressFinalize(this);
        }
    }

    public CVPoint2DPair() : this(LandmarkDetectorPINVOKE.new_CVPoint2DPair__SWIG_0(), true)
    {
    }

    public CVPoint2DPair(SWIGTYPE_p_cv__Point2d t, SWIGTYPE_p_cv__Point2d u) : this(LandmarkDetectorPINVOKE.new_CVPoint2DPair__SWIG_1(SWIGTYPE_p_cv__Point2d.getCPtr(t), SWIGTYPE_p_cv__Point2d.getCPtr(u)), true)
    {
        if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
    }

    public CVPoint2DPair(CVPoint2DPair p) : this(LandmarkDetectorPINVOKE.new_CVPoint2DPair__SWIG_2(CVPoint2DPair.getCPtr(p)), true)
    {
        if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
    }

    public SWIGTYPE_p_cv__Point2d first
    {
        set
        {
            LandmarkDetectorPINVOKE.CVPoint2DPair_first_set(swigCPtr, SWIGTYPE_p_cv__Point2d.getCPtr(value));
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }
        get
        {
            SWIGTYPE_p_cv__Point2d ret = new SWIGTYPE_p_cv__Point2d(LandmarkDetectorPINVOKE.CVPoint2DPair_first_get(swigCPtr), true);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }
    }

    public SWIGTYPE_p_cv__Point2d second
    {
        set
        {
            LandmarkDetectorPINVOKE.CVPoint2DPair_second_set(swigCPtr, SWIGTYPE_p_cv__Point2d.getCPtr(value));
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }
        get
        {
            SWIGTYPE_p_cv__Point2d ret = new SWIGTYPE_p_cv__Point2d(LandmarkDetectorPINVOKE.CVPoint2DPair_second_get(swigCPtr), true);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }
    }

}
