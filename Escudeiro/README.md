# Mestre dos Código - Escudeiro
https://db1group.github.io/mestre-dos-codigos/#/dotnet?id=n%c3%advel-escudeiro

## Respostas das perguntas teóricas

### 1. Em quais linguagens o C# foi inspirado?
Desenhado por Anders Hejlsberg (desenvolvedor do Delphi e Turbo Pascal) tem seus fundamentos no C++ com o paradigma de orientação à objetos e influências do JAVA como código gerenciado - managed code.

### 2. Inicialmente o C# foi criado para qual finalidade?
Ser uma nova linguagem para a plataforma .NET (cujo seu desenvolvimento estava limitada pela linguagem Simple Managed C (SMC)) afim de desprender o framework de outras linguagens já existentes.

### 3. Quais os principais motivos para a Microsoft ter migrado para o .Net Core?
Com a chegada e popularização dos containers, microsserviços, IoT e a ascensão do mobile a Microsoft reveu sua estratégia e percebeu que o .NET Framework não atendia aos novos requisitos do mercado de desenvolvimento de software.

### 4. Cite as principais diferenças entre .Net Full Framework e .Net Core.
> .Net Full Framework é executado somente no ambiente Windows; .Net Core é agnóstico ao sistema operacional (Windows, Linux, Mac);<br>
> .Net Full Framework possui o código fechado na Microsoft; .Net Core é open-source e possui seu código hospedado no Github;<br>

## Instalando .NET 5 - Preparando o ambiente
Para a execução das aplicações é necessário instalar o .NET Desktop Runtime 5.

Execute o comando no console:
```
dotnet --list-runtimes
```

Caso ocorra o erro
> 'dotnet' não é reconhecido como um comando interno

ou 

> -bash: dotnet: command not found

Acesse o link [.NET 5.0.5 Desktop Runtime](https://dotnet.microsoft.com/download/dotnet/thank-you/runtime-desktop-5.0.5-windows-x64-installer) pra baixar o runtime e logo em seguida instalar.

Caso obtenha uma lista parecida com essa
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


Caso já exista Microsoft.WindowsDesktop.App 5.0.x, seu ambiente está totalmente pronto para executar as aplicações
