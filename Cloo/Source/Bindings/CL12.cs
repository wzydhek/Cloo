#region License

/*

Copyright (c) 2009 - 2013 Fatjon Sakiqi

Permission is hereby granted, free of charge, to any person
obtaining a copy of this software and associated documentation
files (the "Software"), to deal in the Software without
restriction, including without limitation the rights to use,
copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the
Software is furnished to do so, subject to the following
conditions:

The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
OTHER DEALINGS IN THE SOFTWARE.

*/

#endregion

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;

namespace Cloo.Bindings
{
    /// <summary>
    /// Contains bindings to the OpenCL 1.2 functions.
    /// </summary>
    /// <remarks> See the OpenCL specification for documentation regarding these functions. </remarks>
    [SuppressUnmanagedCodeSecurity]
    public class CL12 : CL11
    {
        /// <summary>
        /// See the OpenCL specification.
        /// </summary>
        [DllImport(libName, EntryPoint = "clCompileProgram")]
        public static extern ComputeErrorCode CompileProgram(
            CLProgramHandle program,
            int num_devices,
            [MarshalAs(UnmanagedType.LPArray)] CLDeviceHandle[] device_list,
            string options,
            int num_input_headers,
            [MarshalAs(UnmanagedType.LPArray)] CLProgramHandle[] input_headers,
            string[] header_include_names,
            cl_program_callback pfn_notify,
            IntPtr user_data);

        /// <summary>
        /// See the OpenCL specification.
        /// </summary>
        [DllImport(libName, EntryPoint = "clCreateImage")]
        public static extern CLImageHandle CreateImage(
            CLContextHandle context,
            ComputeMemoryFlags flags,
            ref cl_image_format image_format,
            cl_image_desc image_desc,
            IntPtr host_ptr,
            out ComputeErrorCode errcode_ret);

        /// <summary>
        /// See the OpenCL specification.
        /// </summary>
        [DllImport(libName, EntryPoint = "clCreateImageWithProperties")]
        public static extern CLImageHandle CreateImageWithProperties(
            CLContextHandle context,
            [MarshalAs(UnmanagedType.LPArray)] long[] properties,
            ComputeMemoryFlags flags,
            ref cl_image_format image_format,
            cl_image_desc image_desc,
            IntPtr host_ptr,
            out ComputeErrorCode errcode_ret);

        /// <summary>
        /// See the OpenCL specification.
        /// </summary>
        [DllImport(libName, EntryPoint = "clCreateProgramWithBuiltInKernels")]
        public static extern ComputeProgram CreateProgramWithBuiltInKernels(
            CLContextHandle context,
            int num_devices,
            [MarshalAs(UnmanagedType.LPArray)] CLDeviceHandle[] device_list,
            string[] kernel_names,
            out ComputeErrorCode errcode_ret);

        /// <summary>
        /// See the OpenCL specification.
        /// </summary>
        [DllImport(libName, EntryPoint = "clCreateSubDevices")]
        public static extern ComputeErrorCode CreateSubDevices(
            CLDeviceHandle in_device,
            [MarshalAs(UnmanagedType.LPArray)] long[] properties,
            int num_devices,
            [MarshalAs(UnmanagedType.LPArray)] ref CLDeviceHandle[] out_devices,
            out int num_devices_ret);

        /// <summary>
        /// See the OpenCL specification.
        /// </summary>
        [DllImport(libName, EntryPoint = "clEnqueueBarrierWithWaitList")]
        public static extern ComputeErrorCode EnqueueBarrierWithWaitList(
            CLCommandQueueHandle command_queue,
            int num_events,
            [MarshalAs(UnmanagedType.LPArray)] CLEventHandle[] event_list,
            [Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 1)] CLEventHandle[] new_event);

        /// <summary>
        /// See the OpenCL specification.
        /// </summary>
        [DllImport(libName, EntryPoint = "clEnqueueFillBuffer")]
        public static extern ComputeErrorCode EnqueueFillBuffer(
            CLCommandQueueHandle command_queue,
            CLMemoryHandle buffer,
            IntPtr pattern,
            IntPtr pattern_size,
            IntPtr offset,
            IntPtr size,
            int num_events_in_wait_list,
            [MarshalAs(UnmanagedType.LPArray)] CLEventHandle[] event_wait_list,
            [Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 1)] CLEventHandle[] new_event);

        /// <summary>
        /// See the OpenCL specification.
        /// </summary>
        [DllImport(libName, EntryPoint = "clEnqueueFillImage")]
        public static extern ComputeErrorCode EnqueueFillImage(
            CLCommandQueueHandle command_queue,
            CLImageHandle buffer,
            IntPtr fill_color,
            IntPtr origin,
            IntPtr region,
            int num_events_in_wait_list,
            [MarshalAs(UnmanagedType.LPArray)] CLEventHandle[] event_wait_list,
            [Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 1)] CLEventHandle[] new_event);

        /// <summary>
        /// See the OpenCL specification.
        /// </summary>
        [DllImport(libName, EntryPoint = "clEnqueueMarkerWithWaitList")]
        public static extern ComputeErrorCode EnqueueMarkerWithWaitList(
            CLCommandQueueHandle command_queue,
            int num_events,
            [MarshalAs(UnmanagedType.LPArray)] CLEventHandle[] event_list,
            [Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 1)] CLEventHandle[] new_event);

        /// <summary>
        /// See the OpenCL specification.
        /// </summary>
        [DllImport(libName, EntryPoint = "clEnqueueMigrateMemObjects")]
        public static extern ComputeErrorCode EnqueueMigrateMemObjects(
            CLCommandQueueHandle command_queue,
            int num_mem_objects,
            [MarshalAs(UnmanagedType.LPArray)] CLMemoryHandle[] mem_objects,
            ComputeMemoryMigrationFlags flags,
            int num_events_in_wait_list,
            [MarshalAs(UnmanagedType.LPArray)] CLEventHandle[] event_wait_list,
            [Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 1)] CLEventHandle[] new_event);

        /// <summary>
        /// See the OpenCL specification.
        /// </summary>
        [DllImport(libName, EntryPoint = "clGetKernelArgInfo")]
        public static extern ComputeErrorCode GetKernelArgInfo(
            CLKernelHandle kernel,
            int arg_index,
            ComputeKernelArgumentInfo param_name,
            IntPtr param_value_size,
            IntPtr param_value,
            out IntPtr param_value_size_ret);

        /// <summary>
        /// See the OpenCL specification.
        /// </summary>
        [DllImport(libName, EntryPoint = "clLinkProgram")]
        public static extern CLProgramHandle LinkProgram(
            CLContextHandle context,
            int num_devices,
            [MarshalAs(UnmanagedType.LPArray)] CLDeviceHandle[] device_list,
            string options,
            int num_input_programs,
            [MarshalAs(UnmanagedType.LPArray)] CLProgramHandle[] input_programs,
            cl_program_callback notify,
            IntPtr user_data,
            out ComputeErrorCode errcode_ret);

        /// <summary>
        /// See the OpenCL specification.
        /// </summary>
        [DllImport(libName, EntryPoint = "clReleaseDevice")]
        public static extern ComputeErrorCode ReleaseDevice(
            CLDeviceHandle device);

        /// <summary>
        /// See the OpenCL specification.
        /// </summary>
        [DllImport(libName, EntryPoint = "clRetainDevice")]
        public static extern ComputeErrorCode RetainDevice(
            CLDeviceHandle device);

        /// <summary>
        /// See the OpenCL specification.
        /// </summary>
        [DllImport(libName, EntryPoint = "clUnloadPlatformCompiler")]
        public static extern ComputeErrorCode UnloadPlatformCompiler(
            CLPlatformHandle platform);

        /// <summary>
        /// Gets the extension function address for the given function name,
        /// or NULL if a valid function can not be found. The client must
        /// check to make sure the address is not NULL, before using or 
        /// calling the returned function address.
        /// </summary>
        [DllImport(libName, EntryPoint = "clGetExtensionFunctionAddressForPlatform")]
        public static extern IntPtr GetExtensionFunctionAddressForPlatform(
            CLPlatformHandle platform,
            string func_name);

        #region Deprecated functions

        /// <summary>
        /// See the OpenCL specification.
        /// </summary>
        [Obsolete("Deprecated in OpenCL 1.2.")]
        public new static CLMemoryHandle CreateFromGLTexture2D(
            CLContextHandle context,
            ComputeMemoryFlags flags,
            Int32 target,
            Int32 miplevel,
            Int32 texture,
            out ComputeErrorCode errcode_ret)
        {
            Debug.WriteLine("WARNING! clCreateFromGLTexture2D has been deprecated in OpenCL 1.2.");
            return CL11.CreateFromGLTexture2D(context, flags, target, miplevel, texture, out errcode_ret);
        }

        /// <summary>
        /// See the OpenCL specification.
        /// </summary>
        [Obsolete("Deprecated in OpenCL 1.2.")]
        public new static CLMemoryHandle CreateFromGLTexture3D(
            CLContextHandle context,
            ComputeMemoryFlags flags,
            Int32 target,
            Int32 miplevel,
            Int32 texture,
            out ComputeErrorCode errcode_ret)
        {
            Debug.WriteLine("WARNING! clCreateFromGLTexture3D has been deprecated in OpenCL 1.2.");
            return CL11.CreateFromGLTexture3D(context, flags, target, miplevel, texture, out errcode_ret);
        }
        
        /// <summary>
        /// See the OpenCL specification.
        /// </summary>
        [Obsolete("Deprecated in OpenCL 1.2.")]
        public new static CLMemoryHandle CreateImage2D(
            CLContextHandle context,
            ComputeMemoryFlags flags,
            ref ComputeImageFormat image_format,
            IntPtr image_width,
            IntPtr image_height,
            IntPtr image_row_pitch,
            IntPtr host_ptr,
            out ComputeErrorCode errcode_ret)
        {
            Debug.WriteLine("WARNING! clCreateImage2D has been deprecated in OpenCL 1.2.");
            return CL11.CreateImage2D(context, flags, ref image_format, image_width, image_height, image_row_pitch, host_ptr, out errcode_ret);
        }

        /// <summary>
        /// See the OpenCL specification.
        /// </summary>
        [Obsolete("Deprecated in OpenCL 1.2.")]
        public new static CLMemoryHandle CreateImage3D(
            CLContextHandle context,
            ComputeMemoryFlags flags,
            ref ComputeImageFormat image_format,
            IntPtr image_width,
            IntPtr image_height,
            IntPtr image_depth,
            IntPtr image_row_pitch,
            IntPtr image_slice_pitch,
            IntPtr host_ptr,
            out ComputeErrorCode errcode_ret)
        {
            Debug.WriteLine("WARNING! clCreateImage3D has been deprecated in OpenCL 1.2.");
            return CL11.CreateImage3D(context, flags, ref image_format, image_width, image_height, image_depth, image_row_pitch, image_slice_pitch, host_ptr, out errcode_ret);
        }
        
        /// <summary>
        /// See the OpenCL specification.
        /// </summary>
        [Obsolete("Deprecated in OpenCL 1.2.")]
        public new static ComputeErrorCode EnqueueBarrier(
            CLCommandQueueHandle command_queue)
        {
            Debug.WriteLine("WARNING! clEnqueueBarrier has been deprecated in OpenCL 1.2.");
            return CL11.EnqueueBarrier(command_queue);
        }

        /// <summary>
        /// See the OpenCL specification.
        /// </summary>
        [Obsolete("Deprecated in OpenCL 1.2.")]
        public new static ComputeErrorCode EnqueueMarker(
            CLCommandQueueHandle command_queue,
            out CLEventHandle new_event)
        {
            Debug.WriteLine("WARNING! clEnqueueMarker has been deprecated in OpenCL 1.2.");
            return CL11.EnqueueMarker(command_queue, out new_event);
        }

        /// <summary>
        /// See the OpenCL specification.
        /// </summary>
        [Obsolete("Deprecated in OpenCL 1.2.")]
        public new static ComputeErrorCode EnqueueWaitForEvents(
            CLCommandQueueHandle command_queue,
            Int32 num_events,
            [MarshalAs(UnmanagedType.LPArray)] CLEventHandle[] event_list)
        {
            Debug.WriteLine("WARNING! clEnqueueWaitForEvents has been deprecated in OpenCL 1.2.");
            return CL11.EnqueueWaitForEvents(command_queue, num_events, event_list);
        }

        /// <summary>
        /// See the OpenCL specification.
        /// </summary>
        [Obsolete("Deprecated in OpenCL 1.2.")]
        public new static IntPtr GetExtensionFunctionAddress(
            String func_name)
        {
            Debug.WriteLine("WARNING! clGetExtensionFunctionAddress has been deprecated in OpenCL 1.2.");
            return CL11.GetExtensionFunctionAddress(func_name);
        }

        /// <summary>
        /// See the OpenCL specification.
        /// </summary>
        [Obsolete("Deprecated in OpenCL 1.2.")]
        public new static ComputeErrorCode UnloadCompiler()
        {
            Debug.WriteLine("WARNING! clUnloadCompiler has been deprecated in OpenCL 1.2.");
            return CL11.UnloadCompiler();
        }

        #endregion
    }

    /// <summary>
    /// See the OpenCL specification.
    /// </summary>
    public struct cl_image_format
    {
        /// <summary>
        /// See the OpenCL specification.
        /// </summary>
        public ComputeImageChannelOrder image_channel_order;
        /// <summary>
        /// See the OpenCL specification.
        /// </summary>
        public ComputeImageChannelType image_channel_data_type;
    }

    /// <summary>
    /// See the OpenCL specification.
    /// </summary>
    public struct cl_image_desc
    {
        /// <summary>
        /// See the OpenCL specification.
        /// </summary>
        public ComputeMemoryType image_type;
        /// <summary>
        /// See the OpenCL specification.
        /// </summary>
        public IntPtr image_width;
        /// <summary>
        /// See the OpenCL specification.
        /// </summary>
        public IntPtr image_height;
        /// <summary>
        /// See the OpenCL specification.
        /// </summary>
        public IntPtr image_depth;
        /// <summary>
        /// See the OpenCL specification.
        /// </summary>
        public IntPtr image_array_size;
        /// <summary>
        /// See the OpenCL specification.
        /// </summary>
        public IntPtr image_row_pitch;
        /// <summary>
        /// See the OpenCL specification.
        /// </summary>
        public IntPtr image_slice_pitch;
        /// <summary>
        /// See the OpenCL specification.
        /// </summary>
        public int num_mip_levels;
        /// <summary>
        /// See the OpenCL specification.
        /// </summary>
        public int num_samples;
    }
}