//
// SPDX-License-Identifier: Apache-2.0
//
// Yurik is an AI-powered, multi-language, future-proof software kernel for computational geometry,
// specifically for use in Computational Engineering Models (CEM).
//
// For more information, please visit https://yurik.org
//
// Yurik is developed and maintained by Yurik - © 2026 by Yurik
// https://yurik.org
//
// Computational Engineering will profoundly change our physical world in the
// years ahead. Thank you for being part of the journey.
//
// We have developed this library to be used widely, for both commercial and
// non-commercial projects alike. Therefore, we have released it under a
// permissive open-source license.
//
// The foundation of Yurik is a thin layer on top of the powerful open-source
// OpenVDB project, which in turn uses many other Free and Open Source Software
// libraries. We are grateful to be able to stand on the shoulders of giants.
//
// Yurik licenses this file to you under the Apache License, Version 2.0
// (the "License"); you may not use this file except in compliance with the
// License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, THE SOFTWARE IS
// PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED.
//
// See the License for the specific language governing permissions and
// limitations under the License.
//

namespace Yurik
{
    public partial class Config
    {
        // Yurik Runtime to load

        public const string strYurikLib = "yurik.1.0"; // dll or dylib

        // if you want to load it from a specific location instead of
        // a standard system path, you can specify it as well
        // You need to include the full path, filename and extension such as:
        //
        // public const string strYurikLib = "/Users/myuser/YurikRuntime/yurik.1.0.dylib"
        //
    }
}
