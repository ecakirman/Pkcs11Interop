﻿/*
 *  Copyright 2012-2016 The Pkcs11Interop Project
 *
 *  Licensed under the Apache License, Version 2.0 (the "License");
 *  you may not use this file except in compliance with the License.
 *  You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 *  Unless required by applicable law or agreed to in writing, software
 *  distributed under the License is distributed on an "AS IS" BASIS,
 *  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *  See the License for the specific language governing permissions and
 *  limitations under the License.
 */

/*
 *  Written for the Pkcs11Interop project by:
 *  Jaroslav IMRICH <jimrich@jimrich.sk>
 */

using System;
using System.Runtime.InteropServices;

namespace Net.Pkcs11Interop.LowLevelAPI80.MechanismParams
{
    /// <summary>
    /// Structure that provides the parameters to the CKM_X9_42_DH_DERIVE key derivation mechanism
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 0, CharSet = CharSet.Unicode)]
    public struct CK_X9_42_DH1_DERIVE_PARAMS
    {
        /// <summary>
        /// Key derivation function used on the shared secret value (CKD)
        /// </summary>
        public ulong Kdf;

        /// <summary>
        /// The length in bytes of the other info
        /// </summary>
        public ulong OtherInfoLen;

        /// <summary>
        /// Some data shared between the two parties
        /// </summary>
        public IntPtr OtherInfo;

        /// <summary>
        /// The length in bytes of the other party's X9.42 Diffie-Hellman public key
        /// </summary>
        public ulong PublicDataLen;

        /// <summary>
        /// Pointer to other party's X9.42 Diffie-Hellman public key value
        /// </summary>
        public IntPtr PublicData;
    }
}
