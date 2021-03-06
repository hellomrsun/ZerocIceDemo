//
// Copyright (c) ZeroC, Inc. All rights reserved.
//
//
// Ice version 3.7.2
//
// <auto-generated>
//
// Generated from file `HelloMrSun.ice'
//
// Warning: do not edit this file.
//
// </auto-generated>
//


using _System = global::System;

#pragma warning disable 1591

namespace HelloMrSun
{
    [global::System.Runtime.InteropServices.ComVisible(false)]
    [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704")]
    [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707")]
    [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709")]
    [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710")]
    [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1711")]
    [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1715")]
    [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1716")]
    [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1720")]
    [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1722")]
    [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1724")]
    public partial interface Manufacturer : global::Ice.Object, ManufacturerOperations_
    {
    }
}

namespace HelloMrSun
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.7.2")]
    public delegate void Callback_Manufacturer_SendMaterials(bool ret);
}

namespace HelloMrSun
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.7.2")]
    public interface ManufacturerPrx : global::Ice.ObjectPrx
    {
        bool SendMaterials(global::System.Collections.Generic.List<string> materials, global::Ice.OptionalContext context = new global::Ice.OptionalContext());

        global::System.Threading.Tasks.Task<bool> SendMaterialsAsync(global::System.Collections.Generic.List<string> materials, global::Ice.OptionalContext context = new global::Ice.OptionalContext(), global::System.IProgress<bool> progress = null, global::System.Threading.CancellationToken cancel = new global::System.Threading.CancellationToken());

        global::Ice.AsyncResult<Callback_Manufacturer_SendMaterials> begin_SendMaterials(global::System.Collections.Generic.List<string> materials, global::Ice.OptionalContext context = new global::Ice.OptionalContext());

        global::Ice.AsyncResult begin_SendMaterials(global::System.Collections.Generic.List<string> materials, global::Ice.AsyncCallback callback, object cookie);

        global::Ice.AsyncResult begin_SendMaterials(global::System.Collections.Generic.List<string> materials, global::Ice.OptionalContext context, global::Ice.AsyncCallback callback, object cookie);

        bool end_SendMaterials(global::Ice.AsyncResult asyncResult);
    }
}

namespace HelloMrSun
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.7.2")]
    public interface ManufacturerOperations_
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.7.2")]
        bool SendMaterials(global::System.Collections.Generic.List<string> materials, global::Ice.Current current = null);
    }
}

namespace HelloMrSun
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.7.2")]
    public sealed class MaterialsHelper
    {
        public static void write(global::Ice.OutputStream ostr, global::System.Collections.Generic.List<string> v)
        {
            ostr.writeStringSeq(v == null ? 0 : v.Count, v);
        }

        public static global::System.Collections.Generic.List<string> read(global::Ice.InputStream istr)
        {
            global::System.Collections.Generic.List<string> v;
            istr.readStringSeq(out v);
            return v;
        }
    }

    [global::System.Runtime.InteropServices.ComVisible(false)]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.7.2")]
    [global::System.Serializable]
    public sealed class ManufacturerPrxHelper : global::Ice.ObjectPrxHelperBase, ManufacturerPrx
    {
        public ManufacturerPrxHelper()
        {
        }

        public ManufacturerPrxHelper(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
        {
        }

        #region Synchronous operations

        public bool SendMaterials(global::System.Collections.Generic.List<string> materials, global::Ice.OptionalContext context = new global::Ice.OptionalContext())
        {
            try
            {
                return _iceI_SendMaterialsAsync(materials, context, null, global::System.Threading.CancellationToken.None, true).Result;
            }
            catch(global::System.AggregateException ex_)
            {
                throw ex_.InnerException;
            }
        }

        #endregion

        #region Async Task operations

        public global::System.Threading.Tasks.Task<bool> SendMaterialsAsync(global::System.Collections.Generic.List<string> materials, global::Ice.OptionalContext context = new global::Ice.OptionalContext(), global::System.IProgress<bool> progress = null, global::System.Threading.CancellationToken cancel = new global::System.Threading.CancellationToken())
        {
            return _iceI_SendMaterialsAsync(materials, context, progress, cancel, false);
        }

        private global::System.Threading.Tasks.Task<bool> _iceI_SendMaterialsAsync(global::System.Collections.Generic.List<string> iceP_materials, global::Ice.OptionalContext context, global::System.IProgress<bool> progress, global::System.Threading.CancellationToken cancel, bool synchronous)
        {
            iceCheckTwowayOnly(_SendMaterials_name);
            var completed = new global::IceInternal.OperationTaskCompletionCallback<bool>(progress, cancel);
            _iceI_SendMaterials(iceP_materials, context, synchronous, completed);
            return completed.Task;
        }

        private const string _SendMaterials_name = "SendMaterials";

        private void _iceI_SendMaterials(global::System.Collections.Generic.List<string> iceP_materials, global::System.Collections.Generic.Dictionary<string, string> context, bool synchronous, global::IceInternal.OutgoingAsyncCompletionCallback completed)
        {
            var outAsync = getOutgoingAsync<bool>(completed);
            outAsync.invoke(
                _SendMaterials_name,
                global::Ice.OperationMode.Normal,
                global::Ice.FormatType.DefaultFormat,
                context,
                synchronous,
                write: (global::Ice.OutputStream ostr) =>
                {
                    MaterialsHelper.write(ostr, iceP_materials);
                },
                read: (global::Ice.InputStream istr) =>
                {
                    bool ret;
                    ret = istr.readBool();
                    return ret;
                });
        }

        #endregion

        #region Asynchronous operations

        public global::Ice.AsyncResult<Callback_Manufacturer_SendMaterials> begin_SendMaterials(global::System.Collections.Generic.List<string> materials, global::Ice.OptionalContext context = new global::Ice.OptionalContext())
        {
            return begin_SendMaterials(materials, context, null, null, false);
        }

        public global::Ice.AsyncResult begin_SendMaterials(global::System.Collections.Generic.List<string> materials, global::Ice.AsyncCallback callback, object cookie)
        {
            return begin_SendMaterials(materials, new global::Ice.OptionalContext(), callback, cookie, false);
        }

        public global::Ice.AsyncResult begin_SendMaterials(global::System.Collections.Generic.List<string> materials, global::Ice.OptionalContext context, global::Ice.AsyncCallback callback, object cookie)
        {
            return begin_SendMaterials(materials, context, callback, cookie, false);
        }

        public bool end_SendMaterials(global::Ice.AsyncResult asyncResult)
        {
            var resultI_ = global::IceInternal.AsyncResultI.check(asyncResult, this, _SendMaterials_name);
            var outgoing_ = (global::IceInternal.OutgoingAsyncT<bool>)resultI_.OutgoingAsync;
            return outgoing_.getResult(resultI_.wait());
        }

        private global::Ice.AsyncResult<Callback_Manufacturer_SendMaterials> begin_SendMaterials(global::System.Collections.Generic.List<string> iceP_materials, global::System.Collections.Generic.Dictionary<string, string> context, global::Ice.AsyncCallback completedCallback, object cookie, bool synchronous)
        {
            iceCheckAsyncTwowayOnly(_SendMaterials_name);
            var completed = new global::IceInternal.OperationAsyncResultCompletionCallback<Callback_Manufacturer_SendMaterials, bool>(
                (Callback_Manufacturer_SendMaterials cb, bool ret) =>
                {
                    if(cb != null)
                    {
                        cb.Invoke(ret);
                    }
                },
                this, _SendMaterials_name, cookie, completedCallback);
            _iceI_SendMaterials(iceP_materials, context, synchronous, completed);
            return completed;
        }

        #endregion

        #region Checked and unchecked cast operations

        public static ManufacturerPrx checkedCast(global::Ice.ObjectPrx b)
        {
            if(b == null)
            {
                return null;
            }
            ManufacturerPrx r = b as ManufacturerPrx;
            if((r == null) && b.ice_isA(ice_staticId()))
            {
                ManufacturerPrxHelper h = new ManufacturerPrxHelper();
                h.iceCopyFrom(b);
                r = h;
            }
            return r;
        }

        public static ManufacturerPrx checkedCast(global::Ice.ObjectPrx b, global::System.Collections.Generic.Dictionary<string, string> ctx)
        {
            if(b == null)
            {
                return null;
            }
            ManufacturerPrx r = b as ManufacturerPrx;
            if((r == null) && b.ice_isA(ice_staticId(), ctx))
            {
                ManufacturerPrxHelper h = new ManufacturerPrxHelper();
                h.iceCopyFrom(b);
                r = h;
            }
            return r;
        }

        public static ManufacturerPrx checkedCast(global::Ice.ObjectPrx b, string f)
        {
            if(b == null)
            {
                return null;
            }
            global::Ice.ObjectPrx bb = b.ice_facet(f);
            try
            {
                if(bb.ice_isA(ice_staticId()))
                {
                    ManufacturerPrxHelper h = new ManufacturerPrxHelper();
                    h.iceCopyFrom(bb);
                    return h;
                }
            }
            catch(global::Ice.FacetNotExistException)
            {
            }
            return null;
        }

        public static ManufacturerPrx checkedCast(global::Ice.ObjectPrx b, string f, global::System.Collections.Generic.Dictionary<string, string> ctx)
        {
            if(b == null)
            {
                return null;
            }
            global::Ice.ObjectPrx bb = b.ice_facet(f);
            try
            {
                if(bb.ice_isA(ice_staticId(), ctx))
                {
                    ManufacturerPrxHelper h = new ManufacturerPrxHelper();
                    h.iceCopyFrom(bb);
                    return h;
                }
            }
            catch(global::Ice.FacetNotExistException)
            {
            }
            return null;
        }

        public static ManufacturerPrx uncheckedCast(global::Ice.ObjectPrx b)
        {
            if(b == null)
            {
                return null;
            }
            ManufacturerPrx r = b as ManufacturerPrx;
            if(r == null)
            {
                ManufacturerPrxHelper h = new ManufacturerPrxHelper();
                h.iceCopyFrom(b);
                r = h;
            }
            return r;
        }

        public static ManufacturerPrx uncheckedCast(global::Ice.ObjectPrx b, string f)
        {
            if(b == null)
            {
                return null;
            }
            global::Ice.ObjectPrx bb = b.ice_facet(f);
            ManufacturerPrxHelper h = new ManufacturerPrxHelper();
            h.iceCopyFrom(bb);
            return h;
        }

        private static readonly string[] _ids =
        {
            "::HelloMrSun::Manufacturer",
            "::Ice::Object"
        };

        public static string ice_staticId()
        {
            return _ids[0];
        }

        #endregion

        #region Marshaling support

        public static void write(global::Ice.OutputStream ostr, ManufacturerPrx v)
        {
            ostr.writeProxy(v);
        }

        public static ManufacturerPrx read(global::Ice.InputStream istr)
        {
            global::Ice.ObjectPrx proxy = istr.readProxy();
            if(proxy != null)
            {
                ManufacturerPrxHelper result = new ManufacturerPrxHelper();
                result.iceCopyFrom(proxy);
                return result;
            }
            return null;
        }

        #endregion
    }
}

namespace HelloMrSun
{
    [global::System.Runtime.InteropServices.ComVisible(false)]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.7.2")]
    public abstract class ManufacturerDisp_ : global::Ice.ObjectImpl, Manufacturer
    {
        #region Slice operations

        public abstract bool SendMaterials(global::System.Collections.Generic.List<string> materials, global::Ice.Current current = null);

        #endregion

        #region Slice type-related members

        private static readonly string[] _ids =
        {
            "::HelloMrSun::Manufacturer",
            "::Ice::Object"
        };

        public override bool ice_isA(string s, global::Ice.Current current = null)
        {
            return global::System.Array.BinarySearch(_ids, s, IceUtilInternal.StringUtil.OrdinalStringComparer) >= 0;
        }

        public override string[] ice_ids(global::Ice.Current current = null)
        {
            return _ids;
        }

        public override string ice_id(global::Ice.Current current = null)
        {
            return _ids[0];
        }

        public static new string ice_staticId()
        {
            return _ids[0];
        }

        #endregion

        #region Operation dispatch

        [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
        public static global::System.Threading.Tasks.Task<global::Ice.OutputStream>
        iceD_SendMaterials(Manufacturer obj, global::IceInternal.Incoming inS, global::Ice.Current current)
        {
            global::Ice.ObjectImpl.iceCheckMode(global::Ice.OperationMode.Normal, current.mode);
            var istr = inS.startReadParams();
            global::System.Collections.Generic.List<string> iceP_materials;
            iceP_materials = MaterialsHelper.read(istr);
            inS.endReadParams();
            var ret = obj.SendMaterials(iceP_materials, current);
            var ostr = inS.startWriteParams();
            ostr.writeBool(ret);
            inS.endWriteParams(ostr);
            return inS.setResult(ostr);
        }

        private static readonly string[] _all =
        {
            "SendMaterials",
            "ice_id",
            "ice_ids",
            "ice_isA",
            "ice_ping"
        };

        public override global::System.Threading.Tasks.Task<global::Ice.OutputStream>
        iceDispatch(global::IceInternal.Incoming inS, global::Ice.Current current)
        {
            int pos = global::System.Array.BinarySearch(_all, current.operation, global::IceUtilInternal.StringUtil.OrdinalStringComparer);
            if(pos < 0)
            {
                throw new global::Ice.OperationNotExistException(current.id, current.facet, current.operation);
            }

            switch(pos)
            {
                case 0:
                {
                    return iceD_SendMaterials(this, inS, current);
                }
                case 1:
                {
                    return global::Ice.ObjectImpl.iceD_ice_id(this, inS, current);
                }
                case 2:
                {
                    return global::Ice.ObjectImpl.iceD_ice_ids(this, inS, current);
                }
                case 3:
                {
                    return global::Ice.ObjectImpl.iceD_ice_isA(this, inS, current);
                }
                case 4:
                {
                    return global::Ice.ObjectImpl.iceD_ice_ping(this, inS, current);
                }
            }

            global::System.Diagnostics.Debug.Assert(false);
            throw new global::Ice.OperationNotExistException(current.id, current.facet, current.operation);
        }

        #endregion
    }
}
