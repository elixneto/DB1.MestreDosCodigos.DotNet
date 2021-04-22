# DB1.MestreDosCodigos.DotNet
https://db1group.github.io/mestre-dos-codigos/#/dotnet

## Instalando .NET 5 - Preparando o ambiente
Para a execução das aplicações é necessário instalar o .NET Desktop Runtime 5.

### Execute o comando no console:
```
dotnet --list-runtimes
```

### Caso ocorra o erro
> 'dotnet' não é reconhecido como um comando interno

ou 

> -bash: dotnet: command not found

Acesse o link [.NET 5.0.5 Desktop Runtime](https://dotnet.microsoft.com/download/dotnet/thank-you/runtime-desktop-5.0.5-windows-x64-installer) pra baixar o runtime e logo em seguida instalar.

### Caso obtenha uma lista parecida com essa
>Microsoft.AspNetCore.All 2.1.7 \[c:\program files\dotnet\shared\Microsoft.AspNetCore.All]<br>
>Microsoft.AspNetCore.All 2.1.13 \[c:\program files\dotnet\shared\Microsoft.AspNetCore.All]<br>
>Microsoft.AspNetCore.App 2.1.7 \[c:\program files\dotnet\shared\Microsoft.AspNetCore.App]<br>
Microsoft.AspNetCore.App 2.1.13 \[c:\program files\dotnet\shared\Microsoft.AspNetCore.App]<br>
>Microsoft.AspNetCore.App 3.1.0 \[c:\program files\dotnet\shared\Microsoft.AspNetCore.App]<br>
>Microsoft.AspNetCore.App 5.0.0 \[c:\program files\dotnet\shared\Microsoft.AspNetCore.App]<br>
>Microsoft.NETCore.App 2.1.7 \[c:\program files\dotnet\shared\Microsoft.NETCore.App]<br>
>Microsoft.NETCore.App 2.1.13 \[c:\program files\dotnet\shared\Microsoft.NETCore.App]<br>
>Microsoft.NETCore.App 3.1.0 \[c:\program files\dotnet\shared\Microsoft.NETCore.App]<br>
>Microsoft.NETCore.App 5.0.0 \[c:\program files\dotnet\shared\Microsoft.NETCore.App]<br>
>Microsoft.WindowsDesktop.App 3.0.0 \[c:\program files\dotnet\shared\Microsoft.WindowsDesktop.App]<br>
>Microsoft.WindowsDesktop.App 3.1.0 \[c:\program files\dotnet\shared\Microsoft.WindowsDesktop.App]<br>
>Microsoft.WindowsDesktop.App 5.0.0 \[c:\program files\dotnet\shared\Microsoft.WindowsDesktop.App]<br>

Verifique se encontra a linha com a versão 5.0.x do Microsoft.WindowsDesktop.App (onde x pode ser qualquer número)
>Microsoft.WindowsDesktop.App 5.0.x \[c:\program files\dotnet\shared\Microsoft.WindowsDesktop.App]<br>

Se não encontrou, acesse o link [.NET 5.0.5 Desktop Runtime](https://dotnet.microsoft.com/download/dotnet/thank-you/runtime-desktop-5.0.5-windows-x64-installer) pra baixar o runtime e logo em seguida instalar.


### Caso já exista Microsoft.WindowsDesktop.App 5.0.x, seu ambiente está totalmente pronto para executar as aplicações
