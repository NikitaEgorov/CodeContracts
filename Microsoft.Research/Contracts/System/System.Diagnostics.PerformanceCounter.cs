// CodeContracts
// 
// Copyright (c) Microsoft Corporation
// 
// All rights reserved. 
// 
// MIT License
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

using System.Diagnostics.Contracts;
using System;

namespace System.Diagnostics
{

    public class PerformanceCounter
    {

        public PerformanceCounterType CounterType
        {
          get;
        }

        public string CounterHelp
        {
          get;
        }

        public bool ReadOnly
        {
          get;
          set;
        }

        public Int64 RawValue
        {
          get;
          set;
        }

        public string! CategoryName
        {
          get;
          set
            Contract.Requires(value != null);
        }

        public string InstanceName
        {
          get;
          set;
        }

        public string! CounterName
        {
          get;
          set
            Contract.Requires(value != null);
        }

        public string MachineName
        {
          get;
          set;
        }

        public void RemoveInstance () {

        }
        public Single NextValue () {

          return default(Single);
        }
        public CounterSample NextSample () {

          return default(CounterSample);
        }
        public Int64 Increment () {

          return default(Int64);
        }
        public Int64 IncrementBy (Int64 value) {

          return default(Int64);
        }
        public void EndInit () {

        }
        public Int64 Decrement () {

          return default(Int64);
        }
        public static void CloseSharedResources () {

        }
        public void Close () {

        }
        public void BeginInit () {

        }
        public PerformanceCounter (string categoryName, string counterName, bool readOnly) {

          return default(PerformanceCounter);
        }
        public PerformanceCounter (string categoryName, string counterName) {

          return default(PerformanceCounter);
        }
        public PerformanceCounter (string categoryName, string counterName, string instanceName, bool readOnly) {

          return default(PerformanceCounter);
        }
        public PerformanceCounter (string categoryName, string counterName, string instanceName) {

          return default(PerformanceCounter);
        }
        public PerformanceCounter (string categoryName, string counterName, string instanceName, string machineName) {

          return default(PerformanceCounter);
        }
        public PerformanceCounter () {
          return default(PerformanceCounter);
        }
    }
}