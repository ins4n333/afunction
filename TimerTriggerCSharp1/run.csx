#r "TestFuncLib"

using System;

public static void Run(TimerInfo myTimer, TraceWriter log)

{
	log.Info($"Hello world. Current time is : {DateTimeHelper.GetCurrentDateTime()}");
}