using System;
using System.Runtime.InteropServices;
using static Veldrid.MetalBindings.ObjectiveCRuntime;

namespace Veldrid.MetalBindings
{
    [StructLayout(LayoutKind.Sequential)]
    public struct MTLRenderPassColorAttachmentDescriptorArray
    {
        public readonly IntPtr NativePtr;

        public MTLRenderPassColorAttachmentDescriptor this[uint index]
        {
            get
            {
                IntPtr value = IntPtr_objc_msgSend(NativePtr, "objectAtIndexedSubscript:", index);
                return new MTLRenderPassColorAttachmentDescriptor(value);
            }
            set
            {
                objc_msgSend(NativePtr, "setObject:atIndexedSubscript:", value.NativePtr, index);
            }
        }
    }
}