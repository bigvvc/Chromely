﻿//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace Xilium.CefGlue
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    using Xilium.CefGlue.Interop;
    
    // Role: HANDLER
    public abstract unsafe partial class CefUrlRequestClient
    {
        private static Dictionary<IntPtr, CefUrlRequestClient> _roots = new Dictionary<IntPtr, CefUrlRequestClient>();
        
        private int _refct;
        private cef_urlrequest_client_t* _self;
        
        protected object SyncRoot { get { return this; } }
        
        internal static CefUrlRequestClient FromNativeOrNull(cef_urlrequest_client_t* ptr)
        {
            CefUrlRequestClient value = null;
            bool found;
            lock (_roots)
            {
                found = _roots.TryGetValue((IntPtr)ptr, out value);
            }
            return found ? value : null;
        }
        
        internal static CefUrlRequestClient FromNative(cef_urlrequest_client_t* ptr)
        {
            var value = FromNativeOrNull(ptr);
            if (value == null) throw ExceptionBuilder.ObjectNotFound();
            return value;
        }
        
        private cef_urlrequest_client_t.add_ref_delegate _ds0;
        private cef_urlrequest_client_t.release_delegate _ds1;
        private cef_urlrequest_client_t.has_one_ref_delegate _ds2;
        private cef_urlrequest_client_t.has_at_least_one_ref_delegate _ds3;
        private cef_urlrequest_client_t.on_request_complete_delegate _ds4;
        private cef_urlrequest_client_t.on_upload_progress_delegate _ds5;
        private cef_urlrequest_client_t.on_download_progress_delegate _ds6;
        private cef_urlrequest_client_t.on_download_data_delegate _ds7;
        private cef_urlrequest_client_t.get_auth_credentials_delegate _ds8;
        
        protected CefUrlRequestClient()
        {
            _self = cef_urlrequest_client_t.Alloc();
        
            _ds0 = new cef_urlrequest_client_t.add_ref_delegate(add_ref);
            _self->_base._add_ref = Marshal.GetFunctionPointerForDelegate(_ds0);
            _ds1 = new cef_urlrequest_client_t.release_delegate(release);
            _self->_base._release = Marshal.GetFunctionPointerForDelegate(_ds1);
            _ds2 = new cef_urlrequest_client_t.has_one_ref_delegate(has_one_ref);
            _self->_base._has_one_ref = Marshal.GetFunctionPointerForDelegate(_ds2);
            _ds3 = new cef_urlrequest_client_t.has_at_least_one_ref_delegate(has_at_least_one_ref);
            _self->_base._has_at_least_one_ref = Marshal.GetFunctionPointerForDelegate(_ds3);
            _ds4 = new cef_urlrequest_client_t.on_request_complete_delegate(on_request_complete);
            _self->_on_request_complete = Marshal.GetFunctionPointerForDelegate(_ds4);
            _ds5 = new cef_urlrequest_client_t.on_upload_progress_delegate(on_upload_progress);
            _self->_on_upload_progress = Marshal.GetFunctionPointerForDelegate(_ds5);
            _ds6 = new cef_urlrequest_client_t.on_download_progress_delegate(on_download_progress);
            _self->_on_download_progress = Marshal.GetFunctionPointerForDelegate(_ds6);
            _ds7 = new cef_urlrequest_client_t.on_download_data_delegate(on_download_data);
            _self->_on_download_data = Marshal.GetFunctionPointerForDelegate(_ds7);
            _ds8 = new cef_urlrequest_client_t.get_auth_credentials_delegate(get_auth_credentials);
            _self->_get_auth_credentials = Marshal.GetFunctionPointerForDelegate(_ds8);
        }
        
        ~CefUrlRequestClient()
        {
            Dispose(false);
        }
        
        protected virtual void Dispose(bool disposing)
        {
            if (_self != null)
            {
                cef_urlrequest_client_t.Free(_self);
                _self = null;
            }
        }
        
        private void add_ref(cef_urlrequest_client_t* self)
        {
            lock (SyncRoot)
            {
                var result = ++_refct;
                if (result == 1)
                {
                    lock (_roots) { _roots.Add((IntPtr)_self, this); }
                }
            }
        }
        
        private int release(cef_urlrequest_client_t* self)
        {
            lock (SyncRoot)
            {
                var result = --_refct;
                if (result == 0)
                {
                    lock (_roots) { _roots.Remove((IntPtr)_self); }
                    return 1;
                }
                return 0;
            }
        }
        
        private int has_one_ref(cef_urlrequest_client_t* self)
        {
            lock (SyncRoot) { return _refct == 1 ? 1 : 0; }
        }
        
        private int has_at_least_one_ref(cef_urlrequest_client_t* self)
        {
            lock (SyncRoot) { return _refct != 0 ? 1 : 0; }
        }
        
        internal cef_urlrequest_client_t* ToNative()
        {
            add_ref(_self);
            return _self;
        }
        
        [Conditional("DEBUG")]
        private void CheckSelf(cef_urlrequest_client_t* self)
        {
            if (_self != self) throw ExceptionBuilder.InvalidSelfReference();
        }
        
    }
}