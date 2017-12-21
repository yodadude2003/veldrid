using System;
using System.Runtime.InteropServices;
using static Veldrid.MetalBindings.ObjectiveCRuntime;

namespace Veldrid.MetalBindings
{
    [StructLayout(LayoutKind.Sequential)]
    public struct MTLRenderPipelineColorAttachmentDescriptorArray
    {
        public readonly IntPtr NativePtr;

        public MTLRenderPipelineColorAttachmentDescriptor this[uint index]
        {
            get
            {
                IntPtr ptr = IntPtr_objc_msgSend(NativePtr, "objectAtIndexedSubscript:", index);
                return new MTLRenderPipelineColorAttachmentDescriptor(ptr);
            }
            set
            {
                objc_msgSend(NativePtr, "setObject:atIndexedSubscript:", value.NativePtr, index);
            }
        }
    }
}