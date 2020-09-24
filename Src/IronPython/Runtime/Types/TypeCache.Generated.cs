// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.

using System;

using Microsoft.Scripting.Runtime;

using IronPython.Modules;
using IronPython.Runtime.Exceptions;

using System.Numerics;

namespace IronPython.Runtime.Types {
    public static class TypeCache {
        #region Generated TypeCache Storage

        // *** BEGIN GENERATED CODE ***
        // generated by function: gen_typecache_storage from: generate_typecache.py

        private static PythonType array;
        private static PythonType builtinfunction;
        private static PythonType pythondictionary;
        private static PythonType frozensetcollection;
        private static PythonType pythonfunction;
        private static PythonType builtin;
        private static PythonType obj;
        private static PythonType setcollection;
        private static PythonType pythontype;
        private static PythonType str;
        private static PythonType bytes;
        private static PythonType pythontuple;
        private static PythonType weakreference;
        private static PythonType pythonlist;
        private static PythonType pythonmodule;
        private static PythonType method;
        private static PythonType enumerate;
        private static PythonType intType;
        private static PythonType singleType;
        private static PythonType doubleType;
        private static PythonType biginteger;
        private static PythonType complex;
        private static PythonType super;
        private static PythonType nullType;
        private static PythonType boolType;
        private static PythonType baseException;

        // *** END GENERATED CODE ***

        #endregion

        #region Generated TypeCache Entries

        // *** BEGIN GENERATED CODE ***
        // generated by function: gen_typecache from: generate_typecache.py

        public static PythonType Array {
            get {
                if (array == null) array = DynamicHelpers.GetPythonTypeFromType(typeof(Array));
                return array;
            }
        }

        public static PythonType BuiltinFunction {
            get {
                if (builtinfunction == null) builtinfunction = DynamicHelpers.GetPythonTypeFromType(typeof(BuiltinFunction));
                return builtinfunction;
            }
        }

        public static PythonType Dict {
            get {
                if (pythondictionary == null) pythondictionary = DynamicHelpers.GetPythonTypeFromType(typeof(PythonDictionary));
                return pythondictionary;
            }
        }

        public static PythonType FrozenSet {
            get {
                if (frozensetcollection == null) frozensetcollection = DynamicHelpers.GetPythonTypeFromType(typeof(FrozenSetCollection));
                return frozensetcollection;
            }
        }

        public static PythonType Function {
            get {
                if (pythonfunction == null) pythonfunction = DynamicHelpers.GetPythonTypeFromType(typeof(PythonFunction));
                return pythonfunction;
            }
        }

        public static PythonType Builtin {
            get {
                if (builtin == null) builtin = DynamicHelpers.GetPythonTypeFromType(typeof(Builtin));
                return builtin;
            }
        }

        public static PythonType Object {
            get {
                if (obj == null) obj = DynamicHelpers.GetPythonTypeFromType(typeof(Object));
                return obj;
            }
        }

        public static PythonType Set {
            get {
                if (setcollection == null) setcollection = DynamicHelpers.GetPythonTypeFromType(typeof(SetCollection));
                return setcollection;
            }
        }

        public static PythonType PythonType {
            get {
                if (pythontype == null) pythontype = DynamicHelpers.GetPythonTypeFromType(typeof(PythonType));
                return pythontype;
            }
        }

        public static PythonType String {
            get {
                if (str == null) str = DynamicHelpers.GetPythonTypeFromType(typeof(String));
                return str;
            }
        }

        public static PythonType Bytes {
            get {
                if (bytes == null) bytes = DynamicHelpers.GetPythonTypeFromType(typeof(Bytes));
                return bytes;
            }
        }

        public static PythonType PythonTuple {
            get {
                if (pythontuple == null) pythontuple = DynamicHelpers.GetPythonTypeFromType(typeof(PythonTuple));
                return pythontuple;
            }
        }

        public static PythonType WeakReference {
            get {
                if (weakreference == null) weakreference = DynamicHelpers.GetPythonTypeFromType(typeof(WeakReference));
                return weakreference;
            }
        }

        public static PythonType PythonList {
            get {
                if (pythonlist == null) pythonlist = DynamicHelpers.GetPythonTypeFromType(typeof(PythonList));
                return pythonlist;
            }
        }

        public static PythonType Module {
            get {
                if (pythonmodule == null) pythonmodule = DynamicHelpers.GetPythonTypeFromType(typeof(PythonModule));
                return pythonmodule;
            }
        }

        public static PythonType Method {
            get {
                if (method == null) method = DynamicHelpers.GetPythonTypeFromType(typeof(Method));
                return method;
            }
        }

        public static PythonType Enumerate {
            get {
                if (enumerate == null) enumerate = DynamicHelpers.GetPythonTypeFromType(typeof(Enumerate));
                return enumerate;
            }
        }

        public static PythonType Int32 {
            get {
                if (intType == null) intType = DynamicHelpers.GetPythonTypeFromType(typeof(Int32));
                return intType;
            }
        }

        public static PythonType Single {
            get {
                if (singleType == null) singleType = DynamicHelpers.GetPythonTypeFromType(typeof(Single));
                return singleType;
            }
        }

        public static PythonType Double {
            get {
                if (doubleType == null) doubleType = DynamicHelpers.GetPythonTypeFromType(typeof(Double));
                return doubleType;
            }
        }

        public static PythonType BigInteger {
            get {
                if (biginteger == null) biginteger = DynamicHelpers.GetPythonTypeFromType(typeof(BigInteger));
                return biginteger;
            }
        }

        public static PythonType Complex {
            get {
                if (complex == null) complex = DynamicHelpers.GetPythonTypeFromType(typeof(Complex));
                return complex;
            }
        }

        public static PythonType Super {
            get {
                if (super == null) super = DynamicHelpers.GetPythonTypeFromType(typeof(Super));
                return super;
            }
        }

        public static PythonType Null {
            get {
                if (nullType == null) nullType = DynamicHelpers.GetPythonTypeFromType(typeof(DynamicNull));
                return nullType;
            }
        }

        public static PythonType Boolean {
            get {
                if (boolType == null) boolType = DynamicHelpers.GetPythonTypeFromType(typeof(Boolean));
                return boolType;
            }
        }

        public static PythonType BaseException {
            get {
                if (baseException == null) baseException = DynamicHelpers.GetPythonTypeFromType(typeof(PythonExceptions.BaseException));
                return baseException;
            }
        }


        // *** END GENERATED CODE ***

        #endregion

        [Obsolete("use Complex instead")]
        public static PythonType Complex64 {
            get {
                return Complex;
            }
        }
    }
}
