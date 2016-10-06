#r "TestFuncLib.dll"

using System;
using TestFuncLib;

public static void Run(TimerInfo myTimer, TraceWriter log)

{
	log.Info($"Hello world. Current time is : {DateTimeHelper.GetCurrentDateTime()}");
}