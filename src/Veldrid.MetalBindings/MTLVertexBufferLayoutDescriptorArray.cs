using System;
using static Veldrid.MetalBindings.ObjectiveCRuntime;

namespace Veldrid.MetalBindings
{
    public struct MTLVertexBufferLayoutDescriptorArray
    {
        public readonly IntPtr NativePtr;

        public MTLVertexBufferLayoutDescriptor this[uint index]
        {
            get
            {
                IntPtr value = IntPtr_objc_msgSend(NativePtr, "objectAtIndexedSubscript:", index);
                return new MTLVertexBufferLayoutDescriptor(value);
            }
            set => objc_msgSend(NativePtr, "setObject:atIndexedSubscript:", value.NativePtr, index);
        }
    }
}