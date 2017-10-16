# xunit-mvc-repro

Reproduces an issue with dotnet-xunit when testing ASP.NET Core 2.0 mvc views

## Prerequisites

.NET Core SDK 2.0.2

## Steps to reproduce

```shell
dotnet build
cd FunctionalTests && dotnet xunit
```

Expected to pass as it does with visual studio runner (`dotnet test`), but instead

```
Detecting target frameworks in FunctionalTests.csproj...
Building for framework netcoreapp2.0...
  BasicWebSite -> C:\Users\sergees\source\repos\xunit-mvc-repro\BasicWebSite\bin\Debug\netcoreapp2.0\BasicWebSite.dll
  FunctionalTests -> C:\Users\sergees\source\repos\xunit-mvc-repro\FunctionalTests\bin\Debug\netcoreapp2.0\FunctionalTests.dll
Running .NET Core 2.0.0 tests for framework netcoreapp2.0...
xUnit.net Console Runner (64-bit .NET Core 4.6.00001.0)
  Discovering: FunctionalTests
  Discovered:  FunctionalTests
  Starting:    FunctionalTests
    FunctionalTests.WhenRequestingRazorView.ShouldRespondWithValidContent [FAIL]
      System.InvalidOperationException : Can not find compilation library location for package 'FunctionalTests'
      Stack Trace:
           at Microsoft.Extensions.DependencyModel.CompilationLibrary.ResolveReferencePaths()
           at Microsoft.AspNetCore.Mvc.ApplicationParts.AssemblyPart.<>c.<GetReferencePaths>b__8_0(CompilationLibrary library)
           at System.Linq.Enumerable.SelectManySingleSelectorIterator`2.MoveNext()
           at Microsoft.AspNetCore.Mvc.Razor.Compilation.MetadataReferenceFeatureProvider.PopulateFeature(IEnumerable`1 parts, MetadataReferenceFeature feature)
           at Microsoft.AspNetCore.Mvc.ApplicationParts.ApplicationPartManager.PopulateFeature[TFeature](TFeature feature)
           at Microsoft.AspNetCore.Mvc.Razor.Internal.DefaultRazorReferenceManager.GetCompilationReferences()
           at System.Threading.LazyInitializer.EnsureInitializedCore[T](T& target, Boolean& initialized, Object& syncLock, Func`1 valueFactory)
           at Microsoft.AspNetCore.Mvc.Razor.Internal.DefaultRazorReferenceManager.get_CompilationReferences()
           at Microsoft.AspNetCore.Mvc.Razor.Internal.LazyMetadataReferenceFeature.get_References()
           at Microsoft.CodeAnalysis.Razor.CompilationTagHelperFeature.GetDescriptors()
           at Microsoft.AspNetCore.Razor.Language.DefaultRazorTagHelperBinderPhase.ExecuteCore(RazorCodeDocument codeDocument)
           at Microsoft.AspNetCore.Razor.Language.RazorEnginePhaseBase.Execute(RazorCodeDocument codeDocument)
           at Microsoft.AspNetCore.Razor.Language.DefaultRazorEngine.Process(RazorCodeDocument document)
           at Microsoft.AspNetCore.Razor.Language.RazorTemplateEngine.GenerateCode(RazorCodeDocument codeDocument)
           at Microsoft.AspNetCore.Mvc.Razor.Internal.RazorViewCompiler.CompileAndEmit(String relativePath)
           at Microsoft.AspNetCore.Mvc.Razor.Internal.RazorViewCompiler.CreateCacheEntry(String normalizedPath)
        --- End of stack trace from previous location where exception was thrown ---
           at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
           at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
           at System.Runtime.CompilerServices.TaskAwaiter`1.GetResult()
           at Microsoft.AspNetCore.Mvc.Razor.Internal.DefaultRazorPageFactoryProvider.CreateFactory(String relativePath)
           at Microsoft.AspNetCore.Mvc.Razor.RazorViewEngine.CreateCacheResult(HashSet`1 expirationTokens, String relativePath, Boolean isMainPage)
           at Microsoft.AspNetCore.Mvc.Razor.RazorViewEngine.OnCacheMiss(ViewLocationExpanderContext expanderContext, ViewLocationCacheKey cacheKey)
           at Microsoft.AspNetCore.Mvc.Razor.RazorViewEngine.LocatePageFromViewLocations(ActionContext actionContext, String pageName, Boolean isMainPage)
           at Microsoft.AspNetCore.Mvc.Razor.RazorViewEngine.FindView(ActionContext context, String viewName, Boolean isMainPage)
           at Microsoft.AspNetCore.Mvc.ViewEngines.CompositeViewEngine.FindView(ActionContext context, String viewName, Boolean isMainPage)
           at Microsoft.AspNetCore.Mvc.ViewFeatures.Internal.ViewResultExecutor.FindView(ActionContext actionContext, ViewResult viewResult)
           at Microsoft.AspNetCore.Mvc.ViewResult.<ExecuteResultAsync>d__26.MoveNext()
        --- End of stack trace from previous location where exception was thrown ---
           at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
           at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
           at Microsoft.AspNetCore.Mvc.Internal.ResourceInvoker.<InvokeResultAsync>d__19.MoveNext()
        --- End of stack trace from previous location where exception was thrown ---
           at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
           at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
           at Microsoft.AspNetCore.Mvc.Internal.ResourceInvoker.<InvokeNextResultFilterAsync>d__24.MoveNext()
        --- End of stack trace from previous location where exception was thrown ---
           at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
           at Microsoft.AspNetCore.Mvc.Internal.ResourceInvoker.Rethrow(ResultExecutedContext context)
           at Microsoft.AspNetCore.Mvc.Internal.ResourceInvoker.Next(State& next, Scope& scope, Object& state, Boolean& isCompleted)
           at Microsoft.AspNetCore.Mvc.Internal.ResourceInvoker.<InvokeNextResourceFilter>d__22.MoveNext()

        --- End of stack trace from previous location where exception was thrown ---
           at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
           at Microsoft.AspNetCore.Mvc.Internal.ResourceInvoker.Rethrow(ResourceExecutedContext context)
           at Microsoft.AspNetCore.Mvc.Internal.ResourceInvoker.Next(State& next, Scope& scope, Object& state, Boolean& isCompleted)
           at Microsoft.AspNetCore.Mvc.Internal.ResourceInvoker.<InvokeFilterPipelineAsync>d__17.MoveNext()
        --- End of stack trace from previous location where exception was thrown ---
           at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
           at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
           at Microsoft.AspNetCore.Mvc.Internal.ResourceInvoker.<InvokeAsync>d__15.MoveNext()
        --- End of stack trace from previous location where exception was thrown ---
           at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
           at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
           at Microsoft.AspNetCore.Builder.RouterMiddleware.<Invoke>d__4.MoveNext()
        --- End of stack trace from previous location where exception was thrown ---
           at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
           at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
           at Microsoft.AspNetCore.Hosting.Internal.RequestServicesContainerMiddleware.<Invoke>d__3.MoveNext()
        --- End of stack trace from previous location where exception was thrown ---
           at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
           at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
           at Microsoft.AspNetCore.TestHost.ClientHandler.<>c__DisplayClass3_0.<<SendAsync>b__0>d.MoveNext()
        --- End of stack trace from previous location where exception was thrown ---
           at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
           at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
           at Microsoft.AspNetCore.TestHost.ClientHandler.<SendAsync>d__3.MoveNext()
        --- End of stack trace from previous location where exception was thrown ---
           at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
           at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
           at System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1.ConfiguredTaskAwaiter.GetResult()
           at System.Net.Http.HttpClient.<FinishSendAsyncBuffered>d__58.MoveNext()
        --- End of stack trace from previous location where exception was thrown ---
           at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
           at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
           at System.Runtime.CompilerServices.TaskAwaiter`1.GetResult()
        C:\Users\sergees\source\repos\xunit-mvc-repro\FunctionalTests\WhenRequestingRazorView.cs(17,0): at FunctionalTests.WhenRequestingRazorView.<ShouldRespondWithValidContent>d__0.MoveNext()
        --- End of stack trace from previous location where exception was thrown ---
           at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
           at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
        --- End of stack trace from previous location where exception was thrown ---
           at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
           at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
        --- End of stack trace from previous location where exception was thrown ---
           at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw()
           at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
  Finished:    FunctionalTests
=== TEST EXECUTION SUMMARY ===
   FunctionalTests  Total: 1, Errors: 0, Failed: 1, Skipped: 0, Time: 0.610s
```