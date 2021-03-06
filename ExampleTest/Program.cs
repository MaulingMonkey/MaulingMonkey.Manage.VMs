﻿// Copyright 2017 MaulingMonkey
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using MaulingMonkey.Manage.VMs;
using System;

namespace ExampleTest {
	class Program {
		static void Main(string[] args) {
			var vbox = new VirtualBox();
			Console.WriteLine("VMs:");
			foreach (var vm in vbox.TryListVms()) {
				Console.WriteLine("    {0} {1}", vm.Name.PadRight(30,' '), vm.Guid);
				int n=0;
				foreach (var kv in vbox.VmInfo(vm)) {
					if (++n > 10) continue;
					Console.WriteLine("        {0} {1}", kv.Key.PadRight(30,' '), kv.Value);
				}
			}
		}
	}
}
