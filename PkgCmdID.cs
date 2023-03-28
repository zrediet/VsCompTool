// PkgCmdID.cs
// MUST match PkgCmdID.h
using System;

namespace VsCompTool
{
    static class PkgCmdIDList
    {
        public const uint cmdidCompareSelected = 0x100;
        public const uint cmdidCompareSelectedFolder = 0x200;
        public const uint cmdidCompareSelectedEditor = 0x300;
        public const uint cmdidCompareSelectedMultiProj = 0x400;
    };
}