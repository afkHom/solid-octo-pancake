//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.0
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Grapeshot {

public sealed class RequestCallback_FunctionApplicationBridge : RequestCallback_FunctionApplicationBridgeBase {
    public delegate void Delegate(ror.schema.upload.UploadChunkResponse arg);

    private Delegate _delegate;

    public RequestCallback_FunctionApplicationBridge(Delegate d) : base() {
        _delegate = d;
    }

    public override void releaseApplicationCallback() {
        // This doesn't do anything except update reflection info so that the director thinks it needs
        // to call this.
        base.releaseApplicationCallback();
    }

    public override void invokeApplicationLogic(ror.schema.upload.UploadChunkResponse arg) {
        try {
            _delegate(arg);
        } catch {}
    }

}

}
